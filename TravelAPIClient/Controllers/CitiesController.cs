using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelAPIClient.Models;

namespace TravelAPIClient.Controllers
{
    public class CitiesController : Controller
    {
        public IActionResult Index()
        {
            var allCities = City.GetCities();
            return View(allCities);
        }

        [HttpPost]
        public IActionResult Index(City city)
        {
            City.Post(city);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var city = City.GetDetails(id);
            return View(city);
        }

        public IActionResult Edit(int id)
        {
            var city = City.GetDetails(id);
            return View(city);
        }

        [HttpPost]
        public IActionResult Details(int id, City city)
        {
            city.CityId = id;
            City.Put(city);
            return RedirectToAction("Details", id);
        }

        public IActionResult Delete(int id)
        {
            City.Delete(id);
            return RedirectToAction("Index");
        }
    }
}