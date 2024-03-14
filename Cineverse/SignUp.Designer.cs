namespace Cineverse
{
    partial class SignUp
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
            this.SignUpBg = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txt_confirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_lastName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_firstName = new Guna.UI2.WinForms.Guna2TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SignUpBg.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignUpBg
            // 
            this.SignUpBg.BackgroundImage = global::Cineverse.Properties.Resources.Cineverse_Bg;
            this.SignUpBg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SignUpBg.Controls.Add(this.panel5);
            this.SignUpBg.Controls.Add(this.panel3);
            this.SignUpBg.Controls.Add(this.panel2);
            this.SignUpBg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignUpBg.Location = new System.Drawing.Point(0, 0);
            this.SignUpBg.Name = "SignUpBg";
            this.SignUpBg.Size = new System.Drawing.Size(1375, 774);
            this.SignUpBg.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.BackgroundImage = global::Cineverse.Properties.Resources.Close_Button;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Location = new System.Drawing.Point(1343, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(16, 19);
            this.panel5.TabIndex = 3;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.txt_confirmPassword);
            this.panel3.Controls.Add(this.txt_password);
            this.panel3.Controls.Add(this.txt_username);
            this.panel3.Controls.Add(this.txt_lastName);
            this.panel3.Controls.Add(this.txt_firstName);
            this.panel3.Controls.Add(this.Login);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.guna2Button1);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.txt_email);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(425, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(524, 636);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(104, 509);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(317, 20);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "I accept the Terms of Use and Privacy Policy";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // txt_confirmPassword
            // 
            this.txt_confirmPassword.BorderRadius = 10;
            this.txt_confirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_confirmPassword.DefaultText = "Confirm Password";
            this.txt_confirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_confirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_confirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_confirmPassword.FillColor = System.Drawing.Color.Transparent;
            this.txt_confirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confirmPassword.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmPassword.ForeColor = System.Drawing.Color.Silver;
            this.txt_confirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confirmPassword.Location = new System.Drawing.Point(74, 456);
            this.txt_confirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.PasswordChar = '\0';
            this.txt_confirmPassword.PlaceholderText = "";
            this.txt_confirmPassword.SelectedText = "";
            this.txt_confirmPassword.Size = new System.Drawing.Size(375, 40);
            this.txt_confirmPassword.TabIndex = 7;
            this.txt_confirmPassword.Enter += new System.EventHandler(this.txt_confirmPassword_Enter);
            this.txt_confirmPassword.Leave += new System.EventHandler(this.txt_confirmPassword_Leave);
            // 
            // txt_password
            // 
            this.txt_password.BorderRadius = 10;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "Password";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FillColor = System.Drawing.Color.Transparent;
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Silver;
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Location = new System.Drawing.Point(75, 398);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PlaceholderText = "";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(375, 40);
            this.txt_password.TabIndex = 6;
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // txt_username
            // 
            this.txt_username.BorderRadius = 10;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "Username";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FillColor = System.Drawing.Color.Transparent;
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Silver;
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Location = new System.Drawing.Point(74, 340);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderText = "";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(375, 40);
            this.txt_username.TabIndex = 5;
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.Leave += new System.EventHandler(this.txt_username_Leave_1);
            // 
            // txt_lastName
            // 
            this.txt_lastName.BorderRadius = 10;
            this.txt_lastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lastName.DefaultText = "Last Name";
            this.txt_lastName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_lastName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_lastName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lastName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lastName.FillColor = System.Drawing.Color.Transparent;
            this.txt_lastName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lastName.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastName.ForeColor = System.Drawing.Color.Silver;
            this.txt_lastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lastName.Location = new System.Drawing.Point(268, 228);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.PasswordChar = '\0';
            this.txt_lastName.PlaceholderText = "";
            this.txt_lastName.SelectedText = "";
            this.txt_lastName.Size = new System.Drawing.Size(182, 40);
            this.txt_lastName.TabIndex = 3;
            this.txt_lastName.Enter += new System.EventHandler(this.txt_lastName_Enter);
            this.txt_lastName.Leave += new System.EventHandler(this.txt_lastName_Leave);
            // 
            // txt_firstName
            // 
            this.txt_firstName.BorderRadius = 10;
            this.txt_firstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_firstName.DefaultText = "First Name";
            this.txt_firstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_firstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_firstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_firstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_firstName.FillColor = System.Drawing.Color.Transparent;
            this.txt_firstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_firstName.Font = new System.Drawing.Font("Montserrat", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstName.ForeColor = System.Drawing.Color.Silver;
            this.txt_firstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_firstName.Location = new System.Drawing.Point(74, 228);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.PasswordChar = '\0';
            this.txt_firstName.PlaceholderText = "";
            this.txt_firstName.SelectedText = "";
            this.txt_firstName.Size = new System.Drawing.Size(182, 40);
            this.txt_firstName.TabIndex = 2;
            this.txt_firstName.Enter += new System.EventHandler(this.txt_firstName_Enter);
            this.txt_firstName.Leave += new System.EventHandler(this.txt_firstName_Leave);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.Login.Location = new System.Drawing.Point(335, 604);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(55, 19);
            this.Login.TabIndex = 10;
            this.Login.Text = "Log in";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(135, 604);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Already have an account?\r\n";
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
            this.guna2Button1.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(75, 534);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(375, 40);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Sign Up";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Cineverse.Properties.Resources.LogoCiniverse;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(123, 15);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 132);
            this.panel4.TabIndex = 2;
            // 
            // txt_email
            // 
            this.txt_email.BorderRadius = 10;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "Email (Optional)";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FillColor = System.Drawing.Color.Transparent;
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.Silver;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(75, 285);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(375, 40);
            this.txt_email.TabIndex = 4;
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(181, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "SIGN UP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Cineverse.Properties.Resources.LOGO1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(37, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 56);
            this.panel2.TabIndex = 1;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 774);
            this.Controls.Add(this.SignUpBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.SignUpBg.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SignUpBg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_lastName;
        private Guna.UI2.WinForms.Guna2TextBox txt_firstName;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2TextBox txt_confirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}