using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using MVC_2.Models;

namespace MVC_2.ViewModels
{
    public class CountryViewModel
    {


        [Required(ErrorMessage = "Country name is required")]
        [Display(Name = "Country name:")]
        public string CountryName { get; set; }


        public CountryViewModel()
        {
        }
    }
}

