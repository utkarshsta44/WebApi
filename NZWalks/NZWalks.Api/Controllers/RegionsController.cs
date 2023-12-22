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
            var regions=new List<Region> {
                new Region
                {
                    Id=Guid.NewGuid(),
                    Name="Auckland",
                    Code="Akl",
                    RegionImageUrl="https://www.newzealand.com/in/auckland/"
                },
                new Region
                {
                    Id = Guid.NewGuid(),    
                    Name="Wellington",
                    Code="WelG",
                    RegionImageUrl="https://wellington.govt.nz/wellington-city/about-wellington-city/profile-of-wellington"

                }
            }; 

            return Ok(regions);
        }
    }
}
