using System;
using System.Collections.Generic;
using System.Linq;
using CourseWork.Model;
using CourseWork.Model.ApiModel;
using Newtonsoft.Json;
using System.Net;
using System.IO;

namespace CourseWork.Controller
{
    class OrdersController
    {
        public static int GetCountOrders(List<Client> clients)
        {
            int count = 0;
            foreach (Client client in clients)
                count += client.orders.Count;
            return count;
        }
        public static List<Order> AllOrders(List<Client> clients)
        {
            List<Order> orders = new List<Order>();
            foreach (Client client in clients)
                foreach (Order order in client.orders)
                    orders.Add(order);

            return orders;
        }

        public static int CountActualityOrders(List<Client> clients)
        {
            int count = 0;
            foreach (Client client in clients)
                foreach (Order order in client.orders)
                    if (order.Status == false)
                    count++;

            return count;
        }

        public static List<Order> ActualOrders(List<Order> allorders)
        {
            List<Order> orders = new List<Order>();
            foreach (Order order in allorders)
                if (order.Status == false)
                    orders.Add(order);

            return orders;
        }

        public static List<Order> TodayOrders(List<Order> allorders)
        {
            List<Order> orders = new List<Order>();
            foreach (Order order in allorders)
                if (order.CreateOrder >= DateTime.Today)
                    orders.Add(order);

            return orders;
        }

        public static int GetCountMonthOrders(List<Client> clients)
        {
            int count = 0;
            foreach (Client client in clients)
                foreach (Order order in client.orders)
                    foreach (Order.Position position in order.positions)
                    {
                        if (client.FirstOrder >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
                            && (position.name == "Вода Стандарт") && (order.Status == true))
                            count += position.sum;
                        if (client.FirstOrder >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1)
                            && (position.name == "Вода V7") && (order.Status == true))
                            count += position.sum;
                    }

            return count;
        }
        public static int[] CountTodayWaters(List<ClientsController.OrderAddress> orders)
        {
            int classic = 0;
            int v7 = 0;
            int pomp = 0;
            int bottle = 0;
            foreach (ClientsController.OrderAddress orderAddress in orders)
                if (orderAddress.Order.CreateOrder >= DateTime.Today)
                        foreach (Order.Position position in orderAddress.Order.positions)
                            switch (position.name)
                            {
                                case "Вода Стандарт":
                                    classic += position.sum;
                                    break;
                                case "Вода V7":
                                    v7 += position.sum;
                                    break;
                                case "Тара":
                                    bottle += position.sum;
                                    break;
                                case "Помпа":
                                    pomp += position.sum;
                                    break;
                            }

            return new int[] { classic, v7, bottle, pomp, (v7 + classic) };
        }

        public static int CountTodayOrders(List<Client> clients)
        {
            int count = 0;
            foreach (Client client in clients)
                foreach (Order order in client.orders)
                    if (order.CreateOrder >= DateTime.Today)
                        count++;

            return count;
        }

        public static void AddToOrder(ref Order order, string name, int price, int count)
        {
            order.positions.Add(new Order.Position() { name = name, price = price, sum = count });
        }

        public static void DeleteAllOrders(Client client)
        {
            LoadController.LoadInfo();
            foreach (OrderApi order in Load.Orders)
                if (order.ClientAddress == client.Address)
                {
                    //Clean order
                    foreach(ProductsOrder position in Load.ProductsOrder)
                        if (position.OrdersID == order.ID)
                        {
                            WebRequest request = WebRequest.Create(Load.Server + "/ordersproduct/"
                                                                   + Convert.ToString(position.ID));
                            request.Method = "DELETE";
                            request.GetResponse();
                        }

                    //Delete order
                    {
                        WebRequest request = WebRequest.Create(Load.Server + "/orders/" + Convert.ToString(order.ID));
                        request.Method = "DELETE";
                        request.GetResponse();
                    }
                }
        }

        public static void OrderStatusChange(Order order)
        {
            LoadController.LoadInfo();
            foreach (OrderPOST orderPost in Load.OrderPost)
                if (orderPost.ID == order.ID)
                {
                    orderPost.Status = order.Status ? (byte)1 : (byte)0;

                    var request = WebRequest.Create(Load.Server + "/orders");
                    request.ContentType = "application/json";
                    request.Method = "PUT";

                    using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                        streamWriter.Write(JsonConvert.SerializeObject(orderPost));

                    HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                }
        }

        public static void AddOrder(Client client, Order order)
        {
            //POST order
            {
                var request = WebRequest.Create(Load.Server + "/orders");
                request.ContentType = "application/json";
                request.Method = "POST";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    streamWriter.Write(JsonConvert.SerializeObject(new OrderPOST(client.ID, (order.Status) ? (byte)1 : (byte)0, Convert.ToDateTime(order.CreateOrder),1,order.Other)));

                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            }
            //GET order ID
            int id;
            {
                WebRequest request = WebRequest.Create(Load.Server + "/orders/");
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        List<OrderPOST> tempPOST = JsonConvert.DeserializeObject<List<OrderPOST>>(reader.ReadToEnd());
                        id = tempPOST.Last().ID;
                    }

                response.Close();
            }

            //Post Products to Order
            {
                foreach (Order.Position position in order.positions)
                {
                    ProductsOrder tempPosition;
                    for (int i = 0; i < Load.Products.Count; i++)
                        if ((Load.Products[i].Name == position.name) &&
                            (Load.Products[i].Price == position.price))
                        {
                            tempPosition = new ProductsOrder(id, Load.Products[i].ID, position.sum);

                            var request = WebRequest.Create(Load.Server + "/ordersproduct/");
                            request.ContentType = "application/json";
                            request.Method = "POST";

                            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                                streamWriter.Write(JsonConvert.SerializeObject(tempPosition));

                            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                        }
                       
                }
            }
            client.orders.Add(order);
        }

        public static int[] GetMonthStatistic()
        {
            int[] statistic = new int[12];

            WebRequest request = WebRequest.Create(Load.Server + "/clients/month");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                statistic = JsonConvert.DeserializeObject<int[]>(reader.ReadToEnd());

            response.Close();
            return statistic;
        }

        public static int[] GetWeekDayStatistic()
        {
            int[] statistic = new int[7];

            WebRequest request = WebRequest.Create(Load.Server + "/clients/day");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                statistic = JsonConvert.DeserializeObject<int[]>(reader.ReadToEnd());

            response.Close();
            return statistic;
        }

        public static List<DeliverStat> GetDeliversWeekDayStatistic()
        {
            List<DeliverStat> statistic;

            WebRequest request = WebRequest.Create(Load.Server + "/clients/daydelivery");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                statistic = JsonConvert.DeserializeObject<List<DeliverStat>>(reader.ReadToEnd());

            response.Close();
            return statistic;
        }

        public static List<DeliverSalery> DeliversSalery()
        {
            List<DeliverSalery> result;

            WebRequest request = WebRequest.Create(Load.Server + "/delivers/salery");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                result = JsonConvert.DeserializeObject<List<DeliverSalery>>(reader.ReadToEnd());

            response.Close();
            return result;
        }

        public class DeliverStat
        {
            public string Name { get; set; }
            public int[] Stat { get; set; }
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
