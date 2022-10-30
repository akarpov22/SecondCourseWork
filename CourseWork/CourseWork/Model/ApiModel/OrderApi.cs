using System;
using System.Collections.Generic;

namespace CourseWork.Model.ApiModel
{
    class OrderApi
    {
        public int ID { get; set; }
        public System.DateTime DateOfOrder { get; set; }
        public List<string> ProductName { get; set; }
        public List<double> ProductPrice { get; set; }
        public List<int> Quantity { get; set; }
        public byte Status { get; set; }
        public string DeliverName { get; set; }
        public string ClientAddress { get; set; }
        public string Other { get; set; }
        public List<string> ClientPhones { get; set; }
    }

    public class OrderPOST
    {
        public int ID { get; set; }
        public int DeliversID { get; set; }
        public int ClientsID { get; set; }
        public byte Status { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string Other { get; set; }
        public OrderPOST(int clientsID, byte status, DateTime dateOfOrder, int deliversId = 1, string other = "")
        {
            Random rnd = new Random();

            DeliversID = rnd.Next(1, 3);
            ClientsID = clientsID;
            Status = status;
            DateOfOrder = dateOfOrder;
            Other = other;
        }
    }

}
