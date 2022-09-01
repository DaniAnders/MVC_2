using System;
namespace MVC_2.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string LanguageName { get; set; }
        public List<Person_> People { get; set; } = new List<Person_>();


        public Language()
        {
        }
    }
}

