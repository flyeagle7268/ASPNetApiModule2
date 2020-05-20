using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        public IActionResult GetCities()
        {
            return Ok(CitiesDataStore.Current);
        }

        [HttpGet("{Id}")]
        public IActionResult GetCity(int Id)
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == Id);
            if (city == null)
            {
                return NotFound();
            }

            return Ok(city);
        }

    }
}
