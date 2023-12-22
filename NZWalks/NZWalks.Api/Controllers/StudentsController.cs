using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZWalks.Api.Controllers
{  
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase { 
    
    [HttpGet]
   public IActionResult GetAllStudents() {
            string[] studentNames=new string[] {"utkarsh","ajay","govinda","akshat","yash"};
            return Ok(studentNames);
        }
    }
}
