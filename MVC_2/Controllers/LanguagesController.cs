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
    public class LanguagesController : Controller
    {
        private readonly ApplicationDBContext _dbContext;
        Languages_ViewModel model = new Languages_ViewModel();

        public LanguagesController(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;

        }

        // GET:
        public IActionResult Languages()
        {
            model.Title = "Languages";
            model.Description = "List of languages";
            model.Languages = _dbContext.Languages
                .OrderBy(language => language.LanguageName).ToList();
            return View(model);
        }



        public IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Add(LanguageViewModel lvm)
        {
        
           if (ModelState.IsValid)
           {
                if (_dbContext.Languages.Any(language => language.LanguageName == lvm.LanguageName))
                {

                    return RedirectToAction("Languages");

                }
                
               var newLanguage = new Language { LanguageName = lvm.LanguageName };
              _dbContext.Languages.Add(newLanguage);
              _dbContext.SaveChanges();

              return RedirectToAction("Languages");
           }
      
            return View(lvm);
        }


        public IActionResult Edit(Guid id)
        {

            var language = _dbContext.Languages.FirstOrDefault(language => language.Id == id);
            model.Language = language;

            return View(model);
        }


        [HttpPost]
        public IActionResult Edit(Languages_ViewModel lvm)
        {

            if (_dbContext.Languages.Any(lang => lang.LanguageName == lvm.Language.LanguageName))
            {

                return RedirectToAction("Languages");

            }

            var language = _dbContext.Languages.FirstOrDefault(language => language.Id == lvm.Language.Id);
            language.LanguageName = lvm.Language.LanguageName;


            _dbContext.Update(language);
            _dbContext.SaveChanges();

            return RedirectToAction("Languages");
        }


       public IActionResult Delete(Guid id)
         {
             var language = _dbContext.Languages.FirstOrDefault(x => x.Id == id);
             _dbContext.Languages.Remove(language);
             _dbContext.SaveChanges();

             return RedirectToAction("Languages");
       }


    }

}