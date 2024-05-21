namespace Cineverse.UserControls
{
    partial class ScheduleSection
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_booking = new System.Windows.Forms.DataGridView();
            this.lbl_refresh = new System.Windows.Forms.Label();
            this.btn_today = new System.Windows.Forms.Button();
            this.btn_thisWeek = new System.Windows.Forms.Button();
            this.cbo_movies = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_all = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_booking)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(213, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "SCHEDULES";
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
            this.dgv_booking.Location = new System.Drawing.Point(103, 158);
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
            this.dgv_booking.Size = new System.Drawing.Size(942, 647);
            this.dgv_booking.TabIndex = 5;
            // 
            // lbl_refresh
            // 
            this.lbl_refresh.AutoSize = true;
            this.lbl_refresh.BackColor = System.Drawing.Color.Transparent;
            this.lbl_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_refresh.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_refresh.ForeColor = System.Drawing.Color.White;
            this.lbl_refresh.Location = new System.Drawing.Point(1054, 27);
            this.lbl_refresh.Name = "lbl_refresh";
            this.lbl_refresh.Size = new System.Drawing.Size(68, 19);
            this.lbl_refresh.TabIndex = 22;
            this.lbl_refresh.Text = "Refresh";
            this.lbl_refresh.MouseEnter += new System.EventHandler(this.lbl_refresh_MouseEnter);
            this.lbl_refresh.MouseLeave += new System.EventHandler(this.lbl_refresh_MouseLeave);
            // 
            // btn_today
            // 
            this.btn_today.BackColor = System.Drawing.Color.Transparent;
            this.btn_today.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_today.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_today.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_today.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_today.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_today.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_today.ForeColor = System.Drawing.Color.White;
            this.btn_today.Location = new System.Drawing.Point(262, 100);
            this.btn_today.Name = "btn_today";
            this.btn_today.Size = new System.Drawing.Size(143, 35);
            this.btn_today.TabIndex = 30;
            this.btn_today.Text = "Today";
            this.btn_today.UseVisualStyleBackColor = false;
            this.btn_today.Click += new System.EventHandler(this.btn_today_Click);
            this.btn_today.MouseEnter += new System.EventHandler(this.btn_today_MouseEnter);
            this.btn_today.MouseLeave += new System.EventHandler(this.btn_today_MouseLeave);
            // 
            // btn_thisWeek
            // 
            this.btn_thisWeek.BackColor = System.Drawing.Color.Transparent;
            this.btn_thisWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thisWeek.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_thisWeek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_thisWeek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_thisWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_thisWeek.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thisWeek.ForeColor = System.Drawing.Color.White;
            this.btn_thisWeek.Location = new System.Drawing.Point(422, 100);
            this.btn_thisWeek.Name = "btn_thisWeek";
            this.btn_thisWeek.Size = new System.Drawing.Size(143, 35);
            this.btn_thisWeek.TabIndex = 31;
            this.btn_thisWeek.Text = "This Week";
            this.btn_thisWeek.UseVisualStyleBackColor = false;
            this.btn_thisWeek.Click += new System.EventHandler(this.btn_thisWeek_Click);
            this.btn_thisWeek.MouseEnter += new System.EventHandler(this.btn_thisWeek_MouseEnter);
            this.btn_thisWeek.MouseLeave += new System.EventHandler(this.btn_thisWeek_MouseLeave);
            // 
            // cbo_movies
            // 
            this.cbo_movies.BackColor = System.Drawing.Color.Transparent;
            this.cbo_movies.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.cbo_movies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_movies.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_movies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_movies.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cbo_movies.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_movies.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_movies.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbo_movies.ForeColor = System.Drawing.Color.White;
            this.cbo_movies.ItemHeight = 30;
            this.cbo_movies.Location = new System.Drawing.Point(707, 99);
            this.cbo_movies.Name = "cbo_movies";
            this.cbo_movies.Size = new System.Drawing.Size(338, 36);
            this.cbo_movies.TabIndex = 32;
            this.cbo_movies.SelectedIndexChanged += new System.EventHandler(this.cbo_movies_SelectedIndexChanged);
            // 
            // btn_all
            // 
            this.btn_all.BackColor = System.Drawing.Color.Transparent;
            this.btn_all.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_all.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_all.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_all.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_all.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_all.ForeColor = System.Drawing.Color.White;
            this.btn_all.Location = new System.Drawing.Point(103, 100);
            this.btn_all.Name = "btn_all";
            this.btn_all.Size = new System.Drawing.Size(143, 35);
            this.btn_all.TabIndex = 33;
            this.btn_all.Text = "All";
            this.btn_all.UseVisualStyleBackColor = false;
            this.btn_all.Click += new System.EventHandler(this.btn_all_Click);
            this.btn_all.MouseEnter += new System.EventHandler(this.btn_all_MouseEnter);
            this.btn_all.MouseLeave += new System.EventHandler(this.btn_all_MouseLeave);
            // 
            // ScheduleSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.btn_all);
            this.Controls.Add(this.cbo_movies);
            this.Controls.Add(this.btn_thisWeek);
            this.Controls.Add(this.btn_today);
            this.Controls.Add(this.lbl_refresh);
            this.Controls.Add(this.dgv_booking);
            this.Controls.Add(this.label2);
            this.Name = "ScheduleSection";
            this.Size = new System.Drawing.Size(1165, 865);
            this.Load += new System.EventHandler(this.ScheduleSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_booking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_booking;
        private System.Windows.Forms.Label lbl_refresh;
        private System.Windows.Forms.Button btn_today;
        private System.Windows.Forms.Button btn_thisWeek;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_movies;
        private System.Windows.Forms.Button btn_all;
    }
}
