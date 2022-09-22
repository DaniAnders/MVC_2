using System;
using System.Collections.Generic;
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
    public class CitiesController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        Cities_ViewModel model = new Cities_ViewModel();


        public CitiesController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: 
        public IActionResult Cities()
        {
           
            model.Cities = _dbContext.Cities.Include(city => city.Country).OrderBy(c => c.CityName).ToList();
    
            return View(model);
        }


        public IActionResult Add()
        {
          
            model.CountriesList = new SelectList(_dbContext.Countries, "Id", "CountryName").ToList();

            return View(model);
        }


        [HttpPost]
        public IActionResult Add(Cities_ViewModel cvm)
        {
            ModelState.Remove("CityViewModel");
            ModelState.Remove("City");
            ModelState.Remove("Cities");
            ModelState.Remove("CountriesList");
            ModelState.Remove("Message");
            ModelState.Remove("PeopleByCity");

            if (ModelState.IsValid)
            {
                /* Prevent duplicate entries */
                if(_dbContext.Cities.Any(city => city.CityName == cvm.CityViewModel.CityName && city.CountryId == cvm.CityViewModel.CountryId))
                {
                   
                    return RedirectToAction("Cities");
                   
                }
             
                var newCity = new City { CityName = cvm.CityViewModel.CityName, CountryId = cvm.CityViewModel.CountryId};
                _dbContext.Cities.Add(newCity);
                _dbContext.SaveChanges();

                return RedirectToAction("Cities");
            }

            cvm.CountriesList = new SelectList(_dbContext.Countries, "Id", "CountryName").ToList();

            return View(cvm);
        }



        public IActionResult Edit(Guid id)
        {

            var city = _dbContext.Cities.FirstOrDefault(c => c.Id == id);
            model.City = city;

            var countries = _dbContext.Countries.ToList();
            model.CountriesList = new SelectList(_dbContext.Countries, "Id", "CountryName").ToList();


            return View(model);

        }


        [HttpPost]
        public IActionResult Edit(Cities_ViewModel cvm)
        {

            if (_dbContext.Cities.Any(city => city.CityName == cvm.City.CityName && city.CountryId == cvm.City.CountryId))
            {

                return RedirectToAction("Cities");

            }

            var city = _dbContext.Cities.FirstOrDefault(c => c.Id == cvm.City.Id);
            city.CityName = cvm.City.CityName;
            city.CountryId = cvm.City.CountryId;
           


            _dbContext.Update(city);
            _dbContext.SaveChanges();

            return RedirectToAction("Cities");
        }



        public IActionResult Delete(Guid id)
        {
         
            model.Message = "Click the delete button to confirm you want remove this city.";
            var city = _dbContext.Cities.FirstOrDefault(c => c.Id == id);
            model.City = city;

            model.PeopleByCity = _dbContext.People
                           .Include(person => person.City).Where(person => person.CityId == city.Id).ToList();

            return PartialView("_City", model);

        }


        public IActionResult DeleteCity(Guid id)
        {

            var city = _dbContext.Cities.FirstOrDefault(c => c.Id == id);

            List<Person> peopleByCity = _dbContext.People
                           .Include(person => person.City).Where(person => person.CityId == city.Id).ToList();
            if(peopleByCity != null)
            {
                foreach (var person in peopleByCity)
                {
                    person.SSN = person.SSN;
                    person.FirstName = person.FirstName;
                    person.LastName = person.LastName;
                    person.Phone = person.Phone;
                    person.CityId = null;
                    person.City.CountryId = null;
                    _dbContext.People.Update(person);
                    _dbContext.SaveChanges();
                }
            }
            
            _dbContext.Cities.Remove(city);
            _dbContext.SaveChanges();

            return RedirectToAction("Cities");

        }



    }
}

