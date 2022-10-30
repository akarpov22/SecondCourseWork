using System.ComponentModel.DataAnnotations;

namespace CourseWorkServer.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}