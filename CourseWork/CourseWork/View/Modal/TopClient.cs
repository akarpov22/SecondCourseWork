using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.Model;
using CourseWork.Controller;

namespace CourseWork.View.Modal
{
    public partial class TopClient : Form
    {
        public TopClient()
        {
            InitializeComponent();

            List<Client> clients = ClientsController.TopClients();
            int i = 0;
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = clients.Count;
            foreach (Client client in clients)
            {
                dataGridView1.Rows[i].Cells[0].Value = i+1;
                dataGridView1.Rows[i].Cells[1].Value = client.Address;
                dataGridView1.Rows[i].Cells[2].Value = client.orders.Count;
                i++;
            }
        }
    }
}
