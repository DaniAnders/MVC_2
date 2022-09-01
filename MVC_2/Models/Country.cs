using System;
namespace MVC_2.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public List<City> Cities { get; set; } = new List<City>();




        public Country()
        {
        }
    }
}

