using System;
using System.Collections.Generic;

namespace CourseWork.Model
{
    public class Client
    {
        public int ID { get; set; }
        private string _address = "";
        private DateTime? _firstOrder;
        public List<Order> orders = new List<Order>();
        public List<Phone> phones { get; set; }  = new List<Phone>();

        public string Address
        {
            get => _address;
            set
            {
                if (value.Length > 0 && value.Length <= 40)
                    _address = value;
            }
        }
        public DateTime? FirstOrder
        {
            get => _firstOrder;
        }

        public Client(string adress, DateTime? firstOrder = null)
        {
            _address = adress;
            _firstOrder = firstOrder == null ? DateTime.Now : firstOrder;
        }
        public class Phone
        {
            public string phone { get; set; }
            public string name { get; set; }
        }
    }
}
