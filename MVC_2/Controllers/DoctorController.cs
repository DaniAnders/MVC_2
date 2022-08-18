using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_2.Models;

namespace MVC_2.Controllers
{
    public class DoctorController : Controller
    {
        /* GET */
        public IActionResult FeverCheck()
        {
            return View();
        }

        [HttpPost]
        public IActionResult FeverCheck(string name, string radiobt, double temperature)
        {
            ViewBag.Message = Doctor.CheckFever(name, radiobt, temperature);
            return View();
        }

    }
}

