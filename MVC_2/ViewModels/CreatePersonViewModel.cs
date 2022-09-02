using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_2.ViewModels
{
    public class CreatePersonViewModel
    {

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [StringLength(20)]
        public string Phone { get; set; }

        [Required(ErrorMessage = "City name is required")]
        [StringLength(50)]
        public string City { get; set; }


        public CreatePersonViewModel()
        {
        }
    }
}

