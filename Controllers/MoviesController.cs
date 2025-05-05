using Microsoft.AspNetCore.Mvc;
using CineLite.Models;

namespace CineLite.Controllers
{
    public class MoviesController : Controller
    {
        // временный список, вместо БД
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie { Id = 1, Title = "Inception", Genre = "Sci-Fi", Description = "Mind-bending thriller", Duration = TimeSpan.FromMinutes(148) },
            new Movie { Id = 2, Title = "The Godfather", Genre = "Crime", Description = "Mafia classic", Duration = TimeSpan.FromMinutes(175) }
        };

        public IActionResult Index()
        {
            return View(_movies);
        }

        public IActionResult Details(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) return NotFound();
            return View(movie);
        }

        // GET: /Movies/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Movies/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movie.Id = _movies.Max(m => m.Id) + 1; // временно вручную увеличиваем ID
                _movies.Add(movie);
                return RedirectToAction(nameof(Index));
            }

            return View(movie);
        }

        // GET: /Movies/Edit/1
        public IActionResult Edit(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) return NotFound();
            return View(movie);
        }

        // POST: /Movies/Edit/1
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Movie updatedMovie)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) return NotFound();

            if (ModelState.IsValid)
            {
                movie.Title = updatedMovie.Title;
                movie.Genre = updatedMovie.Genre;
                movie.Description = updatedMovie.Description;
                movie.Duration = updatedMovie.Duration;
                return RedirectToAction(nameof(Index));
            }

            return View(updatedMovie);
        }

        // GET: /Movies/Delete/1
        public IActionResult Delete(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) return NotFound();
            return View(movie);
        }

        // POST: /Movies/Delete/1
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie != null)
            {
                _movies.Remove(movie);
            }
            return RedirectToAction(nameof(Index));
        }


    }
}
