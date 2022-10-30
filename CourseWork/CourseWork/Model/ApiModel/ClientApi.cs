using System;
using System.Collections.Generic;

namespace CourseWork.Model.ApiModel
{
    class ClientApi
    {
        public int ID { get; set; }
        public string Address { get; set; }
        public DateTime DateOfCreate { get; set; }
        public List<int> OrdersID { get; set; }
        public List<string> PhonesNumbers { get; set; }

    }

    class ClientApiPOST
    {
        public string Address { get; set; }
        public DateTime DateOfCreate { get; set; }

        public ClientApiPOST(string address, DateTime dateOfCreature)
        {
            Address = address;
            DateOfCreate = dateOfCreature;
        }
    }
}
