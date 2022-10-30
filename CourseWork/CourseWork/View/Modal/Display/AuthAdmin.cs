using System;
using System.Windows.Forms;
using CourseWork.Controller;

namespace CourseWork.View.Modal.Display
{
    public partial class AuthAdmin : Form
    {
        PhoneOfClient contacts;
        ClientBase clients;
        MainScreen main;
        int i;
        public AuthAdmin(PhoneOfClient contacts, int i)
        {
            InitializeComponent();
            this.contacts = contacts;
            this.i = i;
            button1.Visible = true;
            button2.Visible = false;
        }

        public AuthAdmin(ClientBase clients, int i, MainScreen main)
        {
            InitializeComponent();
            this.clients = clients;
            this.i = i;
            this.main = main;
            button1.Visible = false;
            button2.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserController.CheckPasswordLVL2(textBox1.Text))
            {
                ClientsController.DeleteContact(contacts.client, i);
                contacts.PhonePrint(contacts.client);
                this.Close();
            }
            else
                this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (UserController.CheckPasswordLVL2(textBox1.Text))
            {
                ClientsController.DeleteClient(main.GetClients(), i);
                main.UpdateGridActualOrders(main.ordersGrid);
                clients.UpdateSearchClients();
                clients.UpdateStat();
                this.Close();
            }
            else
                this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.PasswordChar == '\0')
                textBox1.PasswordChar = '*';
            else
                textBox1.PasswordChar = '\0';
        }
    }
}
