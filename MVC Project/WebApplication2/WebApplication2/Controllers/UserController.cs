using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        UserDAL ud = new UserDAL();
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpGet]
        public IActionResult SignUp()
        {


            return View();
        }
        [HttpPost]
        public IActionResult SignUp(IFormCollection form)
        {
            User us = new User();
            us.Name = form["Name"];
            us.EmailId = form["EmailId"].ToString();
            us.Password = form["Password"];
            int res = ud.Save(us);


            return View();
        }
    }
}
