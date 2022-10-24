using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_2.ViewModels
{
    public class LanguageViewModel
    {


        [Required(ErrorMessage = "Language name is required")]
        [Display(Name = "Language name:")]
        public string LanguageName { get; set; } = "";

        public LanguageViewModel()
        {
        }
    }
}

