using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace ConsoleToWebAPI
{
    [ApiController]
    [Route("api/[controller]")]
    [BindProperties(SupportsGet=true)]
    public class CountryController:ControllerBase
    {
        public CountryModel country{get;set;}
        public int countryArea{get;set;}

        [HttpGet("getAll")]
        public IActionResult getAll(){
            return Ok( new CountryModel(){name="America",area=2343,population=2398});
        }

        [HttpPost("addcountry/{name}")]
        public IActionResult addCountry([FromRoute] string name,[FromQuery] CountryModel model ){
            return Ok($"Country name = {country.name}, Country area = {model.area} and Country population = {model.population} & Form area: {countryArea}");
        }

    }
}

