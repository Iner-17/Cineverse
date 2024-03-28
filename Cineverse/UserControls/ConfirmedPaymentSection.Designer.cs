namespace Cineverse.UserControls
{
    partial class ConfirmedPaymentSection
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_total2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_transactionComplete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Cineverse.Properties.Resources.check;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(474, 204);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 87);
            this.panel1.TabIndex = 0;
            // 
            // lbl_total2
            // 
            this.lbl_total2.Font = new System.Drawing.Font("Montserrat", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total2.ForeColor = System.Drawing.Color.White;
            this.lbl_total2.Location = new System.Drawing.Point(375, 294);
            this.lbl_total2.Name = "lbl_total2";
            this.lbl_total2.Size = new System.Drawing.Size(285, 54);
            this.lbl_total2.TabIndex = 29;
            this.lbl_total2.Text = "Success!";
            this.lbl_total2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(375, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Payment Completed";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_transactionComplete
            // 
            this.btn_transactionComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_transactionComplete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_transactionComplete.FlatAppearance.BorderSize = 0;
            this.btn_transactionComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_transactionComplete.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_transactionComplete.Location = new System.Drawing.Point(385, 380);
            this.btn_transactionComplete.Name = "btn_transactionComplete";
            this.btn_transactionComplete.Size = new System.Drawing.Size(270, 53);
            this.btn_transactionComplete.TabIndex = 30;
            this.btn_transactionComplete.Text = "Back to Dashboard";
            this.btn_transactionComplete.UseVisualStyleBackColor = false;
            // 
            // ConfirmedPaymentSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.btn_transactionComplete);
            this.Controls.Add(this.lbl_total2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ConfirmedPaymentSection";
            this.Size = new System.Drawing.Size(1035, 718);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_total2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_transactionComplete;
    }
}
