namespace Cineverse
{
    partial class AddScreening
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddScreening));
            this.btn_addScreening = new System.Windows.Forms.Button();
            this.dtp_time = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_timeAdded = new System.Windows.Forms.ComboBox();
            this.cmb_datesAdded = new System.Windows.Forms.ComboBox();
            this.btn_addTime = new System.Windows.Forms.Button();
            this.btn_addDate = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_screeningdate = new System.Windows.Forms.Label();
            this.dgv_booking = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_cinemaNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_booking)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addScreening
            // 
            this.btn_addScreening.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_addScreening.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_addScreening.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addScreening.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addScreening.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_addScreening.Location = new System.Drawing.Point(94, 530);
            this.btn_addScreening.Name = "btn_addScreening";
            this.btn_addScreening.Size = new System.Drawing.Size(143, 35);
            this.btn_addScreening.TabIndex = 51;
            this.btn_addScreening.Text = "Add Screening";
            this.btn_addScreening.UseVisualStyleBackColor = false;
            this.btn_addScreening.Click += new System.EventHandler(this.btn_addScreening_Click);
            // 
            // dtp_time
            // 
            this.dtp_time.Checked = false;
            this.dtp_time.CustomFormat = "HH:mm";
            this.dtp_time.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_time.Location = new System.Drawing.Point(97, 402);
            this.dtp_time.MaximumSize = new System.Drawing.Size(250, 30);
            this.dtp_time.MinimumSize = new System.Drawing.Size(150, 30);
            this.dtp_time.Name = "dtp_time";
            this.dtp_time.Size = new System.Drawing.Size(221, 30);
            this.dtp_time.TabIndex = 50;
            this.dtp_time.Value = new System.DateTime(2024, 4, 26, 0, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(93, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 19);
            this.label9.TabIndex = 49;
            this.label9.Text = "Time Added";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(93, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 48;
            this.label8.Text = "Date Added";
            // 
            // cmb_timeAdded
            // 
            this.cmb_timeAdded.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_timeAdded.FormattingEnabled = true;
            this.cmb_timeAdded.Location = new System.Drawing.Point(97, 473);
            this.cmb_timeAdded.Name = "cmb_timeAdded";
            this.cmb_timeAdded.Size = new System.Drawing.Size(221, 27);
            this.cmb_timeAdded.TabIndex = 47;
            // 
            // cmb_datesAdded
            // 
            this.cmb_datesAdded.BackColor = System.Drawing.SystemColors.Window;
            this.cmb_datesAdded.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_datesAdded.FormattingEnabled = true;
            this.cmb_datesAdded.Location = new System.Drawing.Point(97, 305);
            this.cmb_datesAdded.Name = "cmb_datesAdded";
            this.cmb_datesAdded.Size = new System.Drawing.Size(221, 27);
            this.cmb_datesAdded.TabIndex = 46;
            // 
            // btn_addTime
            // 
            this.btn_addTime.BackColor = System.Drawing.Color.Transparent;
            this.btn_addTime.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_addTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addTime.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addTime.ForeColor = System.Drawing.Color.Transparent;
            this.btn_addTime.Location = new System.Drawing.Point(324, 402);
            this.btn_addTime.Name = "btn_addTime";
            this.btn_addTime.Size = new System.Drawing.Size(73, 27);
            this.btn_addTime.TabIndex = 45;
            this.btn_addTime.Text = "Add";
            this.btn_addTime.UseVisualStyleBackColor = false;
            this.btn_addTime.Click += new System.EventHandler(this.btn_addTime_Click);
            this.btn_addTime.MouseEnter += new System.EventHandler(this.btn_addTime_MouseEnter);
            this.btn_addTime.MouseLeave += new System.EventHandler(this.btn_addTime_MouseLeave);
            // 
            // btn_addDate
            // 
            this.btn_addDate.BackColor = System.Drawing.Color.Transparent;
            this.btn_addDate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_addDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addDate.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addDate.ForeColor = System.Drawing.Color.Transparent;
            this.btn_addDate.Location = new System.Drawing.Point(324, 234);
            this.btn_addDate.Name = "btn_addDate";
            this.btn_addDate.Size = new System.Drawing.Size(73, 27);
            this.btn_addDate.TabIndex = 44;
            this.btn_addDate.Text = "Add";
            this.btn_addDate.UseVisualStyleBackColor = false;
            this.btn_addDate.Click += new System.EventHandler(this.btn_addDate_Click_1);
            this.btn_addDate.MouseEnter += new System.EventHandler(this.btn_addDate_MouseEnter);
            this.btn_addDate.MouseLeave += new System.EventHandler(this.btn_addDate_MouseLeave);
            // 
            // dtp_date
            // 
            this.dtp_date.CalendarForeColor = System.Drawing.Color.Black;
            this.dtp_date.CalendarMonthBackground = System.Drawing.Color.Black;
            this.dtp_date.CalendarTitleBackColor = System.Drawing.Color.Black;
            this.dtp_date.CalendarTitleForeColor = System.Drawing.Color.Transparent;
            this.dtp_date.CalendarTrailingForeColor = System.Drawing.Color.Transparent;
            this.dtp_date.CustomFormat = "MMMM  dd,  yyyy";
            this.dtp_date.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_date.Location = new System.Drawing.Point(94, 234);
            this.dtp_date.MaximumSize = new System.Drawing.Size(250, 50);
            this.dtp_date.MinimumSize = new System.Drawing.Size(180, 30);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(224, 30);
            this.dtp_date.TabIndex = 43;
            this.dtp_date.Value = new System.DateTime(2024, 4, 26, 0, 0, 0, 0);
            this.dtp_date.ValueChanged += new System.EventHandler(this.dtp_date_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(93, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 19);
            this.label7.TabIndex = 42;
            this.label7.Text = "Enter Screening Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(92, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 19);
            this.label6.TabIndex = 41;
            this.label6.Text = "Enter Screening Date";
            // 
            // lbl_screeningdate
            // 
            this.lbl_screeningdate.BackColor = System.Drawing.Color.Transparent;
            this.lbl_screeningdate.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_screeningdate.ForeColor = System.Drawing.Color.White;
            this.lbl_screeningdate.Location = new System.Drawing.Point(685, 128);
            this.lbl_screeningdate.Name = "lbl_screeningdate";
            this.lbl_screeningdate.Size = new System.Drawing.Size(240, 38);
            this.lbl_screeningdate.TabIndex = 53;
            this.lbl_screeningdate.Text = "January 01, 2024";
            this.lbl_screeningdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_booking
            // 
            this.dgv_booking.AllowUserToAddRows = false;
            this.dgv_booking.AllowUserToDeleteRows = false;
            this.dgv_booking.AllowUserToResizeColumns = false;
            this.dgv_booking.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_booking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_booking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_booking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.dgv_booking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_booking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_booking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_booking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_booking.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_booking.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_booking.EnableHeadersVisualStyles = false;
            this.dgv_booking.GridColor = System.Drawing.Color.Black;
            this.dgv_booking.Location = new System.Drawing.Point(536, 296);
            this.dgv_booking.Name = "dgv_booking";
            this.dgv_booking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_booking.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_booking.RowHeadersVisible = false;
            this.dgv_booking.RowHeadersWidth = 40;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_booking.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_booking.RowTemplate.Height = 50;
            this.dgv_booking.RowTemplate.ReadOnly = true;
            this.dgv_booking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_booking.Size = new System.Drawing.Size(533, 406);
            this.dgv_booking.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(169, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 38);
            this.label1.TabIndex = 58;
            this.label1.Text = "ADD SCREENING";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Cineverse.Properties.Resources.LOGO1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 26);
            this.panel3.TabIndex = 59;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::Cineverse.Properties.Resources.Close_Button;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(1107, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(19, 26);
            this.panel5.TabIndex = 5;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(612, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 38);
            this.label2.TabIndex = 60;
            this.label2.Text = "SCREENING SCHEDULES";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SpringGreen;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.button1.Location = new System.Drawing.Point(254, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 35);
            this.button1.TabIndex = 61;
            this.button1.Text = "Done";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(530, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 38);
            this.label3.TabIndex = 62;
            this.label3.Text = "CINEMA ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cinemaNumber
            // 
            this.lbl_cinemaNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cinemaNumber.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cinemaNumber.ForeColor = System.Drawing.Color.White;
            this.lbl_cinemaNumber.Location = new System.Drawing.Point(658, 234);
            this.lbl_cinemaNumber.Name = "lbl_cinemaNumber";
            this.lbl_cinemaNumber.Size = new System.Drawing.Size(55, 38);
            this.lbl_cinemaNumber.TabIndex = 63;
            this.lbl_cinemaNumber.Text = "2";
            this.lbl_cinemaNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddScreening
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(1138, 732);
            this.Controls.Add(this.lbl_cinemaNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_screeningdate);
            this.Controls.Add(this.dgv_booking);
            this.Controls.Add(this.btn_addScreening);
            this.Controls.Add(this.dtp_time);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmb_timeAdded);
            this.Controls.Add(this.cmb_datesAdded);
            this.Controls.Add(this.btn_addTime);
            this.Controls.Add(this.btn_addDate);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddScreening";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddScreening";
            this.Load += new System.EventHandler(this.AddScreening_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_booking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_addScreening;
        private System.Windows.Forms.DateTimePicker dtp_time;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmb_timeAdded;
        private System.Windows.Forms.ComboBox cmb_datesAdded;
        private System.Windows.Forms.Button btn_addTime;
        private System.Windows.Forms.Button btn_addDate;
        private System.Windows.Forms.DateTimePicker dtp_date;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbl_screeningdate;
        private System.Windows.Forms.DataGridView dgv_booking;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lbl_cinemaNumber;
    }
}