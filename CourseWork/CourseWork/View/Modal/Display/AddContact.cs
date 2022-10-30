using System;
using System.Windows.Forms;
using CourseWork.Controller;

namespace CourseWork.View.Modal.Display
{
    public partial class AddContact : Form
    {
        PhoneOfClient phones;
        public AddContact(PhoneOfClient phones)
        {
            InitializeComponent();
            label3.Visible = false;
            this.phones = phones;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PhoneBox.Text.Length == 13)
            {
                label3.Visible = false;
                ClientsController.AddPhone(phones.client, PhoneBox.Text, NameBox.Text);
                phones.PhonePrint(phones.client);
                this.Close();
            }
            else
                label3.Visible = true;
        }
    }
}
