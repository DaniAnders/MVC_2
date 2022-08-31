using System;
using MVC_2.Models;
using System.ComponentModel.DataAnnotations;

namespace MVC_2.ViewModels
{
    public class PeopleViewModel
    {

        public string Title { get; set; }
        public string Description { get; set; }
        //public CreatePersonViewModel CreatePerson { get; set; }
        public List<Person> Persons { get; set; }
        public List<Person_> People_ { get; set; }
        public List<Country> Countries { get; set; }
        public List<City> Cities { get; set; }


        public PeopleViewModel()
        {
        }


    }
}

