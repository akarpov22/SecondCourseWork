using System.Collections.Generic;

namespace CourseWork.Model.ApiModel
{
    class Load
    {
        public static string Server = "https://127.0.0.1:5001";
        public static List<ClientApi> Clients { get; set; }
        public static List<OrderApi> Orders { get; set; }
        public static List<PhoneApi> Phones { get; set; }
        public static List<Product> Products { get; set; }
        public static List<ProductsOrder> ProductsOrder { get; set; }
        public static List<OrderPOST> OrderPost { get; set; }
    }
}
