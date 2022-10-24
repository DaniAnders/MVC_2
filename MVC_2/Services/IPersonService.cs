using System;
using MVC_2.Models;

namespace MVC_2.Services
{
    public interface IPersonService
    {

        Task<List<PersonModel>> GetPeople();
        Task<PersonModel> GetPerson(string ssn);
        Task<IEnumerable<PersonModel>> GetPeopleByName(string name);
        Task<Person> createPerson(PersonModel person);
        Task EditPerson(PersonModel person);
        Task DeletePerson(PersonModel person);

    }
}

