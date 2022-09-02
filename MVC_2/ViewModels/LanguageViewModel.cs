using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_2.ViewModels
{
    public class LanguageViewModel
    {

        public int ID { get; set; }

        [Required(ErrorMessage = "Language name is required")]
        [Display(Name = "Language name:")]
        public string LanguageName { get; set; }

        public LanguageViewModel()
        {
        }
    }
}

