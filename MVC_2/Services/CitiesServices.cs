using System;
using Microsoft.EntityFrameworkCore;
using MVC_2.Data;
using MVC_2.Models;

namespace MVC_2.Services
{
    public class CitiesServices : ICityService
    {
        private readonly ApplicationDBContext _context;

        public CitiesServices(ApplicationDBContext context)
        {
            _context = context;
        }



        public async Task<List<CityModel>> GetCitiesList()
        {
            try
            {
                IEnumerable<City> citieslist = await _context.Cities.Include(city => city.Country).ToListAsync();
                List<CityModel> citiesList = new List<CityModel>();

                foreach (var city in citieslist)
                {

                    CityModel cityModel = new CityModel { CityName = city.CityName, CountryName = city.Country.CountryName};
                    citiesList.Add(cityModel);
                }

                return citiesList;

            }
            catch
            {
                throw;
            }

        }


        public async Task<CityModel> GetCity(string cityName)
        {
       
            var city = await _context.Cities
                .Include(city => city.Country)
                .Where(city => city.CityName == cityName).FirstOrDefaultAsync();

          
            CityModel cityModel = new CityModel
            {
                CityName = city.CityName,
                CountryName = city.Country.CountryName
              
            };


            return cityModel;
        }




        public async Task<City>createCity(CityModel city)
        {
            try
            {
                Country country = _context.Countries.FirstOrDefault(country => country.CountryName == city.CountryName);
                City newCity = new City();

                if (!_context.Cities.Any(x => x.CityName == city.CityName && x.CountryId == country.Id))
                {

                    newCity.CityName = city.CityName;
                    newCity.CountryId = country.Id;
                             
                }

                _context.Cities.Add(newCity);
                await _context.SaveChangesAsync();
                return newCity;
            }
            catch
            {
                throw;
            }
           
        }



        public async Task DeleteCity(CityModel city)
        {
            if(city != null)
            {

                City cityToDelete = _context.Cities.Where(c => c.CityName == city.CityName && c.Country.CountryName == city.CountryName).First();

                _context.Cities.Remove(cityToDelete);
                await _context.SaveChangesAsync();
            }
           
        }


    }
}

