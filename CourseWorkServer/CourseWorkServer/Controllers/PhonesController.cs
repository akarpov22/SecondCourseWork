using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

using CourseWorkServer.Models;
using CourseWorkServer.Models.DbContexts;

namespace CourseWorkServer.Controllers
{
    [ApiController]
    [Route("phones")]
    public class PhonesController : ControllerBase
    {
        readonly AppDbContext db = new AppDbContext();

        [HttpGet]
        public List<Phone> Get() => db.Phones.ToList();

        [HttpGet("{id}")]
        public Phone Get(int id) => db.Phones.First(p => p.ID == id);

        [HttpPost]
        public void Post([FromBody] Phone inputPhone)
        {
            db.Phones.Add(inputPhone);
            db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Phones.Remove(db.Phones.First(p => p.ID == id));
            db.SaveChanges();
        }
    }
}