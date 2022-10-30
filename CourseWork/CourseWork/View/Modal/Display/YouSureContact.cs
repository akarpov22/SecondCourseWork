using System;
using System.Windows.Forms;

namespace CourseWork.View.Modal.Display
{
    public partial class YouSureContact : Form
    {
        PhoneOfClient phones;
        ClientBase clients;
        MainScreen main;
        int i;
        public YouSureContact(PhoneOfClient phones, int i)
        {
            InitializeComponent();
            this.phones = phones;
            this.i = i;
            buttonYes.Visible = true;
            buttonYes2.Visible = false;
        }

        public YouSureContact(ClientBase clients, int i, MainScreen main)
        {
            InitializeComponent();
            this.clients = clients;
            this.i = i;
            this.main = main;
            buttonYes.Visible = false;
            buttonYes2.Visible = true;
        }

        private void buttonYes_Click(object sender, EventArgs e)
        {
            new AuthAdmin(phones, i).Show();
            this.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonYes2_Click(object sender, EventArgs e)
        {
            new AuthAdmin(clients, i, main).Show();
            this.Close();
        }
    }
}
