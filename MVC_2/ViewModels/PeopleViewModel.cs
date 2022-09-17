using System;
using System.Collections.Generic;
using MVC_2.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVC_2.ViewModels
{
    public class PeopleViewModel
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public string Message { get; set; }
        public Person Person { get; set; }
        public CreatePersonViewModel CreatePerson { get; set; }

        public List<Person> People { get; set; }
        public List<SelectListItem> CitiesList { get; set; }
        public List<SelectListItem> LanguagesList { get; set; }

        public Guid[] SelectedLanguages { get; set; }




        public PeopleViewModel()
        {
            People = new List<Person>();
            CitiesList = new List<SelectListItem>();
            LanguagesList = new List<SelectListItem>();
        }


    }
}

