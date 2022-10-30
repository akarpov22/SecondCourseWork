using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

using CourseWorkServer.Models;
using CourseWorkServer.Models.DbContexts;

namespace CourseWorkServer.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        readonly AppDbContext db = new AppDbContext();

        [HttpGet]
        public List<Product> Get() => db.Products.ToList();

        [HttpGet("{id}")]
        public Product Get(int id) => db.Products.First(p => p.ID == id);

        [HttpPost]
        public void Post([FromBody] Product inputProduct)
        {
            db.Products.Add(inputProduct);
            db.SaveChanges();
        }

        [HttpPut]
        public void Put([FromBody] Product inputProduct)
        {
            var productToEdit = db.Products.First(p => p.ID == inputProduct.ID);
            productToEdit.Name = inputProduct.Name;
            productToEdit.Price = inputProduct.Price;
            db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Products.Remove(db.Products.First(p => p.ID == id));
            db.SaveChanges();
        }
    }
}