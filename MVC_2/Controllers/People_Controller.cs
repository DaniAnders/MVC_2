﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_2.Data;
using MVC_2.ViewModels;


namespace MVC_2.Controllers
{
    public class People_Controller : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        PeopleViewModel model = new PeopleViewModel();


        public People_Controller(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: 
        public IActionResult People_()
        {
            model.People_ = _dbContext.People.ToList();
            return View(model);
        }
    }
}
