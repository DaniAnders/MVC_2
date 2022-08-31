using System;
using MVC_2.Models;

namespace MVC_2.Data
{
    public class DataDB
    {
        public DataDB()
        {
        }
      
        private static ApplicationDBContext db = new ApplicationDBContext();

        private static List<Person_> People_ = new List<Person_>();
        private static List<City> Cities_ = new List<City>();
        private static List<Country> Countries_ = new List<Country>();


        public static List<Person_> GetPeopleDB()
        {
            People_ = db.People.ToList();

            return People_;
        }

        public static List<City> GetCities()
        {
            Cities_ = db.Cities.ToList();
            return Cities_;
        }

        public static List<Country> GetCountries()
        {
            Countries_ = db.Countries.ToList();
            return Countries_;
        }
    }
}

