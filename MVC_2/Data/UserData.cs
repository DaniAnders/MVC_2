using System;
using static Microsoft.Extensions.Logging.EventSource.LoggingEventSource;
using MVC_2.Models;

namespace MVC_2.Data
{
    public class UserData
    {
        public UserData()
        {
        }


        static private List<Person> PersonsData = new List<Person>();



        /* Getting all persons in the list */
        public static List<Person> ListPeople()
        {
            return PersonsData;
        }

        /* Getting by id */
        public static Person GetPersonById(int id)
        {
            return PersonsData.Single(x => x.PersonId == id);
        }


        /* Adding a new person in the list */
        public static void AddPerson(Person newPerson)
        {
            PersonsData.Add(newPerson);
        }

        public static List<Person> Search(string value)
        {
            List<Person> result = PersonsData.FindAll(x => x.Name.ToLower() == value.ToLower());

            return result;
        }

        /* Removing a person by id */
        public static void DeleteFromList(int id)
        {
            Person personToDelete = GetPersonById(id);
            PersonsData.Remove(personToDelete);
        }
    }
}

