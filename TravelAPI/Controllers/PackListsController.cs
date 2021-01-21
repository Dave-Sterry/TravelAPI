using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Controllers
{
    [ApiVersion("2.0")]
    [Route("api/Packlists")]
    [ApiController]
    public class PacklistsV2Controller : ControllerBase
    {
        private TravelAPIContext _db;

        public PacklistsV2Controller(TravelAPIContext db)
        {
            _db = db;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Packlist>> Get()
        {
            return _db.Packlists.ToList();
        }
        //POST api/packlists
        [HttpPost]
        public void Post([FromBody] Packlist packlist)
        {
            _db.Packlists.Add(packlist);
            _db.SaveChanges();
        }

        //GET api/packlists/4
        [HttpGet("{id}")]
        public ActionResult<Packlist> Get(int id)
        {
            return _db.Packlists.FirstOrDefault(entry => entry.PacklistId == id);
        }

        //PUT api/packlists/4
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Packlist packlist)
        {
            packlist.PacklistId = id;
            _db.Entry(packlist).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var packlistToDelete = _db.Packlists.FirstOrDefault(entry => entry.PacklistId == id);
            _db.Packlists.Remove(packlistToDelete);
            _db.SaveChanges();
        }
    }
}