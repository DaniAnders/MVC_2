using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_2.Models;
using MVC_2.ViewModels;
using MVC_2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

namespace MVC_2.Controllers
{
    public class PeopleController : Controller
    {

        private readonly ApplicationDBContext _dbContext;
        PeopleViewModel model = new PeopleViewModel();


        public PeopleController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: 
        public IActionResult People()
        {
            model.Title = "People";
            model.Description = "List of Users";
            model.People = _dbContext.People
                           .Include(person => person.City)
                           .ThenInclude(person => person.Country)
                           .Include(person => person.Languages).ToList();
        
            return View(model);
        }


        public IActionResult Create()
        {
            var cities = _dbContext.Cities.ToList();
            model.CitiesList = new SelectList(_dbContext.Cities, "Id", "CityName").ToList();

            var languages = _dbContext.Languages.ToList();
            model.LanguagesList = new SelectList(_dbContext.Languages, "Id", "LanguageName").ToList();

            return View(model);
     
        }


        [HttpPost]
        public IActionResult Create(PeopleViewModel pvm)
        {
            ModelState.Remove("Title");
            ModelState.Remove("Description");
            ModelState.Remove("Message");
            ModelState.Remove("People");
            ModelState.Remove("Person");
         
            if (ModelState.IsValid)
            {
                /* Avoiding having two users with same SSN */
                if (_dbContext.People.Any(person => person.SSN == pvm.CreatePerson.SSN))
                {
                    return RedirectToAction("People");
                }

                var newPerson = new Person { SSN = pvm.CreatePerson.SSN, FirstName = pvm.CreatePerson.FirstName, LastName = pvm.CreatePerson.LastName, Phone = pvm.CreatePerson.Phone, CityId = pvm.CreatePerson.CityId};


                foreach(var id in pvm.SelectedLanguages)
                {
                    var language = _dbContext.Languages.FirstOrDefault(a => a.Id == id);
                    newPerson.Languages.Add(language);
                }

                _dbContext.People.Add(newPerson);
                _dbContext.SaveChanges();

                return RedirectToAction("People");
            }

            pvm.CitiesList = new SelectList(_dbContext.Cities, "Id", "CityName").ToList();
            pvm.LanguagesList = new SelectList(_dbContext.Languages, "Id", "LanguageName").ToList();

            return View(pvm);
        }



        public IActionResult Edit(Guid id)
        {

            var person = _dbContext.People.FirstOrDefault(p => p.Id == id);
            model.Person = person;

            var cities = _dbContext.Cities.ToList();
            model.CitiesList = new SelectList(_dbContext.Cities, "Id", "CityName").ToList();
            model.LanguagesList = new SelectList(_dbContext.Languages, "Id", "LanguageName").ToList();

            return View(model);

        }


        [HttpPost]
        public IActionResult Edit(PeopleViewModel pvm)
        {
            var person = _dbContext.People.FirstOrDefault(p => p.SSN == pvm.Person.SSN);
            person.FirstName = pvm.Person.FirstName;
            person.LastName = pvm.Person.LastName;
            person.Phone = pvm.Person.Phone;
            person.CityId = pvm.Person.CityId;


            _dbContext.People.Update(person);
            _dbContext.SaveChanges();
        
            return RedirectToAction("People");
        }


        public IActionResult Delete(Guid id)
        {
            model.Message = "Click the delete button to confirm you want remove this user";
            var person = _dbContext.People.Include(person => person.City).Include(person => person.Languages).FirstOrDefault(p => p.Id == id);
            model.Person = person;

            return PartialView("_User", model);         
        }


        public IActionResult DeleteUser(Guid id)
        {

            var person = _dbContext.People.FirstOrDefault(p => p.Id == id);
            _dbContext.People.Remove(person);
            _dbContext.SaveChanges();

             return RedirectToAction("People");
        }



        [HttpPost]
        public IActionResult Search(string search)
        {
            var filter = "%" + search + "%";

            model.People = _dbContext.People
                .Include(person => person.City)
                .ThenInclude(person => person.Country)
                .Include(person => person.Languages)
                .Where(p => EF.Functions.Like(p.SSN, filter) || EF.Functions.Like(p.FirstName, filter) || EF.Functions.Like(p.LastName, filter) || EF.Functions.Like(p.City.CityName, filter) || EF.Functions.Like(p.City.Country.CountryName, filter)).ToList();


            return View("People",model);

        }


    }
}

