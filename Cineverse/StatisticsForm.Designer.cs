﻿namespace Cineverse
{
    partial class StatisticsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.lbl_totalRevenue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RevenueChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_totalTransactions = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_all = new System.Windows.Forms.Button();
            this.btn_thisWeek = new System.Windows.Forms.Button();
            this.btn_thisMonth = new System.Windows.Forms.Button();
            this.btn_today = new System.Windows.Forms.Button();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RevenueChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Cineverse.Properties.Resources.LOGO1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 26);
            this.panel3.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::Cineverse.Properties.Resources.Close_Button;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(1489, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(19, 26);
            this.panel5.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(662, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "STATISTICS";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel9.Controls.Add(this.lbl_totalRevenue);
            this.panel9.Location = new System.Drawing.Point(21, 169);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(315, 134);
            this.panel9.TabIndex = 9;
            // 
            // lbl_totalRevenue
            // 
            this.lbl_totalRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalRevenue.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalRevenue.ForeColor = System.Drawing.Color.White;
            this.lbl_totalRevenue.Location = new System.Drawing.Point(3, 27);
            this.lbl_totalRevenue.Name = "lbl_totalRevenue";
            this.lbl_totalRevenue.Size = new System.Drawing.Size(309, 86);
            this.lbl_totalRevenue.TabIndex = 4;
            this.lbl_totalRevenue.Text = "₱250,000.00";
            this.lbl_totalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 50);
            this.label1.TabIndex = 12;
            this.label1.Text = "Total Revenue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RevenueChart
            // 
            chartArea1.Name = "ChartArea1";
            this.RevenueChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.RevenueChart.Legends.Add(legend1);
            this.RevenueChart.Location = new System.Drawing.Point(21, 356);
            this.RevenueChart.Name = "RevenueChart";
            this.RevenueChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.RevenueChart.Series.Add(series1);
            this.RevenueChart.Size = new System.Drawing.Size(941, 553);
            this.RevenueChart.TabIndex = 10;
            this.RevenueChart.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.lbl_totalTransactions);
            this.panel1.Location = new System.Drawing.Point(350, 169);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 134);
            this.panel1.TabIndex = 13;
            // 
            // lbl_totalTransactions
            // 
            this.lbl_totalTransactions.BackColor = System.Drawing.Color.Transparent;
            this.lbl_totalTransactions.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalTransactions.ForeColor = System.Drawing.Color.White;
            this.lbl_totalTransactions.Location = new System.Drawing.Point(3, 27);
            this.lbl_totalTransactions.Name = "lbl_totalTransactions";
            this.lbl_totalTransactions.Size = new System.Drawing.Size(306, 86);
            this.lbl_totalTransactions.TabIndex = 4;
            this.lbl_totalTransactions.Text = "124";
            this.lbl_totalTransactions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(401, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 50);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Transactions";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.Color.Transparent;
            this.btn_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_all.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all.ForeColor = System.Drawing.Color.White;
            this.btn_all.Location = new System.Drawing.Point(674, 186);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(138, 42);
            this.btn_all.TabIndex = 23;
            this.btn_all.Text = "All";
            this.btn_all.UseVisualStyleBackColor = false;
            // 
            // btn_thisWeek
            // 
            this.btn_thisWeek.BackColor = System.Drawing.Color.Transparent;
            this.btn_thisWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thisWeek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_thisWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thisWeek.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thisWeek.ForeColor = System.Drawing.Color.White;
            this.btn_thisWeek.Location = new System.Drawing.Point(674, 243);
            this.btn_thisWeek.Name = "btn_thisWeek";
            this.btn_thisWeek.Size = new System.Drawing.Size(138, 42);
            this.btn_thisWeek.TabIndex = 24;
            this.btn_thisWeek.Text = "This Week";
            this.btn_thisWeek.UseVisualStyleBackColor = false;
            // 
            // btn_thisMonth
            // 
            this.btn_thisMonth.BackColor = System.Drawing.Color.Transparent;
            this.btn_thisMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thisMonth.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_thisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thisMonth.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thisMonth.ForeColor = System.Drawing.Color.White;
            this.btn_thisMonth.Location = new System.Drawing.Point(824, 243);
            this.btn_thisMonth.Name = "btn_thisMonth";
            this.btn_thisMonth.Size = new System.Drawing.Size(138, 42);
            this.btn_thisMonth.TabIndex = 26;
            this.btn_thisMonth.Text = "This Month";
            this.btn_thisMonth.UseVisualStyleBackColor = false;
            // 
            // btn_today
            // 
            this.btn_today.BackColor = System.Drawing.Color.Transparent;
            this.btn_today.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_today.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_today.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_today.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_today.ForeColor = System.Drawing.Color.White;
            this.btn_today.Location = new System.Drawing.Point(824, 186);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(138, 42);
            this.btn_today.TabIndex = 25;
            this.btn_today.Text = "Today";
            this.btn_today.UseVisualStyleBackColor = false;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1520, 950);
            this.Controls.Add(this.btn_thisMonth);
            this.Controls.Add(this.btn_today);
            this.Controls.Add(this.btn_thisWeek);
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RevenueChart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel9);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RevenueChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label lbl_totalRevenue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart RevenueChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_totalTransactions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_all;
        private System.Windows.Forms.Button btn_thisWeek;
        private System.Windows.Forms.Button btn_thisMonth;
        private System.Windows.Forms.Button btn_today;
    }
}