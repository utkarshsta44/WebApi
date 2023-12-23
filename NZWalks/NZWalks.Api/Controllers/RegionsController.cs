using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.Api.Data;
using NZWalks.Api.Model.Domain;
using System.Runtime.InteropServices;

namespace NZWalks.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase

    {
        private readonly NZWalksDbContext dbContext;
        public RegionsController(NZWalksDbContext dbContext)
        {
            this.dbContext=dbContext;

        }

        [HttpGet]
        public IActionResult GetAll()
        {   //this is for the  data that is hardcoded above approach also use the dB data use.
            /*var regions=new List<Region> {
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
*/
            var regions = dbContext.Regions.ToList();
            return Ok(regions);
        }
    }
}
