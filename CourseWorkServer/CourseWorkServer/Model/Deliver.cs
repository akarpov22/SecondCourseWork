using System.ComponentModel.DataAnnotations;
using System;

namespace CourseWorkServer.Models
{
    public class Deliver
    {
        [Key]
        public int ID { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBegin { get; set; }
    }
}