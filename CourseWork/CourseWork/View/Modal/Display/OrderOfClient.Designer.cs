
namespace CourseWork.View.Modal.Display
{
    partial class OrdersOfClient
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
            this.OrdersGrid = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.countOrders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).BeginInit();
            this.SuspendLayout();
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
            this.OrdersGrid.Location = new System.Drawing.Point(12, 12);
            this.OrdersGrid.Name = "OrdersGrid";
            this.OrdersGrid.ReadOnly = true;
            this.OrdersGrid.RowHeadersVisible = false;
            this.OrdersGrid.RowHeadersWidth = 51;
            this.OrdersGrid.RowTemplate.Height = 24;
            this.OrdersGrid.Size = new System.Drawing.Size(517, 482);
            this.OrdersGrid.TabIndex = 8;
            this.OrdersGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdersGrid_CellContentClick);
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 45;
            // 
            // Adress
            // 
            this.Adress.HeaderText = "Статус";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            this.Adress.Width = 80;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 515);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "Количество заказов:";
            // 
            // countOrders
            // 
            this.countOrders.AutoSize = true;
            this.countOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOrders.Location = new System.Drawing.Point(285, 515);
            this.countOrders.Name = "countOrders";
            this.countOrders.Size = new System.Drawing.Size(0, 29);
            this.countOrders.TabIndex = 10;
            // 
            // OrdersOfClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 562);
            this.Controls.Add(this.countOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrdersGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrdersOfClient";
            this.Text = "Заказы";
            ((System.ComponentModel.ISupportInitialize)(this.OrdersGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView OrdersGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewButtonColumn Order;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countOrders;
    }
}