using System;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
using MVC_2.Models;
using System.Linq;

namespace MVC_2.Data
{
    public class UserData
    {
        public UserData()
        {
        }


        static private List<Person> PersonsData = new List<Person>() {
            new Person() {Name ="Anneli", Phone ="04611111", City="Gothenburg" },
            new Person(){Name="Karl", Phone="04622222", City="Stockholm" },
            new Person(){Name="Johan", Phone="04633333", City="Stockholm" },
            new Person(){Name="Anneli", Phone="0464444", City="Uddevalla" }};


        /* Getting all persons in the list */
        public static List<Person> ListPeople()
        {
            return PersonsData;
        }

        public static Person GetPersonById(int id)
        {
            return PersonsData.Single(x => x.PersonId == id);
        }


        public static void AddPerson(Person newPerson)
        {
            PersonsData.Add(newPerson);
        }

        public static List<Person> SearchByName(string value)
        {
            List<Person> result = PersonsData.FindAll(x => x.Name.ToLower().Contains(value.ToLower()));
            return result;
        }

        public static List<Person> SearchByCity(string value)
        {
            List<Person> result = PersonsData.FindAll(x => x.City.ToLower().Contains(value.ToLower()));

            return result;
        }

        public static List<Person> SearchById(string value)
        {
            int.TryParse(value, out int id);
            List<Person> result = PersonsData.FindAll(x => x.PersonId == id);

            return result;
        }

        public static void DeleteFromList(int id)
        {
            Person personToDelete = GetPersonById(id);
            PersonsData.Remove(personToDelete);
        }


        public static void Delete(string id)
        {

            PersonsData.RemoveAll(x => x.PersonId == int.Parse(id));
        }

        
        public static List<Person> SearchByNameOrCity(string value)
        {
            List<Person> searchName = SearchByName(value);
            List<Person> searchCity = SearchByCity(value);

            List<Person> result = new List<Person>();
            foreach(var person in searchName)
            {
                result.Add(person);
            }
            foreach(var person in searchCity)
            {
                result.Add(person);
            }

            return result;
   
        }


    }
}

