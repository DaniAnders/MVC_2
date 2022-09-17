using System;
using System.ComponentModel.DataAnnotations;
using MVC_2.Models;

namespace MVC_2.ViewModels
{
    public class CreatePersonViewModel
    {
        [Required(ErrorMessage = "SSN is required")]
        [Display(Name = "SSN:")]
        public string SSN { get; set; }


        [Required(ErrorMessage = "First name is required")]
        [Display(Name = "First name:")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last name is required")]
        [Display(Name = "Last name:")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [StringLength(20)]
        public string Phone { get; set; }


        [Required(ErrorMessage = "City is required")]
        [Display(Name = "City")]
        public Guid CityId { get; set; }



        public CreatePersonViewModel()
        {
        }
    }
}

