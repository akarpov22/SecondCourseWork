using System;
using System.Net;
using System.Collections.Generic;
using System.Timers;
using System.Drawing;
using CourseWork.Model;
using CourseWork.Controller;
using System.Windows.Forms;
using CourseWork.View;
using CourseWork.View.Login;
using CourseWork.View.Modal;

namespace CourseWork
{
    public partial class MainScreen : Form
    {
        static List<Client> clients;
        static List<ClientsController.OrderAddress> orders;
        public static MainScreen MainForm;
        Form todayOrdersForm;
        Form CleintsBaseForm;
        private static System.Timers.Timer SyncTimer;
        public DataGridView ordersGrid { get => OrdersGrid; }

        public MainScreen()
        {
            InitializeComponent();
            ServicePointManager.ServerCertificateValidationCallback +=
                                    (sender, certificate, chain, sslPolicyErrors) => true;
            MainScreen.MainForm = this;
            Enabled = false;
            new Login(this).Show();
        }

        public bool UpdateClient()
        {
            try 
            { 
                clients = LoadController.LoadInfo();
                orders = ClientsController.ActualOrdersUpdate();
                UpdateGridActualOrders(ordersGrid);
                UpdateLostClient();
                return true;
            }
            catch { return false; }
        }
        public static void SetTimer()
        {
            SyncTimer = new System.Timers.Timer();
            SyncTimer.Elapsed += SyncClient;
            SyncTimer.Interval = 30000;
            SyncTimer.Enabled = true;
        }

        private static void SyncClient(Object source, ElapsedEventArgs e)
        {
            MainForm.Invoke(new Action(() => { MainForm.UpdateClient(); }));
        }
        public void UpdateGridActualOrders(DataGridView ordersGrid)
        {
            CountMonth.Text = Convert.ToString(OrdersController.GetCountMonthOrders(clients));
            OrdersGrid.Rows.Clear();
            if (orders.Count > 0)
            {
                OrdersGrid.RowCount = orders.Count;
                int i = 0;
                foreach (var order in orders)
                {
                    OrdersGrid.Rows[i].Cells[0].Value = i + 1;
                    OrdersGrid.Rows[i].Cells[1].Value = order.Address;
                    OrdersGrid.Rows[i].Cells[2].Value = order.Order.CreateOrder;
                    OrdersGrid.Rows[i].Cells[3].Value = "Просмотр";
                    i++;
                }
            }
        }

        private void OrdersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 3)
                {
                    List<Order> orders = OrdersController.ActualOrders(OrdersController.AllOrders(clients));

                    FormCollection form = Application.OpenForms;
                    bool formOpenCheck = false;
                    int index;
                    for (index = 0; index < form.Count; index++)
                        if (Convert.ToString(form[index].Tag) == Convert.ToString(e.RowIndex))
                        {
                            formOpenCheck = true;
                            break;
                        }

                    if (!formOpenCheck)
                        new ActualOrderForm(orders[e.RowIndex], this, e.RowIndex).Show();
                    else
                        form[index].Focus();
                }
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TodayOrder_Click(object sender, EventArgs e)
        {
            bool formOpenCheck = false;
            foreach (Form form in Application.OpenForms)
                if (form.Name == "TodayOrders")
                    formOpenCheck = true;
            if (!formOpenCheck)
            {
                todayOrdersForm = new TodayOrders();
                todayOrdersForm.Show();
            }else
                todayOrdersForm.Focus();
        }

        private void ClientBase_Click(object sender, EventArgs e)
        {
            bool formOpenCheck = false;
            foreach (Form form in Application.OpenForms)
                if (form.Name == "ClientsBase")
                    formOpenCheck = true;
            if (!formOpenCheck)
            {
                CleintsBaseForm = new ClientBase(this);
                CleintsBaseForm.Show();
            }
            else
                CleintsBaseForm.Focus();
        }

        public List<Client> GetClients()
        {
            return clients;
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            new SearchClients(this).Show();
        }

        private void LostClients_Click(object sender, EventArgs e)
        {
            new LostClients(this).Show();
        }

        private void Statistic_Click(object sender, EventArgs e)
        {
            new Statistic(this).Show();
        }

        public void UpdateLostClient()
        {
            if (ClientsController.GetCountLostClient(clients) > 0)
            {
                Indicator.Visible = true;
                Indicator.BackColor = Color.Orange;
            }
            else
                Indicator.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new DeliverStat().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new TopClient().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Salery().Show();
        }
    }
}
