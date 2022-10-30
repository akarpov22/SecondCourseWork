using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System;
using CourseWorkServer.Models;
using CourseWorkServer.Model.ClientModel;
using CourseWorkServer.Models.DbContexts;

namespace CourseWorkServer.Controllers
{
    [ApiController]
    [Route("clients")]
    public class ClientsController : ControllerBase
    {
        readonly AppDbContext db = new AppDbContext();

        [HttpGet]
        public List<Client> Get() => db.Clients.ToList();

        [HttpGet("{id}")]
        public Client Get(int id) => db.Clients.First(c => c.ID == id);


        [HttpGet("fullInfo")]
        public List<ClientFullInfo> GetFullInfo() => db.Clients.Select(c =>
            new ClientFullInfo
            {
                ID = c.ID,
                Address = c.Address,
                DateOfCreate = c.DateOfCreate,
                OrdersID = db.Orders.Where(o => o.ClientsID == c.ID)
                                    .Select(o => o.ID)
                                    .ToList(),
                PhonesNumbers = db.Phones.Where(p => p.ClientID == c.ID)
                                         .Select(p => p.PhoneNumber)
                                         .ToList()
            }).ToList();

        [HttpGet("fullInfo/{id}")]
        public ClientFullInfo GetFullInfo(int id) => new ClientFullInfo
        {
            ID = id,
            Address = db.Clients.First(c => c.ID == id).Address,
            DateOfCreate = db.Clients.First(c => c.ID == id).DateOfCreate,
            OrdersID = db.Orders.Where(o => o.ClientsID == id)
                                .Select(o => o.ID)
                                .ToList(),
            PhonesNumbers = db.Phones.Where(p => p.ClientID == id)
                                     .Select(p => p.PhoneNumber)
                                     .ToList()
        };

        [HttpGet("search/{search}")]
        public List<ClientC> Search(string search)
        {
            List<Client> baseClients = search == "*" ? db.Clients.ToList() :
                db.Clients.Where(c => c.Address.ToUpper().Contains(search)).ToList();
            List<ClientC> result = new List<ClientC>();
            foreach (Client baseClient in baseClients)
                result.Add(ClientConverter(baseClient));
            return result;
        }

        [HttpGet("sortup")]
        public List<ClientC> SortUp()
        {
            List<Client> baseClients = db.Orders.GroupBy(o => o.ClientsID).
                Select(c => new { id = c.Key, count = c.Count() }).OrderBy(c => c.count).
                Join(db.Clients, o => o.id, c => c.ID, (o, c) => (c)).ToList();
            List<ClientC> result = new List<ClientC>();
            foreach (Client baseClient in baseClients)
                result.Add(ClientConverter(baseClient));
            return result;
        }

        [HttpGet("sortdown")]
        public List<ClientC> SortDown()
        {
            List<Client> baseClients = db.Orders.GroupBy(o => o.ClientsID).
                Select(c => new { id = c.Key, count = c.Count() }).OrderByDescending(c => c.count).
                Join(db.Clients, o => o.id, c => c.ID, (o, c) => (c)).ToList();
            List<ClientC> result = new List<ClientC>();
            foreach (Client baseClient in baseClients)
                result.Add(ClientConverter(baseClient));
            return result;
        }

        [HttpGet("topclient")]
        public List<ClientC> TopClient()
        {
            List<Client> baseClients = db.Orders.GroupBy(o => o.ClientsID).
                Select(c => new { id = c.Key, count = c.Count() }).OrderByDescending(c => c.count).
                Join(db.Clients, o => o.id, c => c.ID, (o, c) => (c)).Take(3).ToList();
            List<ClientC> result = new();
            foreach (Client baseClient in baseClients)
                result.Add(ClientConverter(baseClient));
            return result;
        }

        [HttpGet("ordercount")]
        public int OrderCount()
        {
            int result = db.Orders.Where(o => o.DateOfOrder.Date == DateTime.Now.Date).Count();
            return result;
        }

        [HttpGet("ordersortdown")]
        public List<OrderAddress> OrderSortDown()
        {
            List<Order> baseOrders = db.Orders.Where(o => o.DateOfOrder.Date == DateTime.Now.Date).
               OrderByDescending(c => c.DateOfOrder).ToList();


            List<OrderAddress> result = new List<OrderAddress>();

            foreach (Order baseOrder in baseOrders)
                result.Add(new OrderAddress()
                {
                    Order = OrdersController.ConvertOrder(baseOrder),
                    Address = db.Clients.Where(c => c.ID == baseOrder.ClientsID).First().Address
                });
            return result;
        }

        [HttpGet("ordersortup")]
        public List<OrderAddress> OrderSortUp()
        {
            List<Order> baseOrders = db.Orders.Where(o => o.DateOfOrder.Date == DateTime.Now.Date).
                OrderBy(c => c.DateOfOrder).ToList();


            List<OrderAddress> result = new List<OrderAddress>();

            foreach (Order baseOrder in baseOrders)
                result.Add(new OrderAddress()
                {
                    Order = OrdersController.ConvertOrder(baseOrder),
                    Address = db.Clients.Where(c => c.ID == baseOrder.ClientsID).First().Address
                });
            return result;
        }

