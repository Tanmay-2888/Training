using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCDEMO.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult EmployeeDetails()
        {
            List<string> Options = new List<string>();
            Options.Add("Choose Designation");
            Options.Add("Front End Developer");
            Options.Add("BackEnd Developer");
            Options.Add("Data Scientist");
            Options.Add("Data Analysist");
            ViewData["Options"] = new SelectList(Options);
            return View();
        }

        [HttpPost]
        public ActionResult EmployeeDetails(IFormCollection fc, ICollection<string>  Location)
        {
            ViewBag.EmpName = fc["EmpName"];
            ViewBag.EmpId = fc["EmpId"];
            ViewBag.MobileNumber = fc["phone"];
            ViewBag.salary = fc["salary"];
            ViewBag.gender = fc["gender"];
            ViewBag.Location = fc["Location"];
            ViewBag.Designation = fc["Options"];
            return View("EmpDetails");

        }
    }
}
