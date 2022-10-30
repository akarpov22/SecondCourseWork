using System;
using System.Windows.Forms;
using CourseWork.Model;
using CourseWork.View.Modal.Display;

namespace CourseWork.View.Modal
{
    public partial class PhoneOfClient : Form
    {
        internal Client client;
        public PhoneOfClient(Client client)
        {
            InitializeComponent();
            this.client = client;
            PhonePrint(client);
        }

        public void PhonePrint(Client client)
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            if (client.phones.Count > 0)
            {
                dataGridView1.RowCount = client.phones.Count;
                foreach (var phone in client.phones)
                {
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.Rows[i].Cells[1].Value = phone.name;
                    dataGridView1.Rows[i].Cells[2].Value = phone.phone;
                    dataGridView1.Rows[i].Cells[3].Value = "🗑";
                    i++;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((e.ColumnIndex == 3)&&(client.phones.Count > 0))
            {
                new YouSureContact(this, e.RowIndex).Show();
            }
        }


        private void AddContact_Click(object sender, EventArgs e)
        {
            new AddContact(this).Show();
        }
    }
}
