
namespace CourseWork.Model.ApiModel
{
    class ProductsOrder
    {
        public int ID { get; set; }
        public int OrdersID { get; set; }
        public int ProductsID { get; set; }
        public int Quantity { get; set; }
        public ProductsOrder(int ordersId, int productsID, int quantity)
        {
            OrdersID = ordersId;
            ProductsID = productsID;
            Quantity = quantity;
        }
    }
}
