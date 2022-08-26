using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_2.Data;
using MVC_2.Models;
using MVC_2.ViewModels;


namespace MVC_2.Controllers
{
    public class AjaxController : Controller
    {
        PeopleViewModel model = new PeopleViewModel();


        // GET: /<controller>/
        public IActionResult Ajax()
        {
            model.Persons = UserData.ListPeople();
            return View(model);
        }



        [HttpGet]
        public IActionResult ListPeople()
        {
           model.Persons = UserData.ListPeople();
           return PartialView("_ListPeople", model);
        }


        [HttpPost]
        public IActionResult Delete(string id)
        {
            UserData.Delete(id);
            model.Persons = UserData.ListPeople();
            return PartialView("_ListPeople", model);
        }


        [HttpPost]
        public IActionResult Details(string id)
        {  
            model.Persons = UserData.SearchById(id);
            return PartialView("_User", model);
        }


    }
}

