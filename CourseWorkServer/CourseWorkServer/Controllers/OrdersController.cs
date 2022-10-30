using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using CourseWorkServer.Model.ClientModel;
using CourseWorkServer.Models;
using CourseWorkServer.Models.DbContexts;

namespace CourseWorkServer.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrdersController : ControllerBase
    {
        readonly AppDbContext db = new AppDbContext();

        [HttpGet]
        public List<Order> Get() => db.Orders.ToList();

        [HttpGet("{id}")]
        public Order Get(int id) => db.Orders.First(d => d.ID == id);

        [HttpGet("fullInfo")]
        public List<OrderFullInfo> GetFullInfo()
        {
            List<OrderFullInfo> result = new List<OrderFullInfo>();

            foreach (var order in db.Orders)
                result.Add(new OrderFullInfo
                {
                    ID = order.ID,
                    DateOfOrder = order.DateOfOrder,
                    DeliverName = db.Delivers.First(d => d.ID == order.DeliversID).FullName,
                    Status = order.Status,
                    ClientAddress = db.Clients.First(c => c.ID == order.ClientsID).Address,
                    ClientPhones = db.Phones.Where(p => p.ClientID == order.ClientsID)
                                                .Select(p => p.PhoneNumber)
                                                .ToList(),
                    ProductName = db.Orders_Products.Where(op => op.OrdersID == db.Orders.First(o => o.ID == order.ID).ID)
                                         .Select(op => op).Join(db.Products,
                                                  op => op.ProductsID,
                                                  p => p.ID,
                                                  (op, p) => p.Name).ToList(),
                    ProductPrice = db.Orders_Products.Where(op => op.OrdersID == db.Orders.First(o => o.ID == order.ID).ID)
                                         .Select(op => op).Join(db.Products,
                                                  op => op.ProductsID,
                                                  p => p.ID,
                                                  (op, p) => p.Price).ToList(),
                    Quantity = db.Orders_Products.Where(op => op.OrdersID == order.ID)
                                                .Select(op => op.Quantity)
                                                .ToList(),
                }) ;

            return result;
        }

        [HttpGet("fullInfo/{id}")]
        public OrderFullInfo GetFullInfo(int id) => new OrderFullInfo
        {
            ID = id,
            DateOfOrder = db.Orders.First(o => o.ID == id).DateOfOrder,
            DeliverName = db.Delivers.First(d => d.ID == db.Orders
                                     .First(o => o.ID == id).DeliversID)
                                     .FullName,
            ClientAddress = db.Clients.First(c => c.ID == db.Orders
                                    .First(o => o.ID == id).ClientsID)
                                    .Address,
            ProductName = db.Orders_Products.Join(db.Products,
                                                  op => op.ProductsID,
                                                  p => p.ID,
                                                  (op, p) => p.Name)
                                             .ToList(),
            ProductPrice = db.Orders_Products.Where(op => op.OrdersID == db.Orders.First(o => o.ID == id).ID)
                                         .Select(op => op).Join(db.Products,
                                                  op => op.ProductsID,
                                                  p => p.ID,
                                                  (op, p) => p.Price).ToList(),
            Quantity = db.Orders_Products.Where(op => op.OrdersID == db.Orders.First(o => o.ID == id).ID)
                                         .Select(op => op.Quantity)
                                         .ToList()
        };

        [HttpPost]
        public void Post([FromBody] Order inputOrder)
        {
            db.Orders.Add(inputOrder);
            db.SaveChanges();
        }

        [HttpPut]
        public void Put([FromBody] Order inputOrder)
        {
            var orderToEdit = db.Orders.First(o => o.ID == inputOrder.ID);
            orderToEdit.ClientsID = inputOrder.ClientsID;
            orderToEdit.DeliversID = inputOrder.DeliversID;
            orderToEdit.DateOfOrder = inputOrder.DateOfOrder;
            orderToEdit.Status = inputOrder.Status;
            orderToEdit.Other = inputOrder.Other;
            db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Orders.Remove(db.Orders.First(o => o.ID == id));
            db.SaveChanges();
        }

        public static OrderC ConvertOrder(Order baseOrder)
        {
            OrderC Order = new OrderC(baseOrder.ID, baseOrder.DateOfOrder, Convert.ToBoolean(baseOrder.Status));
            Order.Other = baseOrder.Other;
            AppDbContext db = new AppDbContext();
            List<int> productID = db.Orders_Products.Where(op => op.OrdersID == baseOrder.ID).Join(db.Orders,
                                                  op => op.OrdersID,
                                                  o => o.ID,
                                                  (op, o) => op.ID).ToList();
            foreach(int i in productID)
            {
                OrderC.Position position = new();
                position.sum = db.Orders_Products.Where(op => op.ID == i).Select(op => op.Quantity).First();
                position.name = db.Orders_Products.Where(op => op.ID == i).Join(db.Products, op => op.ProductsID, p => p.ID, (op, p) => p.Name).First();
                position.price = Convert.ToInt32(db.Orders_Products.Where(op => op.ID == i).Join(db.Products, op => op.ProductsID, p => p.ID, (op, p) => p.Price).First());
                Order.positions.Add(position);
            }
            return Order;
        }

        public class OrderFullInfo
        {
            public int ID { get; set; }
            public System.DateTime DateOfOrder { get; set; }
            public List<string> ProductName { get; set; }
            public List<double> ProductPrice { get; set; }
            public List<int> Quantity { get; set; }
            public byte Status { get; set; }
            public string DeliverName { get; set; }
            public string ClientAddress { get; set; }
            public List<string> ClientPhones { get; set; }
        }
    }
}