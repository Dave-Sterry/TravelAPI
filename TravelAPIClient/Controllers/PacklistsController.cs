using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TravelAPIClient.Models;

namespace TravelAPIClient.Controllers
{
    public class PacklistsController: Controller
    {
        public IActionResult Index()
        {
            var allPacklists = Packlist.GetPacklists();
            return View(allPacklists);
        }
    }
}