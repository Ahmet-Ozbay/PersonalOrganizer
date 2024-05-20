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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SignIn_SignUp));
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
            this.pnl_reset_password = new System.Windows.Forms.Panel();
            this.lbl_reset_pass_title = new System.Windows.Forms.Label();
            this.btn_reset_password = new System.Windows.Forms.Button();
            this.lbl_sign_in_reset = new System.Windows.Forms.LinkLabel();
            this.lbl_reset_pass_info = new System.Windows.Forms.Label();
            this.pnl_email_bg_reset_pass = new System.Windows.Forms.Panel();
            this.txt_email_reset_pass = new System.Windows.Forms.TextBox();
            this.lbl_email_reset_pass = new System.Windows.Forms.Label();
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
            this.pnl_reset_password.SuspendLayout();
            this.pnl_email_bg_reset_pass.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::FinalProject.Properties.Resources.btn_close;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Name = "btn_close";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            this.btn_close.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_close_MouseDown);
            this.btn_close.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
            this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
            // 
            // btn_minimize
            // 
            resources.ApplyResources(this.btn_minimize, "btn_minimize");
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.BackgroundImage = global::FinalProject.Properties.Resources.btn_minimize;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Name = "btn_minimize";
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
            resources.ApplyResources(this.pnl_header, "pnl_header");
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseDown);
            this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseMove);
            // 
            // pnl_signin
            // 
            this.pnl_signin.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pnl_signin, "pnl_signin");
            this.pnl_signin.Controls.Add(this.link_signup);
            this.pnl_signin.Controls.Add(this.lbl_title_login);
            this.pnl_signin.Controls.Add(this.link_forgot_password);
            this.pnl_signin.Controls.Add(this.btn_signin);
            this.pnl_signin.Controls.Add(this.lbl_password);
            this.pnl_signin.Controls.Add(this.lbl_email);
            this.pnl_signin.Controls.Add(this.panel_password);
            this.pnl_signin.Controls.Add(this.panel_email);
            this.pnl_signin.ForeColor = System.Drawing.Color.White;
            this.pnl_signin.Name = "pnl_signin";
            // 
            // link_signup
            // 
            this.link_signup.ActiveLinkColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.link_signup, "link_signup");
            this.link_signup.LinkColor = System.Drawing.Color.White;
            this.link_signup.Name = "link_signup";
            this.link_signup.TabStop = true;
            this.link_signup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_signup_LinkClicked);
            // 
            // lbl_title_login
            // 
            resources.ApplyResources(this.lbl_title_login, "lbl_title_login");
            this.lbl_title_login.Image = global::FinalProject.Properties.Resources.icon_unlock;
            this.lbl_title_login.Name = "lbl_title_login";
            // 
            // link_forgot_password
            // 
            this.link_forgot_password.ActiveLinkColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.link_forgot_password, "link_forgot_password");
            this.link_forgot_password.LinkColor = System.Drawing.Color.White;
            this.link_forgot_password.Name = "link_forgot_password";
            this.link_forgot_password.TabStop = true;
            this.link_forgot_password.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_forgot_password_LinkClicked);
            // 
            // btn_signin
            // 
            this.btn_signin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_signin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_signin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_signin, "btn_signin");
            this.btn_signin.ForeColor = System.Drawing.Color.White;
            this.btn_signin.Name = "btn_signin";
            this.btn_signin.UseVisualStyleBackColor = true;
            this.btn_signin.Click += new System.EventHandler(this.btn_signin_Click);
            this.btn_signin.MouseEnter += new System.EventHandler(this.btn_signin_MouseEnter);
            this.btn_signin.MouseLeave += new System.EventHandler(this.btn_signin_MouseLeave);
            this.btn_signin.MouseHover += new System.EventHandler(this.btn_signin_MouseHover);
            // 
            // lbl_password
            // 
            resources.ApplyResources(this.lbl_password, "lbl_password");
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Name = "lbl_password";
            // 
            // lbl_email
            // 
            resources.ApplyResources(this.lbl_email, "lbl_email");
            this.lbl_email.ForeColor = System.Drawing.Color.White;
            this.lbl_email.Name = "lbl_email";
            // 
            // panel_password
            // 
            this.panel_password.BackColor = System.Drawing.Color.White;
            this.panel_password.Controls.Add(this.btn_see_password);
            this.panel_password.Controls.Add(this.txt_password);
            resources.ApplyResources(this.panel_password, "panel_password");
            this.panel_password.Name = "panel_password";
            // 
            // btn_see_password
            // 
            this.btn_see_password.BackColor = System.Drawing.Color.White;
            this.btn_see_password.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            resources.ApplyResources(this.btn_see_password, "btn_see_password");
            this.btn_see_password.FlatAppearance.BorderSize = 0;
            this.btn_see_password.Name = "btn_see_password";
            this.btn_see_password.TabStop = false;
            this.btn_see_password.UseVisualStyleBackColor = false;
            this.btn_see_password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_MouseDown);
            this.btn_see_password.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_MouseUp);
            // 
            // txt_password
            // 
            resources.ApplyResources(this.txt_password, "txt_password");
            this.txt_password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.ForeColor = System.Drawing.Color.LightGray;
            this.txt_password.Name = "txt_password";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
            // 
            // panel_email
            // 
            this.panel_email.BackColor = System.Drawing.Color.White;
            this.panel_email.Controls.Add(this.txt_email);
            resources.ApplyResources(this.panel_email, "panel_email");
            this.panel_email.Name = "panel_email";
            // 
            // txt_email
            // 
            resources.ApplyResources(this.txt_email, "txt_email");
            this.txt_email.BackColor = System.Drawing.SystemColors.Window;
            this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_email.ForeColor = System.Drawing.Color.LightGray;
            this.txt_email.Name = "txt_email";
            this.txt_email.Enter += new System.EventHandler(this.txt_email_Enter);
            this.txt_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_email_KeyPress);
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
            resources.ApplyResources(this.pnl_signup, "pnl_signup");
            this.pnl_signup.Name = "pnl_signup";
            // 
            // lbl_confirm_password
            // 
            resources.ApplyResources(this.lbl_confirm_password, "lbl_confirm_password");
            this.lbl_confirm_password.ForeColor = System.Drawing.Color.White;
            this.lbl_confirm_password.Name = "lbl_confirm_password";
            // 
            // link_signin
            // 
            this.link_signin.ActiveLinkColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.link_signin, "link_signin");
            this.link_signin.LinkColor = System.Drawing.Color.White;
            this.link_signin.Name = "link_signin";
            this.link_signin.TabStop = true;
            this.link_signin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_signin_LinkClicked);
            // 
            // pnl_confirm_password
            // 
            this.pnl_confirm_password.BackColor = System.Drawing.Color.White;
            this.pnl_confirm_password.Controls.Add(this.btn_see_confirmation_register);
            this.pnl_confirm_password.Controls.Add(this.txt_confirm_password);
            resources.ApplyResources(this.pnl_confirm_password, "pnl_confirm_password");
            this.pnl_confirm_password.Name = "pnl_confirm_password";
            // 
            // btn_see_confirmation_register
            // 
            this.btn_see_confirmation_register.BackColor = System.Drawing.Color.White;
            this.btn_see_confirmation_register.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            resources.ApplyResources(this.btn_see_confirmation_register, "btn_see_confirmation_register");
            this.btn_see_confirmation_register.FlatAppearance.BorderSize = 0;
            this.btn_see_confirmation_register.Name = "btn_see_confirmation_register";
            this.btn_see_confirmation_register.TabStop = false;
            this.btn_see_confirmation_register.UseVisualStyleBackColor = false;
            this.btn_see_confirmation_register.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_see_confirmation_register_MouseDown);
            this.btn_see_confirmation_register.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_see_confirmation_register_MouseUp);
            // 
            // txt_confirm_password
            // 
            resources.ApplyResources(this.txt_confirm_password, "txt_confirm_password");
            this.txt_confirm_password.BackColor = System.Drawing.SystemColors.Window;
            this.txt_confirm_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_confirm_password.ForeColor = System.Drawing.Color.LightGray;
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.Enter += new System.EventHandler(this.txt_confirm_password_Enter);
            this.txt_confirm_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_confirm_password_KeyPress);
            this.txt_confirm_password.Leave += new System.EventHandler(this.txt_confirm_password_Leave);
            // 
            // btn_signup
            // 
            this.btn_signup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_signup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_signup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_signup, "btn_signup");
            this.btn_signup.ForeColor = System.Drawing.Color.White;
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            this.btn_signup.MouseEnter += new System.EventHandler(this.btn_signup_MouseEnter);
            this.btn_signup.MouseLeave += new System.EventHandler(this.btn_signup_MouseLeave);
            this.btn_signup.MouseHover += new System.EventHandler(this.btn_signup_MouseHover);
            // 
            // lbl_password_register
            // 
            resources.ApplyResources(this.lbl_password_register, "lbl_password_register");
            this.lbl_password_register.ForeColor = System.Drawing.Color.White;
            this.lbl_password_register.Name = "lbl_password_register";
            // 
            // pnl_email_register
            // 
            this.pnl_email_register.BackColor = System.Drawing.Color.White;
            this.pnl_email_register.Controls.Add(this.txt_email_register);
            resources.ApplyResources(this.pnl_email_register, "pnl_email_register");
            this.pnl_email_register.Name = "pnl_email_register";
            // 
            // txt_email_register
            // 
            resources.ApplyResources(this.txt_email_register, "txt_email_register");
            this.txt_email_register.BackColor = System.Drawing.SystemColors.Window;
            this.txt_email_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email_register.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_email_register.ForeColor = System.Drawing.Color.LightGray;
            this.txt_email_register.Name = "txt_email_register";
            this.txt_email_register.Enter += new System.EventHandler(this.txt_email_register_Enter);
            this.txt_email_register.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_email_register_KeyPress);
            this.txt_email_register.Leave += new System.EventHandler(this.txt_email_register_Leave);
            // 
            // pnl_password_register
            // 
            this.pnl_password_register.BackColor = System.Drawing.Color.White;
            this.pnl_password_register.Controls.Add(this.btn_see_password_register);
            this.pnl_password_register.Controls.Add(this.txt_password_register);
            resources.ApplyResources(this.pnl_password_register, "pnl_password_register");
            this.pnl_password_register.Name = "pnl_password_register";
            // 
            // btn_see_password_register
            // 
            this.btn_see_password_register.BackColor = System.Drawing.Color.White;
            this.btn_see_password_register.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            resources.ApplyResources(this.btn_see_password_register, "btn_see_password_register");
            this.btn_see_password_register.FlatAppearance.BorderSize = 0;
            this.btn_see_password_register.Name = "btn_see_password_register";
            this.btn_see_password_register.TabStop = false;
            this.btn_see_password_register.UseVisualStyleBackColor = false;
            this.btn_see_password_register.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_register_MouseDown);
            this.btn_see_password_register.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_register_MouseUp);
            // 
            // txt_password_register
            // 
            resources.ApplyResources(this.txt_password_register, "txt_password_register");
            this.txt_password_register.BackColor = System.Drawing.SystemColors.Window;
            this.txt_password_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password_register.ForeColor = System.Drawing.Color.LightGray;
            this.txt_password_register.Name = "txt_password_register";
            this.txt_password_register.Enter += new System.EventHandler(this.txt_password_register_Enter);
            this.txt_password_register.Leave += new System.EventHandler(this.txt_password_register_Leave);
            // 
            // lbl_email_register
            // 
            resources.ApplyResources(this.lbl_email_register, "lbl_email_register");
            this.lbl_email_register.ForeColor = System.Drawing.Color.White;
            this.lbl_email_register.Name = "lbl_email_register";
            // 
            // pnl_lastname
            // 
            this.pnl_lastname.BackColor = System.Drawing.Color.White;
            this.pnl_lastname.Controls.Add(this.txt_lastname_register);
            resources.ApplyResources(this.pnl_lastname, "pnl_lastname");
            this.pnl_lastname.Name = "pnl_lastname";
            // 
            // txt_lastname_register
            // 
            resources.ApplyResources(this.txt_lastname_register, "txt_lastname_register");
            this.txt_lastname_register.BackColor = System.Drawing.SystemColors.Window;
            this.txt_lastname_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_lastname_register.ForeColor = System.Drawing.Color.LightGray;
            this.txt_lastname_register.Name = "txt_lastname_register";
            this.txt_lastname_register.Enter += new System.EventHandler(this.txt_lastname_register_Enter);
            this.txt_lastname_register.Leave += new System.EventHandler(this.txt_lastname_register_Leave);
            // 
            // lbl_lastname
            // 
            resources.ApplyResources(this.lbl_lastname, "lbl_lastname");
            this.lbl_lastname.ForeColor = System.Drawing.Color.White;
            this.lbl_lastname.Name = "lbl_lastname";
            // 
            // pnl_name
            // 
            this.pnl_name.BackColor = System.Drawing.Color.White;
            this.pnl_name.Controls.Add(this.txt_name_register);
            resources.ApplyResources(this.pnl_name, "pnl_name");
            this.pnl_name.Name = "pnl_name";
            // 
            // txt_name_register
            // 
            resources.ApplyResources(this.txt_name_register, "txt_name_register");
            this.txt_name_register.BackColor = System.Drawing.SystemColors.Window;
            this.txt_name_register.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_name_register.ForeColor = System.Drawing.Color.LightGray;
            this.txt_name_register.Name = "txt_name_register";
            this.txt_name_register.Enter += new System.EventHandler(this.txt_name_register_Enter);
            this.txt_name_register.Leave += new System.EventHandler(this.txt_name_register_Leave);
            // 
            // lbl_name
            // 
            resources.ApplyResources(this.lbl_name, "lbl_name");
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Name = "lbl_name";
            // 
            // lbl_signup
            // 
            resources.ApplyResources(this.lbl_signup, "lbl_signup");
            this.lbl_signup.ForeColor = System.Drawing.Color.White;
            this.lbl_signup.Image = global::FinalProject.Properties.Resources.icon_newuser;
            this.lbl_signup.Name = "lbl_signup";
            // 
            // bg_flowers
            // 
            this.bg_flowers.BackColor = System.Drawing.Color.Transparent;
            this.bg_flowers.Image = global::FinalProject.Properties.Resources.bg_flowers;
            resources.ApplyResources(this.bg_flowers, "bg_flowers");
            this.bg_flowers.Name = "bg_flowers";
            // 
            // pnl_reset_password
            // 
            this.pnl_reset_password.BackColor = System.Drawing.Color.Transparent;
            this.pnl_reset_password.Controls.Add(this.lbl_reset_pass_title);
            this.pnl_reset_password.Controls.Add(this.btn_reset_password);
            this.pnl_reset_password.Controls.Add(this.lbl_sign_in_reset);
            this.pnl_reset_password.Controls.Add(this.lbl_reset_pass_info);
            this.pnl_reset_password.Controls.Add(this.pnl_email_bg_reset_pass);
            this.pnl_reset_password.Controls.Add(this.lbl_email_reset_pass);
            resources.ApplyResources(this.pnl_reset_password, "pnl_reset_password");
            this.pnl_reset_password.Name = "pnl_reset_password";
            // 
            // lbl_reset_pass_title
            // 
            resources.ApplyResources(this.lbl_reset_pass_title, "lbl_reset_pass_title");
            this.lbl_reset_pass_title.ForeColor = System.Drawing.Color.White;
            this.lbl_reset_pass_title.Image = global::FinalProject.Properties.Resources.icon_forgot_password;
            this.lbl_reset_pass_title.Name = "lbl_reset_pass_title";
            // 
            // btn_reset_password
            // 
            this.btn_reset_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_reset_password.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_reset_password.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_reset_password, "btn_reset_password");
            this.btn_reset_password.ForeColor = System.Drawing.Color.White;
            this.btn_reset_password.Name = "btn_reset_password";
            this.btn_reset_password.UseVisualStyleBackColor = true;
            this.btn_reset_password.Click += new System.EventHandler(this.btn_reset_password_Click);
            // 
            // lbl_sign_in_reset
            // 
            this.lbl_sign_in_reset.ActiveLinkColor = System.Drawing.Color.Black;
            this.lbl_sign_in_reset.LinkColor = System.Drawing.Color.White;
            resources.ApplyResources(this.lbl_sign_in_reset, "lbl_sign_in_reset");
            this.lbl_sign_in_reset.Name = "lbl_sign_in_reset";
            this.lbl_sign_in_reset.TabStop = true;
            this.lbl_sign_in_reset.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_signin_LinkClicked);
            // 
            // lbl_reset_pass_info
            // 
            resources.ApplyResources(this.lbl_reset_pass_info, "lbl_reset_pass_info");
            this.lbl_reset_pass_info.ForeColor = System.Drawing.Color.White;
            this.lbl_reset_pass_info.Name = "lbl_reset_pass_info";
            // 
            // pnl_email_bg_reset_pass
            // 
            this.pnl_email_bg_reset_pass.BackColor = System.Drawing.Color.White;
            this.pnl_email_bg_reset_pass.Controls.Add(this.txt_email_reset_pass);
            resources.ApplyResources(this.pnl_email_bg_reset_pass, "pnl_email_bg_reset_pass");
            this.pnl_email_bg_reset_pass.Name = "pnl_email_bg_reset_pass";
            // 
            // txt_email_reset_pass
            // 
            resources.ApplyResources(this.txt_email_reset_pass, "txt_email_reset_pass");
            this.txt_email_reset_pass.BackColor = System.Drawing.SystemColors.Window;
            this.txt_email_reset_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_email_reset_pass.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_email_reset_pass.ForeColor = System.Drawing.Color.LightGray;
            this.txt_email_reset_pass.Name = "txt_email_reset_pass";
            this.txt_email_reset_pass.Enter += new System.EventHandler(this.txt_email_reset_pass_Enter);
            this.txt_email_reset_pass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_email_reset_pass_KeyPress);
            this.txt_email_reset_pass.Leave += new System.EventHandler(this.txt_email_reset_pass_Leave);
            // 
            // lbl_email_reset_pass
            // 
            resources.ApplyResources(this.lbl_email_reset_pass, "lbl_email_reset_pass");
            this.lbl_email_reset_pass.ForeColor = System.Drawing.Color.White;
            this.lbl_email_reset_pass.Name = "lbl_email_reset_pass";
            // 
            // Form_SignIn_SignUp
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::FinalProject.Properties.Resources.bg_gradient;
            this.Controls.Add(this.pnl_reset_password);
            this.Controls.Add(this.pnl_signin);
            this.Controls.Add(this.pnl_signup);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.bg_flowers);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SignIn_SignUp";
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
            this.pnl_reset_password.ResumeLayout(false);
            this.pnl_reset_password.PerformLayout();
            this.pnl_email_bg_reset_pass.ResumeLayout(false);
            this.pnl_email_bg_reset_pass.PerformLayout();
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
        private System.Windows.Forms.Panel pnl_reset_password;
        private System.Windows.Forms.Label lbl_reset_pass_title;
        private System.Windows.Forms.Label lbl_reset_pass_info;
        private System.Windows.Forms.Panel pnl_email_bg_reset_pass;
        private System.Windows.Forms.TextBox txt_email_reset_pass;
        private System.Windows.Forms.Label lbl_email_reset_pass;
        private System.Windows.Forms.LinkLabel lbl_sign_in_reset;
        private System.Windows.Forms.Button btn_reset_password;
    }
}

