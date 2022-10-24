using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_2.Models;
using MVC_2.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CountriesWebAPIController : ControllerBase
    {

        private ICountryService _countryService;

        public CountriesWebAPIController(ICountryService countryService)
        {
            _countryService = countryService;

        }


        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<CountryModel>>> GetCountriesList()
        {
            try
            {
                var countries = await _countryService.GetCountriesList();
                return Ok(countries);
            }
            catch
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error while trying to return countries list");
            }
        }


        [HttpGet("{countryName}", Name = "GetCountry")]
        public async Task<ActionResult<PersonModel>> GetCountry(string countryName)
        {
            try
            {
                var country = await _countryService.GetCountry(countryName);
                if (country == null)
                    return NotFound($"Country {country} was not found!");

                return Ok(country);

            }
            catch
            {
                return BadRequest("Invalid Request");
            }

        }



        [HttpPost]
        public async Task<ActionResult<CountryModel>> CreateCountry([FromBody] CountryModel country)
        {

            try
            {
                await _countryService.createCountry(country);
                return CreatedAtRoute(nameof(GetCountry), new { country.CountryName }, country);

            }
            catch
            {
                return BadRequest("Invalid Request");
            }


        }



        [HttpDelete("{countryname}")]
        public async Task<ActionResult> DeleteCountry(string countryname)
        {
            try
            {
                var country = await _countryService.GetCountry(countryname);
                if (country != null)
                {
                    await _countryService.DeleteCountry(country);
                    return Ok($"Country  {countryname} has been removed");
                }
                else
                {
                    return NotFound($"Country {countryname} not found!");
                }
            }
            catch
            {
                return BadRequest("Invalid Request");
            }
        }




    }
}

