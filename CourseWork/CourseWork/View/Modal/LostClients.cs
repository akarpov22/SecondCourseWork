using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.Controller;
using CourseWork.Model;
using CourseWork.View.Modal.Display;

namespace CourseWork.View.Modal
{
    public partial class LostClients : Form
    {
        MainScreen main;
        List<Client> clients;
        public LostClients(MainScreen main)
        {
            InitializeComponent();
            this.main = main;
            UpdateGridClients(clientsGrid);
            countClients.Text = Convert.ToString(ClientsController.GetCountLostClient(clients));
        }

        public void UpdateGridClients(DataGridView clientsGrid)
        {
            clients = ClientsController.LostClients();
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
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
