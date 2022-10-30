using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.Controller;
using CourseWork.Model;
using CourseWork.View.Modal.Display;

namespace CourseWork.View.Modal
{
    public partial class TodayOrders : Form
    {
        public List<ClientsController.OrderAddress> orders;
        public TodayOrders()
        {
            InitializeComponent();
            this.Name = "TodayOrders";
            SortUp();
            UpdateGrid();
        }

        private void SortUp()
        {
            orders = ClientsController.TodayOrdersUp();
            UpdateGrid();
            button2.Enabled = false;
            button3.Enabled = true;
        }
        private void SortDown()
        {
            orders = ClientsController.TodayOrdersDown();
            UpdateGrid();
            button3.Enabled = false;
            button2.Enabled = true;
        }
        private void UpdateGrid()
        {
            OrdersGrid.Rows.Clear();
            if (orders.Count > 0)
            {
                OrdersGrid.RowCount = orders.Count;
                int i = 0;
                foreach (var order in orders)
                {
                    OrdersGrid.Rows[i].Cells[0].Value = i + 1;
                    OrdersGrid.Rows[i].Cells[1].Value = order.Address;
                    OrdersGrid.Rows[i].Cells[2].Value = order.Order.Status ? "Выполнен" : "Не выполнен";
                    OrdersGrid.Rows[i].Cells[3].Value = order.Order.CreateOrder;
                    OrdersGrid.Rows[i].Cells[4].Value = "Просмотр";
                    i++;
                }
            }
        }
        private void OrdersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4)
                    new Display.OrderForm(orders[e.RowIndex].Order).Show();
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Report(this).Show();
        }

        private void TodayOrders_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SortUp();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SortDown();
        }
    }
}
