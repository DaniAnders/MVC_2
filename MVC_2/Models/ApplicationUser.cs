using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace MVC_2.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string SSN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public int Age
        {
            get => (int)Math.Floor((DateTime.Now - BirthDate).TotalDays / 365.25);
        }


        public ApplicationUser()
        {
        }
    }
}

