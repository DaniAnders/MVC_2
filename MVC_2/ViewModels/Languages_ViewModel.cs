using System;
using MVC_2.Models;

namespace MVC_2.ViewModels
{
    public class Languages_ViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Language> Languages { get; set; }

        public Languages_ViewModel()
        {
        }
    }
}

