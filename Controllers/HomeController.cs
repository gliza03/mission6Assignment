using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mission6Assignment.Models;

namespace mission6Assignment.Controllers
{
    public class HomeController : Controller
    {
        private movieFormContext _context;
        public HomeController(movieFormContext temp) // Constructor
        {
            _context = temp;
        } 

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Menu()
        {
            return View();
        }
        [HttpGet]
        public IActionResult MovieForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(MovieForm form)
        {
            _context.Movies.Add(form);
            _context.SaveChanges();

            return View("Index");
        }
    }
}
