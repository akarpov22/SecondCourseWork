using System.ComponentModel.DataAnnotations;

namespace CourseWorkServer.Models
{
    public class User
    {
        [Key]
        public string Login { get; set; }
        public string Hash { get; set; }
    }
}
