using System.Drawing;

namespace FinalProject
{
    partial class Form_LandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_LandingPage));
            this.pnl_header = new System.Windows.Forms.Panel();
            this.lbl_header = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_salary = new System.Windows.Forms.Button();
            this.btn_reminder = new System.Windows.Forms.Button();
            this.btn_notebook = new System.Windows.Forms.Button();
            this.btn_phonebook = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.pic_profile = new System.Windows.Forms.PictureBox();
            this.pnl_picture = new System.Windows.Forms.Panel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pnl_profile = new System.Windows.Forms.Panel();
            this.pnl_profile_content = new System.Windows.Forms.Panel();
            this.grp_password = new System.Windows.Forms.GroupBox();
            this.btn_see_password_new_confirm = new System.Windows.Forms.Button();
            this.btn_see_password_new = new System.Windows.Forms.Button();
            this.btn_see_password_current = new System.Windows.Forms.Button();
            this.lbl_password_rules = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_confirm_new_password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_new_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_current_password = new System.Windows.Forms.TextBox();
            this.lbl_change_password = new System.Windows.Forms.Label();
            this.btn_change_password = new System.Windows.Forms.Button();
            this.grp_personal_info = new System.Windows.Forms.GroupBox();
            this.lbl_personal_info = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_phone_number = new System.Windows.Forms.Label();
            this.txt_phone_number = new System.Windows.Forms.TextBox();
            this.lbl_adress = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.btn_save_profile = new System.Windows.Forms.Button();
            this.lbl_title_profile = new System.Windows.Forms.Label();
            this.pnl_contacts = new System.Windows.Forms.Panel();
            this.pnl_contacts_content = new System.Windows.Forms.Panel();
            this.lbl_title_contacts = new System.Windows.Forms.Label();
            this.pnl_notebook = new System.Windows.Forms.Panel();
            this.pnl_notebook_content = new System.Windows.Forms.Panel();
            this.lbl_title_notebook = new System.Windows.Forms.Label();
            this.pnl_reminder = new System.Windows.Forms.Panel();
            this.pnl_reminder_content = new System.Windows.Forms.Panel();
            this.lbl_title_reminder = new System.Windows.Forms.Label();
            this.pnl_salary = new System.Windows.Forms.Panel();
            this.pnl_salary_content = new System.Windows.Forms.Panel();
            this.lbl_title_salary = new System.Windows.Forms.Label();
            this.pnl_admin = new System.Windows.Forms.Panel();
            this.pnl_admin_content = new System.Windows.Forms.Panel();
            this.lbl_title_admin = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).BeginInit();
            this.pnl_profile.SuspendLayout();
            this.pnl_profile_content.SuspendLayout();
            this.grp_password.SuspendLayout();
            this.grp_personal_info.SuspendLayout();
            this.pnl_contacts.SuspendLayout();
            this.pnl_notebook.SuspendLayout();
            this.pnl_reminder.SuspendLayout();
            this.pnl_salary.SuspendLayout();
            this.pnl_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            resources.ApplyResources(this.pnl_header, "pnl_header");
            this.pnl_header.BackColor = System.Drawing.Color.Transparent;
            this.pnl_header.Controls.Add(this.lbl_header);
            this.pnl_header.Controls.Add(this.btn_close);
            this.pnl_header.Controls.Add(this.btn_minimize);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseDown);
            this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseMove);
            // 
            // lbl_header
            // 
            resources.ApplyResources(this.lbl_header, "lbl_header");
            this.lbl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Name = "lbl_header";
            // 
            // btn_close
            // 
            resources.ApplyResources(this.btn_close, "btn_close");
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.BackgroundImage = global::FinalProject.Properties.Resources.btn_close;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
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
            // pnl_menu
            // 
            resources.ApplyResources(this.pnl_menu, "pnl_menu");
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_menu.Controls.Add(this.label1);
            this.pnl_menu.Controls.Add(this.btn_admin);
            this.pnl_menu.Controls.Add(this.btn_salary);
            this.pnl_menu.Controls.Add(this.btn_reminder);
            this.pnl_menu.Controls.Add(this.btn_notebook);
            this.pnl_menu.Controls.Add(this.btn_phonebook);
            this.pnl_menu.Controls.Add(this.btn_profile);
            this.pnl_menu.Controls.Add(this.pic_profile);
            this.pnl_menu.Controls.Add(this.pnl_picture);
            this.pnl_menu.ForeColor = System.Drawing.Color.White;
            this.pnl_menu.Name = "pnl_menu";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // btn_admin
            // 
            resources.ApplyResources(this.btn_admin, "btn_admin");
            this.btn_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btn_admin.FlatAppearance.BorderSize = 0;
            this.btn_admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_admin.Image = global::FinalProject.Properties.Resources.icon_admin;
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            this.btn_admin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_admin_MouseDown);
            this.btn_admin.MouseEnter += new System.EventHandler(this.btn_admin_MouseEnter);
            // 
            // btn_salary
            // 
            resources.ApplyResources(this.btn_salary, "btn_salary");
            this.btn_salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btn_salary.FlatAppearance.BorderSize = 0;
            this.btn_salary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_salary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_salary.Image = global::FinalProject.Properties.Resources.icon_calculator;
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.UseVisualStyleBackColor = false;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            this.btn_salary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_salary_MouseDown);
            this.btn_salary.MouseEnter += new System.EventHandler(this.btn_salary_MouseEnter);
            // 
            // btn_reminder
            // 
            resources.ApplyResources(this.btn_reminder, "btn_reminder");
            this.btn_reminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btn_reminder.FlatAppearance.BorderSize = 0;
            this.btn_reminder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_reminder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_reminder.Image = global::FinalProject.Properties.Resources.icon_reminder;
            this.btn_reminder.Name = "btn_reminder";
            this.btn_reminder.UseVisualStyleBackColor = false;
            this.btn_reminder.Click += new System.EventHandler(this.btn_reminder_Click);
            this.btn_reminder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_reminder_MouseDown);
            this.btn_reminder.MouseEnter += new System.EventHandler(this.btn_reminder_MouseEnter);
            // 
            // btn_notebook
            // 
            resources.ApplyResources(this.btn_notebook, "btn_notebook");
            this.btn_notebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btn_notebook.FlatAppearance.BorderSize = 0;
            this.btn_notebook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_notebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_notebook.Image = global::FinalProject.Properties.Resources.icon_notebook;
            this.btn_notebook.Name = "btn_notebook";
            this.btn_notebook.UseVisualStyleBackColor = false;
            this.btn_notebook.Click += new System.EventHandler(this.btn_notebook_Click);
            this.btn_notebook.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_notebook_MouseDown);
            this.btn_notebook.MouseEnter += new System.EventHandler(this.btn_notebook_MouseEnter);
            // 
            // btn_phonebook
            // 
            resources.ApplyResources(this.btn_phonebook, "btn_phonebook");
            this.btn_phonebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btn_phonebook.FlatAppearance.BorderSize = 0;
            this.btn_phonebook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_phonebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_phonebook.Image = global::FinalProject.Properties.Resources.icon_phonebook;
            this.btn_phonebook.Name = "btn_phonebook";
            this.btn_phonebook.UseVisualStyleBackColor = false;
            this.btn_phonebook.Click += new System.EventHandler(this.btn_phonebook_Click);
            this.btn_phonebook.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_phonebook_MouseDown);
            this.btn_phonebook.MouseEnter += new System.EventHandler(this.btn_phonebook_MouseEnter);
            // 
            // btn_profile
            // 
            resources.ApplyResources(this.btn_profile, "btn_profile");
            this.btn_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_profile.Image = global::FinalProject.Properties.Resources.icon_profile;
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            this.btn_profile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_profile_MouseDown);
            this.btn_profile.MouseEnter += new System.EventHandler(this.btn_profile_MouseEnter);
            // 
            // pic_profile
            // 
            resources.ApplyResources(this.pic_profile, "pic_profile");
            this.pic_profile.BackColor = System.Drawing.Color.Transparent;
            this.pic_profile.BackgroundImage = global::FinalProject.Properties.Resources.bg_error_picture;
            this.pic_profile.ErrorImage = global::FinalProject.Properties.Resources.bg_error_picture;
            this.pic_profile.Image = global::FinalProject.Properties.Resources.pp_test;
            this.pic_profile.InitialImage = global::FinalProject.Properties.Resources.bg_error_picture;
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.TabStop = false;
            // 
            // pnl_picture
            // 
            resources.ApplyResources(this.pnl_picture, "pnl_picture");
            this.pnl_picture.BackColor = System.Drawing.Color.White;
            this.pnl_picture.Name = "pnl_picture";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnl_profile
            // 
            resources.ApplyResources(this.pnl_profile, "pnl_profile");
            this.pnl_profile.BackColor = System.Drawing.Color.Transparent;
            this.pnl_profile.Controls.Add(this.pnl_profile_content);
            this.pnl_profile.Controls.Add(this.lbl_title_profile);
            this.pnl_profile.Name = "pnl_profile";
            this.pnl_profile.VisibleChanged += new System.EventHandler(this.pnl_profile_VisibleChanged);
            // 
            // pnl_profile_content
            // 
            resources.ApplyResources(this.pnl_profile_content, "pnl_profile_content");
            this.pnl_profile_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_profile_content.Controls.Add(this.grp_password);
            this.pnl_profile_content.Controls.Add(this.grp_personal_info);
            this.pnl_profile_content.ForeColor = System.Drawing.Color.White;
            this.pnl_profile_content.Name = "pnl_profile_content";
            // 
            // grp_password
            // 
            resources.ApplyResources(this.grp_password, "grp_password");
            this.grp_password.Controls.Add(this.btn_see_password_new_confirm);
            this.grp_password.Controls.Add(this.btn_see_password_new);
            this.grp_password.Controls.Add(this.btn_see_password_current);
            this.grp_password.Controls.Add(this.lbl_password_rules);
            this.grp_password.Controls.Add(this.label4);
            this.grp_password.Controls.Add(this.txt_confirm_new_password);
            this.grp_password.Controls.Add(this.label3);
            this.grp_password.Controls.Add(this.txt_new_password);
            this.grp_password.Controls.Add(this.label2);
            this.grp_password.Controls.Add(this.txt_current_password);
            this.grp_password.Controls.Add(this.lbl_change_password);
            this.grp_password.Controls.Add(this.btn_change_password);
            this.grp_password.Name = "grp_password";
            this.grp_password.TabStop = false;
            // 
            // btn_see_password_new_confirm
            // 
            resources.ApplyResources(this.btn_see_password_new_confirm, "btn_see_password_new_confirm");
            this.btn_see_password_new_confirm.BackColor = System.Drawing.Color.White;
            this.btn_see_password_new_confirm.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            this.btn_see_password_new_confirm.FlatAppearance.BorderSize = 0;
            this.btn_see_password_new_confirm.Name = "btn_see_password_new_confirm";
            this.btn_see_password_new_confirm.TabStop = false;
            this.btn_see_password_new_confirm.UseVisualStyleBackColor = false;
            this.btn_see_password_new_confirm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_new_confirm_MouseDown);
            this.btn_see_password_new_confirm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_new_confirm_MouseUp);
            // 
            // btn_see_password_new
            // 
            resources.ApplyResources(this.btn_see_password_new, "btn_see_password_new");
            this.btn_see_password_new.BackColor = System.Drawing.Color.White;
            this.btn_see_password_new.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            this.btn_see_password_new.FlatAppearance.BorderSize = 0;
            this.btn_see_password_new.Name = "btn_see_password_new";
            this.btn_see_password_new.TabStop = false;
            this.btn_see_password_new.UseVisualStyleBackColor = false;
            this.btn_see_password_new.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_new_MouseDown);
            this.btn_see_password_new.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_new_MouseUp);
            // 
            // btn_see_password_current
            // 
            resources.ApplyResources(this.btn_see_password_current, "btn_see_password_current");
            this.btn_see_password_current.BackColor = System.Drawing.Color.White;
            this.btn_see_password_current.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            this.btn_see_password_current.FlatAppearance.BorderSize = 0;
            this.btn_see_password_current.Name = "btn_see_password_current";
            this.btn_see_password_current.TabStop = false;
            this.btn_see_password_current.UseVisualStyleBackColor = false;
            this.btn_see_password_current.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_current_MouseDown);
            this.btn_see_password_current.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_current_MouseUp);
            // 
            // lbl_password_rules
            // 
            resources.ApplyResources(this.lbl_password_rules, "lbl_password_rules");
            this.lbl_password_rules.Name = "lbl_password_rules";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // txt_confirm_new_password
            // 
            resources.ApplyResources(this.txt_confirm_new_password, "txt_confirm_new_password");
            this.txt_confirm_new_password.Name = "txt_confirm_new_password";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txt_new_password
            // 
            resources.ApplyResources(this.txt_new_password, "txt_new_password");
            this.txt_new_password.Name = "txt_new_password";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txt_current_password
            // 
            resources.ApplyResources(this.txt_current_password, "txt_current_password");
            this.txt_current_password.Name = "txt_current_password";
            // 
            // lbl_change_password
            // 
            resources.ApplyResources(this.lbl_change_password, "lbl_change_password");
            this.lbl_change_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_change_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_change_password.Name = "lbl_change_password";
            // 
            // btn_change_password
            // 
            resources.ApplyResources(this.btn_change_password, "btn_change_password");
            this.btn_change_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_change_password.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_change_password.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.UseVisualStyleBackColor = false;
            this.btn_change_password.Click += new System.EventHandler(this.btn_change_password_Click);
            this.btn_change_password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_change_password_MouseDown);
            this.btn_change_password.MouseEnter += new System.EventHandler(this.btn_change_password_MouseEnter);
            // 
            // grp_personal_info
            // 
            resources.ApplyResources(this.grp_personal_info, "grp_personal_info");
            this.grp_personal_info.Controls.Add(this.lbl_personal_info);
            this.grp_personal_info.Controls.Add(this.lbl_name);
            this.grp_personal_info.Controls.Add(this.txt_name);
            this.grp_personal_info.Controls.Add(this.lbl_lastname);
            this.grp_personal_info.Controls.Add(this.txt_lastname);
            this.grp_personal_info.Controls.Add(this.lbl_email);
            this.grp_personal_info.Controls.Add(this.txt_email);
            this.grp_personal_info.Controls.Add(this.lbl_phone_number);
            this.grp_personal_info.Controls.Add(this.txt_phone_number);
            this.grp_personal_info.Controls.Add(this.lbl_adress);
            this.grp_personal_info.Controls.Add(this.txt_adress);
            this.grp_personal_info.Controls.Add(this.btn_save_profile);
            this.grp_personal_info.Name = "grp_personal_info";
            this.grp_personal_info.TabStop = false;
            // 
            // lbl_personal_info
            // 
            resources.ApplyResources(this.lbl_personal_info, "lbl_personal_info");
            this.lbl_personal_info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_personal_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_personal_info.Name = "lbl_personal_info";
            // 
            // lbl_name
            // 
            resources.ApplyResources(this.lbl_name, "lbl_name");
            this.lbl_name.Name = "lbl_name";
            // 
            // txt_name
            // 
            resources.ApplyResources(this.txt_name, "txt_name");
            this.txt_name.Name = "txt_name";
            // 
            // lbl_lastname
            // 
            resources.ApplyResources(this.lbl_lastname, "lbl_lastname");
            this.lbl_lastname.Name = "lbl_lastname";
            // 
            // txt_lastname
            // 
            resources.ApplyResources(this.txt_lastname, "txt_lastname");
            this.txt_lastname.Name = "txt_lastname";
            // 
            // lbl_email
            // 
            resources.ApplyResources(this.lbl_email, "lbl_email");
            this.lbl_email.Name = "lbl_email";
            // 
            // txt_email
            // 
            resources.ApplyResources(this.txt_email, "txt_email");
            this.txt_email.Name = "txt_email";
            // 
            // lbl_phone_number
            // 
            resources.ApplyResources(this.lbl_phone_number, "lbl_phone_number");
            this.lbl_phone_number.Name = "lbl_phone_number";
            // 
            // txt_phone_number
            // 
            resources.ApplyResources(this.txt_phone_number, "txt_phone_number");
            this.txt_phone_number.Name = "txt_phone_number";
            // 
            // lbl_adress
            // 
            resources.ApplyResources(this.lbl_adress, "lbl_adress");
            this.lbl_adress.Name = "lbl_adress";
            // 
            // txt_adress
            // 
            resources.ApplyResources(this.txt_adress, "txt_adress");
            this.txt_adress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_adress.Name = "txt_adress";
            // 
            // btn_save_profile
            // 
            resources.ApplyResources(this.btn_save_profile, "btn_save_profile");
            this.btn_save_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_save_profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_save_profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_save_profile.Name = "btn_save_profile";
            this.btn_save_profile.UseVisualStyleBackColor = false;
            this.btn_save_profile.Click += new System.EventHandler(this.btn_save_profile_Click);
            this.btn_save_profile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_save_profile_MouseDown);
            this.btn_save_profile.MouseEnter += new System.EventHandler(this.btn_save_profile_MouseEnter);
            // 
            // lbl_title_profile
            // 
            resources.ApplyResources(this.lbl_title_profile, "lbl_title_profile");
            this.lbl_title_profile.ForeColor = System.Drawing.Color.White;
            this.lbl_title_profile.Image = global::FinalProject.Properties.Resources.icon_profile;
            this.lbl_title_profile.Name = "lbl_title_profile";
            // 
            // pnl_contacts
            // 
            resources.ApplyResources(this.pnl_contacts, "pnl_contacts");
            this.pnl_contacts.BackColor = System.Drawing.Color.Transparent;
            this.pnl_contacts.Controls.Add(this.pnl_contacts_content);
            this.pnl_contacts.Controls.Add(this.lbl_title_contacts);
            this.pnl_contacts.Name = "pnl_contacts";
            this.pnl_contacts.VisibleChanged += new System.EventHandler(this.pnl_contacts_VisibleChanged);
            // 
            // pnl_contacts_content
            // 
            resources.ApplyResources(this.pnl_contacts_content, "pnl_contacts_content");
            this.pnl_contacts_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_contacts_content.ForeColor = System.Drawing.Color.White;
            this.pnl_contacts_content.Name = "pnl_contacts_content";
            // 
            // lbl_title_contacts
            // 
            resources.ApplyResources(this.lbl_title_contacts, "lbl_title_contacts");
            this.lbl_title_contacts.ForeColor = System.Drawing.Color.White;
            this.lbl_title_contacts.Image = global::FinalProject.Properties.Resources.icon_phonebook;
            this.lbl_title_contacts.Name = "lbl_title_contacts";
            // 
            // pnl_notebook
            // 
            resources.ApplyResources(this.pnl_notebook, "pnl_notebook");
            this.pnl_notebook.BackColor = System.Drawing.Color.Transparent;
            this.pnl_notebook.Controls.Add(this.pnl_notebook_content);
            this.pnl_notebook.Controls.Add(this.lbl_title_notebook);
            this.pnl_notebook.Name = "pnl_notebook";
            this.pnl_notebook.VisibleChanged += new System.EventHandler(this.pnl_notebook_VisibleChanged);
            // 
            // pnl_notebook_content
            // 
            resources.ApplyResources(this.pnl_notebook_content, "pnl_notebook_content");
            this.pnl_notebook_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_notebook_content.ForeColor = System.Drawing.Color.White;
            this.pnl_notebook_content.Name = "pnl_notebook_content";
            // 
            // lbl_title_notebook
            // 
            resources.ApplyResources(this.lbl_title_notebook, "lbl_title_notebook");
            this.lbl_title_notebook.ForeColor = System.Drawing.Color.White;
            this.lbl_title_notebook.Image = global::FinalProject.Properties.Resources.icon_notebook;
            this.lbl_title_notebook.Name = "lbl_title_notebook";
            // 
            // pnl_reminder
            // 
            resources.ApplyResources(this.pnl_reminder, "pnl_reminder");
            this.pnl_reminder.BackColor = System.Drawing.Color.Transparent;
            this.pnl_reminder.Controls.Add(this.pnl_reminder_content);
            this.pnl_reminder.Controls.Add(this.lbl_title_reminder);
            this.pnl_reminder.Name = "pnl_reminder";
            this.pnl_reminder.VisibleChanged += new System.EventHandler(this.pnl_reminder_VisibleChanged);
            // 
            // pnl_reminder_content
            // 
            resources.ApplyResources(this.pnl_reminder_content, "pnl_reminder_content");
            this.pnl_reminder_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_reminder_content.ForeColor = System.Drawing.Color.White;
            this.pnl_reminder_content.Name = "pnl_reminder_content";
            // 
            // lbl_title_reminder
            // 
            resources.ApplyResources(this.lbl_title_reminder, "lbl_title_reminder");
            this.lbl_title_reminder.ForeColor = System.Drawing.Color.White;
            this.lbl_title_reminder.Image = global::FinalProject.Properties.Resources.icon_reminder;
            this.lbl_title_reminder.Name = "lbl_title_reminder";
            // 
            // pnl_salary
            // 
            resources.ApplyResources(this.pnl_salary, "pnl_salary");
            this.pnl_salary.BackColor = System.Drawing.Color.Transparent;
            this.pnl_salary.Controls.Add(this.pnl_salary_content);
            this.pnl_salary.Controls.Add(this.lbl_title_salary);
            this.pnl_salary.Name = "pnl_salary";
            this.pnl_salary.VisibleChanged += new System.EventHandler(this.pnl_salary_VisibleChanged);
            // 
            // pnl_salary_content
            // 
            resources.ApplyResources(this.pnl_salary_content, "pnl_salary_content");
            this.pnl_salary_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_salary_content.ForeColor = System.Drawing.Color.White;
            this.pnl_salary_content.Name = "pnl_salary_content";
            // 
            // lbl_title_salary
            // 
            resources.ApplyResources(this.lbl_title_salary, "lbl_title_salary");
            this.lbl_title_salary.ForeColor = System.Drawing.Color.White;
            this.lbl_title_salary.Image = global::FinalProject.Properties.Resources.icon_calculator;
            this.lbl_title_salary.Name = "lbl_title_salary";
            // 
            // pnl_admin
            // 
            resources.ApplyResources(this.pnl_admin, "pnl_admin");
            this.pnl_admin.BackColor = System.Drawing.Color.Transparent;
            this.pnl_admin.Controls.Add(this.pnl_admin_content);
            this.pnl_admin.Controls.Add(this.lbl_title_admin);
            this.pnl_admin.Name = "pnl_admin";
            this.pnl_admin.VisibleChanged += new System.EventHandler(this.pnl_admin_VisibleChanged);
            // 
            // pnl_admin_content
            // 
            resources.ApplyResources(this.pnl_admin_content, "pnl_admin_content");
            this.pnl_admin_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_admin_content.ForeColor = System.Drawing.Color.White;
            this.pnl_admin_content.Name = "pnl_admin_content";
            // 
            // lbl_title_admin
            // 
            resources.ApplyResources(this.lbl_title_admin, "lbl_title_admin");
            this.lbl_title_admin.ForeColor = System.Drawing.Color.White;
            this.lbl_title_admin.Image = global::FinalProject.Properties.Resources.icon_admin;
            this.lbl_title_admin.Name = "lbl_title_admin";
            // 
            // Form_LandingPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.bg_gradient_main;
            this.Controls.Add(this.pnl_contacts);
            this.Controls.Add(this.pnl_profile);
            this.Controls.Add(this.pnl_admin);
            this.Controls.Add(this.pnl_salary);
            this.Controls.Add(this.pnl_reminder);
            this.Controls.Add(this.pnl_notebook);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_header);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_LandingPage";
            this.Load += new System.EventHandler(this.Form_LandingPage_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_profile)).EndInit();
            this.pnl_profile.ResumeLayout(false);
            this.pnl_profile_content.ResumeLayout(false);
            this.grp_password.ResumeLayout(false);
            this.grp_password.PerformLayout();
            this.grp_personal_info.ResumeLayout(false);
            this.grp_personal_info.PerformLayout();
            this.pnl_contacts.ResumeLayout(false);
            this.pnl_notebook.ResumeLayout(false);
            this.pnl_reminder.ResumeLayout(false);
            this.pnl_salary.ResumeLayout(false);
            this.pnl_admin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.PictureBox pic_profile;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_phonebook;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_notebook;
        private System.Windows.Forms.Panel pnl_picture;
        private System.Windows.Forms.Button btn_reminder;
        private System.Windows.Forms.Button btn_salary;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_profile;
        private System.Windows.Forms.Label lbl_title_profile;
        private System.Windows.Forms.Panel pnl_profile_content;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_lastname;
        private System.Windows.Forms.TextBox txt_lastname;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label lbl_phone_number;
        private System.Windows.Forms.TextBox txt_phone_number;
        private System.Windows.Forms.Label lbl_adress;
        private System.Windows.Forms.TextBox txt_adress;
        private System.Windows.Forms.Button btn_save_profile;
        private System.Windows.Forms.Label lbl_personal_info;
        private System.Windows.Forms.GroupBox grp_personal_info;
        private System.Windows.Forms.GroupBox grp_password;
        private System.Windows.Forms.Label lbl_change_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_confirm_new_password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_new_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_current_password;
        private System.Windows.Forms.Label lbl_password_rules;
        private System.Windows.Forms.Button btn_change_password;
        private System.Windows.Forms.Button btn_see_password_new_confirm;
        private System.Windows.Forms.Button btn_see_password_new;
        private System.Windows.Forms.Button btn_see_password_current;
        private System.Windows.Forms.Panel pnl_contacts;
        private System.Windows.Forms.Panel pnl_contacts_content;
        private System.Windows.Forms.Label lbl_title_contacts;
        private System.Windows.Forms.Panel pnl_notebook;
        private System.Windows.Forms.Panel pnl_notebook_content;
        private System.Windows.Forms.Label lbl_title_notebook;
        private System.Windows.Forms.Panel pnl_reminder;
        private System.Windows.Forms.Panel pnl_reminder_content;
        private System.Windows.Forms.Label lbl_title_reminder;
        private System.Windows.Forms.Panel pnl_salary;
        private System.Windows.Forms.Panel pnl_salary_content;
        private System.Windows.Forms.Label lbl_title_salary;
        private System.Windows.Forms.Panel pnl_admin;
        private System.Windows.Forms.Panel pnl_admin_content;
        private System.Windows.Forms.Label lbl_title_admin;
    }
}