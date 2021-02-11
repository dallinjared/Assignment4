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

        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach (TopRestaurants r in TopRestaurants.GetRestaurants())
            {
                restaurantList.Add(string.Format($"#{r.RestaurantRanking}: {r.RestaurantName},  {r.FavDish}. {r.RestaurantAddress} {r.RestaurantPhone} <a href ='{r.RestaurantWebsite}'>{r.RestaurantWebsite}</a>"));
            };

            return View(restaurantList);
        }

        public IActionResult Privacy() => View();

        [HttpGet]
        public IActionResult AddRestaurant() => View();

        [HttpPost]
        public IActionResult AddRestaurant(RestaurantForm restaurantResponse)
        {
            TempStorage.AddRestaurant(restaurantResponse);
            return View("Confirmation", restaurantResponse);
        }

        [HttpGet]
        public IActionResult RestaurantList() => View(TempStorage.RestaurantForms);

        [HttpGet]
        public IActionResult Confirmation() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
