using Microsoft.AspNetCore.Components.Forms;
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
            ViewBag.Genres = _context.Categories.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult MovieForm(MovieForm form)
        {
            _context.Movies.Add(form);
            _context.SaveChanges();

            return View("Index");
        }

        public IActionResult Table()
        {
            // Linq
            var movies = _context.Movies.ToList();

            return View(movies);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.formID == id);

            ViewBag.Genres = _context.Categories.ToList();



            return View("MovieForm", recordToEdit);
        }

        [HttpPost]
        public IActionResult Edit(MovieForm editedForm)
        {
            _context.Update(editedForm);
            _context.SaveChanges();

            return RedirectToAction("Table");
        }


        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.formID == id);

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult Delete(MovieForm deleteForm)
        {
            _context.Remove(deleteForm);
            _context.SaveChanges();

            return RedirectToAction("Table");
        }

    }
}
