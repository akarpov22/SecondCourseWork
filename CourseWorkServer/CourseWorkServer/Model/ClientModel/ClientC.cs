using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkServer.Model.ClientModel
{
    public class ClientC
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public DateTime? FirstOrder { get; set; }
        public List<OrderC> orders { get; set; } = new();
        public List<Phone> phones { get; set; } = new();

        public ClientC(int id, string adress, DateTime? firstOrder = null)
        {
            ID = id;
            Address = adress;
            FirstOrder = firstOrder ?? DateTime.Now;
        }

        public class Phone
        {
            public string phone { get; set; }
            public string name { get; set; }
        }
    }
}
