using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkServer.Model.ClientModel
{
    public class OrderC
    {
        public int ID { get; set; }
        public List<Position> positions { get; set; } = new();
        public DateTime? CreateOrder { get; set; }
        public bool Status { get; set; }
        public string Other { get; set; }

        public OrderC(int id, DateTime? createOrder = null, bool status = false)
        {
            ID = id;
            CreateOrder = createOrder == null ? DateTime.Now : createOrder;
            Status = status;
        }
        public class Position
        {
            public string name { get; set; }
            public int price { get; set; }
            public int sum { get; set; }
        }
    }
}
