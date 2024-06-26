﻿namespace Cineverse
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_user = new System.Windows.Forms.Button();
            this.btn_bookings = new System.Windows.Forms.Button();
            this.btn_schedule = new System.Windows.Forms.Button();
            this.btn_movies = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_user);
            this.panel1.Controls.Add(this.btn_bookings);
            this.panel1.Controls.Add(this.btn_schedule);
            this.panel1.Controls.Add(this.btn_movies);
            this.panel1.Controls.Add(this.btn_dashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 865);
            this.panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Transparent;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logout.Location = new System.Drawing.Point(25, 814);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btn_logout.Size = new System.Drawing.Size(270, 42);
            this.btn_logout.TabIndex = 10;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.button6_Click);
            this.btn_logout.MouseEnter += new System.EventHandler(this.btn_logout_MouseEnter);
            this.btn_logout.MouseLeave += new System.EventHandler(this.btn_logout_MouseLeave);
            // 
            // btn_user
            // 
            this.btn_user.BackColor = System.Drawing.Color.Transparent;
            this.btn_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_user.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.ForeColor = System.Drawing.Color.White;
            this.btn_user.Location = new System.Drawing.Point(25, 561);
            this.btn_user.Name = "btn_user";
            this.btn_user.Size = new System.Drawing.Size(270, 42);
            this.btn_user.TabIndex = 9;
            this.btn_user.Text = "User";
            this.btn_user.UseVisualStyleBackColor = false;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            this.btn_user.MouseEnter += new System.EventHandler(this.btn_user_MouseEnter);
            this.btn_user.MouseLeave += new System.EventHandler(this.btn_user_MouseLeave);
            // 
            // btn_bookings
            // 
            this.btn_bookings.BackColor = System.Drawing.Color.Transparent;
            this.btn_bookings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_bookings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_bookings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bookings.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bookings.ForeColor = System.Drawing.Color.White;
            this.btn_bookings.Location = new System.Drawing.Point(25, 460);
            this.btn_bookings.Name = "btn_bookings";
            this.btn_bookings.Size = new System.Drawing.Size(270, 42);
            this.btn_bookings.TabIndex = 8;
            this.btn_bookings.Text = "Bookings";
            this.btn_bookings.UseVisualStyleBackColor = false;
            this.btn_bookings.Click += new System.EventHandler(this.btn_bookings_Click);
            this.btn_bookings.MouseEnter += new System.EventHandler(this.btn_bookings_MouseEnter);
            this.btn_bookings.MouseLeave += new System.EventHandler(this.btn_bookings_MouseLeave);
            // 
            // btn_schedule
            // 
            this.btn_schedule.BackColor = System.Drawing.Color.Transparent;
            this.btn_schedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_schedule.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_schedule.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_schedule.ForeColor = System.Drawing.Color.White;
            this.btn_schedule.Location = new System.Drawing.Point(25, 509);
            this.btn_schedule.Name = "btn_schedule";
            this.btn_schedule.Size = new System.Drawing.Size(270, 42);
            this.btn_schedule.TabIndex = 7;
            this.btn_schedule.Text = "Schedule";
            this.btn_schedule.UseVisualStyleBackColor = false;
            this.btn_schedule.Click += new System.EventHandler(this.btn_schedule_Click);
            this.btn_schedule.MouseEnter += new System.EventHandler(this.btn_schedule_MouseEnter);
            this.btn_schedule.MouseLeave += new System.EventHandler(this.btn_schedule_MouseLeave);
            // 
            // btn_movies
            // 
            this.btn_movies.BackColor = System.Drawing.Color.Transparent;
            this.btn_movies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_movies.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_movies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_movies.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_movies.ForeColor = System.Drawing.Color.White;
            this.btn_movies.Location = new System.Drawing.Point(25, 410);
            this.btn_movies.Name = "btn_movies";
            this.btn_movies.Size = new System.Drawing.Size(270, 42);
            this.btn_movies.TabIndex = 6;
            this.btn_movies.Text = "Movies";
            this.btn_movies.UseVisualStyleBackColor = false;
            this.btn_movies.Click += new System.EventHandler(this.btn_movies_Click);
            this.btn_movies.MouseEnter += new System.EventHandler(this.btn_movies_MouseEnter);
            this.btn_movies.MouseLeave += new System.EventHandler(this.btn_movies_MouseLeave);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dashboard.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.Location = new System.Drawing.Point(25, 360);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(270, 42);
            this.btn_dashboard.TabIndex = 5;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = false;
            this.btn_dashboard.Click += new System.EventHandler(this.btn_dashboard_Click);
            this.btn_dashboard.MouseEnter += new System.EventHandler(this.btn_dashboard_MouseEnter);
            this.btn_dashboard.MouseLeave += new System.EventHandler(this.btn_dashboard_MouseLeave);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Cineverse.Properties.Resources.LogoCineverseBooking;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(31, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 148);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(343, 54);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1165, 865);
            this.panel4.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Cineverse.Properties.Resources.LOGO1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 26);
            this.panel3.TabIndex = 4;
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
            this.panel5.TabIndex = 3;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1520, 950);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_user;
        private System.Windows.Forms.Button btn_bookings;
        private System.Windows.Forms.Button btn_schedule;
        private System.Windows.Forms.Button btn_movies;
        private System.Windows.Forms.Panel panel4;
    }
}