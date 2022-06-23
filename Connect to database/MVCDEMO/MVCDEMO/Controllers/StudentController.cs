
using Microsoft.AspNetCore.Mvc;
using MVCDEMO.Models;

namespace MVCDEMO.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult AddStudent()
        {
            return View();

        }
        [HttpPost]
       public ActionResult AddStudent(Student student)
        {
            return View();
        }
    }
}
