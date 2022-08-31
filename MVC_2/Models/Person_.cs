using System;
using System.ComponentModel.DataAnnotations;

namespace MVC_2.Models
{
    public class Person_ 
    {
        
        public int ID{ get; set; }
        public string PersonName { get; set; }
        public string Phone { get; set; }
        public City City { get; set; }
        public int CityId { get; set; }
        

        public Person_()
        {
        }
    }
}

