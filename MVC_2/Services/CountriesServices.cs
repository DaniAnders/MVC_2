using System;
using Microsoft.EntityFrameworkCore;
using MVC_2.Data;
using MVC_2.Models;

namespace MVC_2.Services
{
    public class CountriesServices : ICountryService
    {

        private readonly ApplicationDBContext _context;

        public CountriesServices(ApplicationDBContext context)
        {
            _context = context;
        }


        public async Task<List<CountryModel>> GetCountriesList()
        {
            try
            {
                
                IEnumerable<Country> countrieslist = await _context.Countries.ToListAsync();
                List<CountryModel> countriesList = new List<CountryModel>();

                foreach (var country in countrieslist)
                {

                    CountryModel countryModel = new CountryModel { CountryName = country.CountryName };
                    countriesList.Add(countryModel);
                }

                return countriesList;


            }
            catch
            {
                throw;
            }

        }



        public async Task<CountryModel> GetCountry(string countryName)
        {

            var country = await _context.Countries.Where(country => country.CountryName == countryName).FirstOrDefaultAsync();

            CountryModel countryModel = new CountryModel
            {
  
                CountryName = country.CountryName

            };


            return countryModel;
        }



        public async Task<Country> createCountry(CountryModel country)
        {
            try
            {
                Country newCountry = new Country();
                if (!_context.Countries.Any(x => x.CountryName == country.CountryName))
                {
                    newCountry.CountryName = country.CountryName;
                }

                _context.Countries.Add(newCountry);
                await _context.SaveChangesAsync();
                return newCountry;
            }
            catch
            {
                throw;
            }

        }


        public async Task DeleteCountry(CountryModel country)
        {

            Country countryToDelete = _context.Countries.Where(c => c.CountryName == country.CountryName).First();
            _context.Countries.Remove(countryToDelete);
            await _context.SaveChangesAsync();
        }



    }
}

