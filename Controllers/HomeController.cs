using DateMe.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DateMe.Controllers
{
    public class HomeController : Controller
    {

        private MovieDbContext dbContext { get; set; }

        public HomeController(MovieDbContext moviedb)
        {
            dbContext = moviedb;
        }

        public IActionResult Index()
        {
            return View();
        }

       
        //Create Movie Information
        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = dbContext.Categories.ToList();

            return View();
        }


        [HttpPost]
        public IActionResult MovieForm(ApplicationResponse ar)
        {
            ViewBag.Categories = dbContext.Categories.ToList();

            if (ModelState.IsValid)
            {
                dbContext.Add(ar);
                dbContext.SaveChanges();
                return RedirectToAction("MovieList");
            }

            //Makes it go back to the original state in order to make sure the user puts correct information
            else
            {
                return View(ar);
            }
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            var applications = dbContext.Responses
                // If you want to filter data: .Where(i => i.Edited == false)
                .Include(x => x.Category)                
                .OrderBy(x => x.Title)
                .ToList();

            return View(applications);
        }

        [HttpGet]
        //Send the same information from the movie form and Edit / Remove information
        public IActionResult Edit (int movieid)
        {
            ViewBag.Categories = dbContext.Categories.ToList();

            //Grab the data from the previous response
            var application = dbContext.Responses.Single(x => x.MovieId == movieid);

            return View("MovieForm",application);
        }

        [HttpPost]
        public IActionResult Edit(ApplicationResponse editpost)
        {
            dbContext.Update(editpost);
            dbContext.SaveChanges();
            return RedirectToAction("MovieList");
        }

        [HttpGet]
        public IActionResult Delete (int movieid)
        {
            var application = dbContext.Responses.Single(x => x.MovieId == movieid);
            return View(application);
        }

        [HttpPost]
        public IActionResult Delete(ApplicationResponse ar)
        {
            dbContext.Responses.Remove(ar);
            dbContext.SaveChanges();

            return RedirectToAction("MovieList");
            
        }
    }
}
