using System;
namespace MVC_2.Models
{
    public class Language : EntityID
    {
    
        public string LanguageName { get; set; }
        public List<Person> People { get; set; }


        public Language()
        {
            People = new List<Person>();
        }
    }
}

