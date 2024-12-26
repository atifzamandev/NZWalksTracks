using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.Api.Model.Domain;

namespace NZWalks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {

            var region = new List<Region>
            {
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Auckland Region",
                    Code = "AKL",
                    RegionImageUrl = "https://images.pexels.com/photos/17824133/pexels-photo-17824133/free-photo-of-auckland-city-with-a-view-of-the-sky-tower-new-zealand.jpeg"
                },
                new Region
                {
                    Id = Guid.NewGuid(),
                    Name = "Wellington Region",
                    Code = "WLG",
                    RegionImageUrl = "https://images.pexels.com/photos/27623562/pexels-photo-27623562/free-photo-of-a-city-street-at-night-with-a-long-exposure.jpeg"
                }
            };

            return Ok(region);


        }
    }
}
