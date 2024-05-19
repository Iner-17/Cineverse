namespace Cineverse
{
    partial class Voucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Voucher));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_backToDashboard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(177, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 130);
            this.label1.TabIndex = 8;
            this.label1.Text = "Congratulations!\r\nYour voucher code has been redeemed.\r\nEnjoy your well-deserved " +
    "reward!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_backToDashboard
            // 
            this.btn_backToDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_backToDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_backToDashboard.FlatAppearance.BorderSize = 0;
            this.btn_backToDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backToDashboard.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backToDashboard.ForeColor = System.Drawing.Color.Black;
            this.btn_backToDashboard.Location = new System.Drawing.Point(319, 178);
            this.btn_backToDashboard.Name = "btn_backToDashboard";
            this.btn_backToDashboard.Size = new System.Drawing.Size(132, 37);
            this.btn_backToDashboard.TabIndex = 35;
            this.btn_backToDashboard.Text = "OK";
            this.btn_backToDashboard.UseVisualStyleBackColor = false;
            // 
            // Voucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.BackgroundImage = global::Cineverse.Properties.Resources.discount;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(628, 270);
            this.Controls.Add(this.btn_backToDashboard);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Voucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voucher";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_backToDashboard;
    }
}