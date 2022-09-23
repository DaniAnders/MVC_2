using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_2.Models
{
    public class Person : EntityID
    {

        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public City City { get; set; }
        public Guid CityId { get; set; }
        public List<Language> Languages { get; set; }


        public Person()
        {

            Languages = new List<Language>();

        }
    }
}
