using System;
using MVC_2.Models;

namespace MVC_2.ViewModels
{
    public class Countries_ViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public List<Country> Countries { get; set; }

        public Countries_ViewModel()
        {
        }
    }
}

