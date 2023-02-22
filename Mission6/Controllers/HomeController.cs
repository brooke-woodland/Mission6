using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission6.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mission6.Controllers
{
    public class HomeController : Controller
    {
        
        private MovieSubmissionContext _MovieContext { get; set; }
        public HomeController( MovieSubmissionContext x)
        {
            _MovieContext = x;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SubmitMovie()
        {

            ViewBag.Categories= _MovieContext.categories.ToList();

            //this view is shown when this action is first called
            return View("SubmitMovie", new SubmitMovie());
            //return View();
        }

        [HttpPost]
        public IActionResult SubmitMovie(SubmitMovie response)
        {
            if (ModelState.IsValid)
            {
                // saves the data into the database
                _MovieContext.Add(response);
                _MovieContext.SaveChanges();

                //shows the user the confirmation page
                return View("Confirmation");
            }
            else
            {
                ViewBag.Categories = _MovieContext.categories.ToList();
                return View(response);  
            }

        }

        public IActionResult MovieTable()
        {
            //allows the categories to show up
            var submissions = _MovieContext.responses.Include(x => x.Category)
                .ToList();

            return View(submissions);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _MovieContext.categories.ToList();

            // specify which record is being deleted by the id
            var submission = _MovieContext.responses.Single(x => x.MovieID == id);

            return View("SubmitMovie", submission);

        }
        [HttpPost]
        public IActionResult Edit(SubmitMovie blah)
        {
            _MovieContext.Update(blah);
            _MovieContext.SaveChanges();
            return RedirectToAction("MovieTable");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            // specify which record is being deleted by the id
            var submission = _MovieContext.responses.Single(x => x.MovieID == id);
            return View(submission);
        }

        [HttpPost]
        public IActionResult Delete(SubmitMovie ar)
        {
            _MovieContext.responses.Remove(ar);
            _MovieContext.SaveChanges();
            return RedirectToAction("MovieTable");
        }
    }
}