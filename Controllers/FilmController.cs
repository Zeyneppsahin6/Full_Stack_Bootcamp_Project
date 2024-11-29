using Microsoft.AspNetCore.Mvc;
using proje.Models;
using proje.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace proje.Controllers
{
    public class FilmController : Controller
    {
        private readonly DatabaseContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FilmController(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var filmler = from f in _context.Filmler select f;

            if (!string.IsNullOrEmpty(searchString))
            {
                ViewBag.SearchString = searchString;
                filmler = filmler.Where(f => f.Ad.ToLower().Contains(searchString.ToLower()) || f.Aciklama.ToLower().Contains(searchString.ToLower()));
            }

            return View(await filmler.ToListAsync());
        }

        public async Task<IActionResult> Category(string kategori)
        {
            var filmler = await _context.Filmler.Where(f => f.Kategori == kategori).ToListAsync();
            return View("Index", filmler);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Filmler.FindAsync(id);

            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Film film)
        {
            if (ModelState.IsValid)
            {
                _context.Filmler.Add(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(film);
        }

        public async Task<IActionResult> Latest()
        {
            var latestFilms = await _context.Filmler.OrderByDescending(f => f.Id).ToListAsync();
            return View(latestFilms);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Filmler.FindAsync(id);

            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Film film)
        {
            if (id != film.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(film);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(film);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _context.Filmler.FindAsync(id);

            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var film = await _context.Filmler.FindAsync(id);
            if (film != null)
            {
                _context.Filmler.Remove(film);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }
    }
}