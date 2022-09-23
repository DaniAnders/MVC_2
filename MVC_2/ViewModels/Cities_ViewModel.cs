﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_2.Models;

namespace MVC_2.ViewModels
{
    public class Cities_ViewModel
    {

        public CityViewModel CityViewModel { get; set; }
        public City City { get; set; }
        public List<City> Cities { get; set; }
        public List<SelectListItem> CountriesList { get; set; }

        public string Message { get; set; }
        public List<Person> PeopleByCity { get; set; }

      
        public Cities_ViewModel()
        {
            Cities = new List<City>();
            CountriesList = new List<SelectListItem>();
        }
    }
}
