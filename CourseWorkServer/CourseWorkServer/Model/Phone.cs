using System.ComponentModel.DataAnnotations;

namespace CourseWorkServer.Models
{
    public class Phone
    {
        [Key]
        public int ID { get; set; }
        public int ClientID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
    }
}