using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Host;
using MVC_2.Models;
using MVC_2.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesWebAPIController : ControllerBase
    {

        private ICityService _cityService;

        public CitiesWebAPIController(ICityService cityService)
        {
            _cityService = cityService;

        }


        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<CityModel>>> GetCitiesList()
        {
            try
            {
                var cities = await _cityService.GetCitiesList();
                return Ok(cities);
            }
            catch
            {
            
                return StatusCode(StatusCodes.Status500InternalServerError, "Error while trying to return cities list");
            }
        }


        [HttpGet("{cityName}", Name = "GetCity")]
        public async Task<ActionResult<PersonModel>> GetCity(string cityName)
        {
            try
            {    
                var city = await _cityService.GetCity(cityName);
                if(city == null)
                    return NotFound($"City {city} was not found!");

                return Ok(city);

            }
            catch
            {
                return BadRequest("Invalid Request");
            }

        }


        [HttpPost]
        public async Task<ActionResult<CityModel>> CreateCity([FromBody] CityModel city)
        {

            try
            {
                if(city != null)
                {
                    await _cityService.createCity(city);
                    return CreatedAtRoute(nameof(GetCity), new { city.CityName }, city);
                }
                else
                {
                    return BadRequest("The data received was inconsistent!");
                }
               

            }
            catch
            {
                return BadRequest("Invalid Request");
            }


        }




        [HttpDelete("{cityname}")]
        public async Task<ActionResult> DeleteCity(string cityname)
        {
            try
            {
                var city = await _cityService.GetCity(cityname);
                if (city != null)
                {
                    await _cityService.DeleteCity(city);
                    return Ok($"City  {cityname} has been removed");
                }
                else
                {
                    return NotFound($"City {cityname} not found!");
                }
            }
            catch
            {
                return BadRequest("Invalid Request");
            }
        }




    }
}

