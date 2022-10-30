using System;
using System.Windows.Forms;
using CourseWork.Model;

namespace CourseWork.View.Modal.Display
{
    public partial class OrderForm : Form
    {
        Order mainOrder;
        public OrderForm(Order order)
        {
            InitializeComponent();
            mainOrder = order;
            OrderPrint(order);
        }

        public void OrderPrint(Order order)
        {
            int i = 0;
            int sum = 0;
            OrderGrid.RowCount = mainOrder.positions.Count;
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

        private void OrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new OtherForm(mainOrder.Other).Show();
        }
    }
}
