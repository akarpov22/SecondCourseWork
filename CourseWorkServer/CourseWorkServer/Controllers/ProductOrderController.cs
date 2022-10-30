using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

using CourseWorkServer.Models;
using CourseWorkServer.Models.DbContexts;

namespace CourseWorkServer.Controllers
{
    [ApiController]
    [Route("ordersproduct")]
    public class ProductOrderController : ControllerBase
    {
        readonly AppDbContext db = new AppDbContext();

        [HttpGet]
        public List<Orders_Products> Get() => db.Orders_Products.ToList();

        [HttpPost]
        public void Post([FromBody] Orders_Products inputProduct)
        {
            db.Orders_Products.Add(inputProduct);
            db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Orders_Products.Remove(db.Orders_Products.First(op => op.ID == id));
            db.SaveChanges();
        }
    }
}
