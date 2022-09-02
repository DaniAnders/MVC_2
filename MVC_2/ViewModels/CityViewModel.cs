using System;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using MVC_2.Models;

namespace MVC_2.ViewModels
{
    public class CityViewModel
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter the city name")]
        [Display(Name = "City name:")]
        public string CityName { get; set; }


        [Required(ErrorMessage = "Country ID is required")]
        [Display(Name = "Country ID:")]
        public int CountryId { get; set; }
      

        public CityViewModel()
        {
        }
    }
}

