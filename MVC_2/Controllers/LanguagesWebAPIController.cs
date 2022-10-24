using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_2.Data;
using MVC_2.Models;
using MVC_2.Services;
using Newtonsoft.Json;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_2.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesWebAPIController : ControllerBase
    {

        private ILanguageService _languageService;
       


        public LanguagesWebAPIController(ILanguageService languageService)
        {
            _languageService = languageService;
         

        }


        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<LanguageModel>>> GetLanguagesList()
        {
            try
            {
                var languages = await _languageService.GetLanguagesList();
                return Ok(languages);
            }
            catch
            {
                //return BadRequest("Invalid Request");
                return StatusCode(StatusCodes.Status500InternalServerError, "Error while trying to return languages list");
            }
        }




    }
}

