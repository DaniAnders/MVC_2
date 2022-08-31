using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_2.Data;
using MVC_2.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_2.Controllers
{
    public class CitiesController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        PeopleViewModel model = new PeopleViewModel();


        public CitiesController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: 
        public IActionResult Cities()
        {
            model.Cities = _dbContext.Cities.ToList();
            return View(model);
        }
    }
}

