using System;
namespace MVC_2.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
       // public int CountryName { get; set; }
        public List<Person_> People { get; set; } = new List<Person_>();
        

        public City()
        {
        }
    }
}

