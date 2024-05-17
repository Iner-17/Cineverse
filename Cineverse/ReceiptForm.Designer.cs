namespace Cineverse
{
    partial class ReceiptForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_backToDashboard = new System.Windows.Forms.Button();
            this.lbl_success = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.lbl_discount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_total1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_tcktQuantity = new System.Windows.Forms.Label();
            this.lbl_tcktPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_seats = new System.Windows.Forms.Label();
            this.lbl_dateTime = new System.Windows.Forms.Label();
            this.lbl_cinemaNo = new System.Windows.Forms.Label();
            this.btn_print = new System.Windows.Forms.Button();
            this.lbl_titlePayment = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_change = new System.Windows.Forms.Label();
            this.lbl_cash = new System.Windows.Forms.Label();
            this.lbl_currentTimeAndDate = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel4.Controls.Add(this.btn_backToDashboard);
            this.panel4.Controls.Add(this.lbl_success);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Location = new System.Drawing.Point(343, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1165, 865);
            this.panel4.TabIndex = 12;
            // 
            // btn_backToDashboard
            // 
            this.btn_backToDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_backToDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_backToDashboard.FlatAppearance.BorderSize = 0;
            this.btn_backToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backToDashboard.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backToDashboard.Location = new System.Drawing.Point(452, 477);
            this.btn_backToDashboard.Name = "btn_backToDashboard";
            this.btn_backToDashboard.Size = new System.Drawing.Size(270, 53);
            this.btn_backToDashboard.TabIndex = 34;
            this.btn_backToDashboard.Text = "Back to Dashboard";
            this.btn_backToDashboard.UseVisualStyleBackColor = false;
            this.btn_backToDashboard.Click += new System.EventHandler(this.btn_backToDashboard_Click);
            // 
            // lbl_success
            // 
            this.lbl_success.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_success.ForeColor = System.Drawing.Color.White;
            this.lbl_success.Location = new System.Drawing.Point(442, 391);
            this.lbl_success.Name = "lbl_success";
            this.lbl_success.Size = new System.Drawing.Size(285, 54);
            this.lbl_success.TabIndex = 33;
            this.lbl_success.Text = "Success!";
            this.lbl_success.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(442, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 19);
            this.label1.TabIndex = 32;
            this.label1.Text = "Payment Completed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackgroundImage = global::Cineverse.Properties.Resources.check;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel7.Location = new System.Drawing.Point(541, 301);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(86, 87);
            this.panel7.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_currentTimeAndDate);
            this.panel1.Controls.Add(this.lbl_cash);
            this.panel1.Controls.Add(this.lbl_change);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.lbl_genre);
            this.panel1.Controls.Add(this.lbl_discount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_total1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.lbl_tcktQuantity);
            this.panel1.Controls.Add(this.lbl_tcktPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lbl_seats);
            this.panel1.Controls.Add(this.lbl_dateTime);
            this.panel1.Controls.Add(this.lbl_cinemaNo);
            this.panel1.Controls.Add(this.btn_print);
            this.panel1.Controls.Add(this.lbl_titlePayment);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 865);
            this.panel1.TabIndex = 11;
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
            this.lbl_discount.Location = new System.Drawing.Point(182, 606);
            this.lbl_discount.Name = "lbl_discount";
            this.lbl_discount.Size = new System.Drawing.Size(113, 29);
            this.lbl_discount.TabIndex = 32;
            this.lbl_discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 611);
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
            this.lbl_total1.Location = new System.Drawing.Point(182, 648);
            this.lbl_total1.Name = "lbl_total1";
            this.lbl_total1.Size = new System.Drawing.Size(113, 33);
            this.lbl_total1.TabIndex = 30;
            this.lbl_total1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 655);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Total: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel6.Location = new System.Drawing.Point(23, 638);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(272, 3);
            this.panel6.TabIndex = 28;
            // 
            // lbl_tcktQuantity
            // 
            this.lbl_tcktQuantity.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tcktQuantity.ForeColor = System.Drawing.Color.White;
            this.lbl_tcktQuantity.Location = new System.Drawing.Point(182, 585);
            this.lbl_tcktQuantity.Name = "lbl_tcktQuantity";
            this.lbl_tcktQuantity.Size = new System.Drawing.Size(113, 19);
            this.lbl_tcktQuantity.TabIndex = 25;
            this.lbl_tcktQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_tcktPrice
            // 
            this.lbl_tcktPrice.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tcktPrice.ForeColor = System.Drawing.Color.White;
            this.lbl_tcktPrice.Location = new System.Drawing.Point(182, 551);
            this.lbl_tcktPrice.Name = "lbl_tcktPrice";
            this.lbl_tcktPrice.Size = new System.Drawing.Size(113, 29);
            this.lbl_tcktPrice.TabIndex = 24;
            this.lbl_tcktPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(21, 585);
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
            this.label6.Location = new System.Drawing.Point(21, 561);
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
            // btn_print
            // 
            this.btn_print.BackColor = System.Drawing.Color.Transparent;
            this.btn_print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_print.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_print.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_print.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_print.ForeColor = System.Drawing.Color.White;
            this.btn_print.Location = new System.Drawing.Point(25, 801);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(270, 42);
            this.btn_print.TabIndex = 9;
            this.btn_print.Text = "Print";
            this.btn_print.UseVisualStyleBackColor = false;
            this.btn_print.MouseEnter += new System.EventHandler(this.btn_print_MouseEnter);
            this.btn_print.MouseLeave += new System.EventHandler(this.btn_print_MouseLeave);
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
            this.panel2.BackgroundImage = global::Cineverse.Properties.Resources.LogoCineverseBooking;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(58, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(205, 91);
            this.panel2.TabIndex = 1;
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
            this.panel5.TabIndex = 10;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Cineverse.Properties.Resources.LOGO1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 26);
            this.panel3.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 705);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 35;
            this.label5.Text = "CASH:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 731);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 19);
            this.label8.TabIndex = 36;
            this.label8.Text = "CHANGE:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_change
            // 
            this.lbl_change.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_change.ForeColor = System.Drawing.Color.White;
            this.lbl_change.Location = new System.Drawing.Point(182, 727);
            this.lbl_change.Name = "lbl_change";
            this.lbl_change.Size = new System.Drawing.Size(113, 33);
            this.lbl_change.TabIndex = 37;
            this.lbl_change.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_cash
            // 
            this.lbl_cash.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cash.ForeColor = System.Drawing.Color.White;
            this.lbl_cash.Location = new System.Drawing.Point(182, 688);
            this.lbl_cash.Name = "lbl_cash";
            this.lbl_cash.Size = new System.Drawing.Size(113, 33);
            this.lbl_cash.TabIndex = 38;
            this.lbl_cash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_currentTimeAndDate
            // 
            this.lbl_currentTimeAndDate.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentTimeAndDate.ForeColor = System.Drawing.Color.White;
            this.lbl_currentTimeAndDate.Location = new System.Drawing.Point(25, 133);
            this.lbl_currentTimeAndDate.Name = "lbl_currentTimeAndDate";
            this.lbl_currentTimeAndDate.Size = new System.Drawing.Size(266, 19);
            this.lbl_currentTimeAndDate.TabIndex = 39;
            this.lbl_currentTimeAndDate.Text = "March 28, 2024 • 4:30 PM";
            this.lbl_currentTimeAndDate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(1520, 950);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_total1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_tcktQuantity;
        private System.Windows.Forms.Label lbl_tcktPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_seats;
        private System.Windows.Forms.Label lbl_dateTime;
        private System.Windows.Forms.Label lbl_cinemaNo;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Label lbl_titlePayment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_backToDashboard;
        private System.Windows.Forms.Label lbl_success;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lbl_cash;
        private System.Windows.Forms.Label lbl_change;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_currentTimeAndDate;
    }
}