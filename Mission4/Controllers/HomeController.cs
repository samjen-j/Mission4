using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission4.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Controllers
{
    public class HomeController : Controller
    {

        private DatabaseContext databaseContext { get; set; }

        public HomeController(DatabaseContext someName)
        {
            databaseContext = someName;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Podcast()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Movies()
        {
            ViewBag.Categories = databaseContext.Categories.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult Movies(AddToDatabase ad)
        {
            if (ModelState.IsValid)
            {
                databaseContext.Add(ad);
                databaseContext.SaveChanges();

                return View("Confirmation", ad);
            }
            else
            {
                ViewBag.Categories = databaseContext.Categories.ToList();
                return View();
            }
            
            
        }

        [HttpGet]
        public IActionResult Display()
        {
            var movies = databaseContext.addedMovies
                .Include(x => x.Category)
                .OrderBy(x => x.Category)
                .ToList();

            return View(movies);
        }
      
        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = databaseContext.Categories.ToList();

            var movie = databaseContext.addedMovies.Single(x => x.MovieId == movieid);

            return View("Movies", movie);
        }

        [HttpPost]
        public IActionResult Edit(AddToDatabase ad)
        {
            databaseContext.Update(ad);
            databaseContext.SaveChanges();
            
            return RedirectToAction("Display");
        }

        public IActionResult Delete()
        {
            return View();
        }

    }
}
