using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private TravelAPIContext _db;

        public CitiesController(TravelAPIContext db)
        {
            _db = db;
        }

        // [HttpGet("/All/")]
        // public ActionResult<IEnumerable<City>> GetAll()
        // {
        //     return _db.Cities.ToList();
        // }

        //GET api/cities
        [HttpGet]
        public ActionResult<IEnumerable<City>> Get(string name, int rating, string attraction)  
        {
            var query = _db.Cities.AsQueryable();
            if (name !=null)
            {
                query = query.Where(entry=>entry.Name == name);
            }
            if (rating != 0)
            {
                query = query.Where(entry => entry.Rating == rating);
            }
            if (attraction != null)
            {
                query = query.Where(entry => entry.Attraction == attraction);
            }
            return query.ToList();
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