        [HttpGet("actualOrders")]
        public List<OrderAddress> ActualOrders()
        {
            List<Order> baseOrders = db.Orders.Where(o => o.Status == 0).ToList();


            List<OrderAddress> result = new List<OrderAddress>();

            foreach (Order baseOrder in baseOrders)
                result.Add(new OrderAddress()
                {
                    Order = OrdersController.ConvertOrder(baseOrder),
                    Address = db.Clients.Where(c => c.ID == baseOrder.ClientsID).First().Address
                });
            return result;
        }

        [HttpGet("lost")]
        public List<ClientC> Lost()
        {
            DateTime lostDate = DateTime.Now.AddDays(-14);
            List<Client> baseClients = db.Orders.Where(o => o.DateOfOrder < lostDate).
            Join(db.Clients, o => o.ClientsID, c => c.ID, (o, c) => c).Distinct().ToList();

            List<ClientC> result = new List<ClientC>();
            foreach (Client baseClient in baseClients)
                result.Add(ClientConverter(baseClient));
            return result;
        }

        [HttpGet("month")]
        public int[] Month()
        {
            int[] result = new int[12];
            for (int i = 0; i < result.Length; i++)
            {
                try
                {
                    result[i] = db.Orders.Where(o => o.DateOfOrder.Year == DateTime.Now.Year && o.DateOfOrder.Month == i).
                    GroupBy(o => o.DateOfOrder.Month).Select(o => o.Count()).First();
                }
                catch { }
            }

            return result;
        }

        [HttpGet("day")]
        public int[] Day()
        {
            int[] result = new int[7];
            List<DayOfWeek> temp = new();
            DayOfWeek[] days = { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday };
            for (int i = 0; i < result.Length; i++)
            {
                try
                {
                    result[i] = db.Orders.ToList().Where(o => (o.DateOfOrder.Year == DateTime.Now.Year) && (o.DateOfOrder.DayOfWeek == days[i])).
                    GroupBy(o => o.DateOfOrder.DayOfWeek).Select(o => o.Count()).First();
                    temp = db.Orders.ToList().Where(o => o.DateOfOrder.DayOfWeek ==days[i]).Select(o => o.DateOfOrder.DayOfWeek).ToList();
                }
                catch { }
            }

            return result;
        }

        [HttpGet("daydelivery")]
        public List<DeliverStat> DayD()
        {
            List<DeliverStat> result = new();

            List<Deliver> baseDelivers = db.Delivers.ToList();

            foreach (Deliver baseDeliver in baseDelivers)
            {
                int[] statTemp = new int[7];
                List<DayOfWeek> temp = new();
                DayOfWeek[] days = { DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday, DayOfWeek.Friday, DayOfWeek.Saturday, DayOfWeek.Sunday };
                for (int i = 0; i < statTemp.Length; i++)
                {
                    try
                    {
                        statTemp[i] = db.Orders.ToList().Where(o => (o.DateOfOrder.Month == DateTime.Now.Month) && (o.DateOfOrder.DayOfWeek == days[i]) && o.DeliversID == baseDeliver.ID).
                        GroupBy(o => o.DateOfOrder.DayOfWeek).Select(o => o.Count()).First();
                        temp = db.Orders.ToList().Where(o => o.DateOfOrder.DayOfWeek == days[i]).Select(o => o.DateOfOrder.DayOfWeek).ToList();
                    }
                    catch { }
                }

                result.Add(new DeliverStat() { Name = baseDeliver.FullName, Stat = statTemp });
            }

            return result;
        }

        [HttpPost]
        public void Post([FromBody] Client inputClient)
        {
            db.Clients.Add(inputClient);
            db.SaveChanges();
        }

        [HttpPut]
        public void Put([FromBody] Client inputClient)
        {
            var clientToEdit = db.Clients.First(c => c.ID == inputClient.ID);
            clientToEdit.Address = inputClient.Address;
            clientToEdit.DateOfCreate = inputClient.DateOfCreate;
            db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            db.Clients.Remove(db.Clients.First(c => c.ID == id));
            db.SaveChanges();
        }

        public ClientC ClientConverter(Client baseClient)
        {
            ClientC client = new ClientC(baseClient.ID, baseClient.Address, baseClient.DateOfCreate);
            List<int> OrdersID = db.Orders.Where(o => o.ClientsID == baseClient.ID).Select(o => o.ID).ToList();
            foreach (int id in OrdersID)
                client.orders.Add(OrdersController.ConvertOrder(db.Orders.Where(o => o.ID == id).First()));
            List<Phone> basePhones = db.Phones.Where(p => p.ClientID == baseClient.ID).ToList();
            foreach (Phone phone in basePhones)
                client.phones.Add(new ClientC.Phone() { phone = phone.PhoneNumber, name = phone.Name });
            return client;
        }
        public class ClientFullInfo
        {
            public int ID { get; set; }
            public string Address { get; set; }
            public DateTime DateOfCreate { get; set; }
            public List<int> OrdersID { get; set; }
            public List<string> PhonesNumbers { get; set; }
        }

        public class OrderAddress
        {
            public OrderC Order { get; set; }
            public string Address { get; set; }
        }

        public class DeliverStat
        {
            public string Name { get; set; }
            public int[] Stat { get; set; }
        }
    }
}