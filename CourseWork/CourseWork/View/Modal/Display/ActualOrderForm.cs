using System;
using System.Windows.Forms;
using CourseWork.Model;
using CourseWork.Controller;

namespace CourseWork.View
{
    public partial class ActualOrderForm : Form
    {
        Order mainOrder;
        MainScreen mainForm;
        public ActualOrderForm(Order order, MainScreen main, int i)
        {
            InitializeComponent();
            mainOrder = order;
            mainForm = main;
            this.Name = "ActualForm";
            this.Tag = Convert.ToString(i);
            OrderPrint(order);
        }

        public void OrderPrint(Order order)
        {
            int i = 0;
            int sum = 0;
            OrderGrid.RowCount = order.positions.Count;
            foreach (var position in order.positions)
            {
                OrderGrid.Rows[i].Cells[0].Value = i + 1;
                OrderGrid.Rows[i].Cells[1].Value = position.name;
                OrderGrid.Rows[i].Cells[2].Value = position.price;
                OrderGrid.Rows[i].Cells[3].Value = position.sum;
                i++;
                sum += position.sum * position.price;
            }
            SumLabel.Text = Convert.ToString(sum);
            MaxLabel.Text = Convert.ToString(i);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainOrder.Status = true;
            OrdersController.OrderStatusChange(mainOrder);
            mainForm.UpdateGridActualOrders(mainForm.ordersGrid);
            this.Close();
        }
    }
}
