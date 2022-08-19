using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_2.Models;

namespace MVC_2.Controllers
{
    public class GuessingGameController : Controller
    {   
        // GET
        public IActionResult GuessingGame()
        {  
            bool sessionIsNull= string.IsNullOrEmpty(HttpContext.Session.GetString("session"));
            if(sessionIsNull)
            {
                Game.RandomNumber = Game.GetRandomNumber();
                string random = Game.RandomNumber.ToString();
                HttpContext.Session.SetString("session", random);
                ViewBag.Message = "Session created";
            }
            else
            {
                Game.RandomNumber = int.Parse(HttpContext.Session.GetString("session"));
                ViewBag.Message = "Session is still alive. ";
            }
            return View();
        }


        [HttpPost]
        public IActionResult GuessingGame(string guess)
        {
            if (Game.Win)
            {
                Game.RandomNumber = Game.GetRandomNumber();
                string random = Game.RandomNumber.ToString();
                HttpContext.Session.SetString("session", random);
            }
            else
            {
                ViewBag.Message = Game.Guess(guess);
            }
            return View();
        } 

      
        public IActionResult GetSession()
        {
            ViewBag.Message = HttpContext.Session.GetString("session");
            return View();
        }


    }
}

