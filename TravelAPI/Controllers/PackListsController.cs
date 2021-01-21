using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TravelAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelAPI.Controllers
{
    public class PacklistsController : ControllerBase
    {
        private TravelAPIContext _db;

        public PacklistsController(TravelAPIContext db)
        {
            _db = db;
        }
        // 
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
            _db.SaveChanges;
        }
        
        //GET api/packlists/4
        [HttpGet("{id}")]
        public ActionResult<Packlist> Get(int id)
        {
            return _db.Packlists.FirstOrDefault(entry => entry.ListId == id);
        }
        
        //PUT api/packlists/4
     
    }
}