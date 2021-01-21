using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Controllers
{
    public class PackListsController : ControllerBase
    {
        private TravelAPIContext _db;

        public PackListsController(TravelAPIContext db)
        {
            _db = db;
        }

        
    }
}