using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.Model;
using CourseWork.Controller;

namespace CourseWork.View.Modal.Display
{
    public partial class OrdersOfClient : Form
    {
        Client client;
        public OrdersOfClient(MainScreen main, Client client)
        {
            InitializeComponent();
            UpdateGridOrders(client);
            this.client = client;
            countOrders.Text = Convert.ToString(ClientsController.GetOrders(client).Count);
        }

        private void UpdateGridOrders(Client client)
        {
            OrdersGrid.Rows.Clear();
            List<Order> orders = ClientsController.GetOrders(client);
            int countOrders = orders.Count;
            if (countOrders > 0)
            {
                OrdersGrid.RowCount = countOrders;
                int i = 0;
                foreach (var order in orders)
                {
                    OrdersGrid.Rows[i].Cells[0].Value = i + 1;
                    OrdersGrid.Rows[i].Cells[1].Value = order.Status?"Выполнен":"Не выполнен";
                    OrdersGrid.Rows[i].Cells[2].Value = order.CreateOrder;
                    OrdersGrid.Rows[i].Cells[3].Value = "Просмотр";
                    i++;
                }
            }
        }

        private void OrdersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
                new OrderForm(ClientsController.GetOrders(client)[e.RowIndex]).Show();
        }
    }
}
