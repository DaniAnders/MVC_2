using System;
using Microsoft.AspNetCore.Identity;
using MVC_2.Models;

namespace MVC_2.ViewModels
{
    public class UsersRolesViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public IEnumerable<ApplicationUser> ApplicationUsers { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public List<string> UserRoles { get; set; } = new List<string>();
        public IEnumerable<IdentityRole> IdentityRoles { get; set; }


        public UsersRolesViewModel()
        {
        }
    }
}

