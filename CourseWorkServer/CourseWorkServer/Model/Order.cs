using System;
using System.ComponentModel.DataAnnotations;

namespace CourseWorkServer.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public int DeliversID { get; set; }
        public int ClientsID { get; set; }
        public byte Status { get; set; }
        public DateTime DateOfOrder { get; set; }
        public string Other { get; set; }
    }
}