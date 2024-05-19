namespace Cineverse
{
    partial class AddMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMovie));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_addTitle = new System.Windows.Forms.TextBox();
            this.txt_addPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_addDuration = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_uploadImage = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_saveMovie = new System.Windows.Forms.Button();
            this.Ratings = new System.Windows.Forms.Label();
            this.lbl_cinemaNum = new System.Windows.Forms.Label();
            this.cbo_cinemaNum = new System.Windows.Forms.ComboBox();
            this.txt_description = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbo_rating = new System.Windows.Forms.ComboBox();
            this.cbo_addGenre = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(372, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "ADD MOVIE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(115, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Movie Title";
            // 
            // txt_addTitle
            // 
            this.txt_addTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.txt_addTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_addTitle.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addTitle.ForeColor = System.Drawing.Color.White;
            this.txt_addTitle.Location = new System.Drawing.Point(118, 168);
            this.txt_addTitle.Name = "txt_addTitle";
            this.txt_addTitle.Size = new System.Drawing.Size(352, 31);
            this.txt_addTitle.TabIndex = 7;
            // 
            // txt_addPrice
            // 
            this.txt_addPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.txt_addPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_addPrice.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addPrice.ForeColor = System.Drawing.Color.White;
            this.txt_addPrice.Location = new System.Drawing.Point(527, 168);
            this.txt_addPrice.Name = "txt_addPrice";
            this.txt_addPrice.Size = new System.Drawing.Size(100, 31);
            this.txt_addPrice.TabIndex = 9;
            this.txt_addPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_addPrice_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(523, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(115, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Genre";
            // 
            // txt_addDuration
            // 
            this.txt_addDuration.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.txt_addDuration.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_addDuration.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_addDuration.ForeColor = System.Drawing.Color.White;
            this.txt_addDuration.Location = new System.Drawing.Point(657, 168);
            this.txt_addDuration.Name = "txt_addDuration";
            this.txt_addDuration.Size = new System.Drawing.Size(136, 31);
            this.txt_addDuration.TabIndex = 13;
            this.txt_addDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_addDuration_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(653, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Duration (mins.)";
            // 
            // btn_uploadImage
            // 
            this.btn_uploadImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_uploadImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_uploadImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uploadImage.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_uploadImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_uploadImage.Location = new System.Drawing.Point(623, 554);
            this.btn_uploadImage.Name = "btn_uploadImage";
            this.btn_uploadImage.Size = new System.Drawing.Size(196, 35);
            this.btn_uploadImage.TabIndex = 22;
            this.btn_uploadImage.Text = "Upload Image";
            this.btn_uploadImage.UseVisualStyleBackColor = false;
            this.btn_uploadImage.Click += new System.EventHandler(this.btn_uploadImage_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Location = new System.Drawing.Point(492, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = " ₱";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_saveMovie
            // 
            this.btn_saveMovie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_saveMovie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.btn_saveMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saveMovie.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveMovie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.btn_saveMovie.Location = new System.Drawing.Point(119, 554);
            this.btn_saveMovie.Name = "btn_saveMovie";
            this.btn_saveMovie.Size = new System.Drawing.Size(143, 35);
            this.btn_saveMovie.TabIndex = 29;
            this.btn_saveMovie.Text = "Save Movie";
            this.btn_saveMovie.UseVisualStyleBackColor = false;
            this.btn_saveMovie.Click += new System.EventHandler(this.btn_saveMovie_Click);
            // 
            // Ratings
            // 
            this.Ratings.AutoSize = true;
            this.Ratings.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ratings.ForeColor = System.Drawing.Color.White;
            this.Ratings.Location = new System.Drawing.Point(353, 233);
            this.Ratings.Name = "Ratings";
            this.Ratings.Size = new System.Drawing.Size(117, 19);
            this.Ratings.TabIndex = 30;
            this.Ratings.Text = "Movie Rating";
            // 
            // lbl_cinemaNum
            // 
            this.lbl_cinemaNum.AutoSize = true;
            this.lbl_cinemaNum.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cinemaNum.ForeColor = System.Drawing.Color.White;
            this.lbl_cinemaNum.Location = new System.Drawing.Point(500, 233);
            this.lbl_cinemaNum.Name = "lbl_cinemaNum";
            this.lbl_cinemaNum.Size = new System.Drawing.Size(88, 19);
            this.lbl_cinemaNum.TabIndex = 32;
            this.lbl_cinemaNum.Text = "Cinema #";
            // 
            // cbo_cinemaNum
            // 
            this.cbo_cinemaNum.BackColor = System.Drawing.SystemColors.MenuText;
            this.cbo_cinemaNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_cinemaNum.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_cinemaNum.ForeColor = System.Drawing.SystemColors.Menu;
            this.cbo_cinemaNum.FormattingEnabled = true;
            this.cbo_cinemaNum.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cbo_cinemaNum.Location = new System.Drawing.Point(504, 267);
            this.cbo_cinemaNum.Name = "cbo_cinemaNum";
            this.cbo_cinemaNum.Size = new System.Drawing.Size(100, 27);
            this.cbo_cinemaNum.TabIndex = 34;
            this.cbo_cinemaNum.SelectedIndexChanged += new System.EventHandler(this.cbo_cinemaNum_SelectedIndexChanged);
            // 
            // txt_description
            // 
            this.txt_description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.txt_description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_description.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_description.ForeColor = System.Drawing.Color.White;
            this.txt_description.Location = new System.Drawing.Point(119, 352);
            this.txt_description.Multiline = true;
            this.txt_description.Name = "txt_description";
            this.txt_description.Size = new System.Drawing.Size(485, 177);
            this.txt_description.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(115, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 19);
            this.label11.TabIndex = 36;
            this.label11.Text = "Synopsis";
            // 
            // cbo_rating
            // 
            this.cbo_rating.BackColor = System.Drawing.SystemColors.MenuText;
            this.cbo_rating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_rating.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_rating.ForeColor = System.Drawing.SystemColors.Menu;
            this.cbo_rating.FormattingEnabled = true;
            this.cbo_rating.Items.AddRange(new object[] {
            "G",
            "PG",
            "R",
            "R-13",
            "R-16",
            "R-18"});
            this.cbo_rating.Location = new System.Drawing.Point(354, 267);
            this.cbo_rating.Name = "cbo_rating";
            this.cbo_rating.Size = new System.Drawing.Size(116, 27);
            this.cbo_rating.TabIndex = 37;
            // 
            // cbo_addGenre
            // 
            this.cbo_addGenre.BackColor = System.Drawing.SystemColors.MenuText;
            this.cbo_addGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_addGenre.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_addGenre.ForeColor = System.Drawing.SystemColors.Menu;
            this.cbo_addGenre.FormattingEnabled = true;
            this.cbo_addGenre.Items.AddRange(new object[] {
            "Action",
            "Animation",
            "Comedy",
            "Drama",
            "Fantasy",
            "Horror",
            "Mystery",
            "Romance",
            "Romantic Comedy",
            "Science Fiction",
            "Thriller",
            "Western"});
            this.cbo_addGenre.Location = new System.Drawing.Point(116, 267);
            this.cbo_addGenre.Name = "cbo_addGenre";
            this.cbo_addGenre.Size = new System.Drawing.Size(211, 27);
            this.cbo_addGenre.TabIndex = 41;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(623, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 296);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BackgroundImage = global::Cineverse.Properties.Resources.LOGO1;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(90, 26);
            this.panel3.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::Cineverse.Properties.Resources.Close_Button;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(904, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(19, 26);
            this.panel5.TabIndex = 4;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(935, 643);
            this.Controls.Add(this.cbo_addGenre);
            this.Controls.Add(this.cbo_rating);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.cbo_cinemaNum);
            this.Controls.Add(this.lbl_cinemaNum);
            this.Controls.Add(this.Ratings);
            this.Controls.Add(this.btn_saveMovie);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btn_uploadImage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_addDuration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_addPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_addTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddMovie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_addTitle;
        private System.Windows.Forms.TextBox txt_addPrice;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_addDuration;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_uploadImage;
        private System.Windows.Forms.Button btn_saveMovie;
        public System.Windows.Forms.Label Ratings;
        public System.Windows.Forms.Label lbl_cinemaNum;
        private System.Windows.Forms.ComboBox cbo_cinemaNum;
        private System.Windows.Forms.TextBox txt_description;
        public System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbo_rating;
        private System.Windows.Forms.ComboBox cbo_addGenre;
    }
}