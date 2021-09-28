using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientSignup.BL;

namespace ClientSignup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Form client from data collected by the form
        private Client FormToClient()
        {
            Client client = new Client();

            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            client.Email = textBox_Email.Text;
            client.Pwd = textBox_Pwd.Text;
            if (comboBox_Gender.Text != "Not Specified")
                client.Gender = comboBox_Gender.Text;

            return client;
        }

        private void button_Signup_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == true)
            {
                // Set client to the client that just formed
                Client client = FormToClient();

                // Add client to SQL database
                client.Insert();

                // Confirmation message
                MessageBox.Show($"Dear {client.FirstName}, your user has been created succesfully in the database. You can safely leave this page.", "User created succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateForm()
        {
            // First Name Validation
            if ("" == (textBox_FirstName.Text))
            {
                textBox_FirstName.BackColor = Color.OrangeRed;
                MessageBox.Show("First name cannot be empty!", "Error creating user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }

            else
                textBox_FirstName.BackColor = Color.White;

            // Last Name Validation
            if ("" == (textBox_LastName.Text))
            {
                textBox_LastName.BackColor = Color.OrangeRed;
                MessageBox.Show("Last name cannot be empty!", "Error creating user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }

            else
                textBox_LastName.BackColor = Color.White;

            // Email Validation
            if ("" == (textBox_Email.Text))
            {
                textBox_Email.BackColor = Color.OrangeRed;
                MessageBox.Show("Email cannot be empty!", "Error creating user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }

            else
                textBox_Email.BackColor = Color.White;

            // Password Validation
            if ("" == (textBox_Pwd.Text))
            {
                textBox_Pwd.BackColor = Color.OrangeRed;
                MessageBox.Show("Password cannot be empty!", "Error creating user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }

            else
                textBox_Pwd.BackColor = Color.White;

            if (textBox_Pwd.Text.Length < 8)
            {
                textBox_Pwd.BackColor = Color.OrangeRed;
                MessageBox.Show("Password must be longer then 8 characters!", "Error creating user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }

            else
                textBox_Pwd.BackColor = Color.White;

            if (textBox_Pwd.Text != textBox_PwdConfirm.Text)
            {
                textBox_PwdConfirm.BackColor = Color.OrangeRed;
                MessageBox.Show("Passwords must be identical!", "Error creating user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }

            else
            {
                textBox_PwdConfirm.BackColor = Color.White;
            }

            // Terms of Usage and Privacy Policy Validation
            if (!checkBox_AgreeToTerms.Checked)
            {
                checkBox_AgreeToTerms.BackColor = Color.OrangeRed;
                MessageBox.Show("You must agree to the Terms of Usage and Privacy Policy in order to create a user!", "Error creating user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }

            else
                checkBox_AgreeToTerms.BackColor = Color.Empty;

            return true;
        }
    }
}
