
namespace CourseWork.View.Modal
{
    partial class LostClients
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
            this.clientsGrid = new System.Windows.Forms.DataGridView();
            this.NumberOfClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contacts = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Orders = new System.Windows.Forms.DataGridViewButtonColumn();
            this.countClients = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // clientsGrid
            // 
            this.clientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberOfClient,
            this.Address,
            this.Contacts,
            this.Orders});
            this.clientsGrid.Location = new System.Drawing.Point(12, 12);
            this.clientsGrid.Name = "clientsGrid";
            this.clientsGrid.RowHeadersVisible = false;
            this.clientsGrid.RowHeadersWidth = 51;
            this.clientsGrid.RowTemplate.Height = 24;
            this.clientsGrid.Size = new System.Drawing.Size(764, 551);
            this.clientsGrid.TabIndex = 1;
            this.clientsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NumberOfClient
            // 
            this.NumberOfClient.HeaderText = "№";
            this.NumberOfClient.MinimumWidth = 6;
            this.NumberOfClient.Name = "NumberOfClient";
            this.NumberOfClient.ReadOnly = true;
            this.NumberOfClient.Width = 30;
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
            // countClients
            // 
            this.countClients.AutoSize = true;
            this.countClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countClients.Location = new System.Drawing.Point(144, 582);
            this.countClients.Name = "countClients";
            this.countClients.Size = new System.Drawing.Size(0, 25);
            this.countClients.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Количество:";
            // 
            // LostClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 615);
            this.Controls.Add(this.countClients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clientsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LostClients";
            this.Text = "Утраченные клиенты";
            ((System.ComponentModel.ISupportInitialize)(this.clientsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView clientsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewButtonColumn Contacts;
        private System.Windows.Forms.DataGridViewButtonColumn Orders;
        private System.Windows.Forms.Label countClients;
        private System.Windows.Forms.Label label1;
    }
}