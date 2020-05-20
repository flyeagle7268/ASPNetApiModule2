using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.Api.Controllers
{
    [ApiController]
    [Route("api/cities/{Id}/pointsofinterest")]
    public class PointsOfInterestController : ControllerBase
    {

        public IActionResult GetPointsOfInterest(int Id) 
        {
            var city = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == Id);
            if (city == null)
            {
                return NotFound();
            }

            return Ok(CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == Id).PointsOfInterests);

        }
    }
}
