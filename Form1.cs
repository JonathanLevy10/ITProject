﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            if (String.IsNullOrEmpty(textBox_FirstName.Text))
            {
                isValidated = false;
                textBox_FirstName.BackColor = Color.Red;
            }

            else
                textBox_FirstName.BackColor = Color.White;

            if (String.IsNullOrEmpty(textBox_LastName.Text))
            {
                isValidated = false;
                textBox_LastName.BackColor = Color.Red;
            }

            else
                textBox_LastName.BackColor = Color.White;

            if (String.IsNullOrEmpty(textBox_Email.Text))
            {
                isValidated = false;
                textBox_Email.BackColor = Color.Red;
            }

            else
                textBox_Email.BackColor = Color.White;

            if (String.IsNullOrEmpty(textBox_Pwd.Text))
            {
                isValidated = false;
                textBox_Pwd.BackColor = Color.Red;
            }

            else
                textBox_Pwd.BackColor = Color.White;

            if (String.IsNullOrEmpty(textBox_PwdConfirm.Text))
            {
                isValidated = false;
                textBox_PwdConfirm.BackColor = Color.Red;
            }

            else
                textBox_PwdConfirm.BackColor = Color.White;


            // Password Validation
            if (textBox_Pwd.Text != textBox_PwdConfirm.Text)
            {
                isValidated = false;
                textBox_FirstName.BackColor = Color.Red;
            }

            if (textBox_Pwd.Text.Length < 8)
            {
                isValidated = false;
                textBox_FirstName.BackColor = Color.Red;
            }

            return isValidated;
        }

        private void button_Signup_Click(object sender, EventArgs e)
        {
            if (ValidateForm() == false)
            {
                MessageBox.Show("Some of the information provided is incorrect or missspelled. Please verify that everything you typed fits the examples given.", "Lacking or Insufficent Submission", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                return;
            }

            else
                MessageBox.Show("Your submission has been recorded, and your account is being created right now. You can safely leave this page.", "Succesful Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void textBox_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.KeyChar = char.MinValue;
            }
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
