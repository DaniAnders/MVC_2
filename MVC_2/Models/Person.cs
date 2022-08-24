using System;
namespace MVC_2.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public int PersonId { get; set; }
        public static int nextId = 1;

        public Person()
        {
            PersonId = nextId;
            nextId++;
        }


    }
}

