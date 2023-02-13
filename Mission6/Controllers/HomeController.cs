using Microsoft.AspNetCore.Mvc;
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
        private readonly ILogger<HomeController> _logger;
        private MovieSubmissionContext _MovieContext { get; set; }
        public HomeController(ILogger<HomeController> logger, MovieSubmissionContext x)
        {
            _logger = logger;
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
            return View();
        }

        [HttpPost]
        public IActionResult SubmitMovie(SubmitMovie response)
        {
            _MovieContext.Add(response);
            _MovieContext.SaveChanges();
            return View("Confirmation");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}