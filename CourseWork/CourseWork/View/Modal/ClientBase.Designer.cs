
namespace CourseWork.View.Modal
{
    partial class ClientBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumberOfClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacts = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Orders = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.countClients = new System.Windows.Forms.Label();
            this.newClients = new System.Windows.Forms.Label();
            this.addClient = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOfClient,
            this.Address,
            this.Contacts,
            this.Orders,
            this.Delete});
            this.dataGridView1.Location = new System.Drawing.Point(18, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(860, 551);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NumberOfClient
            // 
            this.NumberOfClient.HeaderText = "№";
            this.NumberOfClient.MinimumWidth = 6;
            this.NumberOfClient.Name = "NumberOfClient";
            this.NumberOfClient.ReadOnly = true;
            this.NumberOfClient.Width = 70;
            // 
            // Address
            // 
            this.Address.HeaderText = "Адресс";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 330;
            // 
            // Contacts
            // 
            this.Contacts.HeaderText = "Контакты";
            this.Contacts.MinimumWidth = 6;
            this.Contacts.Name = "Contacts";
            this.Contacts.ReadOnly = true;
            this.Contacts.Width = 105;
            // 
            // Orders
            // 
            this.Orders.HeaderText = "Заказы";
            this.Orders.MinimumWidth = 6;
            this.Orders.Name = "Orders";
            this.Orders.ReadOnly = true;
            this.Orders.Width = 105;
            // 
            // Delete
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "🗑";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle1;
            this.Delete.HeaderText = "";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "🗑";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 621);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Всего клиентов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 663);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Новых в этом месяце:";
            // 
            // countClients
            // 
            this.countClients.AutoSize = true;
            this.countClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countClients.Location = new System.Drawing.Point(225, 621);
            this.countClients.Name = "countClients";
            this.countClients.Size = new System.Drawing.Size(0, 29);
            this.countClients.TabIndex = 3;
            // 
            // newClients
            // 
            this.newClients.AutoSize = true;
            this.newClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.newClients.Location = new System.Drawing.Point(295, 663);
            this.newClients.Name = "newClients";
            this.newClients.Size = new System.Drawing.Size(0, 29);
            this.newClients.TabIndex = 4;
            // 
            // addClient
            // 
            this.addClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addClient.Location = new System.Drawing.Point(593, 628);
            this.addClient.Name = "addClient";
            this.addClient.Size = new System.Drawing.Size(257, 54);
            this.addClient.TabIndex = 5;
            this.addClient.Text = "Добавить клиента";
            this.addClient.UseVisualStyleBackColor = true;
            this.addClient.Click += new System.EventHandler(this.addClient_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(16, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Поиск";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(258, 22);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "↓";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(778, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 26);
            this.button2.TabIndex = 9;
            this.button2.Text = "↑";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сортувати за кількістю замовлень";
            // 
            // ClientBase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 707);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addClient);
            this.Controls.Add(this.newClients);
            this.Controls.Add(this.countClients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientBase";
            this.Text = "База клиентов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label countClients;
        private System.Windows.Forms.Label newClients;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewButtonColumn Contacts;
        private System.Windows.Forms.DataGridViewButtonColumn Orders;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button addClient;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
    }
}