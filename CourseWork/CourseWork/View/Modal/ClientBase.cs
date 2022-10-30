using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.View.Modal.Display;
using CourseWork.Model;
using CourseWork.Model.ApiModel;
using CourseWork.Controller;

namespace CourseWork.View.Modal
{
    public partial class ClientBase : Form
    {
        MainScreen main;
        List<Client> clients;
        DataGridView clientsGrid;
        public DataGridView DataGridView1
        {
            get { return dataGridView1; }
        }
        public ClientBase(MainScreen main)
        {
            InitializeComponent();
            this.clientsGrid = dataGridView1;
            this.Name = "ClientsBase";
            this.main = main;
            UpdateSearchClients();
            UpdateStat();
        }

        public void UpdateSearchClients()
        {
            clients = ClientsController.SearchClients(textBox1.Text);
            UpdateGrid();
        }

        public void UpdateSortUpClients()
        {
            clients = ClientsController.SortUpClients();
            UpdateGrid();
        }

        public void UpdateSortDownClients()
        {
            clients = ClientsController.SortDownClients();
            UpdateGrid();
        }

        public void UpdateGrid()
        {
            clientsGrid.Rows.Clear();
            int countClients = clients.Count;
            if (countClients > 0)
            {
                clientsGrid.RowCount = countClients;
                int i = 0;
                foreach (Client client in clients)
                {
                    clientsGrid.Rows[i].Cells[0].Value = i + 1;
                    clientsGrid.Rows[i].Cells[1].Value = client.Address;
                    clientsGrid.Rows[i].Cells[2].Value = "Контакты";
                    clientsGrid.Rows[i].Cells[3].Value = "Заказы";
                    i++;
                }
            }
        }

        public void UpdateStat()
        {
            countClients.Text = Convert.ToString(ClientsController.GetCountClients(main.GetClients()));
            newClients.Text = Convert.ToString(ClientsController.GetCountNewClients(main.GetClients()));
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    Client client = clients[e.RowIndex];
                    new OrdersOfClient(main, client).Show();
                }
                if (e.ColumnIndex == 2)
                {
                    Client client = clients[e.RowIndex];
                    new PhoneOfClient(client).Show();
                }
                if (e.ColumnIndex == 4)
                {
                    if (clients[e.RowIndex] != null)
                        new YouSureContact(this, e.RowIndex, main).Show();
                }
            }
            catch { }
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            new AddClient(main, this).Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateSearchClients();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateSortUpClients();
            button2.Enabled = false;
            button1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateSortDownClients();
            button2.Enabled = true;
            button1.Enabled = false;
        }
    }
}
