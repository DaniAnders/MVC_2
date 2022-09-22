using System;
namespace MVC_2.Models
{
    public class City : EntityID
    {
        public string CityName { get; set; }
        public Country Country { get; set; }
        public Guid? CountryId { get; set; }
        public List<Person> People { get; set; }
        

        public City()
        {
            People = new List<Person>();
        }
    }
}

