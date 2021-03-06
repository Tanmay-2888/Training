using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo1.Model;
using WebAPIDemo1.Services;

namespace WebAPIDemo1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    
    
        public class CoursesController : ControllerBase
        {
            private readonly ICourseService _courservice;
            public CoursesController(ICourseService Courservice)
            {
                _courservice = Courservice;
            }
            [HttpGet]
            //[Route("[action]")]
            [Route("GetCourse")]
            public IActionResult GetCourse()
            {
                return new ObjectResult(_courservice.GetAllCourse());
                // test code
            }
            [HttpPost]
            [Route("AddCourse")]
            public IActionResult AddCourse(Course Cour)
            {
                return new ObjectResult(_courservice.AddCourse(Cour));
            }

            [HttpPost]
            [Route("ModifyCourse")]
            public IActionResult ModifyCourse(Course Cour)
            {
                return new ObjectResult(_courservice.ModifyCourse(Cour));
            }

            [HttpGet]
            [Route("DeleteCourse/{id}")]
            public IActionResult DeleteCourse(int id)
            {
                return new ObjectResult(_courservice.DeleteCourse(id));
            }
        }

    }

