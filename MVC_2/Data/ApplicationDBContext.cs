﻿using System;
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


       
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Person_> People { get; set; }
        public DbSet<Language> Languages { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Person_>()
                .HasMany(p => p.Languages)
                .WithMany(c => c.People)
                .UsingEntity(j => j.HasData(new { LanguagesId = 1, PeopleID = 1 }));

            modelBuilder.Entity<Person_>()
               .HasMany(p => p.Languages)
               .WithMany(c => c.People)
               .UsingEntity(j => j.HasData(new { LanguagesId = 5, PeopleID = 1 }));

            modelBuilder.Entity<Person_>()
               .HasMany(p => p.Languages)
               .WithMany(c => c.People)
               .UsingEntity(j => j.HasData(new { LanguagesId = 1, PeopleID = 2 }));

            modelBuilder.Entity<Person_>()
              .HasMany(p => p.Languages)
              .WithMany(c => c.People)
              .UsingEntity(j => j.HasData(new { LanguagesId = 3, PeopleID = 2 }));

            modelBuilder.Entity<Person_>()
              .HasMany(p => p.Languages)
              .WithMany(c => c.People)
              .UsingEntity(j => j.HasData(new { LanguagesId = 5, PeopleID = 2 }));

            modelBuilder.Entity<Person_>()
              .HasMany(p => p.Languages)
              .WithMany(c => c.People)
              .UsingEntity(j => j.HasData(new { LanguagesId = 3, PeopleID = 3 }));

            modelBuilder.Entity<Person_>()
              .HasMany(p => p.Languages)
              .WithMany(c => c.People)
              .UsingEntity(j => j.HasData(new { LanguagesId = 3, PeopleID = 4 }));

            modelBuilder.Entity<Person_>()
              .HasMany(p => p.Languages)
              .WithMany(c => c.People)
              .UsingEntity(j => j.HasData(new { LanguagesId = 3, PeopleID = 5 }));

            modelBuilder.Entity<Person_>()
              .HasMany(p => p.Languages)
              .WithMany(c => c.People)
              .UsingEntity(j => j.HasData(new { LanguagesId = 1, PeopleID = 5 }));

            modelBuilder.Entity<Person_>()
             .HasMany(p => p.Languages)
             .WithMany(c => c.People)
             .UsingEntity(j => j.HasData(new { LanguagesId = 1, PeopleID = 6 }));




            modelBuilder.Entity<Language>().HasData(
             new Language { Id = 1, LanguageName = "English" },
             new Language { Id = 2, LanguageName = "French" },
             new Language { Id = 3, LanguageName = "Portuguese" },
             new Language { Id = 4, LanguageName = "Spanish" },
             new Language { Id = 5, LanguageName = "Swedish" }
          
              );


            modelBuilder.Entity<Country>().HasData(
             new Country { Id = 1, CountryName = "Brazil" },
             new Country { Id = 2, CountryName = "Portugal" },
             new Country { Id = 3, CountryName = "Sweden" }

              );

            modelBuilder.Entity<City>().HasData(
             new City { Id = 1, CityName = "Vänersborg", CountryId = 3 },
             new City { Id = 2, CityName = "Petrolina", CountryId = 1 },
             new City { Id = 3, CityName = "Recife", CountryId = 1 },
             new City { Id = 4, CityName = "Göteborg", CountryId = 3 },
             new City { Id = 5, CityName = "Porto", CountryId = 2 },
             new City { Id = 6, CityName = "Sintra", CountryId = 2 }

             );

             modelBuilder.Entity<Person_>().HasData(
              new Person_ { ID = 1, PersonName = "Karl", Phone="046111111", CityId= 1},
              new Person_ { ID = 2, PersonName = "Anneli", Phone = "046222444", CityId = 4 },
              new Person_ { ID = 3, PersonName = "Lucia", Phone = "055123456", CityId = 3 },
              new Person_ { ID = 4, PersonName = "Lourdes", Phone = "055323232", CityId = 2 },
              new Person_ { ID = 5, PersonName = "Antonio", Phone = "0351212121", CityId = 5 },
              new Person_ { ID = 6, PersonName = "Luiza", Phone = "0351212121", CityId = 6 }

                );

        }


    }
}

