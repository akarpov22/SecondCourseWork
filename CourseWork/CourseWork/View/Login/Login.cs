using System;
using System.Windows.Forms;
using CourseWork.Controller;

namespace CourseWork.View.Login
{
    public partial class Login : Form
    {
        MainScreen main;
        public Login(MainScreen main)
        {
            InitializeComponent();
            this.CenterToScreen();
            this.main = main;
            this.TopMost = true;
            ErrorLabel.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (UserController.CheckPasswordLVL1(PasswordBox.Text))
            {
                main.UpdateClient();
                main.Enabled = true;
                MainScreen.SetTimer();
                this.Hide();
            }
            else
                ErrorLabel.Visible = true;
        }

        private void IfClosing(object sender, EventArgs e)
        {
            main.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (PasswordBox.PasswordChar == '\0')
                PasswordBox.PasswordChar = '*';
            else
                PasswordBox.PasswordChar = '\0';
        }
    }
}
