using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NZWalks.Api.Data;
using NZWalks.Api.Model.Domain;
using NZWalks.Api.Models.Domain.DTO;
using System.ComponentModel;
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
        {
            var regionsDomain = dbContext.Regions.ToList();

            var regionsDto = new List<RegionDto>();
            foreach (var regionDomain in regionsDomain)
            {

                regionsDto.Add(new RegionDto()
                {
                    Id = regionDomain.Id,
                    Code = regionDomain.Code,
                    Name = regionDomain.Name,
                    RegionImageUrl = regionDomain.RegionImageUrl
                });

           }
            return Ok(regionsDto);
        }
        //get single element by passing the id
        [HttpGet]
        [Route("id:Guid")]
        public IActionResult GetById([FromRoute]Guid id) {
          //there is both the method for the getting the elemnt by id 1.one methd is the FIND method
          //2.  the LINQ method  that use the FirstOrDefault.
         //  var region= dbContext.Regions.Find(id);
         var region = dbContext.Regions.FirstOrDefault(x=>x.Id==id);
            if (region == null)
            {
                return NotFound();
            }
            return Ok(region);
        }

        //tihis  the post to create new Region.
        [HttpPost]

        public IActionResult Create([FromBody] AddRegionRequestDto addRegionRequestDto)
        {
            
        }
       
    }
}
