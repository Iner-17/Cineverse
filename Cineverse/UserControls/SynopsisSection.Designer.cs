namespace Cineverse.UserControls
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_rating = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_price1 = new System.Windows.Forms.Label();
            this.lbl_genre1 = new System.Windows.Forms.Label();
            this.lbl_duration1 = new System.Windows.Forms.Label();
            this.lbl_Title1 = new System.Windows.Forms.Label();
            this.pb_Poster1 = new System.Windows.Forms.PictureBox();
            this.cbo_titleLists = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Poster1)).BeginInit();
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
            this.label2.Size = new System.Drawing.Size(181, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "SYNOPSIS";
            // 
            // btn_backk
            // 
            this.btn_backk.AutoSize = true;
            this.btn_backk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_backk.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backk.ForeColor = System.Drawing.Color.White;
            this.btn_backk.Location = new System.Drawing.Point(1005, 33);
            this.btn_backk.Name = "btn_backk";
            this.btn_backk.Size = new System.Drawing.Size(125, 19);
            this.btn_backk.TabIndex = 79;
            this.btn_backk.Text = "Back to Movies";
            this.btn_backk.Click += new System.EventHandler(this.btn_backk_Click);
            this.btn_backk.MouseEnter += new System.EventHandler(this.btn_backk_MouseEnter);
            this.btn_backk.MouseLeave += new System.EventHandler(this.btn_backk_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbl_rating);
            this.panel1.Controls.Add(this.lbl_description);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_price1);
            this.panel1.Controls.Add(this.lbl_genre1);
            this.panel1.Controls.Add(this.lbl_duration1);
            this.panel1.Controls.Add(this.lbl_Title1);
            this.panel1.Controls.Add(this.pb_Poster1);
            this.panel1.Location = new System.Drawing.Point(180, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 498);
            this.panel1.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(255, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 91;
            this.label7.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(255, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 90;
            this.label6.Text = "Genre: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(255, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 89;
            this.label5.Text = "Duration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(255, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 88;
            this.label3.Text = "Rating: ";
            // 
            // lbl_rating
            // 
            this.lbl_rating.AutoSize = true;
            this.lbl_rating.BackColor = System.Drawing.Color.Transparent;
            this.lbl_rating.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rating.ForeColor = System.Drawing.Color.White;
            this.lbl_rating.Location = new System.Drawing.Point(354, 122);
            this.lbl_rating.Name = "lbl_rating";
            this.lbl_rating.Size = new System.Drawing.Size(59, 19);
            this.lbl_rating.TabIndex = 87;
            this.lbl_rating.Text = "Rating";
            // 
            // lbl_description
            // 
            this.lbl_description.BackColor = System.Drawing.Color.Transparent;
            this.lbl_description.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_description.Font = new System.Drawing.Font("Montserrat", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_description.ForeColor = System.Drawing.Color.White;
            this.lbl_description.Location = new System.Drawing.Point(255, 249);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(517, 201);
            this.lbl_description.TabIndex = 86;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.label1.Location = new System.Drawing.Point(470, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 85;
            this.label1.Text = "Synopsis";
            // 
            // lbl_price1
            // 
            this.lbl_price1.AutoSize = true;
            this.lbl_price1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_price1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price1.ForeColor = System.Drawing.Color.White;
            this.lbl_price1.Location = new System.Drawing.Point(354, 179);
            this.lbl_price1.Name = "lbl_price1";
            this.lbl_price1.Size = new System.Drawing.Size(51, 19);
            this.lbl_price1.TabIndex = 84;
            this.lbl_price1.Text = "Price";
            // 
            // lbl_genre1
            // 
            this.lbl_genre1.AutoSize = true;
            this.lbl_genre1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_genre1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_genre1.ForeColor = System.Drawing.Color.White;
            this.lbl_genre1.Location = new System.Drawing.Point(354, 160);
            this.lbl_genre1.Name = "lbl_genre1";
            this.lbl_genre1.Size = new System.Drawing.Size(54, 19);
            this.lbl_genre1.TabIndex = 83;
            this.lbl_genre1.Text = "Genre";
            // 
            // lbl_duration1
            // 
            this.lbl_duration1.AutoSize = true;
            this.lbl_duration1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_duration1.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_duration1.ForeColor = System.Drawing.Color.White;
            this.lbl_duration1.Location = new System.Drawing.Point(354, 141);
            this.lbl_duration1.Name = "lbl_duration1";
            this.lbl_duration1.Size = new System.Drawing.Size(76, 19);
            this.lbl_duration1.TabIndex = 81;
            this.lbl_duration1.Text = "Duration";
            // 
            // lbl_Title1
            // 
            this.lbl_Title1.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Title1.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title1.ForeColor = System.Drawing.Color.White;
            this.lbl_Title1.Location = new System.Drawing.Point(253, 88);
            this.lbl_Title1.Name = "lbl_Title1";
            this.lbl_Title1.Size = new System.Drawing.Size(450, 34);
            this.lbl_Title1.TabIndex = 82;
            this.lbl_Title1.Text = "Title";
            // 
            // pb_Poster1
            // 
            this.pb_Poster1.Image = global::Cineverse.Properties.Resources.PosterPlaceholder;
            this.pb_Poster1.Location = new System.Drawing.Point(40, 88);
            this.pb_Poster1.Name = "pb_Poster1";
            this.pb_Poster1.Size = new System.Drawing.Size(196, 295);
            this.pb_Poster1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_Poster1.TabIndex = 16;
            this.pb_Poster1.TabStop = false;
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
            this.cbo_titleLists.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_titleLists.ForeColor = System.Drawing.Color.White;
            this.cbo_titleLists.ItemHeight = 30;
            this.cbo_titleLists.Location = new System.Drawing.Point(399, 686);
            this.cbo_titleLists.Name = "cbo_titleLists";
            this.cbo_titleLists.Size = new System.Drawing.Size(367, 36);
            this.cbo_titleLists.TabIndex = 87;
            this.cbo_titleLists.SelectedIndexChanged += new System.EventHandler(this.cbo_titleLists_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(490, 640);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 34);
            this.label4.TabIndex = 87;
            this.label4.Text = "- MOVIE TITLE -";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Cineverse.Properties.Resources.edit;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel2.Location = new System.Drawing.Point(748, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(24, 23);
            this.panel2.TabIndex = 103;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
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
            this.Size = new System.Drawing.Size(1165, 865);
            this.Load += new System.EventHandler(this.SynopsisSection_Load);
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
        private System.Windows.Forms.Label lbl_Title1;
        private System.Windows.Forms.Label lbl_description;
        private Guna.UI2.WinForms.Guna2ComboBox cbo_titleLists;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_rating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
    }
}
