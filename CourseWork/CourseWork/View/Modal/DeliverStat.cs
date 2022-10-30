using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CourseWork.Controller;

namespace CourseWork.View.Modal
{
    public partial class DeliverStat : Form
    {
        public DeliverStat()
        {
            InitializeComponent();

            List<OrdersController.DeliverStat> delivers = OrdersController.GetDeliversWeekDayStatistic();
            int i = 0;
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = delivers.Count;
            foreach (OrdersController.DeliverStat deliver in delivers)
            {
                dataGridView1.Rows[i].Cells[0].Value = deliver.Name;
                dataGridView1.Rows[i].Cells[1].Value = deliver.Stat[0];
                dataGridView1.Rows[i].Cells[2].Value = deliver.Stat[1];
                dataGridView1.Rows[i].Cells[3].Value = deliver.Stat[2];
                dataGridView1.Rows[i].Cells[4].Value = deliver.Stat[3];
                dataGridView1.Rows[i].Cells[5].Value = deliver.Stat[4];
                dataGridView1.Rows[i].Cells[6].Value = deliver.Stat[5];
                dataGridView1.Rows[i].Cells[7].Value = deliver.Stat[6];
                i++;
            }
        }
    }
}
