
namespace CourseWork.View.Modal
{
    partial class AddOrder
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Price1 = new System.Windows.Forms.Label();
            this.Count1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AllCount = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.OrderGrid = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountGrid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteGrid = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(541, 14);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(162, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(464, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Товар";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(464, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Стоимость";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(464, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Количество";
            // 
            // Price1
            // 
            this.Price1.AutoSize = true;
            this.Price1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price1.Location = new System.Drawing.Point(637, 75);
            this.Price1.Name = "Price1";
            this.Price1.Size = new System.Drawing.Size(0, 25);
            this.Price1.TabIndex = 8;
            // 
            // Count1
            // 
            this.Count1.Location = new System.Drawing.Point(610, 137);
            this.Count1.MaxLength = 4;
            this.Count1.Name = "Count1";
            this.Count1.Size = new System.Drawing.Size(59, 22);
            this.Count1.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(12, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Количество:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(12, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Всего:";
            // 
            // AllCount
            // 
            this.AllCount.AutoSize = true;
            this.AllCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AllCount.Location = new System.Drawing.Point(160, 251);
            this.AllCount.Name = "AllCount";
            this.AllCount.Size = new System.Drawing.Size(0, 25);
            this.AllCount.TabIndex = 14;
            // 
            // Sum
            // 
            this.Sum.AutoSize = true;
            this.Sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sum.Location = new System.Drawing.Point(98, 286);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(0, 25);
            this.Sum.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(600, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 38);
            this.button1.TabIndex = 16;
            this.button1.Text = "Сформировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Location = new System.Drawing.Point(827, 286);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(64, 17);
            this.ErrorLabel.TabIndex = 17;
            this.ErrorLabel.Text = "Ошибка!";
            // 
            // OrderGrid
            // 
            this.OrderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameGrid,
            this.PriceGrid,
            this.CountGrid,
            this.DeleteGrid});
            this.OrderGrid.Location = new System.Drawing.Point(12, 12);
            this.OrderGrid.Name = "OrderGrid";
            this.OrderGrid.RowHeadersVisible = false;
            this.OrderGrid.RowHeadersWidth = 51;
            this.OrderGrid.RowTemplate.Height = 24;
            this.OrderGrid.Size = new System.Drawing.Size(438, 227);
            this.OrderGrid.TabIndex = 18;
            this.OrderGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGrid_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "№";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 30;
            // 
            // NameGrid
            // 
            this.NameGrid.HeaderText = "Наименование";
            this.NameGrid.MinimumWidth = 6;
            this.NameGrid.Name = "NameGrid";
            this.NameGrid.ReadOnly = true;
            this.NameGrid.Width = 120;
            // 
            // PriceGrid
            // 
            this.PriceGrid.HeaderText = "Стоимость (за единицу)";
            this.PriceGrid.MinimumWidth = 6;
            this.PriceGrid.Name = "PriceGrid";
            this.PriceGrid.ReadOnly = true;
            this.PriceGrid.Width = 75;
            // 
            // CountGrid
            // 
            this.CountGrid.HeaderText = "Количество";
            this.CountGrid.MinimumWidth = 6;
            this.CountGrid.Name = "CountGrid";
            this.CountGrid.ReadOnly = true;
            this.CountGrid.Width = 75;
            // 
            // DeleteGrid
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "🗑";
            this.DeleteGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.DeleteGrid.HeaderText = "";
            this.DeleteGrid.MinimumWidth = 6;
            this.DeleteGrid.Name = "DeleteGrid";
            this.DeleteGrid.ReadOnly = true;
            this.DeleteGrid.Text = "🗑";
            this.DeleteGrid.Width = 25;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(594, 206);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(232, 33);
            this.button2.TabIndex = 19;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(749, 44);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 117);
            this.textBox1.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(787, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 25);
            this.label1.TabIndex = 21;
            this.label1.Text = "Коментарий";
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 321);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.OrderGrid);
            this.Controls.Add(this.ErrorLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.AllCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Count1);
            this.Controls.Add(this.Price1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddOrder";
            this.Text = "Добавить заказ";
            ((System.ComponentModel.ISupportInitialize)(this.OrderGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Price1;
        private System.Windows.Forms.TextBox Count1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label AllCount;
        private System.Windows.Forms.Label Sum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.DataGridView OrderGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountGrid;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteGrid;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}