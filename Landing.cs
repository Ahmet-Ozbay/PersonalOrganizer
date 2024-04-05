using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public Form_LandingPage()
        {
            InitializeComponent();
        }

        // Color Palette
        Color blue = Color.FromArgb(165, 84, 154);
        Color light_blue = Color.FromArgb(0, 113, 205);
        Color purple = Color.FromArgb(255, 84, 94);
        Color navy = Color.FromArgb(100, 47, 72, 88);

        //
        // Close Button
        //
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if(pnl_profile.Visible)
            {
                btn_profile.BackColor = blue;
            }
            else
            {
                btn_profile.BackColor = navy;
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
            }
            else
            {
                btn_phonebook.BackColor = navy;
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
            }
            else
            {
                btn_notebook.BackColor = navy;
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
        }

        //
        // Reminder Panel
        //
        private void pnl_reminder_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_reminder.Visible)
            {
                btn_reminder.BackColor = blue;
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
        }

        //
        // Salary Calculator Panel
        //
        private void pnl_salary_VisibleChanged(object sender, EventArgs e)
        {
            if (pnl_salary.Visible)
            {
                btn_salary.BackColor = blue;
            }
            else
            {
                btn_salary.BackColor = navy;
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
    }
}
