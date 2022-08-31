using System;
namespace MVC_2.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public Country Country { get; set; }
        public int CountryId { get; set; }
        public List<Person> People { get; set; }
        

        public City()
        {
        }
    }
}

