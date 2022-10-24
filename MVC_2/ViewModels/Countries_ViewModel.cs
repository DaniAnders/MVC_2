using System;
using MVC_2.Models;

namespace MVC_2.ViewModels
{
    public class Countries_ViewModel
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public List<Country> Countries { get; set; }
        public Country Country { get; set; } = new Country();

        public string Message { get; set; } = "";
        public List<City> CitiesByCountry { get; set; } = new List<City>();

        public Countries_ViewModel()
        {
            Countries = new List<Country>();
        }
    }
}

