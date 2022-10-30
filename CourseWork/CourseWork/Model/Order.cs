using System;
using System.Collections.Generic;

namespace CourseWork.Model
{
    public class Order
    {
        public int ID { get; set; }
        public List<Position> positions { get; set; }  = new List<Position>();
        private DateTime? _createOrder;
        private bool _status;
        public string Other { get; set; }
        public DateTime? CreateOrder
        {
            get => _createOrder;
        }
        public bool Status
        {
            get => _status;
            set => _status = value;
        }

        public Order(DateTime? createOrder = null, bool status = false)
        {
            _createOrder = createOrder == null ? DateTime.Now : createOrder;
            _status = status;
        }
        public class Position
        {
            public string name { get; set; }
            public int price { get; set; }
            public int sum { get; set; }
        }
    }
}
