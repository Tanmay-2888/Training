using Microsoft.AspNetCore.Mvc;
using MVCDEMO.Models;

namespace MVCDEMO.Controllers
{
    public class BookController : Controller
    {
        public IActionResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            return View();
        }

    }
}
