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
using ClientSignup.DAL;

namespace ClientSignup
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Checks whether an email address has an at symbol and a dot after it
        //private bool IsValidEmail(string s)
        //{
        //    bool isValidEmail = false;

        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        if (s[i] == '@')
        //        {
        //            isValidEmail = true;
        //        }

        //        if (s[i] == '.' && isValidEmail)
        //        {
        //            isValidEmail = true;
        //        }

        //        else
        //            isValidEmail = false;
        //    }

        //    return isValidEmail;
        //}

        //this function checks if the form is complete with all the correct criteria for the form. It highlights the missing criteria for the user in red
        public bool ValidateForm()
        {
            bool isValidated = true;

            if ("" == (textBox_FirstName.Text))
            {
                isValidated = false;
                textBox_FirstName.BackColor = Color.OrangeRed;
            }

            else
                textBox_FirstName.BackColor = Color.White;

            if ("" == (textBox_LastName.Text))
            {
                isValidated = false;
                textBox_LastName.BackColor = Color.OrangeRed;
            }

            else
                textBox_LastName.BackColor = Color.White;

            if ("" == (textBox_Email.Text))
            {
                isValidated = false;
                textBox_Email.BackColor = Color.OrangeRed;
            }

            else
                textBox_Email.BackColor = Color.White;


            if ("" == (textBox_Pwd.Text))
            {
                isValidated = false;
                textBox_Pwd.BackColor = Color.OrangeRed;
            }

            else
                textBox_Pwd.BackColor = Color.White;

            if ("" == (textBox_PwdConfirm.Text))
            {
                isValidated = false;
                textBox_PwdConfirm.BackColor = Color.OrangeRed;
            }

            else
                textBox_PwdConfirm.BackColor = Color.White;

            if (!checkBox_AgreeToTerms.Checked)
            {
                isValidated = false;
                checkBox_AgreeToTerms.BackColor = Color.OrangeRed;
            }

            else
                checkBox_AgreeToTerms.BackColor = Color.Empty;

            // Password Validation
            if (textBox_Pwd.Text != textBox_PwdConfirm.Text)
            {
                isValidated = false;
                textBox_Pwd.BackColor = Color.OrangeRed;
                textBox_PwdConfirm.BackColor = Color.OrangeRed;
            }

            if (textBox_Pwd.Text.Length < 8)
            {
                isValidated = false;
                textBox_Pwd.BackColor = Color.OrangeRed;
            }

            return isValidated;
        }
        // form to client funtion. Adds created client object. Connects the client and the form.
        private Client FormToClient()
        {
            Client client = new Client();

            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            client.Email = textBox_Email.Text;
            client.Pwd = textBox_Pwd.Text;
            client.Gender = comboBox_Gender.Text;

            return client;
        }
        //uses ValidateForm to check if form is valid, then shows a message depending on ValidateForm
        private void button_Signup_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == false) //when okay is clicked, it removes message and user can continue/edit previous account creation. When cancel is clickedd, program is terminated
            {
                if (MessageBox.Show("Some of the information provided is incorrect or missspelled. Please verify that everything you typed fits the examples given.", "Lacking or Insufficent Submission", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    this.Close();
            }

            else
            {
                Client client = FormToClient();
                MessageBox.Show($"Dear {client.FirstName}, your submission has been recorded! Your account is being created right now. You can safely leave this page.\n\nA confirmation will be sent to {client.Email} within five business days.", "Succesful Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
                client.Insert();
            }
        }
        //makes sure user can olny use the abc's when writing thier name.
        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }
        //makes sure user can only use one '@' when writing thier email
        private void textBox_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            int count = 0;

            for (int i = 0; i < textBox_Email.Text.Length; i++)
            {
                if (textBox_Email.Text[i] == '@')
                    count++;
            }

            if (count > 0)
                if (e.KeyChar == '@')
                    e.KeyChar = char.MinValue;
        }
    }
}
