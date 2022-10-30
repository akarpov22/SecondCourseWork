
namespace CourseWork.View.Modal
{
    partial class Statistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Month = new System.Windows.Forms.Button();
            this.WeekDay = new System.Windows.Forms.Button();
            this.MonthEn = new System.Windows.Forms.Button();
            this.WeekDayEn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(-38, 65);
            this.chart1.Margin = new System.Windows.Forms.Padding(1);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.CustomProperties = "PixelPointWidth=20, EmptyPointValue=Zero";
            series1.EmptyPointStyle.IsVisibleInLegend = false;
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.IsXValueIndexed = true;
            series1.LabelBorderWidth = 0;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1242, 447);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // Month
            // 
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Month.Location = new System.Drawing.Point(372, 12);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(254, 37);
            this.Month.TabIndex = 1;
            this.Month.Text = "По месяцам";
            this.Month.UseVisualStyleBackColor = true;
            this.Month.Click += new System.EventHandler(this.Month_Click);
            // 
            // WeekDay
            // 
            this.WeekDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeekDay.Location = new System.Drawing.Point(730, 12);
            this.WeekDay.Name = "WeekDay";
            this.WeekDay.Size = new System.Drawing.Size(254, 37);
            this.WeekDay.TabIndex = 2;
            this.WeekDay.Text = "По дням недели";
            this.WeekDay.UseVisualStyleBackColor = true;
            this.WeekDay.Click += new System.EventHandler(this.WeekDay_Click);
            // 
            // MonthEn
            // 
            this.MonthEn.Enabled = false;
            this.MonthEn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.MonthEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonthEn.Location = new System.Drawing.Point(372, 12);
            this.MonthEn.Name = "MonthEn";
            this.MonthEn.Size = new System.Drawing.Size(254, 37);
            this.MonthEn.TabIndex = 3;
            this.MonthEn.Text = "По месяцам";
            this.MonthEn.UseVisualStyleBackColor = true;
            // 
            // WeekDayEn
            // 
            this.WeekDayEn.Enabled = false;
            this.WeekDayEn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WeekDayEn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeekDayEn.Location = new System.Drawing.Point(730, 12);
            this.WeekDayEn.Name = "WeekDayEn";
            this.WeekDayEn.Size = new System.Drawing.Size(254, 37);
            this.WeekDayEn.TabIndex = 4;
            this.WeekDayEn.Text = "По дням недели";
            this.WeekDayEn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(26, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество заказов";
            // 
            // Statistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 512);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeekDayEn);
            this.Controls.Add(this.MonthEn);
            this.Controls.Add(this.WeekDay);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Statistic";
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Button Month;
        private System.Windows.Forms.Button WeekDay;
        private System.Windows.Forms.Button MonthEn;
        private System.Windows.Forms.Button WeekDayEn;
        private System.Windows.Forms.Label label1;
    }
}