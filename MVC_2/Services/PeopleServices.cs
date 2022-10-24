using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MVC_2.Data;
using MVC_2.Models;

namespace MVC_2.Services
{
    public class PeopleServices : IPersonService
    {
        private readonly ApplicationDBContext _context;

        public PeopleServices(ApplicationDBContext context)
        {
            _context = context;
        }


        public async Task<List<PersonModel>> GetPeople()
        {
            try
            {
                IEnumerable<Person> peoplelist = await _context.People
                    .Include(person => person.City)
                    .ThenInclude(person => person.Country)
                    .Include(person => person.Languages).ToListAsync();

                List<PersonModel> peopleList = new List<PersonModel>();

                foreach(var person in peoplelist)
                {             
                    var personlanguages = string.Join(",", person.Languages.Select(language => language.LanguageName).ToList());

                    PersonModel personModel = new PersonModel { SSN = person.SSN, FirstName = person.FirstName, LastName = person.LastName, Phone = person.Phone, City = person.City.CityName, Languages = personlanguages };
                    peopleList.Add(personModel);
                }

                return peopleList;

            }
            catch
            {
                throw;
            }
           
        }



        public async Task<PersonModel> GetPerson(string ssn)
        {
          
            var person = await _context.People
                .Include(person => person.City)
                .ThenInclude(person => person.Country)
                .Include(person => person.Languages).Where(p => p.SSN == ssn).FirstOrDefaultAsync();

            var personlanguages = string.Join(",", person.Languages.Select(language => language.LanguageName).ToList());

            PersonModel personModel = new PersonModel
             {
                 SSN = person.SSN,
                 FirstName = person.FirstName,
                 LastName = person.LastName,
                 Phone = person.Phone,
                 City = person.City.CityName,
                // Country = person.City.Country.CountryName,
                 Languages = personlanguages
             };

            return personModel;
        }




        public async Task<IEnumerable<PersonModel>> GetPeopleByName(string name)
        {
            IEnumerable<Person> people = people = await _context.People
                    .Include(person => person.City)
                    .ThenInclude(person => person.Country)
                    .Where(n => n.FirstName.Contains(name)).ToListAsync();

            List<PersonModel> peopleList = new List<PersonModel>();

            if (!string.IsNullOrWhiteSpace(name))
            {
                foreach(var person in people)
                {
                    var personlanguages = string.Join(",", person.Languages.Select(language => language.LanguageName).ToList());

                    PersonModel personModel = new PersonModel { SSN = person.SSN, FirstName = person.FirstName, LastName = person.LastName, Phone = person.Phone, City = person.City.CityName, Languages = personlanguages };
                      peopleList.Add(personModel);
               
                }

                return peopleList;
            }
            else
            {
                peopleList = await GetPeople();
            }

            return peopleList;
        }




        public async Task<Person> createPerson(PersonModel person)
        {
            try
            {

                var languagesString = person.Languages;
                string[] languagesArray = languagesString.Split(",");


                List<Language> personlanguages = new List<Language>();
                foreach (var language in languagesArray)
                {
                    Language lang = _context.Languages.FirstOrDefault(l => l.LanguageName == language);
                    personlanguages.Add(lang);
                }

                Person newPerson = new Person();

                if(!_context.People.Any(x => x.SSN == person.SSN))
                {
                    newPerson.SSN = person.SSN;
                    newPerson.FirstName = person.FirstName;
                    newPerson.LastName = person.LastName;
                    newPerson.Phone = person.Phone;
                    newPerson.CityId = _context.Cities.Where(c => c.CityName == person.City).Select(c => c.Id).FirstOrDefault();
                    newPerson.Languages = personlanguages;
                }

                _context.People.Add(newPerson);
                await _context.SaveChangesAsync();
                return newPerson;

            }
            catch
            {
                throw;
            }

           
        }




        public async Task EditPerson(PersonModel person)
        {

            Person personToEdit = await _context.People.Where(p => p.SSN == person.SSN).FirstAsync();

            City city = await _context.Cities.Where(city => city.CityName == person.City).FirstAsync();

            if (personToEdit != null)
            {
                personToEdit.FirstName = person.FirstName;
                personToEdit.LastName = person.LastName;
                personToEdit.Phone = person.Phone;
                personToEdit.CityId = city.Id;
      
            }

             _context.Entry(personToEdit).State = EntityState.Modified;
           // _context.People.Update(personToEdit);
            await _context.SaveChangesAsync();
        }



        public async Task DeletePerson(PersonModel person)
        {

            Person personToDelete = _context.People.Where(p => p.SSN == person.SSN).First();

            _context.People.Remove(personToDelete);
            await _context.SaveChangesAsync();
        }






    }
}

