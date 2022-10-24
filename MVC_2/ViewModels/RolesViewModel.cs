using System;
using Microsoft.AspNetCore.Identity;

namespace MVC_2.ViewModels
{
    public class RolesViewModel
    {

        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public IdentityRole IdentityRole { get; set; }
        public IEnumerable<IdentityRole> IdentityRoles { get; set; }


        public RolesViewModel()
        {
        }
    }
}

