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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_booking = new System.Windows.Forms.DataGridView();
            this.lbl_refresh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_booking)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "SCHEDULE";
            // 
            // dgv_booking
            // 
            this.dgv_booking.AllowUserToResizeColumns = false;
            this.dgv_booking.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_booking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_booking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_booking.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.dgv_booking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_booking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgv_booking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_booking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_booking.ColumnHeadersHeight = 35;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_booking.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_booking.EnableHeadersVisualStyles = false;
            this.dgv_booking.GridColor = System.Drawing.SystemColors.Control;
            this.dgv_booking.Location = new System.Drawing.Point(40, 72);
            this.dgv_booking.Name = "dgv_booking";
            this.dgv_booking.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_booking.RowHeadersVisible = false;
            this.dgv_booking.RowHeadersWidth = 40;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_booking.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_booking.RowTemplate.Height = 50;
            this.dgv_booking.RowTemplate.ReadOnly = true;
            this.dgv_booking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_booking.Size = new System.Drawing.Size(748, 603);
            this.dgv_booking.TabIndex = 5;
            // 
            // lbl_refresh
            // 
            this.lbl_refresh.AutoSize = true;
            this.lbl_refresh.BackColor = System.Drawing.Color.Transparent;
            this.lbl_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_refresh.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_refresh.ForeColor = System.Drawing.Color.White;
            this.lbl_refresh.Location = new System.Drawing.Point(939, 31);
            this.lbl_refresh.Name = "lbl_refresh";
            this.lbl_refresh.Size = new System.Drawing.Size(57, 16);
            this.lbl_refresh.TabIndex = 22;
            this.lbl_refresh.Text = "Refresh";
            this.lbl_refresh.MouseEnter += new System.EventHandler(this.lbl_refresh_MouseEnter);
            this.lbl_refresh.MouseLeave += new System.EventHandler(this.lbl_refresh_MouseLeave);
            // 
            // ScheduleSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.lbl_refresh);
            this.Controls.Add(this.dgv_booking);
            this.Controls.Add(this.label2);
            this.Name = "ScheduleSection";
            this.Size = new System.Drawing.Size(1035, 721);
            this.Load += new System.EventHandler(this.ScheduleSection_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_booking)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_booking;
        private System.Windows.Forms.Label lbl_refresh;
    }
}
