
namespace CourseWork
{
    partial class MainScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.ClientBase = new System.Windows.Forms.Button();
            this.AddOrder = new System.Windows.Forms.Button();
            this.TodayOrder = new System.Windows.Forms.Button();
            this.Statistic = new System.Windows.Forms.Button();
            this.LostClients = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Indicator = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CountMonth = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Indicator)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientBase
            // 
            this.ClientBase.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ClientBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientBase.Location = new System.Drawing.Point(9, 55);
            this.ClientBase.Name = "ClientBase";
            this.ClientBase.Size = new System.Drawing.Size(157, 63);
            this.ClientBase.TabIndex = 0;
            this.ClientBase.Text = "База клиентов";
            this.ClientBase.UseVisualStyleBackColor = true;
            this.ClientBase.Click += new System.EventHandler(this.ClientBase_Click);
            // 
            // AddOrder
            // 
            this.AddOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.AddOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrder.Location = new System.Drawing.Point(9, 124);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(157, 63);
            this.AddOrder.TabIndex = 1;
            this.AddOrder.Text = "Добавить заказ";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // TodayOrder
            // 
            this.TodayOrder.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.TodayOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TodayOrder.Location = new System.Drawing.Point(9, 272);
            this.TodayOrder.Name = "TodayOrder";
            this.TodayOrder.Size = new System.Drawing.Size(157, 63);
            this.TodayOrder.TabIndex = 2;
            this.TodayOrder.Text = "Заказы сегодня";
            this.TodayOrder.UseVisualStyleBackColor = true;
            this.TodayOrder.Click += new System.EventHandler(this.TodayOrder_Click);
            // 
            // Statistic
            // 
            this.Statistic.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Statistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Statistic.Location = new System.Drawing.Point(9, 400);
            this.Statistic.Name = "Statistic";
            this.Statistic.Size = new System.Drawing.Size(157, 63);
            this.Statistic.TabIndex = 3;
            this.Statistic.Text = "Статистика";
            this.Statistic.UseVisualStyleBackColor = true;
            this.Statistic.Click += new System.EventHandler(this.Statistic_Click);
            // 
            // LostClients
            // 
            this.LostClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LostClients.Location = new System.Drawing.Point(9, 543);
            this.LostClients.Name = "LostClients";
            this.LostClients.Size = new System.Drawing.Size(157, 63);
            this.LostClients.TabIndex = 4;
            this.LostClients.Text = "Утраченые клиенты";
            this.LostClients.UseVisualStyleBackColor = true;
            this.LostClients.Click += new System.EventHandler(this.LostClients_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(412, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Актуальные заказы";
            // 
            // OrdersGrid
            // 
            this.OrdersGrid.AllowUserToAddRows = false;
            this.OrdersGrid.AllowUserToDeleteRows = false;
            this.OrdersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Adress,
            this.Date,
            this.Order});
            this.OrdersGrid.Location = new System.Drawing.Point(179, 55);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.ReadOnly = true;
            this.OrdersGrid.RowHeadersVisible = false;
            this.OrdersGrid.RowHeadersWidth = 51;
            this.OrdersGrid.RowTemplate.Height = 24;
            this.OrdersGrid.Size = new System.Drawing.Size(829, 526);
            this.OrdersGrid.TabIndex = 6;
            this.OrdersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersGrid_CellContentClick);
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 60;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Адресс";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 280;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата заказа";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 150;
            // 
            // Order
            // 
            this.Order.HeaderText = "Заказ";
            this.Order.MinimumWidth = 6;
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            this.Order.Width = 110;
            // 
            // Indicator
            // 
            this.Indicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Indicator.Location = new System.Drawing.Point(150, 591);
            this.Indicator.Name = "Indicator";
            this.Indicator.Size = new System.Drawing.Size(10, 10);
            this.Indicator.TabIndex = 8;
            this.Indicator.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(627, 588);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(259, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Успешных доставок в этом месяце:";
            // 
            // CountMonth
            // 
            this.CountMonth.AutoSize = true;
            this.CountMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountMonth.Location = new System.Drawing.Point(912, 588);
            this.CountMonth.Name = "CountMonth";
            this.CountMonth.Size = new System.Drawing.Size(0, 18);
            this.CountMonth.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(9, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 59);
            this.button1.TabIndex = 11;
            this.button1.Text = "Статистика кур\'єрів";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(9, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 43);
            this.button2.TabIndex = 12;
            this.button2.Text = "Топ клієнтів";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(9, 470);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(157, 67);
            this.button3.TabIndex = 13;
            this.button3.Text = "Заробітні плати";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1020, 621);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CountMonth);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Indicator);
            this.Controls.Add(this.OrdersGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LostClients);
            this.Controls.Add(this.Statistic);
            this.Controls.Add(this.TodayOrder);
            this.Controls.Add(this.AddOrder);
            this.Controls.Add(this.ClientBase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Indicator)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClientBase;
        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.Button TodayOrder;
        private System.Windows.Forms.Button Statistic;
        private System.Windows.Forms.Button LostClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn Order;
        private System.Windows.Forms.PictureBox Indicator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CountMonth;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

