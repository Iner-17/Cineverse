﻿namespace Cineverse
{
    partial class PaymentForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_genre = new System.Windows.Forms.Label();
            this.btn_voucher = new System.Windows.Forms.Button();
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
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_titlePayment = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_transactionComplete = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_paymentInProgress = new System.Windows.Forms.Label();
            this.lbl_total2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_posterSelected = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer_paymentInProgress = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_posterSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.lbl_time);
            this.panel1.Controls.Add(this.lbl_genre);
            this.panel1.Controls.Add(this.btn_voucher);
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
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Controls.Add(this.lbl_titlePayment);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 865);
            this.panel1.TabIndex = 7;
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
            // btn_voucher
            // 
            this.btn_voucher.BackColor = System.Drawing.Color.Transparent;
            this.btn_voucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_voucher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_voucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voucher.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voucher.ForeColor = System.Drawing.Color.White;
            this.btn_voucher.Location = new System.Drawing.Point(24, 521);
            this.btn_voucher.Name = "btn_voucher";
            this.btn_voucher.Size = new System.Drawing.Size(272, 45);
            this.btn_voucher.TabIndex = 31;
            this.btn_voucher.Text = "Enter Voucher Code";
            this.btn_voucher.UseVisualStyleBackColor = false;
            this.btn_voucher.MouseEnter += new System.EventHandler(this.btn_voucher_MouseEnter);
            this.btn_voucher.MouseLeave += new System.EventHandler(this.btn_voucher_MouseLeave);
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
            this.label3.Location = new System.Drawing.Point(21, 633);
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 677);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Total: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel6.Location = new System.Drawing.Point(23, 660);
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
            this.label7.Location = new System.Drawing.Point(21, 609);
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
            this.label6.Location = new System.Drawing.Point(21, 585);
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
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.Color.White;
            this.btn_back.Location = new System.Drawing.Point(25, 814);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(270, 42);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            this.btn_back.MouseEnter += new System.EventHandler(this.btn_back_MouseEnter);
            this.btn_back.MouseLeave += new System.EventHandler(this.btn_back_MouseLeave);
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
            // btn_transactionComplete
            // 
            this.btn_transactionComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_transactionComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transactionComplete.FlatAppearance.BorderSize = 0;
            this.btn_transactionComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transactionComplete.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transactionComplete.Location = new System.Drawing.Point(447, 645);
            this.btn_transactionComplete.Name = "btn_transactionComplete";
            this.btn_transactionComplete.Size = new System.Drawing.Size(270, 53);
            this.btn_transactionComplete.TabIndex = 5;
            this.btn_transactionComplete.Text = "Transaction Complete";
            this.btn_transactionComplete.UseVisualStyleBackColor = false;
            this.btn_transactionComplete.Click += new System.EventHandler(this.btn_transactionComplete_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel4.Controls.Add(this.lbl_paymentInProgress);
            this.panel4.Controls.Add(this.lbl_total2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.pb_posterSelected);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btn_transactionComplete);
            this.panel4.Location = new System.Drawing.Point(343, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1165, 865);
            this.panel4.TabIndex = 8;
            // 
            // lbl_paymentInProgress
            // 
            this.lbl_paymentInProgress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.lbl_paymentInProgress.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_paymentInProgress.ForeColor = System.Drawing.Color.White;
            this.lbl_paymentInProgress.Location = new System.Drawing.Point(393, 556);
            this.lbl_paymentInProgress.Name = "lbl_paymentInProgress";
            this.lbl_paymentInProgress.Size = new System.Drawing.Size(378, 70);
            this.lbl_paymentInProgress.TabIndex = 29;
            this.lbl_paymentInProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_total2
            // 
            this.lbl_total2.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total2.ForeColor = System.Drawing.Color.White;
            this.lbl_total2.Location = new System.Drawing.Point(440, 493);
            this.lbl_total2.Name = "lbl_total2";
            this.lbl_total2.Size = new System.Drawing.Size(285, 54);
            this.lbl_total2.TabIndex = 27;
            this.lbl_total2.Text = "₱1350.00";
            this.lbl_total2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(440, 474);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "TOTAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_posterSelected
            // 
            this.pb_posterSelected.Image = global::Cineverse.Properties.Resources.PosterPlaceholder;
            this.pb_posterSelected.Location = new System.Drawing.Point(484, 166);
            this.pb_posterSelected.Name = "pb_posterSelected";
            this.pb_posterSelected.Size = new System.Drawing.Size(196, 296);
            this.pb_posterSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_posterSelected.TabIndex = 16;
            this.pb_posterSelected.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(436, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "PAYMENT METHOD: CASH";
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
            this.panel5.TabIndex = 6;
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
            this.panel3.TabIndex = 5;
            // 
            // timer_paymentInProgress
            // 
            this.timer_paymentInProgress.Enabled = true;
            this.timer_paymentInProgress.Interval = 500;
            this.timer_paymentInProgress.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PaymentForm
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
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_posterSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_transactionComplete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pb_posterSelected;
        private System.Windows.Forms.Label lbl_cinemaNo;
        private System.Windows.Forms.Label lbl_titlePayment;
        private System.Windows.Forms.Label lbl_dateTime;
        private System.Windows.Forms.Label lbl_seats;
        private System.Windows.Forms.Label lbl_tcktQuantity;
        private System.Windows.Forms.Label lbl_tcktPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_total2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_paymentInProgress;
        private System.Windows.Forms.Label lbl_total1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer_paymentInProgress;
        private System.Windows.Forms.Label lbl_discount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_voucher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_genre;
        private System.Windows.Forms.Label lbl_time;
    }
}