using System;
using MVC_2.Models;

namespace MVC_2.ViewModels
{
    public class Cities_ViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<City> Cities { get; set; }

        public Cities_ViewModel()
        {
        }
    }
}

