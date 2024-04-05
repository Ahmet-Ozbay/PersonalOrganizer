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
            this.pnl_header.BackColor = System.Drawing.Color.Transparent;
            this.pnl_header.Controls.Add(this.lbl_header);
            this.pnl_header.Controls.Add(this.btn_close);
            this.pnl_header.Controls.Add(this.btn_minimize);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1366, 50);
            this.pnl_header.TabIndex = 3;
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseDown);
            this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseMove);
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.lbl_header.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Location = new System.Drawing.Point(0, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(280, 50);
            this.lbl_header.TabIndex = 2;
            this.lbl_header.Text = "Date / Time";
            this.lbl_header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // pnl_menu
            // 
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
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Font = new System.Drawing.Font("Open Sans ExtraBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnl_menu.ForeColor = System.Drawing.Color.White;
            this.pnl_menu.Location = new System.Drawing.Point(0, 50);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(280, 718);
            this.pnl_menu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Open Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 40);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ahmet Özbay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btn_admin.FlatAppearance.BorderSize = 0;
            this.btn_admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_admin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin.Image = global::FinalProject.Properties.Resources.icon_admin;
            this.btn_admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin.Location = new System.Drawing.Point(30, 608);
            this.btn_admin.Name = "btn_admin";
            this.btn_admin.Size = new System.Drawing.Size(220, 50);
            this.btn_admin.TabIndex = 7;
            this.btn_admin.Text = "        ADMIN";
            this.btn_admin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin.UseVisualStyleBackColor = false;
            this.btn_admin.Click += new System.EventHandler(this.btn_admin_Click);
            this.btn_admin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_admin_MouseDown);
            this.btn_admin.MouseEnter += new System.EventHandler(this.btn_admin_MouseEnter);
            // 
            // btn_salary
            // 
            this.btn_salary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btn_salary.FlatAppearance.BorderSize = 0;
            this.btn_salary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_salary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_salary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salary.Image = global::FinalProject.Properties.Resources.icon_calculator;
            this.btn_salary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salary.Location = new System.Drawing.Point(30, 540);
            this.btn_salary.Name = "btn_salary";
            this.btn_salary.Size = new System.Drawing.Size(220, 50);
            this.btn_salary.TabIndex = 6;
            this.btn_salary.Text = "        SALARY";
            this.btn_salary.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_salary.UseVisualStyleBackColor = false;
            this.btn_salary.Click += new System.EventHandler(this.btn_salary_Click);
            this.btn_salary.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_salary_MouseDown);
            this.btn_salary.MouseEnter += new System.EventHandler(this.btn_salary_MouseEnter);
            // 
            // btn_reminder
            // 
            this.btn_reminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btn_reminder.FlatAppearance.BorderSize = 0;
            this.btn_reminder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_reminder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_reminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reminder.Image = global::FinalProject.Properties.Resources.icon_reminder;
            this.btn_reminder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reminder.Location = new System.Drawing.Point(30, 472);
            this.btn_reminder.Name = "btn_reminder";
            this.btn_reminder.Size = new System.Drawing.Size(220, 50);
            this.btn_reminder.TabIndex = 5;
            this.btn_reminder.Text = "        REMINDER";
            this.btn_reminder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reminder.UseVisualStyleBackColor = false;
            this.btn_reminder.Click += new System.EventHandler(this.btn_reminder_Click);
            this.btn_reminder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_reminder_MouseDown);
            this.btn_reminder.MouseEnter += new System.EventHandler(this.btn_reminder_MouseEnter);
            // 
            // btn_notebook
            // 
            this.btn_notebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btn_notebook.FlatAppearance.BorderSize = 0;
            this.btn_notebook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_notebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_notebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_notebook.Image = global::FinalProject.Properties.Resources.icon_notebook;
            this.btn_notebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_notebook.Location = new System.Drawing.Point(30, 404);
            this.btn_notebook.Name = "btn_notebook";
            this.btn_notebook.Size = new System.Drawing.Size(220, 50);
            this.btn_notebook.TabIndex = 3;
            this.btn_notebook.Text = "        NOTEBOOK";
            this.btn_notebook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_notebook.UseVisualStyleBackColor = false;
            this.btn_notebook.Click += new System.EventHandler(this.btn_notebook_Click);
            this.btn_notebook.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_notebook_MouseDown);
            this.btn_notebook.MouseEnter += new System.EventHandler(this.btn_notebook_MouseEnter);
            // 
            // btn_phonebook
            // 
            this.btn_phonebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btn_phonebook.FlatAppearance.BorderSize = 0;
            this.btn_phonebook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_phonebook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_phonebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_phonebook.Image = global::FinalProject.Properties.Resources.icon_phonebook;
            this.btn_phonebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_phonebook.Location = new System.Drawing.Point(30, 336);
            this.btn_phonebook.Name = "btn_phonebook";
            this.btn_phonebook.Size = new System.Drawing.Size(220, 50);
            this.btn_phonebook.TabIndex = 2;
            this.btn_phonebook.Text = "        CONTACTS";
            this.btn_phonebook.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_phonebook.UseVisualStyleBackColor = false;
            this.btn_phonebook.Click += new System.EventHandler(this.btn_phonebook_Click);
            this.btn_phonebook.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_phonebook_MouseDown);
            this.btn_phonebook.MouseEnter += new System.EventHandler(this.btn_phonebook_MouseEnter);
            // 
            // btn_profile
            // 
            this.btn_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btn_profile.FlatAppearance.BorderSize = 0;
            this.btn_profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_profile.Image = global::FinalProject.Properties.Resources.icon_profile;
            this.btn_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.Location = new System.Drawing.Point(30, 268);
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.Size = new System.Drawing.Size(220, 50);
            this.btn_profile.TabIndex = 1;
            this.btn_profile.Text = "        PROFILE";
            this.btn_profile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            this.btn_profile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_profile_MouseDown);
            this.btn_profile.MouseEnter += new System.EventHandler(this.btn_profile_MouseEnter);
            // 
            // pic_profile
            // 
            this.pic_profile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_profile.BackColor = System.Drawing.Color.Transparent;
            this.pic_profile.BackgroundImage = global::FinalProject.Properties.Resources.bg_error_picture;
            this.pic_profile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_profile.ErrorImage = global::FinalProject.Properties.Resources.bg_error_picture;
            this.pic_profile.Image = global::FinalProject.Properties.Resources.pp_test;
            this.pic_profile.InitialImage = global::FinalProject.Properties.Resources.bg_error_picture;
            this.pic_profile.Location = new System.Drawing.Point(65, 25);
            this.pic_profile.Name = "pic_profile";
            this.pic_profile.Size = new System.Drawing.Size(150, 150);
            this.pic_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_profile.TabIndex = 0;
            this.pic_profile.TabStop = false;
            // 
            // pnl_picture
            // 
            this.pnl_picture.BackColor = System.Drawing.Color.White;
            this.pnl_picture.Location = new System.Drawing.Point(64, 24);
            this.pnl_picture.Name = "pnl_picture";
            this.pnl_picture.Size = new System.Drawing.Size(152, 152);
            this.pnl_picture.TabIndex = 4;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pnl_profile
            // 
            this.pnl_profile.BackColor = System.Drawing.Color.Transparent;
            this.pnl_profile.Controls.Add(this.pnl_profile_content);
            this.pnl_profile.Controls.Add(this.lbl_title_profile);
            this.pnl_profile.Location = new System.Drawing.Point(286, 50);
            this.pnl_profile.Name = "pnl_profile";
            this.pnl_profile.Size = new System.Drawing.Size(1080, 718);
            this.pnl_profile.TabIndex = 5;
            this.pnl_profile.VisibleChanged += new System.EventHandler(this.pnl_profile_VisibleChanged);
            // 
            // pnl_profile_content
            // 
            this.pnl_profile_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_profile_content.Controls.Add(this.grp_password);
            this.pnl_profile_content.Controls.Add(this.grp_personal_info);
            this.pnl_profile_content.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnl_profile_content.ForeColor = System.Drawing.Color.White;
            this.pnl_profile_content.Location = new System.Drawing.Point(11, 57);
            this.pnl_profile_content.Name = "pnl_profile_content";
            this.pnl_profile_content.Size = new System.Drawing.Size(1057, 626);
            this.pnl_profile_content.TabIndex = 1;
            // 
            // grp_password
            // 
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
            this.grp_password.Location = new System.Drawing.Point(661, 9);
            this.grp_password.Name = "grp_password";
            this.grp_password.Size = new System.Drawing.Size(380, 592);
            this.grp_password.TabIndex = 13;
            this.grp_password.TabStop = false;
            // 
            // btn_see_password_new_confirm
            // 
            this.btn_see_password_new_confirm.BackColor = System.Drawing.Color.White;
            this.btn_see_password_new_confirm.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            this.btn_see_password_new_confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_see_password_new_confirm.FlatAppearance.BorderSize = 0;
            this.btn_see_password_new_confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_password_new_confirm.Location = new System.Drawing.Point(326, 315);
            this.btn_see_password_new_confirm.Name = "btn_see_password_new_confirm";
            this.btn_see_password_new_confirm.Size = new System.Drawing.Size(32, 32);
            this.btn_see_password_new_confirm.TabIndex = 21;
            this.btn_see_password_new_confirm.TabStop = false;
            this.btn_see_password_new_confirm.UseVisualStyleBackColor = false;
            this.btn_see_password_new_confirm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_new_confirm_MouseDown);
            this.btn_see_password_new_confirm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_new_confirm_MouseUp);
            // 
            // btn_see_password_new
            // 
            this.btn_see_password_new.BackColor = System.Drawing.Color.White;
            this.btn_see_password_new.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            this.btn_see_password_new.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_see_password_new.FlatAppearance.BorderSize = 0;
            this.btn_see_password_new.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_password_new.Location = new System.Drawing.Point(326, 221);
            this.btn_see_password_new.Name = "btn_see_password_new";
            this.btn_see_password_new.Size = new System.Drawing.Size(32, 32);
            this.btn_see_password_new.TabIndex = 20;
            this.btn_see_password_new.TabStop = false;
            this.btn_see_password_new.UseVisualStyleBackColor = false;
            this.btn_see_password_new.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_new_MouseDown);
            this.btn_see_password_new.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_new_MouseUp);
            // 
            // btn_see_password_current
            // 
            this.btn_see_password_current.BackColor = System.Drawing.Color.White;
            this.btn_see_password_current.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            this.btn_see_password_current.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_see_password_current.FlatAppearance.BorderSize = 0;
            this.btn_see_password_current.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_see_password_current.Location = new System.Drawing.Point(326, 127);
            this.btn_see_password_current.Name = "btn_see_password_current";
            this.btn_see_password_current.Size = new System.Drawing.Size(32, 32);
            this.btn_see_password_current.TabIndex = 3;
            this.btn_see_password_current.TabStop = false;
            this.btn_see_password_current.UseVisualStyleBackColor = false;
            this.btn_see_password_current.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_current_MouseDown);
            this.btn_see_password_current.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_current_MouseUp);
            // 
            // lbl_password_rules
            // 
            this.lbl_password_rules.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_password_rules.Location = new System.Drawing.Point(18, 370);
            this.lbl_password_rules.Name = "lbl_password_rules";
            this.lbl_password_rules.Size = new System.Drawing.Size(340, 130);
            this.lbl_password_rules.TabIndex = 19;
            this.lbl_password_rules.Text = "Your password must contain:\r\n- At least 8 characters\r\n- At least one upper case c" +
    "haracter\r\n- At least one special character";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Confirm New Password:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_confirm_new_password
            // 
            this.txt_confirm_new_password.Location = new System.Drawing.Point(18, 315);
            this.txt_confirm_new_password.Name = "txt_confirm_new_password";
            this.txt_confirm_new_password.PasswordChar = '*';
            this.txt_confirm_new_password.Size = new System.Drawing.Size(340, 33);
            this.txt_confirm_new_password.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "New Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_new_password
            // 
            this.txt_new_password.Location = new System.Drawing.Point(18, 221);
            this.txt_new_password.Name = "txt_new_password";
            this.txt_new_password.PasswordChar = '*';
            this.txt_new_password.Size = new System.Drawing.Size(340, 33);
            this.txt_new_password.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "Current Password: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_current_password
            // 
            this.txt_current_password.Location = new System.Drawing.Point(18, 127);
            this.txt_current_password.Name = "txt_current_password";
            this.txt_current_password.PasswordChar = '*';
            this.txt_current_password.Size = new System.Drawing.Size(340, 33);
            this.txt_current_password.TabIndex = 14;
            // 
            // lbl_change_password
            // 
            this.lbl_change_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_change_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_change_password.Font = new System.Drawing.Font("Open Sans Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_change_password.Location = new System.Drawing.Point(10, 20);
            this.lbl_change_password.Name = "lbl_change_password";
            this.lbl_change_password.Size = new System.Drawing.Size(360, 50);
            this.lbl_change_password.TabIndex = 12;
            this.lbl_change_password.Text = "Change Password";
            this.lbl_change_password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_change_password
            // 
            this.btn_change_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_change_password.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_change_password.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_change_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_password.Location = new System.Drawing.Point(158, 522);
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.Size = new System.Drawing.Size(200, 50);
            this.btn_change_password.TabIndex = 12;
            this.btn_change_password.Text = "Change Password";
            this.btn_change_password.UseVisualStyleBackColor = false;
            this.btn_change_password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_change_password_MouseDown);
            this.btn_change_password.MouseEnter += new System.EventHandler(this.btn_change_password_MouseEnter);
            // 
            // grp_personal_info
            // 
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
            this.grp_personal_info.Location = new System.Drawing.Point(23, 9);
            this.grp_personal_info.Name = "grp_personal_info";
            this.grp_personal_info.Size = new System.Drawing.Size(620, 592);
            this.grp_personal_info.TabIndex = 12;
            this.grp_personal_info.TabStop = false;
            // 
            // lbl_personal_info
            // 
            this.lbl_personal_info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_personal_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_personal_info.Font = new System.Drawing.Font("Open Sans Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_personal_info.Location = new System.Drawing.Point(10, 20);
            this.lbl_personal_info.Name = "lbl_personal_info";
            this.lbl_personal_info.Size = new System.Drawing.Size(600, 50);
            this.lbl_personal_info.TabIndex = 11;
            this.lbl_personal_info.Text = "Personal Information";
            this.lbl_personal_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Open Sans ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_name.Location = new System.Drawing.Point(107, 81);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(90, 31);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name: ";
            this.lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(220, 80);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(360, 33);
            this.txt_name.TabIndex = 1;
            // 
            // lbl_lastname
            // 
            this.lbl_lastname.AutoSize = true;
            this.lbl_lastname.Font = new System.Drawing.Font("Open Sans ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_lastname.Location = new System.Drawing.Point(56, 136);
            this.lbl_lastname.Name = "lbl_lastname";
            this.lbl_lastname.Size = new System.Drawing.Size(141, 31);
            this.lbl_lastname.TabIndex = 2;
            this.lbl_lastname.Text = "Last Name: ";
            this.lbl_lastname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_lastname
            // 
            this.txt_lastname.Location = new System.Drawing.Point(220, 135);
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.Size = new System.Drawing.Size(360, 33);
            this.txt_lastname.TabIndex = 3;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Open Sans ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_email.Location = new System.Drawing.Point(112, 191);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(85, 31);
            this.lbl_email.TabIndex = 4;
            this.lbl_email.Text = "Email: ";
            this.lbl_email.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(220, 190);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(360, 33);
            this.txt_email.TabIndex = 5;
            // 
            // lbl_phone_number
            // 
            this.lbl_phone_number.AutoSize = true;
            this.lbl_phone_number.Font = new System.Drawing.Font("Open Sans ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_phone_number.Location = new System.Drawing.Point(10, 246);
            this.lbl_phone_number.Name = "lbl_phone_number";
            this.lbl_phone_number.Size = new System.Drawing.Size(187, 31);
            this.lbl_phone_number.TabIndex = 6;
            this.lbl_phone_number.Text = "Phone Number: ";
            this.lbl_phone_number.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_phone_number
            // 
            this.txt_phone_number.Location = new System.Drawing.Point(220, 245);
            this.txt_phone_number.Name = "txt_phone_number";
            this.txt_phone_number.Size = new System.Drawing.Size(360, 33);
            this.txt_phone_number.TabIndex = 7;
            // 
            // lbl_adress
            // 
            this.lbl_adress.AutoSize = true;
            this.lbl_adress.Font = new System.Drawing.Font("Open Sans ExtraBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adress.Location = new System.Drawing.Point(98, 385);
            this.lbl_adress.Name = "lbl_adress";
            this.lbl_adress.Size = new System.Drawing.Size(99, 31);
            this.lbl_adress.TabIndex = 8;
            this.lbl_adress.Text = "Adress: ";
            this.lbl_adress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_adress
            // 
            this.txt_adress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_adress.Location = new System.Drawing.Point(220, 300);
            this.txt_adress.Multiline = true;
            this.txt_adress.Name = "txt_adress";
            this.txt_adress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_adress.Size = new System.Drawing.Size(360, 200);
            this.txt_adress.TabIndex = 9;
            // 
            // btn_save_profile
            // 
            this.btn_save_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_save_profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_save_profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_save_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_profile.Location = new System.Drawing.Point(380, 522);
            this.btn_save_profile.Name = "btn_save_profile";
            this.btn_save_profile.Size = new System.Drawing.Size(200, 50);
            this.btn_save_profile.TabIndex = 10;
            this.btn_save_profile.Text = "Save Profile";
            this.btn_save_profile.UseVisualStyleBackColor = false;
            this.btn_save_profile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_save_profile_MouseDown);
            this.btn_save_profile.MouseEnter += new System.EventHandler(this.btn_save_profile_MouseEnter);
            // 
            // lbl_title_profile
            // 
            this.lbl_title_profile.Font = new System.Drawing.Font("Open Sans ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_title_profile.ForeColor = System.Drawing.Color.White;
            this.lbl_title_profile.Image = global::FinalProject.Properties.Resources.icon_profile;
            this.lbl_title_profile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_title_profile.Location = new System.Drawing.Point(10, 3);
            this.lbl_title_profile.Name = "lbl_title_profile";
            this.lbl_title_profile.Size = new System.Drawing.Size(200, 45);
            this.lbl_title_profile.TabIndex = 0;
            this.lbl_title_profile.Text = "PROFILE";
            this.lbl_title_profile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_contacts
            // 
            this.pnl_contacts.BackColor = System.Drawing.Color.Transparent;
            this.pnl_contacts.Controls.Add(this.pnl_contacts_content);
            this.pnl_contacts.Controls.Add(this.lbl_title_contacts);
            this.pnl_contacts.Location = new System.Drawing.Point(286, 50);
            this.pnl_contacts.Name = "pnl_contacts";
            this.pnl_contacts.Size = new System.Drawing.Size(1080, 718);
            this.pnl_contacts.TabIndex = 6;
            this.pnl_contacts.Visible = false;
            this.pnl_contacts.VisibleChanged += new System.EventHandler(this.pnl_contacts_VisibleChanged);
            // 
            // pnl_contacts_content
            // 
            this.pnl_contacts_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_contacts_content.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnl_contacts_content.ForeColor = System.Drawing.Color.White;
            this.pnl_contacts_content.Location = new System.Drawing.Point(11, 57);
            this.pnl_contacts_content.Name = "pnl_contacts_content";
            this.pnl_contacts_content.Size = new System.Drawing.Size(1057, 626);
            this.pnl_contacts_content.TabIndex = 1;
            // 
            // lbl_title_contacts
            // 
            this.lbl_title_contacts.Font = new System.Drawing.Font("Open Sans ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_title_contacts.ForeColor = System.Drawing.Color.White;
            this.lbl_title_contacts.Image = global::FinalProject.Properties.Resources.icon_phonebook;
            this.lbl_title_contacts.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_title_contacts.Location = new System.Drawing.Point(10, 3);
            this.lbl_title_contacts.Name = "lbl_title_contacts";
            this.lbl_title_contacts.Size = new System.Drawing.Size(237, 45);
            this.lbl_title_contacts.TabIndex = 0;
            this.lbl_title_contacts.Text = "CONTACTS";
            this.lbl_title_contacts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_notebook
            // 
            this.pnl_notebook.BackColor = System.Drawing.Color.Transparent;
            this.pnl_notebook.Controls.Add(this.pnl_notebook_content);
            this.pnl_notebook.Controls.Add(this.lbl_title_notebook);
            this.pnl_notebook.Location = new System.Drawing.Point(286, 50);
            this.pnl_notebook.Name = "pnl_notebook";
            this.pnl_notebook.Size = new System.Drawing.Size(1080, 718);
            this.pnl_notebook.TabIndex = 7;
            this.pnl_notebook.Visible = false;
            this.pnl_notebook.VisibleChanged += new System.EventHandler(this.pnl_notebook_VisibleChanged);
            // 
            // pnl_notebook_content
            // 
            this.pnl_notebook_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_notebook_content.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnl_notebook_content.ForeColor = System.Drawing.Color.White;
            this.pnl_notebook_content.Location = new System.Drawing.Point(11, 57);
            this.pnl_notebook_content.Name = "pnl_notebook_content";
            this.pnl_notebook_content.Size = new System.Drawing.Size(1057, 626);
            this.pnl_notebook_content.TabIndex = 1;
            // 
            // lbl_title_notebook
            // 
            this.lbl_title_notebook.Font = new System.Drawing.Font("Open Sans ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_title_notebook.ForeColor = System.Drawing.Color.White;
            this.lbl_title_notebook.Image = global::FinalProject.Properties.Resources.icon_notebook;
            this.lbl_title_notebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_title_notebook.Location = new System.Drawing.Point(10, 3);
            this.lbl_title_notebook.Name = "lbl_title_notebook";
            this.lbl_title_notebook.Size = new System.Drawing.Size(253, 45);
            this.lbl_title_notebook.TabIndex = 0;
            this.lbl_title_notebook.Text = "NOTEBOOK";
            this.lbl_title_notebook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_reminder
            // 
            this.pnl_reminder.BackColor = System.Drawing.Color.Transparent;
            this.pnl_reminder.Controls.Add(this.pnl_reminder_content);
            this.pnl_reminder.Controls.Add(this.lbl_title_reminder);
            this.pnl_reminder.Location = new System.Drawing.Point(286, 50);
            this.pnl_reminder.Name = "pnl_reminder";
            this.pnl_reminder.Size = new System.Drawing.Size(1080, 718);
            this.pnl_reminder.TabIndex = 8;
            this.pnl_reminder.Visible = false;
            this.pnl_reminder.VisibleChanged += new System.EventHandler(this.pnl_reminder_VisibleChanged);
            // 
            // pnl_reminder_content
            // 
            this.pnl_reminder_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_reminder_content.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnl_reminder_content.ForeColor = System.Drawing.Color.White;
            this.pnl_reminder_content.Location = new System.Drawing.Point(11, 57);
            this.pnl_reminder_content.Name = "pnl_reminder_content";
            this.pnl_reminder_content.Size = new System.Drawing.Size(1057, 626);
            this.pnl_reminder_content.TabIndex = 1;
            // 
            // lbl_title_reminder
            // 
            this.lbl_title_reminder.Font = new System.Drawing.Font("Open Sans ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_title_reminder.ForeColor = System.Drawing.Color.White;
            this.lbl_title_reminder.Image = global::FinalProject.Properties.Resources.icon_reminder;
            this.lbl_title_reminder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_title_reminder.Location = new System.Drawing.Point(10, 3);
            this.lbl_title_reminder.Name = "lbl_title_reminder";
            this.lbl_title_reminder.Size = new System.Drawing.Size(237, 45);
            this.lbl_title_reminder.TabIndex = 0;
            this.lbl_title_reminder.Text = "REMINDER";
            this.lbl_title_reminder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_salary
            // 
            this.pnl_salary.BackColor = System.Drawing.Color.Transparent;
            this.pnl_salary.Controls.Add(this.pnl_salary_content);
            this.pnl_salary.Controls.Add(this.lbl_title_salary);
            this.pnl_salary.Location = new System.Drawing.Point(286, 50);
            this.pnl_salary.Name = "pnl_salary";
            this.pnl_salary.Size = new System.Drawing.Size(1080, 718);
            this.pnl_salary.TabIndex = 9;
            this.pnl_salary.Visible = false;
            this.pnl_salary.VisibleChanged += new System.EventHandler(this.pnl_salary_VisibleChanged);
            // 
            // pnl_salary_content
            // 
            this.pnl_salary_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_salary_content.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnl_salary_content.ForeColor = System.Drawing.Color.White;
            this.pnl_salary_content.Location = new System.Drawing.Point(11, 57);
            this.pnl_salary_content.Name = "pnl_salary_content";
            this.pnl_salary_content.Size = new System.Drawing.Size(1057, 626);
            this.pnl_salary_content.TabIndex = 1;
            // 
            // lbl_title_salary
            // 
            this.lbl_title_salary.Font = new System.Drawing.Font("Open Sans ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_title_salary.ForeColor = System.Drawing.Color.White;
            this.lbl_title_salary.Image = global::FinalProject.Properties.Resources.icon_calculator;
            this.lbl_title_salary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_title_salary.Location = new System.Drawing.Point(10, 3);
            this.lbl_title_salary.Name = "lbl_title_salary";
            this.lbl_title_salary.Size = new System.Drawing.Size(417, 45);
            this.lbl_title_salary.TabIndex = 0;
            this.lbl_title_salary.Text = "SALARY CALCULATOR";
            this.lbl_title_salary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_admin
            // 
            this.pnl_admin.BackColor = System.Drawing.Color.Transparent;
            this.pnl_admin.Controls.Add(this.pnl_admin_content);
            this.pnl_admin.Controls.Add(this.lbl_title_admin);
            this.pnl_admin.Location = new System.Drawing.Point(286, 50);
            this.pnl_admin.Name = "pnl_admin";
            this.pnl_admin.Size = new System.Drawing.Size(1080, 718);
            this.pnl_admin.TabIndex = 10;
            this.pnl_admin.Visible = false;
            this.pnl_admin.VisibleChanged += new System.EventHandler(this.pnl_admin_VisibleChanged);
            // 
            // pnl_admin_content
            // 
            this.pnl_admin_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_admin_content.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pnl_admin_content.ForeColor = System.Drawing.Color.White;
            this.pnl_admin_content.Location = new System.Drawing.Point(11, 57);
            this.pnl_admin_content.Name = "pnl_admin_content";
            this.pnl_admin_content.Size = new System.Drawing.Size(1057, 626);
            this.pnl_admin_content.TabIndex = 1;
            // 
            // lbl_title_admin
            // 
            this.lbl_title_admin.Font = new System.Drawing.Font("Open Sans ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_title_admin.ForeColor = System.Drawing.Color.White;
            this.lbl_title_admin.Image = global::FinalProject.Properties.Resources.icon_admin;
            this.lbl_title_admin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_title_admin.Location = new System.Drawing.Point(10, 3);
            this.lbl_title_admin.Name = "lbl_title_admin";
            this.lbl_title_admin.Size = new System.Drawing.Size(299, 45);
            this.lbl_title_admin.TabIndex = 0;
            this.lbl_title_admin.Text = "ADMIN PANEL";
            this.lbl_title_admin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form_LandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.bg_gradient_main;
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnl_admin);
            this.Controls.Add(this.pnl_salary);
            this.Controls.Add(this.pnl_reminder);
            this.Controls.Add(this.pnl_notebook);
            this.Controls.Add(this.pnl_contacts);
            this.Controls.Add(this.pnl_profile);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_header);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_LandingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Landing";
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