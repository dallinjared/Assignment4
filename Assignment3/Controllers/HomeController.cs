using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assignment3.Models;

namespace Assignment3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View();

        public IActionResult Privacy() => View();

        public IActionResult MyPodcasts() => View();

        [HttpGet]
        public IActionResult AddMovie() => View();

        [HttpPost]
        public IActionResult AddMovie(MovieForm movieResponse)
        {
            TempStorage.AddMovie(movieResponse);
            return View("Confirmation", movieResponse);
        }

        [HttpGet]
        public IActionResult MovieList() => View(TempStorage.MovieForms);

        [HttpGet]
        public IActionResult Confirmation() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
