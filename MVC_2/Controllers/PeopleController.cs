using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_2.Models;
using MVC_2.ViewModels;
using MVC_2.Data;


namespace MVC_2.Controllers
{
    public class PeopleController : Controller
    {
   
        PeopleViewModel model = new PeopleViewModel();

        // GET:
        public IActionResult People()
        {

            model.Title = "Users Info";
            model.Description = "Create, Remove and Search";
            model.Persons = UserData.ListPeople();

            return View(model);

        }

        public IActionResult Create()
        {
            return View();
        }




        [HttpPost]
        public IActionResult Create(CreatePersonViewModel pvm)
        {
            if (ModelState.IsValid)
            {
                Person newPerson = new Person
                {
                    Name = pvm.Name,
                    Phone = pvm.Phone,
                    City = pvm.City
                };

                UserData.AddPerson(newPerson);
                return Redirect("/People");
            }

            return View(pvm);
        }



        [HttpPost]
        public IActionResult People(string search)
        {
            
            model.Persons = UserData.Search(search);
            return View(model);
        }


        public IActionResult Delete()
        {
            model.Persons = UserData.ListPeople();
            return View(model);
        }


        [HttpPost]
        public IActionResult Delete(int[] personIds)
        {
           foreach(int id in personIds)
            {
                UserData.DeleteFromList(id);
            }

            model.Persons = UserData.ListPeople();
            return View(model);
        }



    }
}

