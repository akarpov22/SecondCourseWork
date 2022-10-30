using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.Controller;
using CourseWork.Model;

namespace CourseWork.View.Modal
{
    public partial class SearchClients : Form
    {
        MainScreen main;
        List<Client> clients;
        public SearchClients(MainScreen main)
        {
            InitializeComponent();
            this.main = main;
            UpdateGridSearchClients(textBox1.Text);
        }

        public void UpdateGridSearchClients(string search)
        {
            clients = ClientsController.SearchClients(search);
            searchClientsGrid.Rows.Clear();
            int countClients = clients.Count;
            if (countClients > 0)
            {
                searchClientsGrid.RowCount = countClients;
                int i = 0;
                foreach (Client client in clients)
                {
                    searchClientsGrid.Rows[i].Cells[0].Value = i + 1;
                    searchClientsGrid.Rows[i].Cells[1].Value = client.Address;
                    i++;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 2)
                {
                    if (clients[e.RowIndex] != null)
                        new AddOrder(clients[e.RowIndex], main).Show();
                    this.Close();
                }
            }
            catch { }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateGridSearchClients(textBox1.Text);
        }
    }
}
