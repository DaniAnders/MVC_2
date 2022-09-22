using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVC_2.Data;
using MVC_2.Models;
using MVC_2.ViewModels;



namespace MVC_2.Controllers
{
    public class CountriesController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        Countries_ViewModel model = new Countries_ViewModel();

        public CountriesController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET:
        public IActionResult Countries()
        {
            model.Title = "Countries";
            model.Description = "List of countries";
            model.Countries = _dbContext.Countries
                .Include(country => country.Cities)
                .OrderBy(country => country.CountryName).ToList();
            return View(model);
        }


        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(CountryViewModel cvm)
        {
            using var context = new ApplicationDBContext();

            if (ModelState.IsValid)
            {
                /* Prevent duplicate entries */
                if (_dbContext.Countries.Any(country => country.CountryName == cvm.CountryName))
                {

                    return RedirectToAction("Countries");

                }

                var newCountry = new Country{ CountryName = cvm.CountryName};
                _dbContext.Countries.Add(newCountry);
                _dbContext.SaveChanges();

                return RedirectToAction("Countries");
            }

            return View(cvm);
        }


        public IActionResult Edit(Guid id)
        {

            var country = _dbContext.Countries.FirstOrDefault(c => c.Id == id);
            model.Country = country;

            return View(model);

        }



        [HttpPost]
        public IActionResult Edit(Countries_ViewModel cvm)
        {

            if (_dbContext.Countries.Any(country => country.CountryName == cvm.Country.CountryName))
            {

                return RedirectToAction("Countries");

            }

            var country = _dbContext.Countries.FirstOrDefault(c => c.Id == cvm.Country.Id);
            country.CountryName= cvm.Country.CountryName;
           

            _dbContext.Update(country);
            _dbContext.SaveChanges();

            return RedirectToAction("Countries");
        }




        [HttpPost]
        public IActionResult Search(string search)
        {
            var filter = "%" + search + "%";

            model.Countries = _dbContext.Countries
                .Include(country => country.Cities)
                .Where(country => EF.Functions.Like(country.CountryName, filter)).ToList();



            return View("Countries", model);

        }



        public IActionResult Delete(Guid id)
        {

            model.Message = "Click the delete button to confirm you want remove this country";
            var country = _dbContext.Countries.FirstOrDefault(c => c.Id == id);
            model.Country = country;

            model.CitiesByCountry = _dbContext.Cities.Include(city => city.Country).Where(city => city.CountryId == country.Id).ToList();


            return PartialView("_Country", model);

        }


        public IActionResult DeleteCountry(Guid id)
        {
            var country = _dbContext.Countries.FirstOrDefault(x => x.Id == id);

          //  var country = _dbContext.Countries.Include(c => c.Cities).FirstOrDefault(c => c.Id == id); 

            List<City> citiesByCountry = _dbContext.Cities.Include(city => city.Country).Where(city => city.CountryId == id).ToList();

            List <City> list = country.Cities.ToList();

            if (list != null)
            {
                foreach (var city in list)
                {
                    city.CityName = city.CityName;
                    city.CountryId = null;
                    _dbContext.Cities.Update(city);
                    _dbContext.SaveChanges();
                }
            }


            _dbContext.Countries.Remove(country);
            _dbContext.SaveChanges();

            return RedirectToAction("Countries");
        }


    }
}

