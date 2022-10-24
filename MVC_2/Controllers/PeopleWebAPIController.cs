using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using MVC_2.Data;
using MVC_2.Models;
using MVC_2.Services;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   // [Produces("application/json")]
    public class PeopleWebAPIController : ControllerBase
    {
        private IPersonService _personService;
 
        public PeopleWebAPIController(IPersonService personService)
        {
            _personService = personService;       
        }



        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<PersonModel>>> GetPeople()
        {
            try
            {
                var people = await _personService.GetPeople();
                return Ok(people);
            }
            catch
            {
                //return BadRequest("Invalid Request");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error while trying to return people list");
            }
        }




        [HttpGet("PeopleByName")]
        public async Task<ActionResult<IAsyncEnumerable<PersonModel>>> GetPeopleByName([FromQuery] string name)
        {

            try
            {
                var peopleByName = await _personService.GetPeopleByName(name);
                if (peopleByName.Count() == 0)
                    return NotFound($"There are no persons with name {name}");

                return Ok(peopleByName);
            }
            catch
            {
                return BadRequest("Invalid Request");
            }

        }




        [HttpGet("{ssn}", Name = "GetPerson")]
        public async Task<ActionResult<PersonModel>> GetPerson(string ssn)
        {
            try
            {
                var person = await _personService.GetPerson(ssn);
                if (person == null)
                    return NotFound($"Person with ssn = {ssn} was not found!");

                return Ok(person);
            }
            catch
            {
                return BadRequest("Invalid Request");
            }

        }



      
        [HttpPost("Post")]
        public async Task<ActionResult<PersonModel>> CreatePerson([FromBody] PersonModel person)
        {

            try
            {
                if(person != null)
                {
                    await _personService.createPerson(person);
                    return CreatedAtRoute(nameof(GetPerson), new { ssn = person.SSN }, person);
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


        [HttpPut("{ssn}")]
        public async Task<ActionResult> Edit(string ssn, [FromBody] PersonModel personmodel)
         {


            try
             {
                 if(personmodel != null)
                 {

                     await _personService.EditPerson(personmodel);
                     //return NoContent();
                     return Ok($"Details from person with ssn = {ssn} is updated");
                 }
                 else
                 {
                     return BadRequest("The data received was inconsistent!");
                 }
             }
             catch
             {
                 return BadRequest("Invalid Request!");
             }

         }



        [HttpDelete("{ssn}")]
        public async Task<ActionResult> DeletePerson(string ssn)
        {
            try
            {
                var person = await _personService.GetPerson(ssn);
                if(person != null)
                {
                    await _personService.DeletePerson(person);
                    return Ok($"Person with ssn = {ssn} has been removed");
                }
                else
                {
                    return NotFound($"Person with ssn = {ssn} not found!");
                }
            }
            catch
            {
                return BadRequest("Invalid Request");
            }
        }





    }
}

