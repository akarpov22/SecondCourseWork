using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork.View.Modal.Display
{
    public partial class OtherForm : Form
    {
        public OtherForm(string input)
        {
            InitializeComponent();
            textBox1.Text = input;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
