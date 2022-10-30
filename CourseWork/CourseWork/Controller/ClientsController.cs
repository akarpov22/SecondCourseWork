using System;
using System.IO;
using System.Collections.Generic;
using CourseWork.Model;
using CourseWork.Model.ApiModel;
using Newtonsoft.Json;
using System.Net;


namespace CourseWork.Controller
{
    public class ClientsController
    {
        public static int GetCountClients(List<Client> clients)
        {
            return clients.Count;
        }

        public static int GetCountNewClients(List<Client> clients)
        {
            int count = 0;
            foreach(Client client in clients)
                if (client.FirstOrder >= new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1))
                    count++;

            return count;
        }

        public static List<Order> GetOrders(Client client)
        {
            return client.orders;
        }

        public static void AddPhone(Client client, string number, string name)
        {
            client.phones.Add(new Client.Phone(){phone = number, name = name});

            var request = WebRequest.Create(Load.Server + "/phones");
            request.ContentType = "application/json";
            request.Method = "POST";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                streamWriter.Write(JsonConvert.SerializeObject(new PhoneApi(client.ID, name, number)));
            
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
        }

        public static void DeleteContact(Client client, int index)
        {
            LoadController.LoadInfo();
            //DELETE
            for (int i = 0; i < Load.Phones.Count; i++)
                if ((Load.Phones[i].PhoneNumber == client.phones[index].phone) &&
                    (Load.Phones[i].Name == client.phones[index].name))
                {
                    WebRequest request = WebRequest.Create(Load.Server + "/phones/" +
                                                           Convert.ToString(Load.Phones[i].ID));
                    request.Method = "DELETE";
                    request.GetResponse();
                }
            //
            client.phones.RemoveAt(index);
        }

        public static void DeleteAllContact(Client client)
        {
            LoadController.LoadInfo();
            //DELETE
            for (int i = 0; i < Load.Phones.Count; i++)
                if (Load.Phones[i].ClientID == client.ID)
                {
                    WebRequest request = WebRequest.Create(Load.Server + "/phones/" +
                                                           Convert.ToString(Load.Phones[i].ID));
                    request.Method = "DELETE";
                    request.GetResponse();
                }        
        }

        public static void AddClient(List<Client> clients, string address, string phone, string name)
        {
            Client temp = new Client(address);
            int id;
            //POST client
            {
                var request = WebRequest.Create(Load.Server + "/clients");
                request.ContentType = "application/json";
                request.Method = "POST";

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                    streamWriter.Write(JsonConvert.SerializeObject(new ClientApiPOST(temp.Address,
                                                                   Convert.ToDateTime(temp.FirstOrder))));
                
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            }
            //GET client ID
            {
                WebRequest request = WebRequest.Create(Load.Server + "/clients/");
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        List<ClientApi> tempPOST =
                                   JsonConvert.DeserializeObject<List<ClientApi>>(reader.ReadToEnd());
                        id = tempPOST[tempPOST.Count - 1].ID;
                    }
                response.Close();
            }
            temp.ID = id;
            clients.Add(temp);
            AddPhone(temp, phone, name);
        }

        public static void DeleteClient(List<Client> clients, int i)
        {
            LoadController.LoadInfo();
            //DELETE
            DeleteAllContact(clients[i]);
            OrdersController.DeleteAllOrders(clients[i]);

            WebRequest request = WebRequest.Create(Load.Server + "/clients/" +
                                                   Convert.ToString(clients[i].ID));
            request.Method = "DELETE";
            request.GetResponse();

            //
            clients.RemoveAt(i);
        }

        public static List<Client> SearchClients(string search)
        {
            if (search == "") search = "*";
            List < Client > searchClient = new List<Client>();
            WebRequest request = WebRequest.Create(Load.Server + "/clients/search/" + search);
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            searchClient = JsonConvert.DeserializeObject<List<Client>>(reader.ReadToEnd());

            response.Close();
            return searchClient;
        }

        public static List<Client> SortUpClients()
        {
            List<Client> clients = new List<Client>();
            WebRequest request = WebRequest.Create(Load.Server + "/clients/sortup");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                clients = JsonConvert.DeserializeObject<List<Client>>(reader.ReadToEnd());

            response.Close();
            return clients;
        }
        public static List<OrderAddress> TodayOrdersUp()
        {
            List<OrderAddress> orders = new List<OrderAddress>();
            WebRequest request = WebRequest.Create(Load.Server + "/clients/ordersortup");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                orders = JsonConvert.DeserializeObject<List<OrderAddress>>(reader.ReadToEnd());

            response.Close();
            return orders;
        }

        public static List<OrderAddress> TodayOrdersDown()
        {
            List<OrderAddress> orders = new List<OrderAddress>();
            WebRequest request = WebRequest.Create(Load.Server + "/clients/ordersortdown");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                orders = JsonConvert.DeserializeObject<List<OrderAddress>>(reader.ReadToEnd());

            response.Close();
            return orders;
        }

        public static List<OrderAddress> ActualOrdersUpdate()
        {
            List<OrderAddress> orders = new List<OrderAddress>();
            WebRequest request = WebRequest.Create(Load.Server + "/clients/actualOrders");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                orders = JsonConvert.DeserializeObject<List<OrderAddress>>(reader.ReadToEnd());

            response.Close();
            return orders;
        }

        public static int GetCountTodayOrders()
        {
            int result;
            WebRequest request = WebRequest.Create(Load.Server + "/clients/ordercount");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                result = JsonConvert.DeserializeObject<int>(reader.ReadToEnd());

            response.Close();
            return result;
        }

        public static List<Client> SortDownClients()
        {
            List<Client> clients = new List<Client>();
            WebRequest request = WebRequest.Create(Load.Server + "/clients/sortdown");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                clients = JsonConvert.DeserializeObject<List<Client>>(reader.ReadToEnd());

            response.Close();
            return clients;
        }

        public static List<Client> LostClients()
        {
            List<Client> lostClient = new List<Client>();
            WebRequest request = WebRequest.Create(Load.Server + "/clients/lost");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            lostClient = JsonConvert.DeserializeObject<List<Client>>(reader.ReadToEnd());

            response.Close();
            return lostClient;
        }
        public static List<Client> TopClients()
        {
            List<Client> lostClient = new List<Client>();
            WebRequest request = WebRequest.Create(Load.Server + "/clients/topclient");
            WebResponse response = request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
                lostClient = JsonConvert.DeserializeObject<List<Client>>(reader.ReadToEnd());

            response.Close();
            return lostClient;
        }
        public static int GetCountLostClient(List<Client> clients)
        {
            int count = 0;
            foreach (Client client in clients)
                if ((client.orders.Count > 0)
                    && (client.orders[client.orders.Count - 1].CreateOrder
                    < DateTime.Now.Subtract(new TimeSpan(14, 0, 0, 0))))
                        count++;

            return count;
        }

        public class OrderAddress
        {
            public Order Order { get; set; }
            public string Address { get; set; }
        }
    }
}
