using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CourseWork.Controller;
using CourseWork.Model;

namespace CourseWork.View.Modal
{
    public partial class Statistic : Form
    {
        List<Client> clients;
        string[] month = { "Январь", "Февраль", "Март", "Апрель", "Май",
                           "Июнь", "Июль", "Август", "Сентябрь", "Октябрь",
                           "Ноябрь", "Декабрь" };
        string[] days = { "Понедельник", "Вторник", "Среда", "Четверг",
                          "Пятница", "Суббота", "Воскресенье" };

        public Statistic(MainScreen main)
        {
            InitializeComponent();
            this.clients = main.GetClients();

            WeekDayEn.Visible = false;
            MonthEn.Visible = false;

            chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            chart1.ChartAreas[0].AxisX.Interval = 1;

            Month_Click(null, null);
        }

        private void Month_Click(object sender, EventArgs e)
        {
            MonthEn.Visible = true;
            WeekDayEn.Visible = false;
            int[] stat = OrdersController.GetMonthStatistic();
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < stat.Length; i++)
                chart1.Series[0].Points.Add(stat[i]).AxisLabel = month[i];
        }

        private void WeekDay_Click(object sender, EventArgs e)
        {
            MonthEn.Visible = false;
            WeekDayEn.Visible = true;
            int[] stat = OrdersController.GetWeekDayStatistic();
            chart1.Series[0].Points.Clear();
            for (int i = 0; i < stat.Length; i++)
                chart1.Series[0].Points.Add(stat[i]).AxisLabel = days[i];
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
