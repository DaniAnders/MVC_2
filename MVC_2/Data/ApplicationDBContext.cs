using System;
using Microsoft.EntityFrameworkCore;
using MVC_2.Models;

namespace MVC_2.Data
{
    public class ApplicationDBContext : DbContext
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

            
        }


    }
}

