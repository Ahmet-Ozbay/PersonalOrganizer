using System.Drawing;
using System.Windows.Forms.VisualStyles;

namespace FinalProject
{
    partial class Form_SignIn_SignUp
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.pnl_signin = new System.Windows.Forms.Panel();
            this.link_signup = new System.Windows.Forms.LinkLabel();
            this.lbl_title_login = new System.Windows.Forms.Label();
            this.link_forgot_password = new System.Windows.Forms.LinkLabel();
            this.btn_signin = new System.Windows.Forms.Button();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.panel_password = new System.Windows.Forms.Panel();
            this.btn_see_password = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.panel_email = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.pnl_signup = new System.Windows.Forms.Panel();
            this.lbl_confirm_password = new System.Windows.Forms.Label();
            this.link_signin = new System.Windows.Forms.LinkLabel();
            this.pnl_confirm_password = new System.Windows.Forms.Panel();
            this.btn_see_confirmation_register = new System.Windows.Forms.Button();
            this.txt_confirm_password = new System.Windows.Forms.TextBox();
            this.btn_signup = new System.Windows.Forms.Button();
            this.lbl_password_register = new System.Windows.Forms.Label();
            this.pnl_email_register = new System.Windows.Forms.Panel();
            this.txt_email_register = new System.Windows.Forms.TextBox();
            this.pnl_password_register = new System.Windows.Forms.Panel();
            this.btn_see_password_register = new System.Windows.Forms.Button();
            this.txt_password_register = new System.Windows.Forms.TextBox();
            this.lbl_email_register = new System.Windows.Forms.Label();
            this.pnl_lastname = new System.Windows.Forms.Panel();
            this.txt_lastname_register = new System.Windows.Forms.TextBox();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.pnl_name = new System.Windows.Forms.Panel();
            this.txt_name_register = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_signup = new System.Windows.Forms.Label();
            this.bg_flowers = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            this.pnl_signin.SuspendLayout();
            this.panel_password.SuspendLayout();
            this.panel_email.SuspendLayout();
            this.pnl_signup.SuspendLayout();
            this.pnl_confirm_password.SuspendLayout();
            this.pnl_email_register.SuspendLayout();
            this.pnl_password_register.SuspendLayout();
            this.pnl_lastname.SuspendLayout();
            this.pnl_name.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::FinalProject.Properties.Resources.btn_close;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Open Sans ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(1322, 12);
            this.btn_close.MaximumSize = new System.Drawing.Size(32, 32);
            this.btn_close.MinimumSize = new System.Drawing.Size(32, 32);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 32);
            this.btn_close.TabIndex = 0;
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseDown);
            this.btn_close.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BackgroundImage = global::FinalProject.Properties.Resources.btn_minimize;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Open Sans ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(1284, 12);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(32, 32);
            this.btn_minimize.TabIndex = 1;
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            this.btn_minimize.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_minimize_MouseDown);
            this.btn_minimize.MouseEnter += new System.EventHandler(this.btn_minimize_MouseEnter);
            this.btn_minimize.MouseLeave += new System.EventHandler(this.btn_minimize_MouseLeave);
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.Transparent;
            this.pnl_header.Controls.Add(this.btn_close);
            this.pnl_header.Controls.Add(this.btn_minimize);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1366, 50);
            this.pnl_header.TabIndex = 2;
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseDown);
            this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseMove);
            // 
            // pnl_signin
            // 
            this.pnl_signin.BackColor = System.Drawing.Color.Transparent;
            this.pnl_signin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnl_signin.Controls.Add(this.link_signup);
            this.pnl_signin.Controls.Add(this.lbl_title_login);
            this.pnl_signin.Controls.Add(this.link_forgot_password);
            this.pnl_signin.Controls.Add(this.btn_signin);
            this.pnl_signin.Controls.Add(this.lbl_password);
            this.pnl_signin.Controls.Add(this.lbl_email);
            this.pnl_signin.Controls.Add(this.panel_password);
            this.pnl_signin.Controls.Add(this.panel_email);
            this.pnl_signin.ForeColor = System.Drawing.Color.White;
            this.pnl_signin.Location = new System.Drawing.Point(459, 134);
            this.pnl_signin.Name = "pnl_signin";
            this.pnl_signin.Size = new System.Drawing.Size(450, 500);
            this.pnl_signin.TabIndex = 3;
            // 
            // link_signup
            // 
            this.link_signup.ActiveLinkColor = System.Drawing.Color.Black;
            this.link_signup.AutoSize = true;
            this.link_signup.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.link_signup.LinkColor = System.Drawing.Color.White;
            this.link_signup.Location = new System.Drawing.Point(146, 436);
            this.link_signup.Name = "link_signup";
            this.link_signup.Size = new System.Drawing.Size(153, 19);
            this.link_signup.TabIndex = 4;
            this.link_signup.TabStop = true;
            this.link_signup.Text = "Not a Member? Sign Up!";
            this.link_signup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_signup_LinkClicked);
            // 
            // lbl_title_login
            // 
            this.lbl_title_login.AutoSize = true;
            this.lbl_title_login.Font = new System.Drawing.Font("Open Sans ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_title_login.Image = global::FinalProject.Properties.Resources.icon_unlock;
            this.lbl_title_login.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_title_login.Location = new System.Drawing.Point(0, 0);
            this.lbl_title_login.Name = "lbl_title_login";
            this.lbl_title_login.Size = new System.Drawing.Size(401, 69);
            this.lbl_title_login.TabIndex = 6;
            this.lbl_title_login.Text = "      Hello There!";
            this.lbl_title_login.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // link_forgot_password
            // 
            this.link_forgot_password.ActiveLinkColor = System.Drawing.Color.Black;
            this.link_forgot_password.AutoSize = true;
            this.link_forgot_password.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.link_forgot_password.LinkColor = System.Drawing.Color.White;
            this.link_forgot_password.Location = new System.Drawing.Point(149, 406);
            this.link_forgot_password.Name = "link_forgot_password";
            this.link_forgot_password.Size = new System.Drawing.Size(147, 19);
            this.link_forgot_password.TabIndex = 3;
            this.link_forgot_password.TabStop = true;
            this.link_forgot_password.Text = "Forgot Your Password?";
            this.link_forgot_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_signin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_signin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_signin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signin.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_signin.ForeColor = System.Drawing.Color.White;
            this.btn_signin.Location = new System.Drawing.Point(110, 326);
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.Size = new System.Drawing.Size(225, 50);
            this.btn_signin.TabIndex = 2;
            this.btn_signin.Text = "Sign In";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            this.btn_signin.MouseEnter += new System.EventHandler(this.btn_signin_MouseEnter);
            this.btn_signin.MouseLeave += new System.EventHandler(this.btn_signin_MouseLeave);
            this.btn_signin.MouseHover += new System.EventHandler(this.btn_signin_MouseHover);
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Open Sans ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(-5, 195);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(111, 27);
            this.lbl_password.TabIndex = 3;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Open Sans ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Location = new System.Drawing.Point(-5, 98);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(70, 27);
            this.lbl_email.TabIndex = 2;
            this.lbl_email.Text = "Email:";
            // 
            // panel_password
            // 
            this.panel_password.BackColor = System.Drawing.Color.White;
            this.panel_password.Controls.Add(this.btn_see_password);
            this.panel_password.Controls.Add(this.txt_password);
            this.panel_password.Location = new System.Drawing.Point(0, 225);
            this.panel_password.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panel_password.Name = "panel_password";
            this.panel_password.Size = new System.Drawing.Size(450, 50);
            this.panel_password.TabIndex = 1;
            // 
            // btn_see_password
            // 
            this.btn_see_password.BackColor = System.Drawing.Color.White;
            this.btn_see_password.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            this.btn_see_password.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_see_password.FlatAppearance.BorderSize = 0;
            this.btn_see_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_password.Location = new System.Drawing.Point(414, 10);
            this.btn_see_password.Name = "btn_see_password";
            this.btn_see_password.Size = new System.Drawing.Size(32, 32);
            this.btn_see_password.TabIndex = 2;
            this.btn_see_password.TabStop = false;
            this.btn_see_password.UseVisualStyleBackColor = false;
            this.btn_see_password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_MouseDown);
            this.btn_see_password.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_MouseUp);
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_password.ForeColor = System.Drawing.Color.LightGray;
            this.txt_password.Location = new System.Drawing.Point(12, 12);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(420, 26);
            this.txt_password.TabIndex = 1;
            this.txt_password.Text = "enter your password";
            this.txt_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // panel_email
            // 
            this.panel_email.BackColor = System.Drawing.Color.White;
            this.panel_email.Controls.Add(this.txt_email);
            this.panel_email.Location = new System.Drawing.Point(0, 128);
            this.panel_email.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.panel_email.Name = "panel_email";
            this.panel_email.Size = new System.Drawing.Size(450, 50);
            this.panel_email.TabIndex = 0;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email.BackColor = System.Drawing.SystemColors.Window;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_email.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email.ForeColor = System.Drawing.Color.LightGray;
            this.txt_email.Location = new System.Drawing.Point(12, 12);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(420, 26);
            this.txt_email.TabIndex = 1;
            this.txt_email.Text = "general_kenobi@jedi.com";
            this.txt_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.Leave += new System.EventHandler(this.txt_email_Leave);
            // 
            // pnl_signup
            // 
            this.pnl_signup.BackColor = System.Drawing.Color.Transparent;
            this.pnl_signup.Controls.Add(this.lbl_confirm_password);
            this.pnl_signup.Controls.Add(this.link_signin);
            this.pnl_signup.Controls.Add(this.pnl_confirm_password);
            this.pnl_signup.Controls.Add(this.btn_signup);
            this.pnl_signup.Controls.Add(this.lbl_password_register);
            this.pnl_signup.Controls.Add(this.pnl_email_register);
            this.pnl_signup.Controls.Add(this.pnl_password_register);
            this.pnl_signup.Controls.Add(this.lbl_email_register);
            this.pnl_signup.Controls.Add(this.pnl_lastname);
            this.pnl_signup.Controls.Add(this.lbl_lastname);
            this.pnl_signup.Controls.Add(this.pnl_name);
            this.pnl_signup.Controls.Add(this.lbl_name);
            this.pnl_signup.Controls.Add(this.lbl_signup);
            this.pnl_signup.Location = new System.Drawing.Point(459, 67);
            this.pnl_signup.Name = "pnl_signup";
            this.pnl_signup.Size = new System.Drawing.Size(450, 600);
            this.pnl_signup.TabIndex = 5;
            this.pnl_signup.Visible = false;
            // 
            // lbl_confirm_password
            // 
            this.lbl_confirm_password.AutoSize = true;
            this.lbl_confirm_password.Font = new System.Drawing.Font("Open Sans ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_confirm_password.ForeColor = System.Drawing.Color.White;
            this.lbl_confirm_password.Location = new System.Drawing.Point(-7, 396);
            this.lbl_confirm_password.Name = "lbl_confirm_password";
            this.lbl_confirm_password.Size = new System.Drawing.Size(247, 27);
            this.lbl_confirm_password.TabIndex = 11;
            this.lbl_confirm_password.Text = "Confirm Your Password:";
            // 
            // link_signin
            // 
            this.link_signin.ActiveLinkColor = System.Drawing.Color.Black;
            this.link_signin.AutoSize = true;
            this.link_signin.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.link_signin.LinkColor = System.Drawing.Color.White;
            this.link_signin.Location = new System.Drawing.Point(137, 572);
            this.link_signin.Name = "link_signin";
            this.link_signin.Size = new System.Drawing.Size(170, 19);
            this.link_signin.TabIndex = 6;
            this.link_signin.TabStop = true;
            this.link_signin.Text = "Already a Member? Sign In!";
            this.link_signin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.link_signin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_signin_LinkClicked);
            // 
            // pnl_confirm_password
            // 
            this.pnl_confirm_password.BackColor = System.Drawing.Color.White;
            this.pnl_confirm_password.Controls.Add(this.btn_see_confirmation_register);
            this.pnl_confirm_password.Controls.Add(this.txt_confirm_password);
            this.pnl_confirm_password.Location = new System.Drawing.Point(0, 426);
            this.pnl_confirm_password.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pnl_confirm_password.Name = "pnl_confirm_password";
            this.pnl_confirm_password.Size = new System.Drawing.Size(450, 50);
            this.pnl_confirm_password.TabIndex = 4;
            // 
            // btn_see_confirmation_register
            // 
            this.btn_see_confirmation_register.BackColor = System.Drawing.Color.White;
            this.btn_see_confirmation_register.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            this.btn_see_confirmation_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_see_confirmation_register.FlatAppearance.BorderSize = 0;
            this.btn_see_confirmation_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_confirmation_register.Location = new System.Drawing.Point(414, 10);
            this.btn_see_confirmation_register.Name = "btn_see_confirmation_register";
            this.btn_see_confirmation_register.Size = new System.Drawing.Size(32, 32);
            this.btn_see_confirmation_register.TabIndex = 2;
            this.btn_see_confirmation_register.TabStop = false;
            this.btn_see_confirmation_register.UseVisualStyleBackColor = false;
            this.btn_see_confirmation_register.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_see_confirmation_register_MouseDown);
            this.btn_see_confirmation_register.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_see_confirmation_register_MouseUp);
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_confirm_password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_confirm_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirm_password.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_confirm_password.ForeColor = System.Drawing.Color.LightGray;
            this.txt_confirm_password.Location = new System.Drawing.Point(12, 12);
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.Size = new System.Drawing.Size(420, 26);
            this.txt_confirm_password.TabIndex = 4;
            this.txt_confirm_password.Text = "confirm your password";
            this.txt_confirm_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_confirm_password.Enter += new System.EventHandler(this.txt_confirm_password_Enter);
            this.txt_confirm_password.Leave += new System.EventHandler(this.txt_confirm_password_Leave);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_signup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_signup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signup.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_signup.ForeColor = System.Drawing.Color.White;
            this.btn_signup.Location = new System.Drawing.Point(110, 514);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(225, 50);
            this.btn_signup.TabIndex = 5;
            this.btn_signup.Text = "Sign Up";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.MouseEnter += new System.EventHandler(this.btn_signup_MouseEnter);
            this.btn_signup.MouseLeave += new System.EventHandler(this.btn_signup_MouseLeave);
            this.btn_signup.MouseHover += new System.EventHandler(this.btn_signup_MouseHover);
            // 
            // lbl_password_register
            // 
            this.lbl_password_register.AutoSize = true;
            this.lbl_password_register.Font = new System.Drawing.Font("Open Sans ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_password_register.ForeColor = System.Drawing.Color.White;
            this.lbl_password_register.Location = new System.Drawing.Point(-7, 296);
            this.lbl_password_register.Name = "lbl_password_register";
            this.lbl_password_register.Size = new System.Drawing.Size(111, 27);
            this.lbl_password_register.TabIndex = 9;
            this.lbl_password_register.Text = "Password:";
            // 
            // pnl_email_register
            // 
            this.pnl_email_register.BackColor = System.Drawing.Color.White;
            this.pnl_email_register.Controls.Add(this.txt_email_register);
            this.pnl_email_register.Location = new System.Drawing.Point(0, 225);
            this.pnl_email_register.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pnl_email_register.Name = "pnl_email_register";
            this.pnl_email_register.Size = new System.Drawing.Size(450, 50);
            this.pnl_email_register.TabIndex = 2;
            // 
            // txt_email_register
            // 
            this.txt_email_register.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_email_register.BackColor = System.Drawing.SystemColors.Window;
            this.txt_email_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email_register.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_email_register.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_email_register.ForeColor = System.Drawing.Color.LightGray;
            this.txt_email_register.Location = new System.Drawing.Point(12, 12);
            this.txt_email_register.Name = "txt_email_register";
            this.txt_email_register.Size = new System.Drawing.Size(420, 26);
            this.txt_email_register.TabIndex = 2;
            this.txt_email_register.Text = "your_email@domain.com";
            this.txt_email_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_email_register.Enter += new System.EventHandler(this.txt_email_register_Enter);
            this.txt_email_register.Leave += new System.EventHandler(this.txt_email_register_Leave);
            // 
            // pnl_password_register
            // 
            this.pnl_password_register.BackColor = System.Drawing.Color.White;
            this.pnl_password_register.Controls.Add(this.btn_see_password_register);
            this.pnl_password_register.Controls.Add(this.txt_password_register);
            this.pnl_password_register.Location = new System.Drawing.Point(0, 326);
            this.pnl_password_register.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pnl_password_register.Name = "pnl_password_register";
            this.pnl_password_register.Size = new System.Drawing.Size(450, 50);
            this.pnl_password_register.TabIndex = 3;
            // 
            // btn_see_password_register
            // 
            this.btn_see_password_register.BackColor = System.Drawing.Color.White;
            this.btn_see_password_register.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            this.btn_see_password_register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_see_password_register.FlatAppearance.BorderSize = 0;
            this.btn_see_password_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_password_register.Location = new System.Drawing.Point(414, 10);
            this.btn_see_password_register.Name = "btn_see_password_register";
            this.btn_see_password_register.Size = new System.Drawing.Size(32, 32);
            this.btn_see_password_register.TabIndex = 2;
            this.btn_see_password_register.TabStop = false;
            this.btn_see_password_register.UseVisualStyleBackColor = false;
            this.btn_see_password_register.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_register_MouseDown);
            this.btn_see_password_register.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_register_MouseUp);
            // 
            // txt_password_register
            // 
            this.txt_password_register.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password_register.BackColor = System.Drawing.SystemColors.Window;
            this.txt_password_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password_register.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_password_register.ForeColor = System.Drawing.Color.LightGray;
            this.txt_password_register.Location = new System.Drawing.Point(12, 12);
            this.txt_password_register.Name = "txt_password_register";
            this.txt_password_register.Size = new System.Drawing.Size(420, 26);
            this.txt_password_register.TabIndex = 3;
            this.txt_password_register.Text = "enter your password";
            this.txt_password_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_password_register.Enter += new System.EventHandler(this.txt_password_register_Enter);
            this.txt_password_register.Leave += new System.EventHandler(this.txt_password_register_Leave);
            // 
            // lbl_email_register
            // 
            this.lbl_email_register.AutoSize = true;
            this.lbl_email_register.Font = new System.Drawing.Font("Open Sans ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email_register.ForeColor = System.Drawing.Color.White;
            this.lbl_email_register.Location = new System.Drawing.Point(-5, 195);
            this.lbl_email_register.Name = "lbl_email_register";
            this.lbl_email_register.Size = new System.Drawing.Size(70, 27);
            this.lbl_email_register.TabIndex = 9;
            this.lbl_email_register.Text = "Email:";
            // 
            // pnl_lastname
            // 
            this.pnl_lastname.BackColor = System.Drawing.Color.White;
            this.pnl_lastname.Controls.Add(this.txt_lastname_register);
            this.pnl_lastname.Location = new System.Drawing.Point(230, 128);
            this.pnl_lastname.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pnl_lastname.Name = "pnl_lastname";
            this.pnl_lastname.Size = new System.Drawing.Size(220, 50);
            this.pnl_lastname.TabIndex = 1;
            // 
            // txt_lastname_register
            // 
            this.txt_lastname_register.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_lastname_register.BackColor = System.Drawing.SystemColors.Window;
            this.txt_lastname_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lastname_register.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_lastname_register.ForeColor = System.Drawing.Color.LightGray;
            this.txt_lastname_register.Location = new System.Drawing.Point(12, 12);
            this.txt_lastname_register.Name = "txt_lastname_register";
            this.txt_lastname_register.Size = new System.Drawing.Size(190, 26);
            this.txt_lastname_register.TabIndex = 1;
            this.txt_lastname_register.Text = "Last Name";
            this.txt_lastname_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_lastname_register.Enter += new System.EventHandler(this.txt_lastname_register_Enter);
            this.txt_lastname_register.Leave += new System.EventHandler(this.txt_lastname_register_Leave);
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Open Sans ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_lastname.ForeColor = System.Drawing.Color.White;
            this.lbl_lastname.Location = new System.Drawing.Point(225, 98);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(123, 27);
            this.lbl_lastname.TabIndex = 11;
            this.lbl_lastname.Text = "Last Name:";
            // 
            // pnl_name
            // 
            this.pnl_name.BackColor = System.Drawing.Color.White;
            this.pnl_name.Controls.Add(this.txt_name_register);
            this.pnl_name.Location = new System.Drawing.Point(0, 128);
            this.pnl_name.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.pnl_name.Name = "pnl_name";
            this.pnl_name.Size = new System.Drawing.Size(220, 50);
            this.pnl_name.TabIndex = 0;
            // 
            // txt_name_register
            // 
            this.txt_name_register.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_name_register.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name_register.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_name_register.ForeColor = System.Drawing.Color.LightGray;
            this.txt_name_register.Location = new System.Drawing.Point(12, 12);
            this.txt_name_register.Name = "txt_name_register";
            this.txt_name_register.Size = new System.Drawing.Size(190, 26);
            this.txt_name_register.TabIndex = 0;
            this.txt_name_register.Text = "Name";
            this.txt_name_register.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_name_register.Enter += new System.EventHandler(this.txt_name_register_Enter);
            this.txt_name_register.Leave += new System.EventHandler(this.txt_name_register_Leave);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Open Sans ExtraBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(-5, 98);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(76, 27);
            this.lbl_name.TabIndex = 9;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_signup
            // 
            this.lbl_signup.AutoSize = true;
            this.lbl_signup.Font = new System.Drawing.Font("Open Sans Condensed ExtraBold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_signup.ForeColor = System.Drawing.Color.White;
            this.lbl_signup.Image = global::FinalProject.Properties.Resources.icon_newuser;
            this.lbl_signup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_signup.Location = new System.Drawing.Point(0, 0);
            this.lbl_signup.Name = "lbl_signup";
            this.lbl_signup.Size = new System.Drawing.Size(442, 69);
            this.lbl_signup.TabIndex = 8;
            this.lbl_signup.Text = "        Welcome Aboard!";
            this.lbl_signup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bg_flowers
            // 
            this.bg_flowers.BackColor = System.Drawing.Color.Transparent;
            this.bg_flowers.Image = global::FinalProject.Properties.Resources.bg_flowers;
            this.bg_flowers.Location = new System.Drawing.Point(-12, 25);
            this.bg_flowers.Name = "bg_flowers";
            this.bg_flowers.Size = new System.Drawing.Size(1391, 912);
            this.bg_flowers.TabIndex = 6;
            // 
            // Form_SignIn_SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::FinalProject.Properties.Resources.bg_gradient;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnl_signin);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.bg_flowers);
            this.Controls.Add(this.pnl_signup);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SignIn_SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignIn_SignUp";
            this.pnl_header.ResumeLayout(false);
            this.pnl_signin.ResumeLayout(false);
            this.pnl_signin.PerformLayout();
            this.panel_password.ResumeLayout(false);
            this.panel_password.PerformLayout();
            this.panel_email.ResumeLayout(false);
            this.panel_email.PerformLayout();
            this.pnl_signup.ResumeLayout(false);
            this.pnl_signup.PerformLayout();
            this.pnl_confirm_password.ResumeLayout(false);
            this.pnl_confirm_password.PerformLayout();
            this.pnl_email_register.ResumeLayout(false);
            this.pnl_email_register.PerformLayout();
            this.pnl_password_register.ResumeLayout(false);
            this.pnl_password_register.PerformLayout();
            this.pnl_lastname.ResumeLayout(false);
            this.pnl_lastname.PerformLayout();
            this.pnl_name.ResumeLayout(false);
            this.pnl_name.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Panel panel_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Panel panel_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_see_password;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Button btn_signin;
        private System.Windows.Forms.LinkLabel link_forgot_password;
        private System.Windows.Forms.Label lbl_title_login;
        private System.Windows.Forms.LinkLabel link_signup;
        private System.Windows.Forms.Panel pnl_signin;
        private System.Windows.Forms.Panel pnl_signup;
        private System.Windows.Forms.Panel pnl_name;
        private System.Windows.Forms.TextBox txt_name_register;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_signup;
        private System.Windows.Forms.Panel pnl_email_register;
        private System.Windows.Forms.TextBox txt_email_register;
        private System.Windows.Forms.Label lbl_email_register;
        private System.Windows.Forms.Panel pnl_lastname;
        private System.Windows.Forms.TextBox txt_lastname_register;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.Label lbl_password_register;
        private System.Windows.Forms.Panel pnl_password_register;
        private System.Windows.Forms.Button btn_see_password_register;
        private System.Windows.Forms.TextBox txt_password_register;
        private System.Windows.Forms.Label lbl_confirm_password;
        private System.Windows.Forms.LinkLabel link_signin;
        private System.Windows.Forms.Panel pnl_confirm_password;
        private System.Windows.Forms.Button btn_see_confirmation_register;
        private System.Windows.Forms.TextBox txt_confirm_password;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label bg_flowers;
    }
}

