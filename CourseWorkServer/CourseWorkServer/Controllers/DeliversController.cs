using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using CourseWorkServer.Models;
using CourseWorkServer.Models.DbContexts;

namespace CourseWorkServer.Controllers
{
    [ApiController]
    [Route("delivers")]
    public class DeliversController : ControllerBase
    {
        readonly AppDbContext db = new AppDbContext();

        [HttpGet]
        public List<Deliver> Get() => db.Delivers.ToList();

        [HttpGet("{id}")]
        public Deliver Get(int id) => db.Delivers.First(d => d.ID == id);

        [HttpGet("fullInfo")]
        public List<DeliverFullInfo> GetFullInfo() => db.Delivers.Select(d =>
            new DeliverFullInfo
            {
                ID = d.ID,
                FullName = d.FullName,
                OrdersID = db.Orders.Where(o => o.DeliversID == d.ID)
                                    .Select(o => o.ID)
                                    .ToList()
            }).ToList();

        [HttpGet("fullInfo/{id}")]
        public DeliverFullInfo GetFullInfo(int id) => new DeliverFullInfo
        {
            ID = id,
            FullName = db.Delivers.First(d => d.ID == id).FullName,
            OrdersID = db.Orders.Where(o => o.DeliversID == id)
                                .Select(o => o.ID)
                                .ToList()
        };


        [HttpGet("salery")]
        public List<DeliverSalery> DeliverSaleries()
        {
            List<Deliver> baseDelivers = db.Delivers.ToList();
            List<DeliverSalery> result = new();
            foreach (Deliver deliver in baseDelivers)
                result.Add(new DeliverSalery()
                {
                    ID = deliver.ID,
                    fullName = deliver.FullName,
                    days = db.Orders.Where(o => o.DeliversID == deliver.ID && o.DateOfOrder.Month == DateTime.Now.Month).
                GroupBy(o => o.DateOfOrder.Day).Count(),
                    saleries = 6500 + db.Orders.Where(o => o.DeliversID == deliver.ID && o.DateOfOrder.Month == DateTime.Now.Month).
                Join(db.Orders_Products.Join(db.Products, op => op.ProductsID, p => p.ID, (op, p) => new { ID = op.OrdersID, Price = p.Price, Count = op.Quantity })
                , o => o.ID, op => op.ID, (o, op) => new { id = o.ID, Price = op.Price, Count = op.Count }).Select(o => (o.Price * o.Count)).Sum()*0.2
                });

            return result;
        }

        [HttpPost]
        public void Post([FromBody] Deliver inputDeliver)
        {
            db.Delivers.Add(inputDeliver);
            db.SaveChanges();
        }

        [HttpPut]
        public void Put([FromBody] Deliver inputDeliver)
        {
            var deliverToEdit = db.Delivers.First(d => d.ID == inputDeliver.ID);
            deliverToEdit.FullName = inputDeliver.FullName;
            deliverToEdit.DateOfBegin = inputDeliver.DateOfBegin;
            db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Delivers.Remove(db.Delivers.First(c => c.ID == id));
            db.SaveChanges();
        }

        public class DeliverFullInfo
        {
            public int ID { get; set; }
            public string FullName { get; set; }
            public List<int> OrdersID { get; set; }
        }

        public class DeliverSalery
        {
            public int ID { get; set; }
            public string fullName { get; set; }
            public DateTime DateOfBegin { get; set; }
            public int days { get; set; }  
            public double saleries { get; set; }
        }
    }
}