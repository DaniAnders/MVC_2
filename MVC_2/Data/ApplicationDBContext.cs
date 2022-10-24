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



            /* string admin_RoleId = Guid.NewGuid().ToString();
             string user_RoleId = Guid.NewGuid().ToString();
             string userId = Guid.NewGuid().ToString();*/

            /*  modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
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
              });*/





            //  PasswordHasher<ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            /*  modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
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
              });*/

            /*  modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
              {
                  RoleId = admin_RoleId,
                  UserId = userId
              });*/


            Country portugal = new Country() { Id = Guid.NewGuid(), CountryName = "Portugal" };
            Country norway = new Country() { Id = Guid.NewGuid(), CountryName = "Norway" };
            Country denmark = new Country() { Id = Guid.NewGuid(), CountryName = "Denmark" };
            Country france = new Country() { Id = Guid.NewGuid(), CountryName = "France" };
            Country italy = new Country() { Id = Guid.NewGuid(), CountryName = "Italy" };
          
       
            modelBuilder.Entity<Country>().HasData(portugal);
            modelBuilder.Entity<Country>().HasData(norway);
            modelBuilder.Entity<Country>().HasData(denmark);
            modelBuilder.Entity<Country>().HasData(france);
            modelBuilder.Entity<Country>().HasData(italy);
         


            City porto = new City() { Id = Guid.NewGuid(), CityName = "Porto", CountryId = portugal.Id};
            City braga = new City() { Id = Guid.NewGuid(), CityName = "Braga", CountryId = portugal.Id };
            City guimaraes = new City() { Id = Guid.NewGuid(), CityName = "Guimaraes", CountryId = portugal.Id };

            City bergen= new City() { Id = Guid.NewGuid(), CityName = "Bergen", CountryId = norway.Id };
            City oslo = new City() { Id = Guid.NewGuid(), CityName = "Oslo", CountryId = norway.Id };
            City trondheim = new City() { Id = Guid.NewGuid(), CityName = "Trondheim", CountryId = norway.Id };

            City copenhagen = new City() { Id = Guid.NewGuid(), CityName = "Copenhagen", CountryId = denmark.Id };
            City odense = new City() { Id = Guid.NewGuid(), CityName = "Odense ", CountryId = denmark.Id };
            City aarhus = new City() { Id = Guid.NewGuid(), CityName = "Aarhus", CountryId = denmark.Id };

            City paris= new City() { Id = Guid.NewGuid(), CityName = "Paris", CountryId = france.Id };
            City annecy  = new City() { Id = Guid.NewGuid(), CityName = "Annecy", CountryId = france.Id };
            City dijon = new City() { Id = Guid.NewGuid(), CityName = "Dijon", CountryId = france.Id };

            City florence = new City() { Id = Guid.NewGuid(), CityName = "Florence", CountryId = italy.Id };
            City rome = new City() { Id = Guid.NewGuid(), CityName = "Rome", CountryId = italy.Id };
            City venice = new City() { Id = Guid.NewGuid(), CityName = "Venice", CountryId = italy.Id };


            modelBuilder.Entity<City>().HasData(porto);
            modelBuilder.Entity<City>().HasData(braga);
            modelBuilder.Entity<City>().HasData(guimaraes);

            modelBuilder.Entity<City>().HasData(bergen);
            modelBuilder.Entity<City>().HasData(oslo);
            modelBuilder.Entity<City>().HasData(trondheim);

            modelBuilder.Entity<City>().HasData(copenhagen);
            modelBuilder.Entity<City>().HasData(odense);
            modelBuilder.Entity<City>().HasData(aarhus);

            modelBuilder.Entity<City>().HasData(paris);
            modelBuilder.Entity<City>().HasData(annecy);
            modelBuilder.Entity<City>().HasData(dijon);

            modelBuilder.Entity<City>().HasData(florence);
            modelBuilder.Entity<City>().HasData(rome);
            modelBuilder.Entity<City>().HasData(venice);


            Language english = new Language() { Id = Guid.NewGuid(), LanguageName = "English" };
            Language swedish = new Language() { Id = Guid.NewGuid(), LanguageName = "Swedish" };
            Language italian = new Language() { Id = Guid.NewGuid(), LanguageName = "Italian" };
            Language japanese = new Language() { Id = Guid.NewGuid(), LanguageName = "Japanese" };
            Language portuguese = new Language() { Id = Guid.NewGuid(), LanguageName = "Portuguese" };
            Language french = new Language() { Id = Guid.NewGuid(), LanguageName = "French" };
          

            modelBuilder.Entity<Language>().HasData(english);
            modelBuilder.Entity<Language>().HasData(swedish);
            modelBuilder.Entity<Language>().HasData(italian);
            modelBuilder.Entity<Language>().HasData(japanese);
            modelBuilder.Entity<Language>().HasData(portuguese);
            modelBuilder.Entity<Language>().HasData(french);


            Person p1 = new Person() { Id = Guid.NewGuid(), SSN = "801009", FirstName = "Antonio", LastName = "Pereira", Phone = "00351786533", CityId = porto.Id };
            Person p2 = new Person() { Id = Guid.NewGuid(), SSN = "851209", FirstName = "Manuel", LastName = "Carvalho", Phone = "00351786533", CityId = braga.Id };

            Person p3 = new Person() { Id = Guid.NewGuid(), SSN = "820413", FirstName = "Petter", LastName = "Bjorge", Phone = "00471786533", CityId = bergen.Id };
            Person p4 = new Person() { Id = Guid.NewGuid(), SSN = "861211", FirstName = "Maja", LastName = "Nilsen", Phone = "0047786533", CityId = oslo.Id };


            Person p5 = new Person() { Id = Guid.NewGuid(), SSN = "700511", FirstName = "Elise", LastName = "Jensen", Phone = "00451786533", CityId = copenhagen.Id };
            Person p6 = new Person() { Id = Guid.NewGuid(), SSN = "750912", FirstName = "Elisabeth", LastName = "Garnier", Phone = "00331786533", CityId = paris.Id };


            modelBuilder.Entity<Person>().HasData(p1);
            modelBuilder.Entity<Person>().HasData(p2);
            modelBuilder.Entity<Person>().HasData(p3);
            modelBuilder.Entity<Person>().HasData(p4);
            modelBuilder.Entity<Person>().HasData(p5);
            modelBuilder.Entity<Person>().HasData(p6);


            modelBuilder.Entity<Person>()
                .HasMany(person => person.Languages)
                .WithMany(lang => lang.People)
                .UsingEntity(j => j.HasData(new { LanguagesId = english.Id, PeopleId = p1.Id }));

            modelBuilder.Entity<Person>()
                .HasMany(person => person.Languages)
                .WithMany(lang => lang.People)
                .UsingEntity(j => j.HasData(new { LanguagesId = portuguese.Id, PeopleId = p1.Id }));

            modelBuilder.Entity<Person>()
                .HasMany(person => person.Languages)
                .WithMany(lang => lang.People)
                .UsingEntity(j => j.HasData(new { LanguagesId = portuguese.Id, PeopleId =  p2.Id}));


            modelBuilder.Entity<Person>()
               .HasMany(person => person.Languages)
               .WithMany(lang => lang.People)
               .UsingEntity(j => j.HasData(new { LanguagesId = english.Id, PeopleId = p3.Id }));

            modelBuilder.Entity<Person>()
              .HasMany(person => person.Languages)
              .WithMany(lang => lang.People)
              .UsingEntity(j => j.HasData(new { LanguagesId = english.Id, PeopleId = p4.Id }));

            modelBuilder.Entity<Person>()
             .HasMany(person => person.Languages)
             .WithMany(lang => lang.People)
             .UsingEntity(j => j.HasData(new { LanguagesId = swedish.Id, PeopleId = p5.Id }));

            modelBuilder.Entity<Person>()
            .HasMany(person => person.Languages)
            .WithMany(lang => lang.People)
            .UsingEntity(j => j.HasData(new { LanguagesId = japanese.Id, PeopleId = p5.Id }));

            modelBuilder.Entity<Person>()
           .HasMany(person => person.Languages)
           .WithMany(lang => lang.People)
           .UsingEntity(j => j.HasData(new { LanguagesId = french.Id, PeopleId = p6.Id }));



        }


    }
}

