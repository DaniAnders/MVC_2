using System;
using MVC_2.Models;

namespace MVC_2.Services
{
    public interface ICountryService
    {

        Task<List<CountryModel>> GetCountriesList();
        Task<CountryModel> GetCountry(string countryName);
        Task <Country>createCountry(CountryModel country);
        Task DeleteCountry(CountryModel country);

    }
}

