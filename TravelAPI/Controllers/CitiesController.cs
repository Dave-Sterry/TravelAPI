using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Controllers
{
    // [ApiVersion("1.0")]
    // [Route("api/Cities")]
    // [ApiController]
    // public class CitiesV1Controller : ControllerBase
    // {
    //     private TravelAPIContext _db;

    //     public CitiesV1Controller(TravelAPIContext db)
    //     {
    //         _db = db;
    //     }

    //     // [HttpGet("/All/")]
    //     // public ActionResult<IEnumerable<City>> GetAll()
    //     // {
    //     //     return _db.Cities.ToList();
    //     // }

    //     //GET api/cities
    //     [HttpGet]
    //     public ActionResult<IEnumerable<City>> Get(string name, int rating, string attraction, string review)
    //     {
    //         var query = _db.Cities.AsQueryable();
    //         if (name !=null)
    //         {
    //             query = query.Where(entry=>entry.Name == name);
    //         }
    //         if (rating != 0)
    //         {
    //             query = query.Where(entry => entry.Rating == rating);
    //         }
    //         if (attraction != null)
    //         {
    //             query = query.Where(entry => entry.Attraction == attraction);
    //         }
    //         return query.ToList();
    //         // return new string[] { "Value1 from Version 1", "value2 from Version 1" };
    //         // }
    //     }
    // }

    [ApiVersion("2.0")]
    [Route("api/Cities")]
    [ApiController]
    public class CitiesV2Controller : ControllerBase
    {
        private TravelAPIContext _db;

        public CitiesV2Controller(TravelAPIContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<City>> Get()
        {
            return _db.Cities.ToList();
        }

        //POST api/cities
        [HttpPost]
        public void Post([FromBody] City city)
        {
            _db.Cities.Add(city);
            _db.SaveChanges();
        }

        //GET api/cities/5
        [HttpGet("{id}")]
        public ActionResult<City> Get(int id)
        {
            return _db.Cities.FirstOrDefault(entry => entry.CityId == id);
        }

        // PUT api/cities/5
        // Remember to restart server after each route addition to prevent 400 errors in Postman
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] City city)
        {
            city.CityId = id;
            _db.Entry(city).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/cities/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var cityToDelete = _db.Cities.FirstOrDefault(entry => entry.CityId == id);
            _db.Cities.Remove(cityToDelete);
            _db.SaveChanges();
        }
    }
}