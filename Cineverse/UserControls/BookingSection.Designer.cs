namespace Cineverse.UserControls
{
    partial class BookingSection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_booking = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_total1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_tcktQuantity = new System.Windows.Forms.Label();
            this.lbl_tcktPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_seats = new System.Windows.Forms.Label();
            this.lbl_dateTime = new System.Windows.Forms.Label();
            this.lbl_cinemaNo = new System.Windows.Forms.Label();
            this.lbl_titlePayment = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_booking)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "BOOKINGS";
            // 
            // dgv_booking
            // 
            this.dgv_booking.AllowUserToResizeColumns = false;
            this.dgv_booking.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_booking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_booking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_booking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.dgv_booking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_booking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_booking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.NullValue = null;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_booking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_booking.ColumnHeadersHeight = 35;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_booking.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_booking.EnableHeadersVisualStyles = false;
            this.dgv_booking.GridColor = System.Drawing.Color.Black;
            this.dgv_booking.Location = new System.Drawing.Point(39, 109);
            this.dgv_booking.Name = "dgv_booking";
            this.dgv_booking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_booking.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_booking.RowHeadersVisible = false;
            this.dgv_booking.RowHeadersWidth = 40;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_booking.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgv_booking.RowTemplate.Height = 50;
            this.dgv_booking.RowTemplate.ReadOnly = true;
            this.dgv_booking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_booking.Size = new System.Drawing.Size(706, 672);
            this.dgv_booking.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.lbl_genre);
            this.panel1.Controls.Add(this.lbl_discount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_total1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.lbl_tcktQuantity);
            this.panel1.Controls.Add(this.lbl_tcktPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_seats);
            this.panel1.Controls.Add(this.lbl_dateTime);
            this.panel1.Controls.Add(this.lbl_cinemaNo);
            this.panel1.Controls.Add(this.lbl_titlePayment);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(775, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 672);
            this.panel1.TabIndex = 12;
            // 
            // lbl_time
            // 
            this.lbl_time.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.Color.White;
            this.lbl_time.Location = new System.Drawing.Point(27, 278);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(266, 19);
            this.lbl_time.TabIndex = 34;
            this.lbl_time.Text = "Time";
            this.lbl_time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_genre
            // 
            this.lbl_genre.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genre.ForeColor = System.Drawing.Color.White;
            this.lbl_genre.Location = new System.Drawing.Point(27, 233);
            this.lbl_genre.Name = "lbl_genre";
            this.lbl_genre.Size = new System.Drawing.Size(266, 19);
            this.lbl_genre.TabIndex = 33;
            this.lbl_genre.Text = "Genre";
            this.lbl_genre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_discount
            // 
            this.lbl_discount.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_discount.ForeColor = System.Drawing.Color.White;
            this.lbl_discount.Location = new System.Drawing.Point(182, 628);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(113, 29);
            this.lbl_discount.TabIndex = 32;
            this.lbl_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 561);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 19);
            this.label3.TabIndex = 31;
            this.label3.Text = "Discount:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_total1
            // 
            this.lbl_total1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total1.ForeColor = System.Drawing.Color.White;
            this.lbl_total1.Location = new System.Drawing.Point(182, 670);
            this.lbl_total1.Name = "lbl_total1";
            this.lbl_total1.Size = new System.Drawing.Size(109, 33);
            this.lbl_total1.TabIndex = 30;
            this.lbl_total1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Total: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel6.Location = new System.Drawing.Point(29, 588);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(272, 3);
            this.panel6.TabIndex = 28;
            // 
            // lbl_tcktQuantity
            // 
            this.lbl_tcktQuantity.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tcktQuantity.ForeColor = System.Drawing.Color.White;
            this.lbl_tcktQuantity.Location = new System.Drawing.Point(192, 609);
            this.lbl_tcktQuantity.Name = "lbl_tcktQuantity";
            this.lbl_tcktQuantity.Size = new System.Drawing.Size(103, 19);
            this.lbl_tcktQuantity.TabIndex = 25;
            this.lbl_tcktQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_tcktPrice
            // 
            this.lbl_tcktPrice.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tcktPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_tcktPrice.Location = new System.Drawing.Point(182, 575);
            this.lbl_tcktPrice.Name = "lbl_tcktPrice";
            this.lbl_tcktPrice.Size = new System.Drawing.Size(113, 29);
            this.lbl_tcktPrice.TabIndex = 24;
            this.lbl_tcktPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(27, 537);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ticket/s Quantity:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(27, 513);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Ticket/s Price:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(24, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(272, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Seats";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_seats
            // 
            this.lbl_seats.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seats.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.lbl_seats.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_seats.Location = new System.Drawing.Point(23, 402);
            this.lbl_seats.Name = "lbl_seats";
            this.lbl_seats.Size = new System.Drawing.Size(274, 84);
            this.lbl_seats.TabIndex = 20;
            this.lbl_seats.Text = "E11, E12, E13";
            this.lbl_seats.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_dateTime
            // 
            this.lbl_dateTime.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dateTime.ForeColor = System.Drawing.Color.White;
            this.lbl_dateTime.Location = new System.Drawing.Point(28, 299);
            this.lbl_dateTime.Name = "lbl_dateTime";
            this.lbl_dateTime.Size = new System.Drawing.Size(266, 19);
            this.lbl_dateTime.TabIndex = 19;
            this.lbl_dateTime.Text = "March 28, 2024 • Wednesday";
            this.lbl_dateTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_cinemaNo
            // 
            this.lbl_cinemaNo.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cinemaNo.ForeColor = System.Drawing.Color.White;
            this.lbl_cinemaNo.Location = new System.Drawing.Point(28, 257);
            this.lbl_cinemaNo.Name = "lbl_cinemaNo";
            this.lbl_cinemaNo.Size = new System.Drawing.Size(266, 19);
            this.lbl_cinemaNo.TabIndex = 18;
            this.lbl_cinemaNo.Text = "Cinema #";
            this.lbl_cinemaNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_titlePayment
            // 
            this.lbl_titlePayment.Font = new System.Drawing.Font("Montserrat", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titlePayment.ForeColor = System.Drawing.Color.White;
            this.lbl_titlePayment.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_titlePayment.Location = new System.Drawing.Point(25, 152);
            this.lbl_titlePayment.Name = "lbl_titlePayment";
            this.lbl_titlePayment.Size = new System.Drawing.Size(271, 71);
            this.lbl_titlePayment.TabIndex = 17;
            this.lbl_titlePayment.Text = "Inside Out 2 ";
            this.lbl_titlePayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Cineverse.Properties.Resources.LogoCiniverse;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(65, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 91);
            this.panel2.TabIndex = 1;
            // 
            // BookingSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_booking);
            this.Controls.Add(this.label2);
            this.Name = "BookingSection";
            this.Size = new System.Drawing.Size(1165, 865);
            this.Load += new System.EventHandler(this.BookingSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_booking)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_booking;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_total1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_tcktQuantity;
        private System.Windows.Forms.Label lbl_tcktPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_seats;
        private System.Windows.Forms.Label lbl_dateTime;
        private System.Windows.Forms.Label lbl_cinemaNo;
        private System.Windows.Forms.Label lbl_titlePayment;
        private System.Windows.Forms.Panel panel2;
    }
}
