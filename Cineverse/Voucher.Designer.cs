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
            this.txt_voucher = new System.Windows.Forms.TextBox();
            this.btn_submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_voucher
            // 
            this.txt_voucher.Location = new System.Drawing.Point(68, 121);
            this.txt_voucher.Name = "txt_voucher";
            this.txt_voucher.Size = new System.Drawing.Size(144, 20);
            this.txt_voucher.TabIndex = 0;
            // 
            // btn_submit
            // 
            this.btn_submit.Location = new System.Drawing.Point(235, 121);
            this.btn_submit.Name = "btn_submit";
            this.btn_submit.Size = new System.Drawing.Size(75, 23);
            this.btn_submit.TabIndex = 1;
            this.btn_submit.Text = "button1";
            this.btn_submit.UseVisualStyleBackColor = true;
            // 
            // Voucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 225);
            this.Controls.Add(this.btn_submit);
            this.Controls.Add(this.txt_voucher);
            this.Name = "Voucher";
            this.Text = "Voucher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_voucher;
        private System.Windows.Forms.Button btn_submit;
    }
}