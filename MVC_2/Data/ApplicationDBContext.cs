using System;
using Microsoft.AspNetCore.Identity;
using System.Reflection.Emit;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MVC_2.Models;
using System.Runtime.Intrinsics.X86;

namespace MVC_2.Data
{
    public class ApplicationDBContext : IdentityDbContext<ApplicationUser>
    {

        public ApplicationDBContext() { }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }



        public DbSet<Country> Countries { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Person> People { get; set; }
     

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            string admin_RoleId = Guid.NewGuid().ToString();
            string user_RoleId = Guid.NewGuid().ToString();
            string userId = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = admin_RoleId,
                Name = "Admin",
                NormalizedName = "ADMIN"
            });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = user_RoleId,
                Name = "User",
                NormalizedName = "USER"
            });





            PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = userId,
                Email = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                UserName = "admin@admin.com",
                NormalizedUserName = "ADMIN@ADMIN.COM",
                SSN = "800101",
                FirstName = "Administrator",
                LastName = "System Admin",
                BirthDate = new DateTime(1980, 1, 1),
                PasswordHash = hasher.HashPassword(null, "@pass@123")
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = admin_RoleId,
                UserId = userId
            });

        }


    }
}

