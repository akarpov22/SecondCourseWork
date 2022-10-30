using System.ComponentModel.DataAnnotations;

namespace CourseWorkServer.Models
{
    public class Orders_Products
    {
        [Key]
        public int ID { get; set; }
        public int OrdersID { get; set; }
        public int ProductsID { get; set; }
        public int Quantity { get; set; }
    }
}