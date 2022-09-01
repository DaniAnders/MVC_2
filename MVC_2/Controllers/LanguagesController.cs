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
    public class LanguagesController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        PeopleViewModel model = new PeopleViewModel();

        public LanguagesController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;

        }

        // GET:
        public IActionResult Languages()
        {
            model.Languages = _dbContext.Languages.ToList();
            return View(model);
        }
    }
}

