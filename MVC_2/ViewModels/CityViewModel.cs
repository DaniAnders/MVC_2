using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_2.Models;

namespace MVC_2.ViewModels
{
    public class CityViewModel
    {

        [Required(ErrorMessage = "You must enter the city name")]
        [Display(Name = "City name:")]
        public string CityName { get; set; }


        [Display(Name = "Country:")]
        public Guid CountryId { get; set; }



        public CityViewModel()
        {
           
        }
    }
}

