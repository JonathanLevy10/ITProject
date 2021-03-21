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

        private void button_Signup_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == false)
                MessageBox.Show("Some of the information provided is incorrect or missspelled. Please verify that everything you typed fits the examples given.", "Lacking or Insufficent Submission", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);

            else
                MessageBox.Show("Your submission has been recorded, and your account is being created right now. You can safely leave this page.", "Succesful Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }

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
