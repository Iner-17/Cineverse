﻿namespace Cineverse.UserControls
{
    partial class SynopsisSection
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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_backk = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_Poster1 = new System.Windows.Forms.PictureBox();
            this.lbl_price1 = new System.Windows.Forms.Label();
            this.lbl_genre1 = new System.Windows.Forms.Label();
            this.lbl_duration1 = new System.Windows.Forms.Label();
            this.lbl_title1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_titleLists = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Poster1)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(168, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "SYNOPSIS";
            // 
            // btn_backk
            // 
            this.btn_backk.AutoSize = true;
            this.btn_backk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_backk.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backk.ForeColor = System.Drawing.Color.White;
            this.btn_backk.Location = new System.Drawing.Point(905, 31);
            this.btn_backk.Name = "btn_backk";
            this.btn_backk.Size = new System.Drawing.Size(107, 16);
            this.btn_backk.TabIndex = 79;
            this.btn_backk.Text = "Back to Movies";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_price1);
            this.panel1.Controls.Add(this.lbl_genre1);
            this.panel1.Controls.Add(this.lbl_duration1);
            this.panel1.Controls.Add(this.lbl_title1);
            this.panel1.Controls.Add(this.pb_Poster1);
            this.panel1.Location = new System.Drawing.Point(115, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 399);
            this.panel1.TabIndex = 81;
            // 
            // pb_Poster1
            // 
            this.pb_Poster1.Image = global::Cineverse.Properties.Resources.PosterPlaceholder;
            this.pb_Poster1.Location = new System.Drawing.Point(42, 51);
            this.pb_Poster1.Name = "pb_Poster1";
            this.pb_Poster1.Size = new System.Drawing.Size(196, 296);
            this.pb_Poster1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Poster1.TabIndex = 16;
            this.pb_Poster1.TabStop = false;
            // 
            // lbl_price1
            // 
            this.lbl_price1.AutoSize = true;
            this.lbl_price1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price1.ForeColor = System.Drawing.Color.White;
            this.lbl_price1.Location = new System.Drawing.Point(244, 148);
            this.lbl_price1.Name = "lbl_price1";
            this.lbl_price1.Size = new System.Drawing.Size(47, 19);
            this.lbl_price1.TabIndex = 84;
            this.lbl_price1.Text = "Price";
            // 
            // lbl_genre1
            // 
            this.lbl_genre1.AutoSize = true;
            this.lbl_genre1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_genre1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genre1.ForeColor = System.Drawing.Color.White;
            this.lbl_genre1.Location = new System.Drawing.Point(244, 130);
            this.lbl_genre1.Name = "lbl_genre1";
            this.lbl_genre1.Size = new System.Drawing.Size(46, 16);
            this.lbl_genre1.TabIndex = 83;
            this.lbl_genre1.Text = "Genre";
            // 
            // lbl_duration1
            // 
            this.lbl_duration1.AutoSize = true;
            this.lbl_duration1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_duration1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration1.ForeColor = System.Drawing.Color.White;
            this.lbl_duration1.Location = new System.Drawing.Point(244, 110);
            this.lbl_duration1.Name = "lbl_duration1";
            this.lbl_duration1.Size = new System.Drawing.Size(63, 16);
            this.lbl_duration1.TabIndex = 81;
            this.lbl_duration1.Text = "Duration";
            // 
            // lbl_title1
            // 
            this.lbl_title1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_title1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title1.ForeColor = System.Drawing.Color.White;
            this.lbl_title1.Location = new System.Drawing.Point(244, 76);
            this.lbl_title1.Name = "lbl_title1";
            this.lbl_title1.Size = new System.Drawing.Size(450, 34);
            this.lbl_title1.TabIndex = 82;
            this.lbl_title1.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.label1.Location = new System.Drawing.Point(245, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "Synopsis";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(245, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(527, 137);
            this.label3.TabIndex = 86;
            this.label3.Text = "Lorem itsum";
            // 
            // cbo_titleLists
            // 
            this.cbo_titleLists.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cbo_titleLists.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbo_titleLists.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbo_titleLists.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_titleLists.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cbo_titleLists.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_titleLists.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbo_titleLists.Font = new System.Drawing.Font("Montserrat", 12F);
            this.cbo_titleLists.ForeColor = System.Drawing.Color.White;
            this.cbo_titleLists.ItemHeight = 30;
            this.cbo_titleLists.Location = new System.Drawing.Point(334, 576);
            this.cbo_titleLists.Name = "cbo_titleLists";
            this.cbo_titleLists.Size = new System.Drawing.Size(367, 36);
            this.cbo_titleLists.TabIndex = 87;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(425, 530);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 34);
            this.label4.TabIndex = 87;
            this.label4.Text = "- MOVIE TITLE -";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SynopsisSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbo_titleLists);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_backk);
            this.Controls.Add(this.label2);
            this.Name = "SynopsisSection";
            this.Size = new System.Drawing.Size(1035, 721);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Poster1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btn_backk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Poster1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_price1;
        private System.Windows.Forms.Label lbl_genre1;
        private System.Windows.Forms.Label lbl_duration1;
        private System.Windows.Forms.Label lbl_title1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_titleLists;
        private System.Windows.Forms.Label label4;
    }
}