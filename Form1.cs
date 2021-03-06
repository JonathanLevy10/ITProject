using System;
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

        private void button_Signup_Click(object sender, EventArgs e)
        {
            if (textBox_FirstName.Text == "" || textBox_LastName.Text == "" || textBox_Email.Text == "" || textBox_Pwd.Text == "" || textBox_PwdConfirm.Text == "" || comboBox_Gender.SelectedIndex.ToString() == "Choose Gender")
            {
                MessageBox.Show("Please fill out the entire form!", "Lacking Submission", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBox_Pwd.Text != textBox_PwdConfirm.Text)
            {
                MessageBox.Show("Your passwords are inconsistent!", "Inconsistent Passwords", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_Pwd.Text.Length < 8)
            {
                MessageBox.Show("Your password must have at least 8 characters in length.", "Password Not Long Enough", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Thanks for creating an account with Shawarma, Inc. Group!", "Succesful Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
