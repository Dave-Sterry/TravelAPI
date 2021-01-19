using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelAPI.Models;

namespace TravelAPI.Controllers
{
    [Route("api/[controller")]
    [ApiController]
    public class CitiesController : ControllerBase 
    {
        private TravelAPIContext _db;

        public CitiesController(TravelAPIContext db)
        {
            _db = db;
        }

        //GET api/cites
        [HttpGet]
        public ActionResult<IEnumerable<City>> Get()
        {
            return _db.Cities.ToList();
        }

        //POST api/cities
        [HttpPost]
        public void Post([FromBody]City city)
        {
            _db.Cities.Add(city);
            _db.SaveChanges();
        }
    }
}