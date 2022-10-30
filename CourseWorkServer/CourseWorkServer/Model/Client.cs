using System.ComponentModel.DataAnnotations;
using System;

namespace CourseWorkServer.Models
{
    public class Client
    {
        [Key]
        public int ID { get; set; }
        public string Address { get; set; }
        public DateTime DateOfCreate { get; set; }
    }
}