using System;
using MVC_2.Models;

namespace MVC_2.Services
{
    public interface ICityService
    {
        Task<List<CityModel>> GetCitiesList();
        Task<CityModel> GetCity(string cityName);
        Task <City>createCity(CityModel city);
        Task DeleteCity(CityModel city);
    }
}

