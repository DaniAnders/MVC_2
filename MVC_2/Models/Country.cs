using System;
namespace MVC_2.Models
{
    public class Country : EntityID
    {

        public string CountryName { get; set; } = "";
        public List<City> Cities { get; set; }



        public Country()
        {
            Cities = new List<City>();
        }
    }
}

