using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
using CourseWork.Model.ApiModel;
using CourseWork.Model;
using Newtonsoft.Json;

namespace CourseWork.Controller
{
    class LoadController
    {
        public static List<Client> LoadInfo()
        {
            //Load all client
            {
                WebRequest request = WebRequest.Create(Load.Server + "/clients/fullinfo");
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                        Load.Clients =
                                JsonConvert.DeserializeObject<List<ClientApi>>(reader.ReadToEnd());

                response.Close();
            }

            //Load all Positions
            {
                WebRequest request = WebRequest.Create(Load.Server + "/ordersproduct/");
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                        Load.ProductsOrder =
                            JsonConvert.DeserializeObject<List<ProductsOrder>>(reader.ReadToEnd());

                response.Close();
            }

            //Load all orderPost
            {
                WebRequest request = WebRequest.Create(Load.Server + "/orders/");
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                        Load.OrderPost =
                            JsonConvert.DeserializeObject<List<OrderPOST>>(reader.ReadToEnd());

                response.Close();
            }

            //Load all Product
            {
                WebRequest request = WebRequest.Create(Load.Server + "/products/");
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                        Load.Products =
                            JsonConvert.DeserializeObject<List<Product>>(reader.ReadToEnd());
                
                response.Close();
            }

            //Load orders for client
            {
                WebRequest request = WebRequest.Create(Load.Server + "/orders/fullinfo");
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                        Load.Orders =
                            JsonConvert.DeserializeObject<List<OrderApi>>(reader.ReadToEnd());

                response.Close();
            }
            //Load Phones
            {
                WebRequest request = WebRequest.Create(Load.Server + "/phones/");
                WebResponse response = request.GetResponse();
                using (Stream stream = response.GetResponseStream())
                    using (StreamReader reader = new StreamReader(stream))
                        Load.Phones =
                            JsonConvert.DeserializeObject<List<PhoneApi>>(reader.ReadToEnd());

                response.Close();
            }
            // Create needs object
            List <Client> myClients = new List<Client>();
            {
                int index = 0;
                foreach (ClientApi client in Load.Clients)
                {
                    myClients.Add(new Client(client.Address, client.DateOfCreate));
                    myClients[index].ID = client.ID;

                    for (int orderOnClientApi = 0; orderOnClientApi < client.OrdersID.Count; orderOnClientApi++)
                        for (int allOrdersApi = 0; allOrdersApi < Load.Orders.Count; allOrdersApi++)
                            if (client.OrdersID[orderOnClientApi] == Load.Orders[allOrdersApi].ID)
                            {
                                myClients[index].orders.Add(new Order(Load.Orders[allOrdersApi].DateOfOrder));

                                for (int k = 0; k < Load.Orders[allOrdersApi].ProductName.Count; k++)
                                    myClients[index].orders[orderOnClientApi].positions.Add(
                                                    new Order.Position(){ name = Load.Orders[allOrdersApi].ProductName[k],
                                                     price = Convert.ToInt32(Load.Orders[allOrdersApi].ProductPrice[k]),
                                                     sum = Load.Orders[allOrdersApi].Quantity[k]});

                                myClients[index].orders[orderOnClientApi].Status =
                                            (Load.Orders[allOrdersApi].Status == 1) ? (bool)true : (bool)false;
                                myClients[index].orders[orderOnClientApi].ID = Load.Orders[allOrdersApi].ID;
                            }
                                

                    for (int phoneClientApi = 0; phoneClientApi < client.PhonesNumbers.Count; phoneClientApi++)
                        for (int phonesIndexApi = 0; phonesIndexApi < Load.Phones.Count; phonesIndexApi++)
                            if (client.PhonesNumbers[phoneClientApi] == Load.Phones[phonesIndexApi].PhoneNumber)
                                myClients[index].phones.Add(new Client.Phone()
                                {
                                    phone = Load.Phones[phonesIndexApi].PhoneNumber,
                                    name = Load.Phones[phonesIndexApi].Name
                                });

                    index++;
                }
            }

            return myClients;
        }

    }
}
