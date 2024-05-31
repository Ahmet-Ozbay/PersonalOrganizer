using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace FinalProject
{
    public partial class Form_LandingPage : Form
    {
#pragma warning disable S1104 // Fields should not have public accessibility
        public Point mouse_location; // Necessary for dragging the window around
#pragma warning restore S1104 // Fields should not have public accessibility

        // This reduces flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x2000000;
                return cp;
            }
        }

        // Color Palette
        Color blue = Color.FromArgb(165, 84, 154);
        Color light_blue = Color.FromArgb(0, 113, 205);
        Color purple = Color.FromArgb(255, 84, 94);
        Color navy = Color.FromArgb(100, 47, 72, 88);

        // Constructor
        public Form_LandingPage()
        {
            InitializeComponent();
            InitializeDataGridView();
            this.Load += Form_LandingPage_Load;
        }

        /*
         * Load event for the form
         */
        private void Form_LandingPage_Load(object sender, EventArgs e)
        {
            // User Profile
            Read_user_data();
            lblName.Text = this.current_user.Name + ' ' + this.current_user.LastName;

            // Notebook
            notebook = new NoteBook(new CsvRepository());
            LoadNotes();

            // Phonebook
            phonebook = new PhoneBook(new CsvRepository(), current_user);
            LoadContacts();

            // Reminder
            IReminderFactory reminder_factory = new ReminderFactory();
            reminder_manager = new ReminderManager(new CsvRepository(reminder_factory), reminder_factory);
            LoadReminders();

            // Salary Calculator
            cmb_experience.DataSource = experience.Keys.ToList();
            cmb_city.DataSource = city.Keys.ToList();
            cmb_education.DataSource = education.Keys.ToList();
            cmb_language.DataSource = language.Keys.ToList();
            cmb_duties.DataSource = duties.Keys.ToList();
        }

        private string default_mail_extension = "@gmail.com";
        private User current_user;
        private NoteBook notebook;
        private PhoneBook phonebook;
        private ReminderManager reminder_manager;
        private BindingList<IReminder> reminderBindingList;

        private Dictionary<string, double> experience = new Dictionary<string, double>
        {
            {"Less than 2 years", 0.0 },
            {"2-4",0.60},
            {"5-9",0.80},
            {"10-14",1.20},
            {"15-20",1.35},
            {"20+",1.50}
        };

        private Dictionary<string, double> city = new Dictionary<string, double>
        {
            {"TR10: Istanbul", 0.30},
            {"TR51: Ankara", 0.20},
            {"TR31: Izmir", 0.20},
            {"TR42: Kocaeli, Sakarya, Düzce, Bolu, Yalova", 0.10},
            {"TR21: Edirne, Kırklareli, Tekirdağ", 0.10},
            {"TR90: Trabzon, Ordu, Giresun, Rize, Artvin", 0.5},
            {"TR41: Bursa, Eskişehir, Bilecik", 0.5},
            {"TR32: Aydın, Denizli, Muğla", 0.5},
            {"TR62: Adana, Mersin", 0.5},
            {"TR22: Balıkesir, Çanakkale", 0.5},
            {"TR61: Antalya, Isparta, Burdur", 0.5},
            {"Other", 0}
        };

        private Dictionary<string, double> education = new Dictionary<string, double>
        {
            {"Only CENG Bachelor's Degree", 0.0},
            {"Field Related Master's Degree",0.10},
            {"Field Related Doctorate Degree",0.30},
            {"Field Related Assoc. Doc. Degree",0.35},
            {"Field Unrelated Master's Degree",0.05},
            {"Field Unrelated Doctorate Degree",0.15}
        };

        private Dictionary<string, double> language = new Dictionary<string, double>
        {
            {"No Secondary Language", 0},
            {"English Certificate",0.20},
            {"English School Graduation",0.20},
            {"Other Language Certificate(s)",0.05}

        };

        private Dictionary<string, double> duties = new Dictionary<string, double>
        {
            {"No Administrative Duties", 0.0 },
            {"Team Leader/Technical Manager",0.50},
            {"Project Manager",0.75},
            {"Director",0.85},
            {"CTO",1.00},
            {"IT Officer/Manager (Employee <= 5)",0.40},
            {"IT Officer/Manager (Employee > 5)",0.60}
        };


        /*
         * Reads user data from the database to fill the profile page
         */
        private void Read_user_data()
        {
            CsvRepository reader = new CsvRepository();
            string email = Form_SignIn_SignUp.e_mail;
            List<User> users = reader.List();
            current_user = users.FirstOrDefault(u => u.Email == email);
            if (current_user != null)
            {
                txt_name.Text = current_user.Name;
                txt_lastname.Text = current_user.LastName;
                txt_email.Text = current_user.Email;
                txt_phone_number.Text = current_user.PhoneNumber;
                txt_adress.Text = current_user.Address;
                txt_salary.Text = current_user.Salary.ToString();
            }
        }

        /*
         * Loads notes of the current user
         */
        private void LoadNotes()
        {
            var notes = notebook.List(current_user.Email);
            dgv_notes.DataSource = notes;
        }

        /*
         * Loads contacts of the current user
         */
        private void LoadContacts()
        {
            var contacts = phonebook.List(current_user.Email);
            dgv_phonebook.DataSource = contacts;
        }

        /*
        * Loads contacts of the current user
        */

        private void LoadReminders()
        {
            var reminders = reminder_manager.ListReminders(current_user.Email);
            reminderBindingList = new BindingList<IReminder>(reminders);
            dgv_reminder.DataSource = reminderBindingList;
        }

        //
        // Close Button
        //
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Form_SignIn_SignUp.form_signIn_signUp.Close();
        }
        private void btn_close_MouseEnter(object sender, EventArgs e)
        {
            btn_close.FlatAppearance.MouseOverBackColor = blue;

        }
        private void btn_close_MouseDown(object sender, MouseEventArgs e)
        {
            btn_close.BackColor = purple;
        }
        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.BackColor = Color.Transparent;
        } //end - Close button

        //
        // Minimize Button
        //
        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void btn_minimize_MouseEnter(object sender, EventArgs e)
        {
            btn_minimize.FlatAppearance.MouseOverBackColor = blue;

        }
        private void btn_minimize_MouseDown(object sender, MouseEventArgs e)
        {
            btn_minimize.BackColor = purple;
        }
        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_minimize.BackColor = Color.Transparent;
        } //end - Minimize button

        //
        // Title Bar
        //
        private void pnl_header_MouseDown(object sender, MouseEventArgs e)
        {
            mouse_location = new Point(-e.X, -e.Y);
        }
        private void pnl_header_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mouse_pose = Control.MousePosition;
                mouse_pose.Offset(mouse_location.X, mouse_location.Y);
                Location = mouse_pose;
            }
        } // end - Title Bar

        // 
        // Header Clock
        //
        private void timer_Tick(object sender, EventArgs e)
        {
            lbl_header.Text = DateTime.UtcNow.ToLocalTime().ToString("M MMMM dddd | HH:mm:ss");
        }

        //
        // Menu Buttons
        //
        // Profile Button
        private void btn_profile_MouseEnter(object sender, EventArgs e)
        {
            btn_profile.FlatAppearance.MouseOverBackColor = light_blue;
        }
        private void btn_profile_MouseDown(object sender, MouseEventArgs e)
        {
            btn_profile.FlatAppearance.MouseDownBackColor = purple;
        }
        // Phonebook Button
        private void btn_phonebook_MouseEnter(object sender, EventArgs e)
        {
            btn_phonebook.FlatAppearance.MouseOverBackColor = light_blue;
        }
        private void btn_phonebook_MouseDown(object sender, MouseEventArgs e)
        {
            btn_phonebook.FlatAppearance.MouseDownBackColor = purple;
        }
        // Notebook Button
        private void btn_notebook_MouseEnter(object sender, EventArgs e)
        {
            btn_notebook.FlatAppearance.MouseOverBackColor = light_blue;
        }
        private void btn_notebook_MouseDown(object sender, MouseEventArgs e)
        {
            btn_notebook.FlatAppearance.MouseDownBackColor = purple;
        }
        // Reminder Button
        private void btn_reminder_MouseEnter(object sender, EventArgs e)
        {
            btn_reminder.FlatAppearance.MouseOverBackColor = light_blue;
        }
        private void btn_reminder_MouseDown(object sender, MouseEventArgs e)
        {
            btn_reminder.FlatAppearance.MouseDownBackColor = purple;
        }
        // Salary Button
        private void btn_salary_MouseEnter(object sender, EventArgs e)
        {
            btn_salary.FlatAppearance.MouseOverBackColor = light_blue;
        }
        private void btn_salary_MouseDown(object sender, MouseEventArgs e)
        {
            btn_salary.FlatAppearance.MouseDownBackColor = purple;
        }
        // Admin Button
        private void btn_admin_MouseEnter(object sender, EventArgs e)
        {
            btn_admin.FlatAppearance.MouseOverBackColor = light_blue;
        }
        private void btn_admin_MouseDown(object sender, MouseEventArgs e)
        {
            btn_admin.FlatAppearance.MouseDownBackColor = purple;
        }

        //
        // Profile Panel
        //
        private void pnl_profile_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_profile.Visible)
            {
                btn_profile.BackColor = blue;
                this.AcceptButton = btn_save_profile;
            }
            else
            {
                btn_profile.BackColor = navy;
                this.AcceptButton = null;
            }
        }
        private void btn_profile_Click(object sender, EventArgs e)
        {
            pnl_profile.Visible = true;
            pnl_contacts.Visible = false;
            pnl_notebook.Visible = false;
            pnl_reminder.Visible = false;
            pnl_salary.Visible = false;
            pnl_admin.Visible = false;
        }
        // Save Profile Button
        private void btn_save_profile_MouseEnter(object sender, EventArgs e)
        {
            btn_save_profile.FlatAppearance.MouseOverBackColor = light_blue;
        }
        private void btn_save_profile_MouseDown(object sender, MouseEventArgs e)
        {
            btn_save_profile.FlatAppearance.MouseDownBackColor = purple;
        }
        // Change Password Button
        private void btn_change_password_MouseEnter(object sender, EventArgs e)
        {
            btn_save_profile.FlatAppearance.MouseOverBackColor = light_blue;
        }
        private void btn_change_password_MouseDown(object sender, MouseEventArgs e)
        {
            btn_change_password.FlatAppearance.MouseDownBackColor = purple;
        } // end - Save & Change buttons

        // Show / Hide Password Buttons
        private void btn_see_password_current_MouseDown(object sender, MouseEventArgs e)
        {
            txt_current_password.PasswordChar = '\0';
            btn_see_password_current.BackgroundImage = global::FinalProject.Properties.Resources.btn_hide_password;

        }
        private void btn_see_password_current_MouseUp(object sender, MouseEventArgs e)
        {
            txt_current_password.PasswordChar = '*';
            btn_see_password_current.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
        }
        private void btn_see_password_new_MouseDown(object sender, MouseEventArgs e)
        {
            txt_new_password.PasswordChar = '\0';
            btn_see_password_new.BackgroundImage = global::FinalProject.Properties.Resources.btn_hide_password;

        }
        private void btn_see_password_new_MouseUp(object sender, MouseEventArgs e)
        {
            txt_new_password.PasswordChar = '*';
            btn_see_password_new.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
        }
        private void btn_see_password_new_confirm_MouseDown(object sender, MouseEventArgs e)
        {
            txt_confirm_new_password.PasswordChar = '\0';
            btn_see_password_new_confirm.BackgroundImage = global::FinalProject.Properties.Resources.btn_hide_password;

        }
        private void btn_see_password_new_confirm_MouseUp(object sender, MouseEventArgs e)
        {
            txt_current_password.PasswordChar = '*';
            btn_see_password_new_confirm.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
        } // end - Show / Hide Password Buttons

        //
        // Contacts Panel
        //
        private void pnl_contacts_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_contacts.Visible)
            {
                btn_phonebook.BackColor = blue;
                this.AcceptButton = btn_save_contact;
                dgv_phonebook.ClearSelection();
                ClearContactFields();
            }
            else
            {
                btn_phonebook.BackColor = navy;
                this.AcceptButton = null;
            }
        }

        private void btn_phonebook_Click(object sender, EventArgs e)
        {
            pnl_profile.Visible = false;
            pnl_contacts.Visible = true;
            pnl_notebook.Visible = false;
            pnl_reminder.Visible = false;
            pnl_salary.Visible = false;
            pnl_admin.Visible = false;
        }

        //
        // Notebook Panel
        //
        private void pnl_notebook_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_notebook.Visible)
            {
                btn_notebook.BackColor = blue;
                this.AcceptButton = btn_save_note;
            }
            else
            {
                btn_notebook.BackColor = navy;
                this.AcceptButton = null;
            }
        }

        private void btn_notebook_Click(object sender, EventArgs e)
        {
            pnl_profile.Visible = false;
            pnl_contacts.Visible = false;
            pnl_notebook.Visible = true;
            pnl_reminder.Visible = false;
            pnl_salary.Visible = false;
            pnl_admin.Visible = false;
            dgv_notes.ClearSelection();
            ClearNoteFields();
        }

        //
        // Reminder Panel
        //
        private void pnl_reminder_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_reminder.Visible)
            {
                btn_reminder.BackColor = blue;
                this.AcceptButton = btn_save_reminder;
            }
            else
            {
                btn_reminder.BackColor = navy;
            }
        }

        private void btn_reminder_Click(object sender, EventArgs e)
        {
            pnl_profile.Visible = false;
            pnl_contacts.Visible = false;
            pnl_notebook.Visible = false;
            pnl_reminder.Visible = true;
            pnl_salary.Visible = false;
            pnl_admin.Visible = false;

            DateTime today = DateTime.Today;
            datePicker2.Value = today.AddDays(1);
            dgv_reminder.ClearSelection();
            ClearReminderFields();
        }

        //
        // Salary Calculator Panel
        //
        private void pnl_salary_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_salary.Visible)
            {
                btn_salary.BackColor = blue;
                this.AcceptButton = btn_calculate;
            }
            else
            {
                btn_salary.BackColor = navy;
                this.AcceptButton = null;
            }
        }
        private void btn_salary_Click(object sender, EventArgs e)
        {
            pnl_profile.Visible = false;
            pnl_contacts.Visible = false;
            pnl_notebook.Visible = false;
            pnl_reminder.Visible = false;
            pnl_salary.Visible = true;
            pnl_admin.Visible = false;
        }
        private void rb_single_CheckedChanged(object sender, EventArgs e)
        {
            if (!rb_single.Checked)
            {
                grp_spouse.Enabled = true;
            }
            else
            {
                grp_spouse.Enabled = false;
            }

        }
        private void cb_children_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_children.Checked)
            {
                grp_children.Enabled = true;
            }
            else
            {
                grp_children.Enabled = false;
                nud_0_6.Value = 0;
                nud_7_18.Value = 0;
                nud_18_plus.Value = 0;
            }
        }

        //
        // Admin Panel
        // 
        private void pnl_admin_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_admin.Visible)
            {
                btn_admin.BackColor = blue;
            }
            else
            {
                btn_admin.BackColor = navy;
            }

        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            pnl_profile.Visible = false;
            pnl_contacts.Visible = false;
            pnl_notebook.Visible = false;
            pnl_reminder.Visible = false;
            pnl_salary.Visible = false;
            pnl_admin.Visible = true;
        }


        /*
         * Checks if the input is an actual email adress.
         */
        private bool IsValidEmail(string email)
        {
            string pattern = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(email, pattern);
        }
        /*
         * Checks if the new password matches requirements.
         */
        public static bool IsValidString(string input)
        {
            string pattern = "^(?=.*[A-Z])(?=.*[!@#$*%^&(),.?\":{}|<>]).{8,}$";
            return Regex.IsMatch(input, pattern);
        }

        //
        // Save profile button click event
        //
        private void btn_save_profile_Click(object sender, EventArgs e)
        {
            if (!IsValidEmail(txt_email.Text))
            {
                string title = "Invalid Email";
                string message = "Please make sure that you enter a correct email adress.";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txt_email.Text.Length == 0 || txt_adress.Text.Length == 0 || !txt_phone_number.MaskCompleted)
            {
                string title = "Error";
                string message = "Please fill in all the fields.";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CsvRepository writer = new CsvRepository();
            CsvRepository reader = new CsvRepository();

            string name = txt_name.Text;
            string lastname = txt_lastname.Text;
            string email = txt_email.Text;
            string phone = txt_phone_number.Text;
            string address = txt_adress.Text;

            List<User> users = reader.List();
            User current_user = users.FirstOrDefault(u => u.Email == email);
            if (current_user != null)
            {
                current_user.Name = name;
                current_user.LastName = lastname;
                current_user.Email = email;
                current_user.PhoneNumber = phone;
                current_user.Address = address;
                writer.Update(current_user);
                Read_user_data();
                lblName.Text = current_user.Name + " " + current_user.LastName;
                string title = "Success";
                string message = "Your profile has been updated successfully.";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //
        // Change password button click event
        //
        private void btn_change_password_Click(object sender, EventArgs e)
        {
            if (txt_current_password.Text.Length == 0 || txt_new_password.Text.Length == 0 ||
                txt_confirm_new_password.Text.Length == 0)
            {
                string title = "Error";
                string message = "Please fill in all the fields.";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CsvRepository writer = new CsvRepository();
            CsvRepository reader = new CsvRepository();

            string current_password = txt_current_password.Text;
            string new_password = txt_new_password.Text;
            string confirm_new_password = txt_confirm_new_password.Text;

            if (new_password != confirm_new_password)
            {
                string title = "Error";
                string message = "Passwords do not match.";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<User> users = reader.List();
            User current_user = users.FirstOrDefault(u => u.Email == txt_email.Text);

            if (current_user != null)
            {
                if (current_user.Password == current_password)
                {
                    if (IsValidString(new_password))
                    {
                        current_user.Password = new_password;
                        writer.Update(current_user);
                        string title = "Success";
                        string message = "Your password has been changed successfully.";
                        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string title = "Error";
                        string message = "Password must contain at least 8 characters, one uppercase letter and one special character.";
                        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    string title = "Error";
                    string message = "Current password is incorrect.";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }


        //
        // Salary Calculation
        //
        private void cmb_language_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_language_count.Visible = nud_langauge_count.Visible = (cmb_language.SelectedIndex == 3);
        }

        //
        // Calculates salary according to the coefficients
        //
        private double CalculateSalary()
        {
            double coefficient = 0;
            double base_salary = 26828;

            coefficient += experience[cmb_experience.SelectedItem.ToString()];
            coefficient += city[cmb_city.SelectedItem.ToString()];
            coefficient += education[cmb_education.SelectedItem.ToString()];
            coefficient += language[cmb_language.SelectedItem.ToString()];
            coefficient += duties[cmb_duties.SelectedItem.ToString()];

            double family_coefficient = 0;
            if (rb_married.Checked)
            {
                if (rb_not_working.Checked)
                {
                    family_coefficient += 0.20;
                }
            }

            if (cb_children.Checked)
            {
                coefficient += CalculateSalaryCoefficient(Convert.ToInt32(nud_0_6.Value),
                                                          Convert.ToInt32(nud_7_18.Value),
                                                          Convert.ToInt32(nud_18_plus.Value));
            }


            return base_salary * (coefficient + 1);
        }

        // 
        // Calculates coefficient for the children
        //
        public double CalculateSalaryCoefficient(int nud_0_6, int nud_7_18, int nud_18_plus)
        {
            // Initialize coefficients
            double coefficient_0_6 = 0.20;
            double coefficient_7_18 = 0.30;
            double coefficient_18_plus = 0.40;

            // Initialize the total coefficient
            double totalCoefficient = 0;

            // Check for children 18+ first since they have the highest priority
            if (nud_18_plus > 0)
            {
                int count = Math.Min(nud_18_plus, 2); // Can only offer money up to 2 children
                totalCoefficient += count * coefficient_18_plus;
            }

            // If less than 2 children 18+ were counted, check for children 7-18
            if (nud_18_plus < 2 && nud_7_18 > 0)
            {
                int remainingSlots = 2 - nud_18_plus; // Remaining slots after counting children 18+
                int count = Math.Min(nud_7_18, remainingSlots);
                totalCoefficient += count * coefficient_7_18;
            }

            // If there are still slots available after counting older children, count children 0-6
            if (nud_18_plus + nud_7_18 < 2 && nud_0_6 > 0)
            {
                int remainingSlots = 2 - (nud_18_plus + nud_7_18); // Remaining slots after counting older children
                int count = Math.Min(nud_0_6, remainingSlots);
                totalCoefficient += count * coefficient_0_6;
            }

            return totalCoefficient;
        }

        //
        // Calculate salary button click event
        //
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            txt_calculated_salary.Text = "₺" + CalculateSalary().ToString();
            this.current_user.Salary = CalculateSalary();

            if(current_user.Authorisation == Authority.Part_Time_User)
            {
                current_user.Salary /= 2;
                txt_calculated_salary.Text = "₺" + ( CalculateSalary() / 2 ).ToString();
            }

            CsvRepository updater = new CsvRepository();
            updater.Update(this.current_user);
            Read_user_data();
        }

        //
        // Automatically fill @gmail.com in the email field
        //
        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Check if the '@' sign is not already present in the TextBox
            if (!txt_email.Text.Contains("@") && e.KeyChar == '@')
            {
                // Insert the '@' sign and a default domain
                txt_email.Text += default_mail_extension;

                // Move the cursor before the domain for user convenience
                txt_email.SelectionStart = txt_email.Text.IndexOf("@");

                // Prevent further processing of the '@' key press
                e.Handled = true;
            }
        }

        //
        // Save & Update Notes Button
        //
        private void btn_save_note_Click(object sender, EventArgs e)
        {
            // If there's exactly one row selected, proceed with the update.
            if (dgv_notes.SelectedRows.Count == 1)
            {
                var selected_note = (Note)dgv_notes.SelectedRows[0].DataBoundItem;
                selected_note.Title = txt_note_title.Text;
                selected_note.Content = txt_note_content.Text;

                if (notebook.Update(selected_note))
                {
                    LoadNotes();
                    ClearNoteFields();
                    MessageBox.Show("Note updated successfully.");
                    dgv_notes.ClearSelection();
                }
                else
                {
                    MessageBox.Show("There was an error updating the note.");
                }
            }
            else if (dgv_notes.SelectedRows.Count == 0)
            {
                // No note is selected, so create a new note.
                var newNote = new Note
                {
                    Title = txt_note_title.Text,
                    Content = txt_note_content.Text
                };

                if (notebook.Add(newNote, current_user.Email))
                {
                    LoadNotes();
                    ClearNoteFields();
                    MessageBox.Show("Note added successfully.");
                    dgv_notes.ClearSelection();
                }
                else
                {
                    MessageBox.Show("There was an error adding the note.");
                }
            }
            else
            {
                // More than one note is selected, which is not allowed for updating.
                MessageBox.Show("Please select only one note to update.");
            }
        }

        //
        // Auxillary function to clear note fields
        //
        private void ClearNoteFields()
        {
            txt_note_title.Clear();
            txt_note_content.Clear();
        }

        //
        // Auxillary function to clear contact fields
        //
        private void ClearContactFields()
        {
            txt_contact_name.Clear();
            txt_contact_lastname.Clear();
            txt_contact_phone.Clear();
            txt_contact_email.Clear();
            txt_contact_address.Clear();
        }
        private void ClearReminderFields()
        {
            txt_reminder_summary.Clear();
            txt_reminder_description.Clear();
            datePicker1.Value = DateTime.Now;
            timePicker1.Value = DateTime.Now;
            datePicker2.Value = DateTime.Now;
            timePicker2.Value = DateTime.Now;
            rb_meeting.Checked = true;
            rb_task.Checked = false;
        }

        private void dgv_notes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_notes.SelectedRows.Count > 0)
            {
                var selected_note = (Note)dgv_notes.SelectedRows[0].DataBoundItem;
                txt_note_title.Text = UnescapeFromCsv(selected_note.Title);

                string decodedContent = selected_note.Content;
                try
                {
                    // Try to set the Rtf property.
                    txt_note_content.Text = decodedContent;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error displaying note content: " + ex.Message);
                }
            }
        }

        private void btn_delete_note_Click(object sender, EventArgs e)
        {
            if (dgv_notes.SelectedRows.Count > 0)
            {
                // Ask the user to confirm the deletion.
                var confirmResult = MessageBox.Show("Are you sure you want to delete the selected notes? This action cannot be undone.",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    ClearNoteFields();
                    // If the user confirmed, delete the notes.
                    var notesToDelete = new List<Note>();
                    foreach (DataGridViewRow row in dgv_notes.SelectedRows)
                    {
                        notesToDelete.Add((Note)row.DataBoundItem);
                    }

                    foreach (var note in notesToDelete)
                    {
                        notebook.Delete(note);
                    }

                    LoadNotes();
                    MessageBox.Show("Selected notes deleted successfully.");
                }
                // If the user clicked 'No', do nothing.
            }
            else
            {
                MessageBox.Show("Please select at least one note to delete.");
            }
        }

        private void clearSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgv_notes.ClearSelection();
            ClearNoteFields();
        }
        private string UnescapeFromCsv(string input)
        {
            if (input.StartsWith("\"") && input.EndsWith("\""))
            {
                return input.Substring(1, input.Length - 2).Replace("\"\"", "\"");
            }
            else
            {
                return input;
            }
        }

        private void btn_save_contact_Click(object sender, EventArgs e)
        {
            // Check if we're updating an existing contact or adding a new one
            if (dgv_phonebook.SelectedRows.Count == 1)
            {
                // Update existing contact
                var selectedContact = (Contact)dgv_phonebook.SelectedRows[0].DataBoundItem;
                selectedContact.Name = txt_contact_name.Text;
                selectedContact.LastName = txt_contact_lastname.Text;
                selectedContact.PhoneNumber = ExtractDigits(txt_contact_phone.Text);
                selectedContact.Email = txt_contact_email.Text;
                selectedContact.Address = txt_contact_address.Text;

                if (phonebook.Update(selectedContact))
                {
                    LoadContacts(); // Refresh the DataGridView
                    MessageBox.Show("Contact updated successfully.");
                    dgv_phonebook.ClearSelection();
                    ClearContactFields();
                }
                else
                {
                    MessageBox.Show("There was an error updating the contact.");
                }
            }
            else
            {
                // Add new contact
                var newContact = new Contact
                {
                    Name = txt_contact_name.Text,
                    LastName = txt_contact_lastname.Text,
                    PhoneNumber = ExtractDigits(txt_contact_phone.Text),
                    Email = txt_contact_email.Text,
                    Address = txt_contact_address.Text,
                    UserEmail = current_user.Email // Set the UserEmail to the current user's email
                };

                if (phonebook.Add(newContact, current_user.Email))
                {
                    LoadContacts(); // Refresh the DataGridView
                    MessageBox.Show("Contact added successfully.");
                    dgv_phonebook.ClearSelection();
                    ClearContactFields();
                }
                else
                {
                    MessageBox.Show("There was an error adding the contact.");
                }
            }
        }

        private void btn_delete_contact_Click(object sender, EventArgs e)
        {
            if (dgv_phonebook.SelectedRows.Count > 0)
            {
                // Ask the user to confirm the deletion.
                var confirmResult = MessageBox.Show("Are you sure you want to delete the selected contacts? This action cannot be undone.",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    // If the user confirmed, delete the contacts.
                    var contactsToDelete = new List<Contact>();
                    foreach (DataGridViewRow row in dgv_phonebook.SelectedRows)
                    {
                        contactsToDelete.Add((Contact)row.DataBoundItem);
                    }

                    foreach (var contact in contactsToDelete)
                    {
                        phonebook.Delete(contact);
                    }

                    LoadContacts(); // Refresh the DataGridView
                    MessageBox.Show("Selected contacts deleted successfully.");
                }
                // If the user clicked 'No', do nothing.
            }
            else
            {
                MessageBox.Show("Please select at least one contact to delete.");
            }
        }

        private void dgv_phonebook_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_phonebook.SelectedRows.Count > 0)
            {
                var selectedContact = (Contact)dgv_phonebook.SelectedRows[0].DataBoundItem;
                if (selectedContact != null) // Check if the selected contact is not null
                {
                    txt_contact_name.Text = selectedContact.Name;
                    txt_contact_lastname.Text = selectedContact.LastName;
                    txt_contact_phone.Text = String.Format("{0:(000) 000 00 00}", Int64.Parse(selectedContact.PhoneNumber));
                    txt_contact_email.Text = selectedContact.Email;
                    txt_contact_address.Text = selectedContact.Address;
                }
                else
                {
                    ClearContactFields(); // Clear the fields if the selected row is empty
                }
            }
            else
            {
                ClearContactFields(); // Clear the fields if no row is selected
            }
        }

        private void clearSelectionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dgv_phonebook.ClearSelection();
            ClearContactFields();
        }

        // Method to extract digits from formatted phone number
        private string ExtractDigits(string formattedPhoneNumber)
        {
            return new String(formattedPhoneNumber.Where(Char.IsDigit).ToArray());
        }

        private void btn_save_reminder_Click(object sender, EventArgs e)
        {
            // Prepare data
            DateTime startDate = datePicker1.Value.Date + timePicker1.Value.TimeOfDay;
            DateTime endDate = datePicker2.Value.Date + timePicker2.Value.TimeOfDay;

            string reminderType = rb_meeting.Checked ? "Meeting" : "Task";
            string reminderSummary = txt_reminder_summary.Text;
            string reminderDescription = txt_reminder_description.Text;
            string userEmail = current_user.Email; // Get the user's email
            string title = reminderType; // Set the title based on the selected radio button

            // Check if we're updating an existing reminder or adding a new one
            if (dgv_reminder.SelectedRows.Count == 1)
            {
                // Update existing reminder
                var selectedReminder = (IReminder)dgv_reminder.SelectedRows[0].DataBoundItem;
                selectedReminder.Summary = reminderSummary;
                selectedReminder.Description = reminderDescription;
                selectedReminder.StartDate = startDate;
                selectedReminder.EndDate = endDate;
                selectedReminder.UserEmail = userEmail;
                selectedReminder.Title = title;

                if (reminder_manager.UpdateReminder(selectedReminder))
                {
                    LoadReminders(); // Refresh the DataGridView
                    MessageBox.Show("Reminder updated successfully.");
                    dgv_reminder.ClearSelection();
                    ClearReminderFields();
                }
                else
                {
                    MessageBox.Show("There was an error updating the reminder.");
                }
            }
            else
            {
                // Add new reminder
                IReminder newReminder = reminder_manager.CreateReminder(reminderType);
                newReminder.Summary = reminderSummary;
                newReminder.Description = reminderDescription;
                newReminder.StartDate = startDate;
                newReminder.EndDate = endDate;
                newReminder.UserEmail = userEmail;
                newReminder.Title = title;

                if (reminder_manager.AddReminder(newReminder))
                {
                    LoadReminders(); // Refresh the DataGridView
                    MessageBox.Show("New reminder added successfully.");
                    dgv_reminder.ClearSelection();
                    ClearReminderFields();
                }
                else
                {
                    MessageBox.Show("There was an error adding the new reminder.");
                }
            }
        }

        private void clearSelectionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            dgv_reminder.ClearSelection();
        }

        private void dgv_reminder_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv_reminder.SelectedRows.Count > 0)
            {
                var selectedReminder = (IReminder)dgv_reminder.SelectedRows[0].DataBoundItem;
                if (selectedReminder != null)
                {
                    txt_reminder_summary.Text = selectedReminder.Summary;
                    txt_reminder_description.Text = selectedReminder.Description;
                    datePicker1.Value = selectedReminder.StartDate;
                    timePicker1.Value = selectedReminder.StartDate;
                    datePicker2.Value = selectedReminder.EndDate;
                    timePicker2.Value = selectedReminder.EndDate;
                    rb_meeting.Checked = selectedReminder.Title == "Meeting";
                    rb_task.Checked = selectedReminder.Title != "Meeting";
                }
                else
                {
                    ClearReminderFields();
                }
            }
            else
            {
                ClearReminderFields();
            }
        }

        private void btn_delete_reminder_Click(object sender, EventArgs e)
        {
            if (dgv_reminder.SelectedRows.Count > 0)
            {
                // Ask the user to confirm the deletion.
                var confirmResult = MessageBox.Show("Are you sure you want to delete the selected reminders? This action cannot be undone.",
                                                    "Confirm Delete",
                                                    MessageBoxButtons.YesNo);

                if (confirmResult == DialogResult.Yes)
                {
                    // If the user confirmed, delete the reminders.
                    var remindersToDelete = new List<IReminder>();
                    foreach (DataGridViewRow row in dgv_reminder.SelectedRows)
                    {
                        remindersToDelete.Add((IReminder)row.DataBoundItem);
                    }

                    foreach (var reminder in remindersToDelete)
                    {
                        reminder_manager.DeleteReminder(reminder);
                    }

                    LoadReminders(); // Refresh the DataGridView
                    MessageBox.Show("Selected reminders deleted successfully.");
                }
                // If the user clicked 'No', do nothing.
            }
            else
            {
                MessageBox.Show("Please select at least one reminder to delete.");
            }
        }


        private void InitializeDataGridView()
        {
            dgv_reminder.AutoGenerateColumns = false;


            dgv_reminder.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Title",
                HeaderText = "Title"
            });

            dgv_reminder.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Summary",
                HeaderText = "Summary"
            });

            dgv_reminder.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "Description",
                HeaderText = "Description"
            });

            dgv_reminder.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "StartDate",
                HeaderText = "Start Date"
            });

            dgv_reminder.Columns.Add(new DataGridViewTextBoxColumn()
            {
                DataPropertyName = "EndDate",
                HeaderText = "End Date"
            });


        }
    }
}
