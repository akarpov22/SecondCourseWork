using System;
using System.Windows.Forms;
using CourseWork.Model;
using CourseWork.Controller;

namespace CourseWork.View.Modal
{
    public partial class AddOrder : Form
    {
        Client client;
        MainScreen main;
        Order order = new Order();
        string[] products = { "Вода Стандарт", "Вода V7", "Помпа", "Тара" };
        int[] prices = { 65, 70, 130, 160 };
        public AddOrder(Client client, MainScreen main)
        {
            InitializeComponent();
            this.client = client;
            comboBox1.Items.AddRange(products);
            ErrorLabel.Visible = false;
            this.main = main;
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            int i = 0;
            int allCount = 0;
            int allSum = 0;

            OrderGrid.Rows.Clear();
            if (order.positions.Count > 0)
            {
                OrderGrid.RowCount = order.positions.Count;
                foreach (var position in order.positions)
                {
                    OrderGrid.Rows[i].Cells[0].Value = i + 1;
                    OrderGrid.Rows[i].Cells[1].Value = position.name;
                    OrderGrid.Rows[i].Cells[2].Value = position.price;
                    OrderGrid.Rows[i].Cells[3].Value = position.sum;
                    i++;
                    allCount += position.sum;
                    allSum += position.price * position.sum;
                }
            }
            AllCount.Text = Convert.ToString(allCount);
            Sum.Text = Convert.ToString(allSum);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Price1.Text = Convert.ToString(prices[comboBox1.SelectedIndex]);
        }

        private void DeleteItem(string deleteData)
        {
            string[] tempProducts = new string[products.Length - 1];
            int[] tempPrices = new int[prices.Length - 1];
            int length = 0;
            for (int i = 0; i < products.Length; i++)
                if (products[i] != deleteData)
                {
                    tempProducts[length] = products[i];
                    tempPrices[length++] = prices[i];
                }
            prices = tempPrices;
            products = tempProducts;
        }

        private void AddItem(Order.Position position)
        {
            string[] tempProducts = new string[products.Length + 1];
            int[] tempPrices = new int[prices.Length + 1];
            for (int i = 0; i < products.Length; i++)
            {
                tempPrices[i] = prices[i];
                tempProducts[i] = products[i];
            }
            tempPrices[prices.Length] = position.price;
            tempProducts[products.Length] = position.name;
            prices = tempPrices;
            products = tempProducts;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (order.positions.Count > 0)
            {
                order.Other = textBox1.Text;
                OrdersController.AddOrder(client, order);
                main.UpdateGridActualOrders(main.ordersGrid);
                this.Close();
            }
            else
                ErrorLabel.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OrdersController.AddToOrder(ref order, comboBox1.SelectedItem.ToString(),
                                                   Convert.ToInt32(Price1.Text), Convert.ToInt32(Count1.Text));
                ErrorLabel.Visible = false;
                Price1.Text = "";
                Count1.Text = "";
                UpdateGrid();
                DeleteItem(comboBox1.SelectedItem.ToString());
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(products);
                comboBox1.Text = "";

            }
            catch { ErrorLabel.Visible = true; }
        }

        private void OrderGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 4) && (order.positions.Count > 0))
            {
                AddItem(order.positions[e.RowIndex]);
                comboBox1.Items.Clear();
                comboBox1.Items.AddRange(products);
                comboBox1.Update();
                order.positions.RemoveAt(e.RowIndex);
                UpdateGrid();
            }
        }
    }
}
