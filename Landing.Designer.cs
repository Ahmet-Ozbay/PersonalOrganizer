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
            this.lblName = new System.Windows.Forms.Label();
            this.btn_admin = new System.Windows.Forms.Button();
            this.btn_salary = new System.Windows.Forms.Button();
            this.btn_reminder = new System.Windows.Forms.Button();
            this.btn_notebook = new System.Windows.Forms.Button();
            this.btn_phonebook = new System.Windows.Forms.Button();
            this.btn_profile = new System.Windows.Forms.Button();
            this.pnl_picture = new System.Windows.Forms.Panel();
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            this.context_avatar = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsm_change = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_remove = new System.Windows.Forms.ToolStripMenuItem();
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
            this.txt_phone_number = new System.Windows.Forms.MaskedTextBox();
            this.lbl_personal_info = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_salary = new System.Windows.Forms.Label();
            this.lbl_lastname = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_lastname = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.lbl_phone_number = new System.Windows.Forms.Label();
            this.lbl_adress = new System.Windows.Forms.Label();
            this.txt_adress = new System.Windows.Forms.TextBox();
            this.btn_save_profile = new System.Windows.Forms.Button();
            this.lbl_title_profile = new System.Windows.Forms.Label();
            this.pnl_contacts = new System.Windows.Forms.Panel();
            this.btn_delete_contact = new System.Windows.Forms.Button();
            this.pnl_contacts_content = new System.Windows.Forms.Panel();
            this.btn_save_contact = new System.Windows.Forms.Button();
            this.lbl_contact_address = new System.Windows.Forms.Label();
            this.lbl_contact_email = new System.Windows.Forms.Label();
            this.lbl_contact_phone = new System.Windows.Forms.Label();
            this.lbl_contact_lastname = new System.Windows.Forms.Label();
            this.lbl_contact_name = new System.Windows.Forms.Label();
            this.pnl_contact_email = new System.Windows.Forms.Panel();
            this.txt_contact_email = new System.Windows.Forms.TextBox();
            this.pnl_contact_phone = new System.Windows.Forms.Panel();
            this.txt_contact_phone = new System.Windows.Forms.MaskedTextBox();
            this.pnl_contact_lastname = new System.Windows.Forms.Panel();
            this.txt_contact_lastname = new System.Windows.Forms.TextBox();
            this.pnl_contact_name = new System.Windows.Forms.Panel();
            this.txt_contact_name = new System.Windows.Forms.TextBox();
            this.grp_phonebook = new System.Windows.Forms.GroupBox();
            this.dgv_phonebook = new System.Windows.Forms.DataGridView();
            this.PhoneBook_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneBook_UserEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneBook_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneBook_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneBook_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneBook_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneBook_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.context_dgv_phonebook = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearSelectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_contact_address = new System.Windows.Forms.Panel();
            this.txt_contact_address = new System.Windows.Forms.TextBox();
            this.lbl_title_contacts = new System.Windows.Forms.Label();
            this.pnl_notebook = new System.Windows.Forms.Panel();
            this.pnl_notebook_content = new System.Windows.Forms.Panel();
            this.grp_note = new System.Windows.Forms.GroupBox();
            this.btn_delete_note = new System.Windows.Forms.Button();
            this.btn_save_note = new System.Windows.Forms.Button();
            this.lbl_note_content = new System.Windows.Forms.Label();
            this.lbl_note_title = new System.Windows.Forms.Label();
            this.pnl_note_content = new System.Windows.Forms.Panel();
            this.txt_note_content = new System.Windows.Forms.TextBox();
            this.pnl_note_title = new System.Windows.Forms.Panel();
            this.txt_note_title = new System.Windows.Forms.TextBox();
            this.grp_notebook = new System.Windows.Forms.GroupBox();
            this.dgv_notes = new System.Windows.Forms.DataGridView();
            this.Column_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.context_dgv_notebook = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_title_notebook = new System.Windows.Forms.Label();
            this.pnl_reminder = new System.Windows.Forms.Panel();
            this.pnl_reminder_content = new System.Windows.Forms.Panel();
            this.pnl_dgv_reminder = new System.Windows.Forms.Panel();
            this.dgv_reminder = new System.Windows.Forms.DataGridView();
            this.context_dgv_reminder = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearSelectionToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_delete_reminder = new System.Windows.Forms.Button();
            this.btn_save_reminder = new System.Windows.Forms.Button();
            this.rb_task = new System.Windows.Forms.RadioButton();
            this.rb_meeting = new System.Windows.Forms.RadioButton();
            this.lbl_time_end = new System.Windows.Forms.Label();
            this.lbl_time_start = new System.Windows.Forms.Label();
            this.datePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbl_description = new System.Windows.Forms.Label();
            this.lbl_summary = new System.Windows.Forms.Label();
            this.txt_reminder_description = new System.Windows.Forms.TextBox();
            this.txt_reminder_summary = new System.Windows.Forms.TextBox();
            this.timePicker2 = new System.Windows.Forms.DateTimePicker();
            this.timePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbl_title_reminder = new System.Windows.Forms.Label();
            this.pnl_salary = new System.Windows.Forms.Panel();
            this.pnl_salary_content = new System.Windows.Forms.Panel();
            this.grp_family = new System.Windows.Forms.GroupBox();
            this.lbl_18_plus_clause = new System.Windows.Forms.Label();
            this.lbl_family_info = new System.Windows.Forms.Label();
            this.cb_children = new System.Windows.Forms.CheckBox();
            this.grp_children = new System.Windows.Forms.GroupBox();
            this.nud_18_plus = new System.Windows.Forms.NumericUpDown();
            this.lbl_18plus = new System.Windows.Forms.Label();
            this.nud_7_18 = new System.Windows.Forms.NumericUpDown();
            this.lbl_7_18 = new System.Windows.Forms.Label();
            this.nud_0_6 = new System.Windows.Forms.NumericUpDown();
            this.lbl_0_6 = new System.Windows.Forms.Label();
            this.lbl_spouse_status = new System.Windows.Forms.Label();
            this.grp_spouse = new System.Windows.Forms.GroupBox();
            this.rb_working = new System.Windows.Forms.RadioButton();
            this.rb_not_working = new System.Windows.Forms.RadioButton();
            this.lbl_marital_status = new System.Windows.Forms.Label();
            this.grp_marital_status = new System.Windows.Forms.GroupBox();
            this.rb_married = new System.Windows.Forms.RadioButton();
            this.rb_single = new System.Windows.Forms.RadioButton();
            this.pnl_screen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_calculated_salary = new System.Windows.Forms.TextBox();
            this.btn_calculate = new System.Windows.Forms.Button();
            this.nud_langauge_count = new System.Windows.Forms.NumericUpDown();
            this.lbl_language_count = new System.Windows.Forms.Label();
            this.cmb_duties = new System.Windows.Forms.ComboBox();
            this.cmb_language = new System.Windows.Forms.ComboBox();
            this.cmb_education = new System.Windows.Forms.ComboBox();
            this.cmb_city = new System.Windows.Forms.ComboBox();
            this.cmb_experience = new System.Windows.Forms.ComboBox();
            this.lbl_duties = new System.Windows.Forms.Label();
            this.lbl_language = new System.Windows.Forms.Label();
            this.lbl_education = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.lbl_experience = new System.Windows.Forms.Label();
            this.lbl_title_salary = new System.Windows.Forms.Label();
            this.pnl_admin = new System.Windows.Forms.Panel();
            this.pnl_admin_content = new System.Windows.Forms.Panel();
            this.lbl_title_admin = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USEREMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STARTTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ENDTIME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_header.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.pnl_picture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            this.context_avatar.SuspendLayout();
            this.pnl_profile.SuspendLayout();
            this.pnl_profile_content.SuspendLayout();
            this.grp_password.SuspendLayout();
            this.grp_personal_info.SuspendLayout();
            this.pnl_contacts.SuspendLayout();
            this.pnl_contacts_content.SuspendLayout();
            this.pnl_contact_email.SuspendLayout();
            this.pnl_contact_phone.SuspendLayout();
            this.pnl_contact_lastname.SuspendLayout();
            this.pnl_contact_name.SuspendLayout();
            this.grp_phonebook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phonebook)).BeginInit();
            this.context_dgv_phonebook.SuspendLayout();
            this.pnl_contact_address.SuspendLayout();
            this.pnl_notebook.SuspendLayout();
            this.pnl_notebook_content.SuspendLayout();
            this.grp_note.SuspendLayout();
            this.pnl_note_content.SuspendLayout();
            this.pnl_note_title.SuspendLayout();
            this.grp_notebook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notes)).BeginInit();
            this.context_dgv_notebook.SuspendLayout();
            this.pnl_reminder.SuspendLayout();
            this.pnl_reminder_content.SuspendLayout();
            this.pnl_dgv_reminder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reminder)).BeginInit();
            this.context_dgv_reminder.SuspendLayout();
            this.pnl_salary.SuspendLayout();
            this.pnl_salary_content.SuspendLayout();
            this.grp_family.SuspendLayout();
            this.grp_children.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_18_plus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_7_18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_0_6)).BeginInit();
            this.grp_spouse.SuspendLayout();
            this.grp_marital_status.SuspendLayout();
            this.pnl_screen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_langauge_count)).BeginInit();
            this.pnl_admin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.Transparent;
            this.pnl_header.Controls.Add(this.lbl_header);
            this.pnl_header.Controls.Add(this.btn_close);
            this.pnl_header.Controls.Add(this.btn_minimize);
            resources.ApplyResources(this.pnl_header, "pnl_header");
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseDown);
            this.pnl_header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_header_MouseMove);
            // 
            // lbl_header
            // 
            this.lbl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            resources.ApplyResources(this.lbl_header, "lbl_header");
            this.lbl_header.ForeColor = System.Drawing.Color.White;
            this.lbl_header.Name = "lbl_header";
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
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_menu.Controls.Add(this.lblName);
            this.pnl_menu.Controls.Add(this.btn_admin);
            this.pnl_menu.Controls.Add(this.btn_salary);
            this.pnl_menu.Controls.Add(this.btn_reminder);
            this.pnl_menu.Controls.Add(this.btn_notebook);
            this.pnl_menu.Controls.Add(this.btn_phonebook);
            this.pnl_menu.Controls.Add(this.btn_profile);
            this.pnl_menu.Controls.Add(this.pnl_picture);
            resources.ApplyResources(this.pnl_menu, "pnl_menu");
            this.pnl_menu.ForeColor = System.Drawing.Color.White;
            this.pnl_menu.Name = "pnl_menu";
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.lblName, "lblName");
            this.lblName.Name = "lblName";
            // 
            // btn_admin
            // 
            this.btn_admin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.btn_admin.FlatAppearance.BorderSize = 0;
            this.btn_admin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_admin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_admin, "btn_admin");
            this.btn_admin.Image = global::FinalProject.Properties.Resources.icon_admin;
            this.btn_admin.Name = "btn_admin";
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
            resources.ApplyResources(this.btn_salary, "btn_salary");
            this.btn_salary.Image = global::FinalProject.Properties.Resources.icon_calculator;
            this.btn_salary.Name = "btn_salary";
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
            resources.ApplyResources(this.btn_reminder, "btn_reminder");
            this.btn_reminder.Image = global::FinalProject.Properties.Resources.icon_reminder;
            this.btn_reminder.Name = "btn_reminder";
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
            resources.ApplyResources(this.btn_notebook, "btn_notebook");
            this.btn_notebook.Image = global::FinalProject.Properties.Resources.icon_notebook;
            this.btn_notebook.Name = "btn_notebook";
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
            resources.ApplyResources(this.btn_phonebook, "btn_phonebook");
            this.btn_phonebook.Image = global::FinalProject.Properties.Resources.icon_phonebook;
            this.btn_phonebook.Name = "btn_phonebook";
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
            resources.ApplyResources(this.btn_profile, "btn_profile");
            this.btn_profile.Image = global::FinalProject.Properties.Resources.icon_profile;
            this.btn_profile.Name = "btn_profile";
            this.btn_profile.UseVisualStyleBackColor = false;
            this.btn_profile.Click += new System.EventHandler(this.btn_profile_Click);
            this.btn_profile.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_profile_MouseDown);
            this.btn_profile.MouseEnter += new System.EventHandler(this.btn_profile_MouseEnter);
            // 
            // pnl_picture
            // 
            this.pnl_picture.BackColor = System.Drawing.Color.Transparent;
            this.pnl_picture.Controls.Add(this.pb_avatar);
            resources.ApplyResources(this.pnl_picture, "pnl_picture");
            this.pnl_picture.Name = "pnl_picture";
            // 
            // pb_avatar
            // 
            this.pb_avatar.ContextMenuStrip = this.context_avatar;
            resources.ApplyResources(this.pb_avatar, "pb_avatar");
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.TabStop = false;
            // 
            // context_avatar
            // 
            this.context_avatar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_change,
            this.tsm_remove});
            this.context_avatar.Name = "context_avatar";
            resources.ApplyResources(this.context_avatar, "context_avatar");
            // 
            // tsm_change
            // 
            this.tsm_change.Name = "tsm_change";
            resources.ApplyResources(this.tsm_change, "tsm_change");
            this.tsm_change.Click += new System.EventHandler(this.tsm_change_Click);
            // 
            // tsm_remove
            // 
            this.tsm_remove.Name = "tsm_remove";
            resources.ApplyResources(this.tsm_remove, "tsm_remove");
            this.tsm_remove.Click += new System.EventHandler(this.tsm_remove_Click);
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
            resources.ApplyResources(this.pnl_profile, "pnl_profile");
            this.pnl_profile.Name = "pnl_profile";
            this.pnl_profile.VisibleChanged += new System.EventHandler(this.pnl_profile_VisibleChanged);
            // 
            // pnl_profile_content
            // 
            this.pnl_profile_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_profile_content.Controls.Add(this.grp_password);
            this.pnl_profile_content.Controls.Add(this.grp_personal_info);
            resources.ApplyResources(this.pnl_profile_content, "pnl_profile_content");
            this.pnl_profile_content.ForeColor = System.Drawing.Color.White;
            this.pnl_profile_content.Name = "pnl_profile_content";
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
            resources.ApplyResources(this.grp_password, "grp_password");
            this.grp_password.Name = "grp_password";
            this.grp_password.TabStop = false;
            // 
            // btn_see_password_new_confirm
            // 
            this.btn_see_password_new_confirm.BackColor = System.Drawing.Color.White;
            this.btn_see_password_new_confirm.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            resources.ApplyResources(this.btn_see_password_new_confirm, "btn_see_password_new_confirm");
            this.btn_see_password_new_confirm.FlatAppearance.BorderSize = 0;
            this.btn_see_password_new_confirm.Name = "btn_see_password_new_confirm";
            this.btn_see_password_new_confirm.TabStop = false;
            this.btn_see_password_new_confirm.UseVisualStyleBackColor = false;
            this.btn_see_password_new_confirm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_new_confirm_MouseDown);
            this.btn_see_password_new_confirm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_new_confirm_MouseUp);
            // 
            // btn_see_password_new
            // 
            this.btn_see_password_new.BackColor = System.Drawing.Color.White;
            this.btn_see_password_new.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            resources.ApplyResources(this.btn_see_password_new, "btn_see_password_new");
            this.btn_see_password_new.FlatAppearance.BorderSize = 0;
            this.btn_see_password_new.Name = "btn_see_password_new";
            this.btn_see_password_new.TabStop = false;
            this.btn_see_password_new.UseVisualStyleBackColor = false;
            this.btn_see_password_new.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_new_MouseDown);
            this.btn_see_password_new.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_see_password_new_MouseUp);
            // 
            // btn_see_password_current
            // 
            this.btn_see_password_current.BackColor = System.Drawing.Color.White;
            this.btn_see_password_current.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
            resources.ApplyResources(this.btn_see_password_current, "btn_see_password_current");
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
            this.lbl_change_password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_change_password.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lbl_change_password, "lbl_change_password");
            this.lbl_change_password.Name = "lbl_change_password";
            // 
            // btn_change_password
            // 
            this.btn_change_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_change_password.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_change_password.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_change_password, "btn_change_password");
            this.btn_change_password.Name = "btn_change_password";
            this.btn_change_password.UseVisualStyleBackColor = false;
            this.btn_change_password.Click += new System.EventHandler(this.btn_change_password_Click);
            this.btn_change_password.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_change_password_MouseDown);
            this.btn_change_password.MouseEnter += new System.EventHandler(this.btn_change_password_MouseEnter);
            // 
            // grp_personal_info
            // 
            this.grp_personal_info.Controls.Add(this.txt_phone_number);
            this.grp_personal_info.Controls.Add(this.lbl_personal_info);
            this.grp_personal_info.Controls.Add(this.lbl_name);
            this.grp_personal_info.Controls.Add(this.txt_name);
            this.grp_personal_info.Controls.Add(this.lbl_salary);
            this.grp_personal_info.Controls.Add(this.lbl_lastname);
            this.grp_personal_info.Controls.Add(this.txt_salary);
            this.grp_personal_info.Controls.Add(this.txt_lastname);
            this.grp_personal_info.Controls.Add(this.lbl_email);
            this.grp_personal_info.Controls.Add(this.txt_email);
            this.grp_personal_info.Controls.Add(this.lbl_phone_number);
            this.grp_personal_info.Controls.Add(this.lbl_adress);
            this.grp_personal_info.Controls.Add(this.txt_adress);
            this.grp_personal_info.Controls.Add(this.btn_save_profile);
            resources.ApplyResources(this.grp_personal_info, "grp_personal_info");
            this.grp_personal_info.Name = "grp_personal_info";
            this.grp_personal_info.TabStop = false;
            // 
            // txt_phone_number
            // 
            resources.ApplyResources(this.txt_phone_number, "txt_phone_number");
            this.txt_phone_number.Name = "txt_phone_number";
            // 
            // lbl_personal_info
            // 
            this.lbl_personal_info.BackColor = System.Drawing.Color.Transparent;
            this.lbl_personal_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.lbl_personal_info, "lbl_personal_info");
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
            // lbl_salary
            // 
            resources.ApplyResources(this.lbl_salary, "lbl_salary");
            this.lbl_salary.Name = "lbl_salary";
            // 
            // lbl_lastname
            // 
            resources.ApplyResources(this.lbl_lastname, "lbl_lastname");
            this.lbl_lastname.Name = "lbl_lastname";
            // 
            // txt_salary
            // 
            this.txt_salary.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.txt_salary, "txt_salary");
            this.txt_salary.Name = "txt_salary";
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
            this.txt_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_email_KeyPress);
            // 
            // lbl_phone_number
            // 
            resources.ApplyResources(this.lbl_phone_number, "lbl_phone_number");
            this.lbl_phone_number.Name = "lbl_phone_number";
            // 
            // lbl_adress
            // 
            resources.ApplyResources(this.lbl_adress, "lbl_adress");
            this.lbl_adress.Name = "lbl_adress";
            // 
            // txt_adress
            // 
            this.txt_adress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_adress, "txt_adress");
            this.txt_adress.Name = "txt_adress";
            // 
            // btn_save_profile
            // 
            this.btn_save_profile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_save_profile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_save_profile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_save_profile, "btn_save_profile");
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
            this.pnl_contacts.BackColor = System.Drawing.Color.Transparent;
            this.pnl_contacts.Controls.Add(this.btn_delete_contact);
            this.pnl_contacts.Controls.Add(this.pnl_contacts_content);
            this.pnl_contacts.Controls.Add(this.lbl_title_contacts);
            resources.ApplyResources(this.pnl_contacts, "pnl_contacts");
            this.pnl_contacts.Name = "pnl_contacts";
            this.pnl_contacts.VisibleChanged += new System.EventHandler(this.pnl_contacts_VisibleChanged);
            // 
            // btn_delete_contact
            // 
            this.btn_delete_contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_delete_contact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_delete_contact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_delete_contact, "btn_delete_contact");
            this.btn_delete_contact.ForeColor = System.Drawing.Color.White;
            this.btn_delete_contact.Name = "btn_delete_contact";
            this.btn_delete_contact.UseVisualStyleBackColor = false;
            this.btn_delete_contact.Click += new System.EventHandler(this.btn_delete_contact_Click);
            // 
            // pnl_contacts_content
            // 
            this.pnl_contacts_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_contacts_content.Controls.Add(this.btn_save_contact);
            this.pnl_contacts_content.Controls.Add(this.lbl_contact_address);
            this.pnl_contacts_content.Controls.Add(this.lbl_contact_email);
            this.pnl_contacts_content.Controls.Add(this.lbl_contact_phone);
            this.pnl_contacts_content.Controls.Add(this.lbl_contact_lastname);
            this.pnl_contacts_content.Controls.Add(this.lbl_contact_name);
            this.pnl_contacts_content.Controls.Add(this.pnl_contact_email);
            this.pnl_contacts_content.Controls.Add(this.pnl_contact_phone);
            this.pnl_contacts_content.Controls.Add(this.pnl_contact_lastname);
            this.pnl_contacts_content.Controls.Add(this.pnl_contact_name);
            this.pnl_contacts_content.Controls.Add(this.grp_phonebook);
            this.pnl_contacts_content.Controls.Add(this.pnl_contact_address);
            resources.ApplyResources(this.pnl_contacts_content, "pnl_contacts_content");
            this.pnl_contacts_content.ForeColor = System.Drawing.Color.White;
            this.pnl_contacts_content.Name = "pnl_contacts_content";
            // 
            // btn_save_contact
            // 
            this.btn_save_contact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_save_contact.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_save_contact.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_save_contact, "btn_save_contact");
            this.btn_save_contact.Name = "btn_save_contact";
            this.btn_save_contact.UseVisualStyleBackColor = false;
            this.btn_save_contact.Click += new System.EventHandler(this.btn_save_contact_Click);
            // 
            // lbl_contact_address
            // 
            resources.ApplyResources(this.lbl_contact_address, "lbl_contact_address");
            this.lbl_contact_address.Name = "lbl_contact_address";
            // 
            // lbl_contact_email
            // 
            resources.ApplyResources(this.lbl_contact_email, "lbl_contact_email");
            this.lbl_contact_email.Name = "lbl_contact_email";
            // 
            // lbl_contact_phone
            // 
            resources.ApplyResources(this.lbl_contact_phone, "lbl_contact_phone");
            this.lbl_contact_phone.Name = "lbl_contact_phone";
            // 
            // lbl_contact_lastname
            // 
            resources.ApplyResources(this.lbl_contact_lastname, "lbl_contact_lastname");
            this.lbl_contact_lastname.Name = "lbl_contact_lastname";
            // 
            // lbl_contact_name
            // 
            resources.ApplyResources(this.lbl_contact_name, "lbl_contact_name");
            this.lbl_contact_name.Name = "lbl_contact_name";
            // 
            // pnl_contact_email
            // 
            this.pnl_contact_email.BackColor = System.Drawing.Color.White;
            this.pnl_contact_email.Controls.Add(this.txt_contact_email);
            resources.ApplyResources(this.pnl_contact_email, "pnl_contact_email");
            this.pnl_contact_email.Name = "pnl_contact_email";
            // 
            // txt_contact_email
            // 
            this.txt_contact_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_contact_email, "txt_contact_email");
            this.txt_contact_email.Name = "txt_contact_email";
            // 
            // pnl_contact_phone
            // 
            this.pnl_contact_phone.BackColor = System.Drawing.Color.White;
            this.pnl_contact_phone.Controls.Add(this.txt_contact_phone);
            resources.ApplyResources(this.pnl_contact_phone, "pnl_contact_phone");
            this.pnl_contact_phone.Name = "pnl_contact_phone";
            // 
            // txt_contact_phone
            // 
            this.txt_contact_phone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_contact_phone, "txt_contact_phone");
            this.txt_contact_phone.Name = "txt_contact_phone";
            // 
            // pnl_contact_lastname
            // 
            this.pnl_contact_lastname.BackColor = System.Drawing.Color.White;
            this.pnl_contact_lastname.Controls.Add(this.txt_contact_lastname);
            resources.ApplyResources(this.pnl_contact_lastname, "pnl_contact_lastname");
            this.pnl_contact_lastname.Name = "pnl_contact_lastname";
            // 
            // txt_contact_lastname
            // 
            this.txt_contact_lastname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_contact_lastname, "txt_contact_lastname");
            this.txt_contact_lastname.Name = "txt_contact_lastname";
            // 
            // pnl_contact_name
            // 
            this.pnl_contact_name.BackColor = System.Drawing.Color.White;
            this.pnl_contact_name.Controls.Add(this.txt_contact_name);
            resources.ApplyResources(this.pnl_contact_name, "pnl_contact_name");
            this.pnl_contact_name.Name = "pnl_contact_name";
            // 
            // txt_contact_name
            // 
            this.txt_contact_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_contact_name, "txt_contact_name");
            this.txt_contact_name.Name = "txt_contact_name";
            // 
            // grp_phonebook
            // 
            this.grp_phonebook.Controls.Add(this.dgv_phonebook);
            this.grp_phonebook.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.grp_phonebook, "grp_phonebook");
            this.grp_phonebook.Name = "grp_phonebook";
            this.grp_phonebook.TabStop = false;
            // 
            // dgv_phonebook
            // 
            this.dgv_phonebook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_phonebook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_phonebook.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PhoneBook_ID,
            this.PhoneBook_UserEmail,
            this.PhoneBook_Name,
            this.PhoneBook_LastName,
            this.PhoneBook_PhoneNumber,
            this.PhoneBook_Email,
            this.PhoneBook_Address});
            this.dgv_phonebook.ContextMenuStrip = this.context_dgv_phonebook;
            resources.ApplyResources(this.dgv_phonebook, "dgv_phonebook");
            this.dgv_phonebook.Name = "dgv_phonebook";
            this.dgv_phonebook.ReadOnly = true;
            this.dgv_phonebook.RowHeadersVisible = false;
            this.dgv_phonebook.RowTemplate.Height = 30;
            this.dgv_phonebook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_phonebook.SelectionChanged += new System.EventHandler(this.dgv_phonebook_SelectionChanged);
            // 
            // PhoneBook_ID
            // 
            this.PhoneBook_ID.DataPropertyName = "ID";
            resources.ApplyResources(this.PhoneBook_ID, "PhoneBook_ID");
            this.PhoneBook_ID.Name = "PhoneBook_ID";
            this.PhoneBook_ID.ReadOnly = true;
            // 
            // PhoneBook_UserEmail
            // 
            this.PhoneBook_UserEmail.DataPropertyName = "UserEmail";
            resources.ApplyResources(this.PhoneBook_UserEmail, "PhoneBook_UserEmail");
            this.PhoneBook_UserEmail.Name = "PhoneBook_UserEmail";
            this.PhoneBook_UserEmail.ReadOnly = true;
            // 
            // PhoneBook_Name
            // 
            this.PhoneBook_Name.DataPropertyName = "Name";
            resources.ApplyResources(this.PhoneBook_Name, "PhoneBook_Name");
            this.PhoneBook_Name.Name = "PhoneBook_Name";
            this.PhoneBook_Name.ReadOnly = true;
            // 
            // PhoneBook_LastName
            // 
            this.PhoneBook_LastName.DataPropertyName = "LastName";
            resources.ApplyResources(this.PhoneBook_LastName, "PhoneBook_LastName");
            this.PhoneBook_LastName.Name = "PhoneBook_LastName";
            this.PhoneBook_LastName.ReadOnly = true;
            // 
            // PhoneBook_PhoneNumber
            // 
            this.PhoneBook_PhoneNumber.DataPropertyName = "PhoneNumber";
            resources.ApplyResources(this.PhoneBook_PhoneNumber, "PhoneBook_PhoneNumber");
            this.PhoneBook_PhoneNumber.Name = "PhoneBook_PhoneNumber";
            this.PhoneBook_PhoneNumber.ReadOnly = true;
            // 
            // PhoneBook_Email
            // 
            this.PhoneBook_Email.DataPropertyName = "Email";
            resources.ApplyResources(this.PhoneBook_Email, "PhoneBook_Email");
            this.PhoneBook_Email.Name = "PhoneBook_Email";
            this.PhoneBook_Email.ReadOnly = true;
            // 
            // PhoneBook_Address
            // 
            this.PhoneBook_Address.DataPropertyName = "Address";
            resources.ApplyResources(this.PhoneBook_Address, "PhoneBook_Address");
            this.PhoneBook_Address.Name = "PhoneBook_Address";
            this.PhoneBook_Address.ReadOnly = true;
            // 
            // context_dgv_phonebook
            // 
            this.context_dgv_phonebook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearSelectionToolStripMenuItem1});
            this.context_dgv_phonebook.Name = "context_dgv_phonebook";
            resources.ApplyResources(this.context_dgv_phonebook, "context_dgv_phonebook");
            // 
            // clearSelectionToolStripMenuItem1
            // 
            this.clearSelectionToolStripMenuItem1.Name = "clearSelectionToolStripMenuItem1";
            resources.ApplyResources(this.clearSelectionToolStripMenuItem1, "clearSelectionToolStripMenuItem1");
            this.clearSelectionToolStripMenuItem1.Click += new System.EventHandler(this.clearSelectionToolStripMenuItem1_Click);
            // 
            // pnl_contact_address
            // 
            this.pnl_contact_address.BackColor = System.Drawing.Color.White;
            this.pnl_contact_address.Controls.Add(this.txt_contact_address);
            resources.ApplyResources(this.pnl_contact_address, "pnl_contact_address");
            this.pnl_contact_address.Name = "pnl_contact_address";
            // 
            // txt_contact_address
            // 
            this.txt_contact_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_contact_address, "txt_contact_address");
            this.txt_contact_address.Name = "txt_contact_address";
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
            this.pnl_notebook.BackColor = System.Drawing.Color.Transparent;
            this.pnl_notebook.Controls.Add(this.pnl_notebook_content);
            this.pnl_notebook.Controls.Add(this.lbl_title_notebook);
            resources.ApplyResources(this.pnl_notebook, "pnl_notebook");
            this.pnl_notebook.Name = "pnl_notebook";
            this.pnl_notebook.VisibleChanged += new System.EventHandler(this.pnl_notebook_VisibleChanged);
            // 
            // pnl_notebook_content
            // 
            this.pnl_notebook_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_notebook_content.Controls.Add(this.grp_note);
            this.pnl_notebook_content.Controls.Add(this.grp_notebook);
            resources.ApplyResources(this.pnl_notebook_content, "pnl_notebook_content");
            this.pnl_notebook_content.ForeColor = System.Drawing.Color.White;
            this.pnl_notebook_content.Name = "pnl_notebook_content";
            // 
            // grp_note
            // 
            this.grp_note.Controls.Add(this.btn_delete_note);
            this.grp_note.Controls.Add(this.btn_save_note);
            this.grp_note.Controls.Add(this.lbl_note_content);
            this.grp_note.Controls.Add(this.lbl_note_title);
            this.grp_note.Controls.Add(this.pnl_note_content);
            this.grp_note.Controls.Add(this.pnl_note_title);
            this.grp_note.ForeColor = System.Drawing.Color.White;
            resources.ApplyResources(this.grp_note, "grp_note");
            this.grp_note.Name = "grp_note";
            this.grp_note.TabStop = false;
            // 
            // btn_delete_note
            // 
            this.btn_delete_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_delete_note.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_delete_note.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_delete_note, "btn_delete_note");
            this.btn_delete_note.Name = "btn_delete_note";
            this.btn_delete_note.UseVisualStyleBackColor = false;
            this.btn_delete_note.Click += new System.EventHandler(this.btn_delete_note_Click);
            // 
            // btn_save_note
            // 
            this.btn_save_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_save_note.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_save_note.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_save_note, "btn_save_note");
            this.btn_save_note.Name = "btn_save_note";
            this.btn_save_note.UseVisualStyleBackColor = false;
            this.btn_save_note.Click += new System.EventHandler(this.btn_save_note_Click);
            // 
            // lbl_note_content
            // 
            resources.ApplyResources(this.lbl_note_content, "lbl_note_content");
            this.lbl_note_content.Name = "lbl_note_content";
            // 
            // lbl_note_title
            // 
            resources.ApplyResources(this.lbl_note_title, "lbl_note_title");
            this.lbl_note_title.Name = "lbl_note_title";
            // 
            // pnl_note_content
            // 
            this.pnl_note_content.BackColor = System.Drawing.Color.White;
            this.pnl_note_content.Controls.Add(this.txt_note_content);
            this.pnl_note_content.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pnl_note_content, "pnl_note_content");
            this.pnl_note_content.Name = "pnl_note_content";
            // 
            // txt_note_content
            // 
            this.txt_note_content.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_note_content, "txt_note_content");
            this.txt_note_content.Name = "txt_note_content";
            // 
            // pnl_note_title
            // 
            this.pnl_note_title.BackColor = System.Drawing.Color.White;
            this.pnl_note_title.Controls.Add(this.txt_note_title);
            this.pnl_note_title.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.pnl_note_title, "pnl_note_title");
            this.pnl_note_title.Name = "pnl_note_title";
            // 
            // txt_note_title
            // 
            this.txt_note_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_note_title, "txt_note_title");
            this.txt_note_title.Name = "txt_note_title";
            // 
            // grp_notebook
            // 
            this.grp_notebook.Controls.Add(this.dgv_notes);
            resources.ApplyResources(this.grp_notebook, "grp_notebook");
            this.grp_notebook.ForeColor = System.Drawing.Color.Black;
            this.grp_notebook.Name = "grp_notebook";
            this.grp_notebook.TabStop = false;
            // 
            // dgv_notes
            // 
            this.dgv_notes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_notes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_notes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_notes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_ID,
            this.Column_Email,
            this.Column_Title,
            this.Column_Content});
            this.dgv_notes.ContextMenuStrip = this.context_dgv_notebook;
            resources.ApplyResources(this.dgv_notes, "dgv_notes");
            this.dgv_notes.Name = "dgv_notes";
            this.dgv_notes.ReadOnly = true;
            this.dgv_notes.RowHeadersVisible = false;
            this.dgv_notes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgv_notes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_notes.SelectionChanged += new System.EventHandler(this.dgv_notes_SelectionChanged);
            // 
            // Column_ID
            // 
            this.Column_ID.DataPropertyName = "ID";
            resources.ApplyResources(this.Column_ID, "Column_ID");
            this.Column_ID.Name = "Column_ID";
            this.Column_ID.ReadOnly = true;
            // 
            // Column_Email
            // 
            this.Column_Email.DataPropertyName = "UserEmail";
            resources.ApplyResources(this.Column_Email, "Column_Email");
            this.Column_Email.Name = "Column_Email";
            this.Column_Email.ReadOnly = true;
            // 
            // Column_Title
            // 
            this.Column_Title.DataPropertyName = "Title";
            this.Column_Title.FillWeight = 188F;
            resources.ApplyResources(this.Column_Title, "Column_Title");
            this.Column_Title.Name = "Column_Title";
            this.Column_Title.ReadOnly = true;
            // 
            // Column_Content
            // 
            this.Column_Content.DataPropertyName = "Content";
            this.Column_Content.FillWeight = 400F;
            resources.ApplyResources(this.Column_Content, "Column_Content");
            this.Column_Content.Name = "Column_Content";
            this.Column_Content.ReadOnly = true;
            // 
            // context_dgv_notebook
            // 
            resources.ApplyResources(this.context_dgv_notebook, "context_dgv_notebook");
            this.context_dgv_notebook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearSelectionToolStripMenuItem});
            this.context_dgv_notebook.Name = "context_dgv";
            // 
            // clearSelectionToolStripMenuItem
            // 
            this.clearSelectionToolStripMenuItem.Name = "clearSelectionToolStripMenuItem";
            resources.ApplyResources(this.clearSelectionToolStripMenuItem, "clearSelectionToolStripMenuItem");
            this.clearSelectionToolStripMenuItem.Click += new System.EventHandler(this.clearSelectionToolStripMenuItem_Click);
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
            this.pnl_reminder.BackColor = System.Drawing.Color.Transparent;
            this.pnl_reminder.Controls.Add(this.pnl_reminder_content);
            this.pnl_reminder.Controls.Add(this.lbl_title_reminder);
            resources.ApplyResources(this.pnl_reminder, "pnl_reminder");
            this.pnl_reminder.Name = "pnl_reminder";
            this.pnl_reminder.VisibleChanged += new System.EventHandler(this.pnl_reminder_VisibleChanged);
            // 
            // pnl_reminder_content
            // 
            this.pnl_reminder_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_reminder_content.Controls.Add(this.pnl_dgv_reminder);
            this.pnl_reminder_content.Controls.Add(this.btn_delete_reminder);
            this.pnl_reminder_content.Controls.Add(this.btn_save_reminder);
            this.pnl_reminder_content.Controls.Add(this.rb_task);
            this.pnl_reminder_content.Controls.Add(this.rb_meeting);
            this.pnl_reminder_content.Controls.Add(this.lbl_time_end);
            this.pnl_reminder_content.Controls.Add(this.lbl_time_start);
            this.pnl_reminder_content.Controls.Add(this.datePicker2);
            this.pnl_reminder_content.Controls.Add(this.lbl_description);
            this.pnl_reminder_content.Controls.Add(this.lbl_summary);
            this.pnl_reminder_content.Controls.Add(this.txt_reminder_description);
            this.pnl_reminder_content.Controls.Add(this.txt_reminder_summary);
            this.pnl_reminder_content.Controls.Add(this.timePicker2);
            this.pnl_reminder_content.Controls.Add(this.timePicker1);
            this.pnl_reminder_content.Controls.Add(this.datePicker1);
            resources.ApplyResources(this.pnl_reminder_content, "pnl_reminder_content");
            this.pnl_reminder_content.ForeColor = System.Drawing.Color.White;
            this.pnl_reminder_content.Name = "pnl_reminder_content";
            // 
            // pnl_dgv_reminder
            // 
            this.pnl_dgv_reminder.BackColor = System.Drawing.Color.Transparent;
            this.pnl_dgv_reminder.Controls.Add(this.dgv_reminder);
            resources.ApplyResources(this.pnl_dgv_reminder, "pnl_dgv_reminder");
            this.pnl_dgv_reminder.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnl_dgv_reminder.Name = "pnl_dgv_reminder";
            // 
            // dgv_reminder
            // 
            this.dgv_reminder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_reminder.BackgroundColor = System.Drawing.Color.White;
            this.dgv_reminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reminder.ContextMenuStrip = this.context_dgv_reminder;
            resources.ApplyResources(this.dgv_reminder, "dgv_reminder");
            this.dgv_reminder.Name = "dgv_reminder";
            this.dgv_reminder.ReadOnly = true;
            this.dgv_reminder.RowHeadersVisible = false;
            this.dgv_reminder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_reminder.SelectionChanged += new System.EventHandler(this.dgv_reminder_SelectionChanged);
            // 
            // context_dgv_reminder
            // 
            this.context_dgv_reminder.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearSelectionToolStripMenuItem2});
            this.context_dgv_reminder.Name = "context_dgv_reminder";
            resources.ApplyResources(this.context_dgv_reminder, "context_dgv_reminder");
            // 
            // clearSelectionToolStripMenuItem2
            // 
            this.clearSelectionToolStripMenuItem2.Name = "clearSelectionToolStripMenuItem2";
            resources.ApplyResources(this.clearSelectionToolStripMenuItem2, "clearSelectionToolStripMenuItem2");
            this.clearSelectionToolStripMenuItem2.Click += new System.EventHandler(this.clearSelectionToolStripMenuItem2_Click);
            // 
            // btn_delete_reminder
            // 
            this.btn_delete_reminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_delete_reminder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_delete_reminder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_delete_reminder, "btn_delete_reminder");
            this.btn_delete_reminder.Name = "btn_delete_reminder";
            this.btn_delete_reminder.UseVisualStyleBackColor = false;
            this.btn_delete_reminder.Click += new System.EventHandler(this.btn_delete_reminder_Click);
            // 
            // btn_save_reminder
            // 
            this.btn_save_reminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_save_reminder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_save_reminder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_save_reminder, "btn_save_reminder");
            this.btn_save_reminder.Name = "btn_save_reminder";
            this.btn_save_reminder.UseVisualStyleBackColor = false;
            this.btn_save_reminder.Click += new System.EventHandler(this.btn_save_reminder_Click);
            // 
            // rb_task
            // 
            resources.ApplyResources(this.rb_task, "rb_task");
            this.rb_task.Name = "rb_task";
            this.rb_task.UseVisualStyleBackColor = true;
            // 
            // rb_meeting
            // 
            resources.ApplyResources(this.rb_meeting, "rb_meeting");
            this.rb_meeting.Checked = true;
            this.rb_meeting.Name = "rb_meeting";
            this.rb_meeting.TabStop = true;
            this.rb_meeting.UseVisualStyleBackColor = true;
            // 
            // lbl_time_end
            // 
            resources.ApplyResources(this.lbl_time_end, "lbl_time_end");
            this.lbl_time_end.Name = "lbl_time_end";
            // 
            // lbl_time_start
            // 
            resources.ApplyResources(this.lbl_time_start, "lbl_time_start");
            this.lbl_time_start.Name = "lbl_time_start";
            // 
            // datePicker2
            // 
            resources.ApplyResources(this.datePicker2, "datePicker2");
            this.datePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker2.Name = "datePicker2";
            this.datePicker2.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // lbl_description
            // 
            resources.ApplyResources(this.lbl_description, "lbl_description");
            this.lbl_description.Name = "lbl_description";
            // 
            // lbl_summary
            // 
            resources.ApplyResources(this.lbl_summary, "lbl_summary");
            this.lbl_summary.Name = "lbl_summary";
            // 
            // txt_reminder_description
            // 
            resources.ApplyResources(this.txt_reminder_description, "txt_reminder_description");
            this.txt_reminder_description.Name = "txt_reminder_description";
            // 
            // txt_reminder_summary
            // 
            resources.ApplyResources(this.txt_reminder_summary, "txt_reminder_summary");
            this.txt_reminder_summary.Name = "txt_reminder_summary";
            // 
            // timePicker2
            // 
            this.timePicker2.Checked = false;
            resources.ApplyResources(this.timePicker2, "timePicker2");
            this.timePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker2.Name = "timePicker2";
            this.timePicker2.ShowUpDown = true;
            // 
            // timePicker1
            // 
            resources.ApplyResources(this.timePicker1, "timePicker1");
            this.timePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker1.Name = "timePicker1";
            this.timePicker1.ShowUpDown = true;
            // 
            // datePicker1
            // 
            resources.ApplyResources(this.datePicker1, "datePicker1");
            this.datePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker1.Name = "datePicker1";
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
            this.pnl_salary.BackColor = System.Drawing.Color.Transparent;
            this.pnl_salary.Controls.Add(this.pnl_salary_content);
            this.pnl_salary.Controls.Add(this.lbl_title_salary);
            resources.ApplyResources(this.pnl_salary, "pnl_salary");
            this.pnl_salary.Name = "pnl_salary";
            this.pnl_salary.VisibleChanged += new System.EventHandler(this.pnl_salary_VisibleChanged);
            // 
            // pnl_salary_content
            // 
            this.pnl_salary_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            this.pnl_salary_content.Controls.Add(this.grp_family);
            this.pnl_salary_content.Controls.Add(this.pnl_screen);
            this.pnl_salary_content.Controls.Add(this.btn_calculate);
            this.pnl_salary_content.Controls.Add(this.nud_langauge_count);
            this.pnl_salary_content.Controls.Add(this.lbl_language_count);
            this.pnl_salary_content.Controls.Add(this.cmb_duties);
            this.pnl_salary_content.Controls.Add(this.cmb_language);
            this.pnl_salary_content.Controls.Add(this.cmb_education);
            this.pnl_salary_content.Controls.Add(this.cmb_city);
            this.pnl_salary_content.Controls.Add(this.cmb_experience);
            this.pnl_salary_content.Controls.Add(this.lbl_duties);
            this.pnl_salary_content.Controls.Add(this.lbl_language);
            this.pnl_salary_content.Controls.Add(this.lbl_education);
            this.pnl_salary_content.Controls.Add(this.lbl_city);
            this.pnl_salary_content.Controls.Add(this.lbl_experience);
            resources.ApplyResources(this.pnl_salary_content, "pnl_salary_content");
            this.pnl_salary_content.ForeColor = System.Drawing.Color.White;
            this.pnl_salary_content.Name = "pnl_salary_content";
            // 
            // grp_family
            // 
            this.grp_family.BackColor = System.Drawing.Color.Transparent;
            this.grp_family.Controls.Add(this.lbl_18_plus_clause);
            this.grp_family.Controls.Add(this.lbl_family_info);
            this.grp_family.Controls.Add(this.cb_children);
            this.grp_family.Controls.Add(this.grp_children);
            this.grp_family.Controls.Add(this.lbl_spouse_status);
            this.grp_family.Controls.Add(this.grp_spouse);
            this.grp_family.Controls.Add(this.lbl_marital_status);
            this.grp_family.Controls.Add(this.grp_marital_status);
            resources.ApplyResources(this.grp_family, "grp_family");
            this.grp_family.Name = "grp_family";
            this.grp_family.TabStop = false;
            // 
            // lbl_18_plus_clause
            // 
            resources.ApplyResources(this.lbl_18_plus_clause, "lbl_18_plus_clause");
            this.lbl_18_plus_clause.Name = "lbl_18_plus_clause";
            // 
            // lbl_family_info
            // 
            resources.ApplyResources(this.lbl_family_info, "lbl_family_info");
            this.lbl_family_info.Name = "lbl_family_info";
            // 
            // cb_children
            // 
            resources.ApplyResources(this.cb_children, "cb_children");
            this.cb_children.Name = "cb_children";
            this.cb_children.UseVisualStyleBackColor = true;
            this.cb_children.CheckedChanged += new System.EventHandler(this.cb_children_CheckedChanged);
            // 
            // grp_children
            // 
            resources.ApplyResources(this.grp_children, "grp_children");
            this.grp_children.Controls.Add(this.nud_18_plus);
            this.grp_children.Controls.Add(this.lbl_18plus);
            this.grp_children.Controls.Add(this.nud_7_18);
            this.grp_children.Controls.Add(this.lbl_7_18);
            this.grp_children.Controls.Add(this.nud_0_6);
            this.grp_children.Controls.Add(this.lbl_0_6);
            this.grp_children.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grp_children.Name = "grp_children";
            this.grp_children.TabStop = false;
            // 
            // nud_18_plus
            // 
            resources.ApplyResources(this.nud_18_plus, "nud_18_plus");
            this.nud_18_plus.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_18_plus.Name = "nud_18_plus";
            this.nud_18_plus.ReadOnly = true;
            // 
            // lbl_18plus
            // 
            resources.ApplyResources(this.lbl_18plus, "lbl_18plus");
            this.lbl_18plus.Name = "lbl_18plus";
            // 
            // nud_7_18
            // 
            resources.ApplyResources(this.nud_7_18, "nud_7_18");
            this.nud_7_18.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_7_18.Name = "nud_7_18";
            this.nud_7_18.ReadOnly = true;
            // 
            // lbl_7_18
            // 
            resources.ApplyResources(this.lbl_7_18, "lbl_7_18");
            this.lbl_7_18.Name = "lbl_7_18";
            // 
            // nud_0_6
            // 
            resources.ApplyResources(this.nud_0_6, "nud_0_6");
            this.nud_0_6.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_0_6.Name = "nud_0_6";
            this.nud_0_6.ReadOnly = true;
            // 
            // lbl_0_6
            // 
            resources.ApplyResources(this.lbl_0_6, "lbl_0_6");
            this.lbl_0_6.Name = "lbl_0_6";
            // 
            // lbl_spouse_status
            // 
            resources.ApplyResources(this.lbl_spouse_status, "lbl_spouse_status");
            this.lbl_spouse_status.Name = "lbl_spouse_status";
            // 
            // grp_spouse
            // 
            resources.ApplyResources(this.grp_spouse, "grp_spouse");
            this.grp_spouse.Controls.Add(this.rb_working);
            this.grp_spouse.Controls.Add(this.rb_not_working);
            this.grp_spouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grp_spouse.Name = "grp_spouse";
            this.grp_spouse.TabStop = false;
            // 
            // rb_working
            // 
            resources.ApplyResources(this.rb_working, "rb_working");
            this.rb_working.Name = "rb_working";
            this.rb_working.UseVisualStyleBackColor = true;
            // 
            // rb_not_working
            // 
            resources.ApplyResources(this.rb_not_working, "rb_not_working");
            this.rb_not_working.Checked = true;
            this.rb_not_working.Name = "rb_not_working";
            this.rb_not_working.TabStop = true;
            this.rb_not_working.UseVisualStyleBackColor = true;
            // 
            // lbl_marital_status
            // 
            resources.ApplyResources(this.lbl_marital_status, "lbl_marital_status");
            this.lbl_marital_status.Name = "lbl_marital_status";
            // 
            // grp_marital_status
            // 
            resources.ApplyResources(this.grp_marital_status, "grp_marital_status");
            this.grp_marital_status.Controls.Add(this.rb_married);
            this.grp_marital_status.Controls.Add(this.rb_single);
            this.grp_marital_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grp_marital_status.Name = "grp_marital_status";
            this.grp_marital_status.TabStop = false;
            // 
            // rb_married
            // 
            resources.ApplyResources(this.rb_married, "rb_married");
            this.rb_married.Name = "rb_married";
            this.rb_married.UseVisualStyleBackColor = true;
            // 
            // rb_single
            // 
            resources.ApplyResources(this.rb_single, "rb_single");
            this.rb_single.Checked = true;
            this.rb_single.Name = "rb_single";
            this.rb_single.TabStop = true;
            this.rb_single.UseVisualStyleBackColor = true;
            this.rb_single.CheckedChanged += new System.EventHandler(this.rb_single_CheckedChanged);
            // 
            // pnl_screen
            // 
            this.pnl_screen.BackColor = System.Drawing.Color.White;
            this.pnl_screen.Controls.Add(this.label1);
            this.pnl_screen.Controls.Add(this.txt_calculated_salary);
            resources.ApplyResources(this.pnl_screen, "pnl_screen");
            this.pnl_screen.Name = "pnl_screen";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Name = "label1";
            // 
            // txt_calculated_salary
            // 
            this.txt_calculated_salary.BackColor = System.Drawing.Color.White;
            this.txt_calculated_salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txt_calculated_salary, "txt_calculated_salary");
            this.txt_calculated_salary.Name = "txt_calculated_salary";
            // 
            // btn_calculate
            // 
            this.btn_calculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btn_calculate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_calculate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btn_calculate, "btn_calculate");
            this.btn_calculate.Name = "btn_calculate";
            this.btn_calculate.UseVisualStyleBackColor = false;
            this.btn_calculate.Click += new System.EventHandler(this.btn_calculate_Click);
            // 
            // nud_langauge_count
            // 
            resources.ApplyResources(this.nud_langauge_count, "nud_langauge_count");
            this.nud_langauge_count.Maximum = new decimal(new int[] {
            53,
            0,
            0,
            0});
            this.nud_langauge_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_langauge_count.Name = "nud_langauge_count";
            this.nud_langauge_count.ReadOnly = true;
            this.nud_langauge_count.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_language_count
            // 
            resources.ApplyResources(this.lbl_language_count, "lbl_language_count");
            this.lbl_language_count.Name = "lbl_language_count";
            // 
            // cmb_duties
            // 
            this.cmb_duties.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_duties.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_duties, "cmb_duties");
            this.cmb_duties.Name = "cmb_duties";
            // 
            // cmb_language
            // 
            this.cmb_language.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_language.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_language, "cmb_language");
            this.cmb_language.Name = "cmb_language";
            this.cmb_language.SelectedIndexChanged += new System.EventHandler(this.cmb_language_SelectedIndexChanged);
            // 
            // cmb_education
            // 
            this.cmb_education.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_education.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_education, "cmb_education");
            this.cmb_education.Name = "cmb_education";
            // 
            // cmb_city
            // 
            this.cmb_city.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_city.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_city, "cmb_city");
            this.cmb_city.Name = "cmb_city";
            // 
            // cmb_experience
            // 
            this.cmb_experience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_experience.FormattingEnabled = true;
            resources.ApplyResources(this.cmb_experience, "cmb_experience");
            this.cmb_experience.Name = "cmb_experience";
            // 
            // lbl_duties
            // 
            resources.ApplyResources(this.lbl_duties, "lbl_duties");
            this.lbl_duties.Name = "lbl_duties";
            // 
            // lbl_language
            // 
            resources.ApplyResources(this.lbl_language, "lbl_language");
            this.lbl_language.Name = "lbl_language";
            // 
            // lbl_education
            // 
            resources.ApplyResources(this.lbl_education, "lbl_education");
            this.lbl_education.Name = "lbl_education";
            // 
            // lbl_city
            // 
            resources.ApplyResources(this.lbl_city, "lbl_city");
            this.lbl_city.Name = "lbl_city";
            // 
            // lbl_experience
            // 
            resources.ApplyResources(this.lbl_experience, "lbl_experience");
            this.lbl_experience.Name = "lbl_experience";
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
            this.pnl_admin.BackColor = System.Drawing.Color.Transparent;
            this.pnl_admin.Controls.Add(this.pnl_admin_content);
            this.pnl_admin.Controls.Add(this.lbl_title_admin);
            resources.ApplyResources(this.pnl_admin, "pnl_admin");
            this.pnl_admin.Name = "pnl_admin";
            this.pnl_admin.VisibleChanged += new System.EventHandler(this.pnl_admin_VisibleChanged);
            // 
            // pnl_admin_content
            // 
            this.pnl_admin_content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(47)))), ((int)(((byte)(72)))), ((int)(((byte)(88)))));
            resources.ApplyResources(this.pnl_admin_content, "pnl_admin_content");
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
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            resources.ApplyResources(this.ID, "ID");
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // USEREMAIL
            // 
            this.USEREMAIL.DataPropertyName = "UserEmail";
            resources.ApplyResources(this.USEREMAIL, "USEREMAIL");
            this.USEREMAIL.Name = "USEREMAIL";
            this.USEREMAIL.ReadOnly = true;
            // 
            // STARTTIME
            // 
            resources.ApplyResources(this.STARTTIME, "STARTTIME");
            this.STARTTIME.Name = "STARTTIME";
            this.STARTTIME.ReadOnly = true;
            // 
            // ENDTIME
            // 
            resources.ApplyResources(this.ENDTIME, "ENDTIME");
            this.ENDTIME.Name = "ENDTIME";
            this.ENDTIME.ReadOnly = true;
            // 
            // Form_LandingPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinalProject.Properties.Resources.bg_gradient_main;
            this.Controls.Add(this.pnl_reminder);
            this.Controls.Add(this.pnl_contacts);
            this.Controls.Add(this.pnl_notebook);
            this.Controls.Add(this.pnl_profile);
            this.Controls.Add(this.pnl_salary);
            this.Controls.Add(this.pnl_admin);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_header);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_LandingPage";
            this.Load += new System.EventHandler(this.Form_LandingPage_Load);
            this.pnl_header.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_picture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            this.context_avatar.ResumeLayout(false);
            this.pnl_profile.ResumeLayout(false);
            this.pnl_profile_content.ResumeLayout(false);
            this.grp_password.ResumeLayout(false);
            this.grp_password.PerformLayout();
            this.grp_personal_info.ResumeLayout(false);
            this.grp_personal_info.PerformLayout();
            this.pnl_contacts.ResumeLayout(false);
            this.pnl_contacts_content.ResumeLayout(false);
            this.pnl_contacts_content.PerformLayout();
            this.pnl_contact_email.ResumeLayout(false);
            this.pnl_contact_email.PerformLayout();
            this.pnl_contact_phone.ResumeLayout(false);
            this.pnl_contact_phone.PerformLayout();
            this.pnl_contact_lastname.ResumeLayout(false);
            this.pnl_contact_lastname.PerformLayout();
            this.pnl_contact_name.ResumeLayout(false);
            this.pnl_contact_name.PerformLayout();
            this.grp_phonebook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_phonebook)).EndInit();
            this.context_dgv_phonebook.ResumeLayout(false);
            this.pnl_contact_address.ResumeLayout(false);
            this.pnl_contact_address.PerformLayout();
            this.pnl_notebook.ResumeLayout(false);
            this.pnl_notebook_content.ResumeLayout(false);
            this.grp_note.ResumeLayout(false);
            this.grp_note.PerformLayout();
            this.pnl_note_content.ResumeLayout(false);
            this.pnl_note_content.PerformLayout();
            this.pnl_note_title.ResumeLayout(false);
            this.pnl_note_title.PerformLayout();
            this.grp_notebook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_notes)).EndInit();
            this.context_dgv_notebook.ResumeLayout(false);
            this.pnl_reminder.ResumeLayout(false);
            this.pnl_reminder_content.ResumeLayout(false);
            this.pnl_reminder_content.PerformLayout();
            this.pnl_dgv_reminder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reminder)).EndInit();
            this.context_dgv_reminder.ResumeLayout(false);
            this.pnl_salary.ResumeLayout(false);
            this.pnl_salary_content.ResumeLayout(false);
            this.pnl_salary_content.PerformLayout();
            this.grp_family.ResumeLayout(false);
            this.grp_family.PerformLayout();
            this.grp_children.ResumeLayout(false);
            this.grp_children.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_18_plus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_7_18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_0_6)).EndInit();
            this.grp_spouse.ResumeLayout(false);
            this.grp_spouse.PerformLayout();
            this.grp_marital_status.ResumeLayout(false);
            this.grp_marital_status.PerformLayout();
            this.pnl_screen.ResumeLayout(false);
            this.pnl_screen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_langauge_count)).EndInit();
            this.pnl_admin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Button btn_profile;
        private System.Windows.Forms.Button btn_phonebook;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_notebook;
        private System.Windows.Forms.Panel pnl_picture;
        private System.Windows.Forms.Button btn_reminder;
        private System.Windows.Forms.Button btn_salary;
        private System.Windows.Forms.Button btn_admin;
        private System.Windows.Forms.Label lblName;
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
        private System.Windows.Forms.Label lbl_experience;
        private System.Windows.Forms.Label lbl_duties;
        private System.Windows.Forms.Label lbl_language;
        private System.Windows.Forms.Label lbl_education;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.ComboBox cmb_duties;
        private System.Windows.Forms.ComboBox cmb_language;
        private System.Windows.Forms.ComboBox cmb_education;
        private System.Windows.Forms.ComboBox cmb_city;
        private System.Windows.Forms.ComboBox cmb_experience;
        private System.Windows.Forms.Label lbl_language_count;
        private System.Windows.Forms.NumericUpDown nud_langauge_count;
        private System.Windows.Forms.Panel pnl_screen;
        private System.Windows.Forms.TextBox txt_calculated_salary;
        private System.Windows.Forms.Button btn_calculate;
        private System.Windows.Forms.Label lbl_salary;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.MaskedTextBox txt_phone_number;
        private System.Windows.Forms.GroupBox grp_family;
        private System.Windows.Forms.Label lbl_marital_status;
        private System.Windows.Forms.GroupBox grp_marital_status;
        private System.Windows.Forms.RadioButton rb_married;
        private System.Windows.Forms.RadioButton rb_single;
        private System.Windows.Forms.Label lbl_spouse_status;
        private System.Windows.Forms.GroupBox grp_spouse;
        private System.Windows.Forms.RadioButton rb_working;
        private System.Windows.Forms.RadioButton rb_not_working;
        private System.Windows.Forms.Label lbl_family_info;
        private System.Windows.Forms.CheckBox cb_children;
        private System.Windows.Forms.GroupBox grp_children;
        private System.Windows.Forms.NumericUpDown nud_0_6;
        private System.Windows.Forms.Label lbl_0_6;
        private System.Windows.Forms.NumericUpDown nud_18_plus;
        private System.Windows.Forms.Label lbl_18plus;
        private System.Windows.Forms.NumericUpDown nud_7_18;
        private System.Windows.Forms.Label lbl_7_18;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_18_plus_clause;
        private System.Windows.Forms.GroupBox grp_note;
        private System.Windows.Forms.GroupBox grp_notebook;
        private System.Windows.Forms.DataGridView dgv_notes;
        private System.Windows.Forms.Panel pnl_note_content;
        private System.Windows.Forms.Panel pnl_note_title;
        private System.Windows.Forms.TextBox txt_note_title;
        private System.Windows.Forms.Label lbl_note_content;
        private System.Windows.Forms.Label lbl_note_title;
        private System.Windows.Forms.Button btn_delete_note;
        private System.Windows.Forms.Button btn_save_note;
        private System.Windows.Forms.ContextMenuStrip context_dgv_notebook;
        private System.Windows.Forms.ToolStripMenuItem clearSelectionToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_note_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Content;
        private System.Windows.Forms.GroupBox grp_phonebook;
        private System.Windows.Forms.DataGridView dgv_phonebook;
        private System.Windows.Forms.MaskedTextBox txt_contact_phone;
        private System.Windows.Forms.TextBox txt_contact_name;
        private System.Windows.Forms.Panel pnl_contact_address;
        private System.Windows.Forms.TextBox txt_contact_address;
        private System.Windows.Forms.Panel pnl_contact_email;
        private System.Windows.Forms.TextBox txt_contact_email;
        private System.Windows.Forms.Panel pnl_contact_phone;
        private System.Windows.Forms.Panel pnl_contact_lastname;
        private System.Windows.Forms.TextBox txt_contact_lastname;
        private System.Windows.Forms.Panel pnl_contact_name;
        private System.Windows.Forms.Label lbl_contact_email;
        private System.Windows.Forms.Label lbl_contact_phone;
        private System.Windows.Forms.Label lbl_contact_lastname;
        private System.Windows.Forms.Label lbl_contact_name;
        private System.Windows.Forms.Label lbl_contact_address;
        private System.Windows.Forms.Button btn_delete_contact;
        private System.Windows.Forms.Button btn_save_contact;
        private System.Windows.Forms.ContextMenuStrip context_dgv_phonebook;
        private System.Windows.Forms.ToolStripMenuItem clearSelectionToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneBook_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneBook_UserEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneBook_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneBook_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneBook_PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneBook_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneBook_Address;
        private System.Windows.Forms.DateTimePicker datePicker1;
        private System.Windows.Forms.DateTimePicker timePicker1;
        private System.Windows.Forms.DateTimePicker timePicker2;
        private System.Windows.Forms.TextBox txt_reminder_description;
        private System.Windows.Forms.TextBox txt_reminder_summary;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_summary;
        private System.Windows.Forms.Label lbl_time_end;
        private System.Windows.Forms.Label lbl_time_start;
        private System.Windows.Forms.DateTimePicker datePicker2;
        private System.Windows.Forms.Button btn_save_reminder;
        private System.Windows.Forms.RadioButton rb_task;
        private System.Windows.Forms.RadioButton rb_meeting;
        private System.Windows.Forms.Button btn_delete_reminder;
        private System.Windows.Forms.DataGridView dgv_reminder;
        private System.Windows.Forms.Panel pnl_dgv_reminder;
        private System.Windows.Forms.ContextMenuStrip context_dgv_reminder;
        private System.Windows.Forms.ToolStripMenuItem clearSelectionToolStripMenuItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn USEREMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn STARTTIME;
        private System.Windows.Forms.DataGridViewTextBoxColumn ENDTIME;
        private System.Windows.Forms.PictureBox pb_avatar;
        private System.Windows.Forms.ContextMenuStrip context_avatar;
        private System.Windows.Forms.ToolStripMenuItem tsm_change;
        private System.Windows.Forms.ToolStripMenuItem tsm_remove;
    }
}