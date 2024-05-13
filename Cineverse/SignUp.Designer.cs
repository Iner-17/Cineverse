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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.SignUpBg = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_astConfirmPass = new System.Windows.Forms.Label();
            this.lbl_astPass = new System.Windows.Forms.Label();
            this.lbl_astUsername = new System.Windows.Forms.Label();
            this.lbl_astContactNo = new System.Windows.Forms.Label();
            this.lbl_astEmail = new System.Windows.Forms.Label();
            this.lbl_astLN = new System.Windows.Forms.Label();
            this.lbl_astFN = new System.Windows.Forms.Label();
            this.txt_ContactNum = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.ep_FN = new System.Windows.Forms.ErrorProvider(this.components);
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_hide = new System.Windows.Forms.Button();
            this.btn_confirmShow = new System.Windows.Forms.Button();
            this.btn_confirmHide = new System.Windows.Forms.Button();
            this.SignUpBg.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_FN)).BeginInit();
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
            this.SignUpBg.Size = new System.Drawing.Size(1520, 950);
            this.SignUpBg.TabIndex = 0;
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
            this.panel5.TabIndex = 3;
            this.panel5.Click += new System.EventHandler(this.panel5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.btn_confirmHide);
            this.panel3.Controls.Add(this.btn_confirmShow);
            this.panel3.Controls.Add(this.btn_hide);
            this.panel3.Controls.Add(this.btn_show);
            this.panel3.Controls.Add(this.lbl_astConfirmPass);
            this.panel3.Controls.Add(this.lbl_astPass);
            this.panel3.Controls.Add(this.lbl_astUsername);
            this.panel3.Controls.Add(this.lbl_astContactNo);
            this.panel3.Controls.Add(this.lbl_astEmail);
            this.panel3.Controls.Add(this.lbl_astLN);
            this.panel3.Controls.Add(this.lbl_astFN);
            this.panel3.Controls.Add(this.txt_ContactNum);
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
            this.panel3.Location = new System.Drawing.Point(450, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(620, 727);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // lbl_astConfirmPass
            // 
            this.lbl_astConfirmPass.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_astConfirmPass.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_astConfirmPass.Location = new System.Drawing.Point(268, 549);
            this.lbl_astConfirmPass.Name = "lbl_astConfirmPass";
            this.lbl_astConfirmPass.Size = new System.Drawing.Size(16, 11);
            this.lbl_astConfirmPass.TabIndex = 18;
            this.lbl_astConfirmPass.Text = "*";
            // 
            // lbl_astPass
            // 
            this.lbl_astPass.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_astPass.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_astPass.Location = new System.Drawing.Point(192, 494);
            this.lbl_astPass.Name = "lbl_astPass";
            this.lbl_astPass.Size = new System.Drawing.Size(16, 11);
            this.lbl_astPass.TabIndex = 17;
            this.lbl_astPass.Text = "*";
            // 
            // lbl_astUsername
            // 
            this.lbl_astUsername.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_astUsername.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_astUsername.Location = new System.Drawing.Point(200, 439);
            this.lbl_astUsername.Name = "lbl_astUsername";
            this.lbl_astUsername.Size = new System.Drawing.Size(16, 11);
            this.lbl_astUsername.TabIndex = 16;
            this.lbl_astUsername.Text = "*";
            // 
            // lbl_astContactNo
            // 
            this.lbl_astContactNo.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_astContactNo.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_astContactNo.Location = new System.Drawing.Point(212, 385);
            this.lbl_astContactNo.Name = "lbl_astContactNo";
            this.lbl_astContactNo.Size = new System.Drawing.Size(16, 11);
            this.lbl_astContactNo.TabIndex = 15;
            this.lbl_astContactNo.Text = "*";
            // 
            // lbl_astEmail
            // 
            this.lbl_astEmail.BackColor = System.Drawing.Color.Black;
            this.lbl_astEmail.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_astEmail.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_astEmail.Location = new System.Drawing.Point(159, 330);
            this.lbl_astEmail.Name = "lbl_astEmail";
            this.lbl_astEmail.Size = new System.Drawing.Size(16, 11);
            this.lbl_astEmail.TabIndex = 14;
            this.lbl_astEmail.Text = "*";
            // 
            // lbl_astLN
            // 
            this.lbl_astLN.BackColor = System.Drawing.Color.Black;
            this.lbl_astLN.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_astLN.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_astLN.Location = new System.Drawing.Point(426, 275);
            this.lbl_astLN.Name = "lbl_astLN";
            this.lbl_astLN.Size = new System.Drawing.Size(16, 11);
            this.lbl_astLN.TabIndex = 13;
            this.lbl_astLN.Text = "*";
            // 
            // lbl_astFN
            // 
            this.lbl_astFN.BackColor = System.Drawing.Color.Black;
            this.lbl_astFN.Font = new System.Drawing.Font("Montserrat", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_astFN.ForeColor = System.Drawing.Color.DarkRed;
            this.lbl_astFN.Location = new System.Drawing.Point(203, 275);
            this.lbl_astFN.Name = "lbl_astFN";
            this.lbl_astFN.Size = new System.Drawing.Size(16, 11);
            this.lbl_astFN.TabIndex = 12;
            this.lbl_astFN.Text = "*";
            // 
            // txt_ContactNum
            // 
            this.txt_ContactNum.BorderRadius = 10;
            this.txt_ContactNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ContactNum.DefaultText = "Contact No.";
            this.txt_ContactNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_ContactNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_ContactNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ContactNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_ContactNum.FillColor = System.Drawing.Color.Transparent;
            this.txt_ContactNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ContactNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ContactNum.ForeColor = System.Drawing.Color.Silver;
            this.txt_ContactNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_ContactNum.Location = new System.Drawing.Point(105, 382);
            this.txt_ContactNum.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ContactNum.Name = "txt_ContactNum";
            this.txt_ContactNum.PasswordChar = '\0';
            this.txt_ContactNum.PlaceholderText = "";
            this.txt_ContactNum.SelectedText = "";
            this.txt_ContactNum.Size = new System.Drawing.Size(409, 40);
            this.txt_ContactNum.TabIndex = 5;
            this.txt_ContactNum.TextChanged += new System.EventHandler(this.txt_ContactNum_TextChanged);
            this.txt_ContactNum.Enter += new System.EventHandler(this.txt_ContactNum_Enter);
            this.txt_ContactNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_ContactNum_KeyPress);
            this.txt_ContactNum.Leave += new System.EventHandler(this.txt_ContactNum_Leave);
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
            this.txt_confirmPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirmPassword.ForeColor = System.Drawing.Color.Silver;
            this.txt_confirmPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_confirmPassword.Location = new System.Drawing.Point(105, 547);
            this.txt_confirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txt_confirmPassword.Name = "txt_confirmPassword";
            this.txt_confirmPassword.PasswordChar = '\0';
            this.txt_confirmPassword.PlaceholderText = "";
            this.txt_confirmPassword.SelectedText = "";
            this.txt_confirmPassword.Size = new System.Drawing.Size(409, 40);
            this.txt_confirmPassword.TabIndex = 8;
            this.txt_confirmPassword.TextChanged += new System.EventHandler(this.txt_confirmPassword_TextChanged);
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
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.Silver;
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.Location = new System.Drawing.Point(105, 492);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PlaceholderText = "";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(410, 40);
            this.txt_password.TabIndex = 7;
            this.txt_password.TextChanged += new System.EventHandler(this.txt_password_TextChanged);
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
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.ForeColor = System.Drawing.Color.Silver;
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Location = new System.Drawing.Point(105, 437);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderText = "";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(409, 40);
            this.txt_username.TabIndex = 6;
            this.txt_username.TextChanged += new System.EventHandler(this.txt_username_TextChanged);
            this.txt_username.Enter += new System.EventHandler(this.txt_username_Enter);
            this.txt_username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_username_KeyPress);
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
            this.txt_lastName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lastName.ForeColor = System.Drawing.Color.Silver;
            this.txt_lastName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lastName.Location = new System.Drawing.Point(330, 272);
            this.txt_lastName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lastName.Name = "txt_lastName";
            this.txt_lastName.PasswordChar = '\0';
            this.txt_lastName.PlaceholderText = "";
            this.txt_lastName.SelectedText = "";
            this.txt_lastName.Size = new System.Drawing.Size(185, 40);
            this.txt_lastName.TabIndex = 3;
            this.txt_lastName.TextChanged += new System.EventHandler(this.txt_lastName_TextChanged);
            this.txt_lastName.Enter += new System.EventHandler(this.txt_lastName_Enter);
            this.txt_lastName.Leave += new System.EventHandler(this.txt_lastName_Leave);
            // 
            // txt_firstName
            // 
            this.txt_firstName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_firstName.BorderRadius = 10;
            this.txt_firstName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_firstName.DefaultText = "First Name";
            this.txt_firstName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_firstName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_firstName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_firstName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_firstName.FillColor = System.Drawing.Color.Transparent;
            this.txt_firstName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_firstName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_firstName.ForeColor = System.Drawing.Color.Silver;
            this.txt_firstName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_firstName.Location = new System.Drawing.Point(105, 272);
            this.txt_firstName.Margin = new System.Windows.Forms.Padding(4);
            this.txt_firstName.Name = "txt_firstName";
            this.txt_firstName.PasswordChar = '\0';
            this.txt_firstName.PlaceholderText = "";
            this.txt_firstName.SelectedText = "";
            this.txt_firstName.Size = new System.Drawing.Size(200, 40);
            this.txt_firstName.TabIndex = 2;
            this.txt_firstName.TextChanged += new System.EventHandler(this.txt_firstName_TextChanged);
            this.txt_firstName.Enter += new System.EventHandler(this.txt_firstName_Enter);
            this.txt_firstName.Leave += new System.EventHandler(this.txt_firstName_Leave);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(178)))), ((int)(((byte)(198)))));
            this.Login.Location = new System.Drawing.Point(386, 682);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(56, 19);
            this.Login.TabIndex = 9;
            this.Login.Text = "Log in";
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(179, 682);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(211, 19);
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
            this.guna2Button1.Location = new System.Drawing.Point(105, 617);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(410, 40);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Sign Up";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.BackgroundImage = global::Cineverse.Properties.Resources.LogoCiniverse;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel4.Location = new System.Drawing.Point(171, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(278, 132);
            this.panel4.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.BorderRadius = 10;
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "Email";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FillColor = System.Drawing.Color.Transparent;
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.txt_email.ForeColor = System.Drawing.Color.Silver;
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(105, 327);
            this.txt_email.Margin = new System.Windows.Forms.Padding(4);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(409, 40);
            this.txt_email.TabIndex = 4;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_email_KeyPress);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Montserrat", 33.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(203, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 55);
            this.label2.TabIndex = 1;
            this.label2.Text = "SIGN UP";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::Cineverse.Properties.Resources.LOGO1;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(22, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 56);
            this.panel2.TabIndex = 1;
            // 
            // ep_FN
            // 
            this.ep_FN.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ep_FN.ContainerControl = this;
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
            this.btn_show.Location = new System.Drawing.Point(477, 499);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(35, 27);
            this.btn_show.TabIndex = 19;
            this.btn_show.UseVisualStyleBackColor = false;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
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
            this.btn_hide.Location = new System.Drawing.Point(477, 499);
            this.btn_hide.Name = "btn_hide";
            this.btn_hide.Size = new System.Drawing.Size(35, 27);
            this.btn_hide.TabIndex = 20;
            this.btn_hide.UseVisualStyleBackColor = false;
            this.btn_hide.Click += new System.EventHandler(this.btn_hide_Click);
            // 
            // btn_confirmShow
            // 
            this.btn_confirmShow.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirmShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirmShow.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_confirmShow.FlatAppearance.BorderSize = 0;
            this.btn_confirmShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_confirmShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_confirmShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmShow.Image = global::Cineverse.Properties.Resources.showsmol;
            this.btn_confirmShow.Location = new System.Drawing.Point(477, 554);
            this.btn_confirmShow.Name = "btn_confirmShow";
            this.btn_confirmShow.Size = new System.Drawing.Size(35, 27);
            this.btn_confirmShow.TabIndex = 21;
            this.btn_confirmShow.UseVisualStyleBackColor = false;
            this.btn_confirmShow.Click += new System.EventHandler(this.btn_confirmShow_Click);
            // 
            // btn_confirmHide
            // 
            this.btn_confirmHide.BackColor = System.Drawing.Color.Transparent;
            this.btn_confirmHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_confirmHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_confirmHide.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_confirmHide.FlatAppearance.BorderSize = 0;
            this.btn_confirmHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btn_confirmHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btn_confirmHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_confirmHide.Image = global::Cineverse.Properties.Resources.hidesmol;
            this.btn_confirmHide.Location = new System.Drawing.Point(477, 554);
            this.btn_confirmHide.Name = "btn_confirmHide";
            this.btn_confirmHide.Size = new System.Drawing.Size(35, 27);
            this.btn_confirmHide.TabIndex = 22;
            this.btn_confirmHide.UseVisualStyleBackColor = false;
            this.btn_confirmHide.Click += new System.EventHandler(this.btn_confirmHide_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 950);
            this.Controls.Add(this.SignUpBg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.SignUpBg.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep_FN)).EndInit();
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
        private Guna.UI2.WinForms.Guna2TextBox txt_ContactNum;
        private System.Windows.Forms.Label lbl_astFN;
        private System.Windows.Forms.Label lbl_astContactNo;
        private System.Windows.Forms.Label lbl_astEmail;
        private System.Windows.Forms.Label lbl_astLN;
        private System.Windows.Forms.Label lbl_astConfirmPass;
        private System.Windows.Forms.Label lbl_astPass;
        private System.Windows.Forms.Label lbl_astUsername;
        private System.Windows.Forms.ErrorProvider ep_FN;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_hide;
        private System.Windows.Forms.Button btn_confirmHide;
        private System.Windows.Forms.Button btn_confirmShow;
    }
}