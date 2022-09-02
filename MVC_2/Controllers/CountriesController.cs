using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_2.Data;
using MVC_2.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

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
            model.Title = "Countries Index";
            model.Description = "List of countries";
            model.Countries = _dbContext.Countries.ToList();
            return View(model);
        }
    }
}

