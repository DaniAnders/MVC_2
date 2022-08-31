using System;
using MVC_2.Models;

namespace MVC_2.ViewModels
{
    public class CityViewModel
    {

        public int Id { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
      

        public CityViewModel()
        {
        }
    }
}

