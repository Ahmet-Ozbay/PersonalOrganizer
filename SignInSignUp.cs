﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace FinalProject
{
    public partial class Form_SignIn_SignUp : Form
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

        // Veri transferi
        
        public static string e_mail;
        public static Form_SignIn_SignUp form_signIn_signUp;


        public Form_SignIn_SignUp()
        {
            InitializeComponent();
            form_signIn_signUp = this;
        }
        
        //
        // Close Button
        //
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_close_MouseEnter(object sender, EventArgs e)
        {
            btn_close.FlatAppearance.MouseOverBackColor = Color.FromArgb(165, 84, 154);

        }
        private void btn_close_MouseDown(object sender, MouseEventArgs e)
        {
            btn_close.BackColor = Color.FromArgb(255, 84, 94);
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
            btn_minimize.FlatAppearance.MouseOverBackColor = Color.FromArgb(165, 84, 154);

        }
        private void btn_minimize_MouseDown(object sender, MouseEventArgs e)
        {
            btn_minimize.BackColor = Color.FromArgb(255, 84, 94);
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
        // Show/Hide Password Button
        //
        private void btn_see_password_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password.PasswordChar = '\0';
            btn_see_password.BackgroundImage = global::FinalProject.Properties.Resources.btn_hide_password;

        }
        private void btn_see_password_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password.PasswordChar = '*';
            btn_see_password.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
        }
        private void btn_see_password_register_MouseDown(object sender, MouseEventArgs e)
        {
            txt_password_register.PasswordChar = '\0';
            btn_see_password_register.BackgroundImage = global::FinalProject.Properties.Resources.btn_hide_password;

        }
        private void btn_see_password_register_MouseUp(object sender, MouseEventArgs e)
        {
            txt_password_register.PasswordChar = '*';
            btn_see_password_register.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
        }
        private void btn_see_confirmation_register_MouseDown(object sender, MouseEventArgs e)
        {
            txt_confirm_password.PasswordChar = '\0';
            btn_see_confirmation_register.BackgroundImage = global::FinalProject.Properties.Resources.btn_hide_password;

        }
        private void btn_see_confirmation_register_MouseUp(object sender, MouseEventArgs e)
        {
            txt_confirm_password.PasswordChar = '*';
            btn_see_confirmation_register.BackgroundImage = global::FinalProject.Properties.Resources.btn_show_password;
        }// end - Show/Hide Password

        //
        // Sign Up Link
        //
        private void link_signup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnl_signin.Visible = false;
            pnl_signup.Visible = true;
            pnl_signup.BringToFront();
        } // end - SignUp

        //
        // Sign In Link
        //
        private void link_signin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnl_signup.Visible = false;
            pnl_signin.Visible = true;
            pnl_signin.BringToFront();
        } // end - SignIn

        //
        // Text-field Place Holders
        //
        private void txt_email_Enter(object sender, EventArgs e)
        {
            if(txt_email.Text == "general_kenobi@jedi.com")
            {
                txt_email.Text = "";
                txt_email.ForeColor = Color.Black;
            }
        }
        private void txt_email_Leave(object sender, EventArgs e)
        {
            if(txt_email.Text == "")
            {
                txt_email.Text = "general_kenobi@jedi.com";
                txt_email.ForeColor = Color.LightGray;
            }
        }
        private void txt_password_Enter(object sender, EventArgs e)
        {
            if( txt_password.Text == "enter your password")
            {
                txt_password.Text = "";
                txt_password.ForeColor = Color.Black;
                txt_password.PasswordChar= '*';
            }
        }
        private void txt_password_Leave(object sender, EventArgs e)
        {
            if(txt_password.Text == "")
            {
                txt_password.Text = "enter your password";
                txt_password.ForeColor= Color.LightGray;
                txt_password.PasswordChar = '*';
            }
        }
        private void txt_name_register_Enter(object sender, EventArgs e)
        {
            if (txt_name_register.Text == "Name")
            {
                txt_name_register.Text = "";
                txt_name_register.ForeColor = Color.Black;
            }
        }
        private void txt_name_register_Leave(object sender, EventArgs e)
        {
            if (txt_name_register.Text == "")
            {
                txt_name_register.Text = "Name";
                txt_name_register.ForeColor = Color.LightGray;
            }
        }
        private void txt_lastname_register_Enter(object sender, EventArgs e)
        {
            if (txt_lastname_register.Text == "Last Name")
            {
                txt_lastname_register.Text = "";
                txt_lastname_register.ForeColor = Color.Black;
            }
        }
        private void txt_lastname_register_Leave(object sender, EventArgs e)
        {
            if (txt_lastname_register.Text == "")
            {
                txt_lastname_register.Text = "Last Name";
                txt_lastname_register.ForeColor = Color.LightGray;
            }
        }
        private void txt_email_register_Enter(object sender, EventArgs e)
        {
            if (txt_email_register.Text == "your_email@domain.com")
            {
                txt_email_register.Text = "";
                txt_email_register.ForeColor = Color.Black;
            }
        }
        private void txt_email_register_Leave(object sender, EventArgs e)
        {
            if (txt_email_register.Text == "")
            {
                txt_email_register.Text = "your_email@domain.com";
                txt_email_register.ForeColor = Color.LightGray;
            }
        }
        private void txt_password_register_Enter(object sender, EventArgs e)
        {
            if (txt_password_register.Text == "enter your password")
            {
                txt_password_register.Text = "";
                txt_password_register.ForeColor = Color.Black;
                txt_password_register.PasswordChar = '*';
            }
        }
        private void txt_password_register_Leave(object sender, EventArgs e)
        {
            if (txt_password_register.Text == "")
            {
                txt_password_register.Text = "enter your password";
                txt_password_register.ForeColor = Color.LightGray;
                txt_password_register.PasswordChar = '*';
            }
        }
        private void txt_confirm_password_Enter(object sender, EventArgs e)
        {
            if (txt_confirm_password.Text == "confirm your password")
            {
                txt_confirm_password.Text = "";
                txt_confirm_password.ForeColor = Color.Black;
                txt_confirm_password.PasswordChar = '*';
            }
        }
        private void txt_confirm_password_Leave(object sender, EventArgs e)
        {
            if (txt_confirm_password.Text == "")
            {
                txt_confirm_password.Text = "confirm your password";
                txt_confirm_password.ForeColor = Color.LightGray;
                txt_confirm_password.PasswordChar = '*';
            }
        }
        // end - Text Field PlaceHolders

        //
        // Sign Buttons
        //
        private void btn_signin_MouseEnter(object sender, EventArgs e)
        {
            btn_signin.BackColor = Color.FromArgb(121, 158, 0);
        }
        private void btn_signin_MouseLeave(object sender, EventArgs e)
        {
            btn_signin.BackColor = Color.FromArgb(255, 84, 94);
        }
        private void btn_signin_MouseHover(object sender, EventArgs e)
        {
            btn_signin.FlatAppearance.MouseOverBackColor = Color.FromArgb(165, 84, 154);
            btn_signin.BackColor = Color.FromArgb(121, 158, 0);
        }
        private void btn_signup_MouseEnter(object sender, EventArgs e)
        {
            btn_signup.BackColor = Color.FromArgb(121, 158, 0);
        }
        private void btn_signup_MouseLeave(object sender, EventArgs e)
        {
            btn_signup.BackColor = Color.FromArgb(255, 84, 94);
        }
        private void btn_signup_MouseHover(object sender, EventArgs e)
        {
            btn_signup.FlatAppearance.MouseOverBackColor = Color.FromArgb(165, 84, 154);
            btn_signup.BackColor = Color.FromArgb(121, 158, 0);
        } // end - Sign Buttons

        private void btn_signin_Click(object sender, EventArgs e)
        {
            string email = txt_email.Text;
            string password = txt_password.Text;

            User existing_user = new User
            {
                Email = email,
                Password = password
            };

            CsvRepository csv = new CsvRepository();
            SignInService sign_in = new SignInService(csv);

            bool success = sign_in.SignIn(existing_user);


            if(success)
            {
                this.Hide();
                Form landing = new Form_LandingPage();
                e_mail = email;
                landing.ShowDialog();
            } else
            {
                MessageBox.Show("Wrong email or password", "Unsuccessful Sign In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_signup_Click(object sender, EventArgs e)
        {
            string name = txt_name_register.Text;
            string last_name = txt_lastname_register.Text;
            string email = txt_email_register.Text;
            string password = txt_password_register.Text;
            string password_confirmation = txt_confirm_password.Text;
            
            /*
             * Confirmation password doesn't match
             */
            if(password != password_confirmation)
            {
                MessageBox.Show("Passwords don't match. Please re-enter your password carefully.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_password_register.Text = "enter your password";
                txt_password_register.PasswordChar = '\0';
                txt_password_register.ForeColor = Color.LightGray;

                txt_confirm_password.Text = "confirm your password";
                txt_confirm_password.PasswordChar = '\0';
                txt_confirm_password.ForeColor = Color.LightGray;
            }
            else
            {
                if(name != "Name" && last_name != "Last Name" && email != "your_email@domain.com") 
                {
                    CsvRepository csv = new CsvRepository();
                    SignUpService sign_up_service = new SignUpService(csv);

                    User new_user = new User()
                    {
                        Name = name,
                        LastName = last_name,
                        Email = email,
                        Password = password,
                        Authorisation = Authority.User
                    };

                    bool success = sign_up_service.SignUp(new_user);

                    if (success)
                    {
                        MessageBox.Show("Signed up successfully. You can now sign in!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        pnl_signup.Visible = false;
                        pnl_signin.Visible = true;
                        txt_email.Text = email;
                        txt_password.Text = password;

                        txt_email.ForeColor = Color.Black;
                        txt_password.PasswordChar = '*';

                    } else
                    {
                        MessageBox.Show("This email is already in use. If you forgot your password, you can reset it!", "Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
