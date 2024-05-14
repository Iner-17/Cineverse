namespace Cineverse
{
    partial class Login
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
        {            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.LoginBg = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_forgotPass = new System.Windows.Forms.Label();
            this.btn_hide = new System.Windows.Forms.Button();
            this.signup = new System.Windows.Forms.Label();
            this.btn_show = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_user = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ep_username = new System.Windows.Forms.ErrorProvider(this.components);
            this.ep_password = new System.Windows.Forms.ErrorProvider(this.components);
            this.LoginBg.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_password)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBg
            // 
            this.LoginBg.BackgroundImage = global::Cineverse.Properties.Resources.Cineverse_Bg;
            this.LoginBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoginBg.Controls.Add(this.panel5);
            this.LoginBg.Controls.Add(this.panel3);
            this.LoginBg.Controls.Add(this.panel2);
            this.LoginBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginBg.Location = new System.Drawing.Point(0, 0);
            this.LoginBg.Name = "LoginBg";
            this.LoginBg.Size = new System.Drawing.Size(1520, 950);
            this.LoginBg.TabIndex = 0;
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
            this.panel5.TabIndex = 2;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.lbl_forgotPass);
            this.panel3.Controls.Add(this.btn_hide);
            this.panel3.Controls.Add(this.signup);
            this.panel3.Controls.Add(this.btn_show);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txt_pass);
            this.panel3.Controls.Add(this.txt_user);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(794, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 656);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbl_forgotPass
            // 
            this.lbl_forgotPass.AutoSize = true;
            this.lbl_forgotPass.BackColor = System.Drawing.Color.Transparent;
            this.lbl_forgotPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_forgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_forgotPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.lbl_forgotPass.Location = new System.Drawing.Point(221, 470);
            this.lbl_forgotPass.Name = "lbl_forgotPass";
            this.lbl_forgotPass.Size = new System.Drawing.Size(147, 18);
            this.lbl_forgotPass.TabIndex = 10;
            this.lbl_forgotPass.Text = "Forgot Password?";
            this.lbl_forgotPass.Click += new System.EventHandler(this.lbl_forgotPass_Click);
            this.lbl_forgotPass.MouseEnter += new System.EventHandler(this.lbl_forgotPass_MouseEnter);
            this.lbl_forgotPass.MouseLeave += new System.EventHandler(this.lbl_forgotPass_MouseLeave);
            // 
            // btn_hide
            // 
            this.btn_hide.BackColor = System.Drawing.Color.Transparent;
            this.btn_hide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_hide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_hide.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_hide.FlatAppearance.BorderSize = 0;
            this.btn_hide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_hide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_hide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hide.Image = global::Cineverse.Properties.Resources.hidesmol;
            this.btn_hide.Location = new System.Drawing.Point(443, 422);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(35, 27);
            this.btn_hide.TabIndex = 5;
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // signup
            // 
            this.signup.AutoSize = true;
            this.signup.BackColor = System.Drawing.Color.Transparent;
            this.signup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.signup.Location = new System.Drawing.Point(356, 598);
            this.signup.Name = "signup";
            this.signup.Size = new System.Drawing.Size(70, 19);
            this.signup.TabIndex = 9;
            this.signup.Text = "Sign Up";
            this.signup.Click += new System.EventHandler(this.signup_Click);
            // 
            // btn_show
            // 
            this.btn_show.BackColor = System.Drawing.Color.Transparent;
            this.btn_show.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_show.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_show.FlatAppearance.BorderSize = 0;
            this.btn_show.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_show.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_show.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_show.Image = global::Cineverse.Properties.Resources.showsmol;
            this.btn_show.Location = new System.Drawing.Point(443, 422);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(35, 27);
            this.btn_show.TabIndex = 4;
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(166, 598);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Don\'t have an account?\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(109, 392);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(109, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Username";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderRadius = 10;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.guna2Button1.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(113, 512);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(375, 40);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Login";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Cineverse.Properties.Resources.LogoCiniverse;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(147, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(305, 152);
            this.panel4.TabIndex = 2;
            // 
            // txt_pass
            // 
            this.txt_pass.BorderRadius = 10;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_pass.DefaultText = "Enter Password";
            this.txt_pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_pass.FillColor = System.Drawing.Color.Transparent;
            this.txt_pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Silver;
            this.txt_pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_pass.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.txt_pass.IconRightOffset = new System.Drawing.Point(3, 0);
            this.txt_pass.Location = new System.Drawing.Point(113, 415);
            this.txt_pass.Margin = new System.Windows.Forms.Padding(4);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '\0';
            this.txt_pass.PlaceholderText = "";
            this.txt_pass.SelectedText = "";
            this.txt_pass.Size = new System.Drawing.Size(375, 40);
            this.txt_pass.TabIndex = 3;
            this.txt_pass.TextChanged += new System.EventHandler(this.txt_pass_TextChanged);
            this.txt_pass.Enter += new System.EventHandler(this.txt_pass_Enter);
            this.txt_pass.Leave += new System.EventHandler(this.txt_pass_Leave);
            // 
            // txt_user
            // 
            this.txt_user.BorderRadius = 10;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_user.DefaultText = "Enter Username or Email";
            this.txt_user.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_user.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_user.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_user.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_user.FillColor = System.Drawing.Color.Transparent;
            this.txt_user.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_user.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.Silver;
            this.txt_user.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_user.Location = new System.Drawing.Point(113, 334);
            this.txt_user.Margin = new System.Windows.Forms.Padding(4);
            this.txt_user.Name = "txt_user";
            this.txt_user.PasswordChar = '\0';
            this.txt_user.PlaceholderText = "";
            this.txt_user.SelectedText = "";
            this.txt_user.Size = new System.Drawing.Size(375, 40);
            this.txt_user.TabIndex = 2;
            this.txt_user.TextChanged += new System.EventHandler(this.txt_user_TextChanged);
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            this.txt_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_KeyPress);
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(216, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 55);
            this.label2.TabIndex = 0;
            this.label2.Text = "LOG IN";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Cineverse.Properties.Resources.LOGO1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(22, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 56);
            this.panel2.TabIndex = 0;
            // 
            // ep_username
            // 
            this.ep_username.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ep_username.ContainerControl = this;
            // 
            // ep_password
            // 
            this.ep_password.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ep_password.ContainerControl = this;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 950);
            this.Controls.Add(this.LoginBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cineverse";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Login_KeyPress);
            this.LoginBg.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep_password)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel LoginBg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_pass;
        private Guna.UI2.WinForms.Guna2TextBox txt_user;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label signup;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Label lbl_forgotPass;
        private System.Windows.Forms.ErrorProvider ep_username;
        private System.Windows.Forms.ErrorProvider ep_password;
    }
}

