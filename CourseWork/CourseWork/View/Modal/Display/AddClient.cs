using System;
using System.Windows.Forms;
using CourseWork.Controller;

namespace CourseWork.View.Modal.Display
{
    public partial class AddClient : Form
    {
        ClientBase clients;
        MainScreen main;
        public AddClient(MainScreen main, ClientBase clients)
        {
            InitializeComponent();
            label4.Visible = false;
            this.clients = clients;
            this.main = main;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((AddressBox.Text.Length >= 10)
              && (PhoneBox.Text.Length == 13)
              && (NameBox.Text.Length >= 2))
            {
                label4.Visible = false;
                ClientsController.AddClient(main.GetClients(),
                         AddressBox.Text, PhoneBox.Text, NameBox.Text);
                clients.UpdateSearchClients();
                clients.UpdateStat();
                this.Close();
            }
            else
                label4.Visible = true;

        }
    }
}
