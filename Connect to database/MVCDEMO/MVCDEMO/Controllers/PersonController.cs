using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;


namespace MVCDEMO.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]

        public IActionResult Personaldetails()
        {
            List<string> Options = new List<string>();
            Options.Add("Choose an Option");
            Options.Add("Yes");
            Options.Add("No");
            ViewData["Options"] = new SelectList(Options);
            return View();
        }
        [HttpPost]

        public ActionResult PersonalDetails(IFormCollection fc, ICollection<string> hobbies)
        {
            ViewBag.firstname = fc["Firstname"];
            ViewBag.lastname = fc["lastname"];
            ViewBag.phone = fc["phone"];
            ViewBag.gender = fc["gender"];
            ViewBag.hobbies = fc["hobbies"];
            ViewBag.options = fc["options"];
            return View("Details");

        }
    }
}
