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
using System.Net.Mail;
using System.Net;
using System.Net.Mime;

namespace CourseWork.View.Modal
{
    public partial class Salery : Form
    {
        List<OrdersController.DeliverSalery> saleries;
        public Salery()
        {
            InitializeComponent();

            saleries = OrdersController.DeliversSalery();
            int i = 0;
            dataGridView1.Rows.Clear();
            dataGridView1.RowCount = saleries.Count;
            foreach (OrdersController.DeliverSalery salery in saleries)
            {
                dataGridView1.Rows[i].Cells[0].Value = salery.ID;
                dataGridView1.Rows[i].Cells[1].Value = salery.fullName;
                dataGridView1.Rows[i].Cells[2].Value = salery.days;
                dataGridView1.Rows[i].Cells[3].Value = salery.saleries;
                i++;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image = new Bitmap(800, 600);
            Graphics graph = Graphics.FromImage(image);
            PointF[] points = { new Point(0, 0), new Point(0, 600), new Point(800, 600), new Point(800, 0) };
            graph.FillPolygon(new SolidBrush(Color.White), points);
            string myString = "";
            foreach (OrdersController.DeliverSalery salery in saleries)
                myString += $"ID кур'єра: {salery.ID} \n Ім'я: {salery.fullName} \n Кількість робочих днів: {salery.days} \n Заробітна плата: {salery.saleries} \n \n \n";
                graph.DrawString(myString, new Font("Calibri", 16), Brushes.Black, 1, 1);
            (image as Bitmap).Save("Report.png", System.Drawing.Imaging.ImageFormat.Png);

            SmtpClient Smtp = new SmtpClient("smtp.office365.com");
            Smtp.Port = 587;
            Smtp.Credentials = new NetworkCredential("myCoursework123@outlook.com", "123456DB");
            Smtp.EnableSsl = true;
            Smtp.Timeout = 20000;

            MailMessage message = new MailMessage();
            message.From = new MailAddress("myCoursework123@outlook.com");
            message.To.Add(new MailAddress("artem.karpov@nure.ua"));
            message.Subject = $"Звіт від {DateTime.Now.Date.ToString().Substring(0, 10)}";
            message.Body = "";

            string file = "Report.png";
            Attachment attach = new Attachment(file, MediaTypeNames.Application.Octet);

            ContentDisposition disposition = attach.ContentDisposition;
            disposition.CreationDate = System.IO.File.GetCreationTime(file);
            disposition.ModificationDate = System.IO.File.GetLastWriteTime(file);
            disposition.ReadDate = System.IO.File.GetLastAccessTime(file);

            message.Attachments.Add(attach);

            Smtp.Send(message);
        }
    }
}
