using System;
using System.Drawing;
using CourseWork.Controller;
using System.Windows.Forms;

namespace CourseWork.View.Modal.Display
{
    public partial class Report : Form
    {
        TodayOrders today;
        public Report(TodayOrders today)
        {
            InitializeComponent();
            this.today = today;
            CenterToScreen();
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            ReportGrid.Rows.Clear();
            int[] report = OrdersController.CountTodayWaters(today.orders);
            string[] name = { "Стандарт", "V7", "Тара", "Помпа", "Всего" };
            ReportGrid.RowCount = report.Length;

            for (int i = 0; i < report.Length; i++)
            {
                ReportGrid.Rows[i].Cells[0].Value = name[i];
                ReportGrid.Rows[i].Cells[1].Value = Convert.ToString(report[i]);
            }
            using (Font font = new Font(ReportGrid.DefaultCellStyle.Font.FontFamily, 12, FontStyle.Bold))
                ReportGrid.Rows[report.Length - 1].Cells[0].Style.Font = font;
        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
