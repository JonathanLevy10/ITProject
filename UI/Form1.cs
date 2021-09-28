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
            // Set client to the client that just formed
            Client client = FormToClient();

            // Add client to SQL database
            client.Insert();

            // Confirmation message
            MessageBox.Show($"Dear {client.FirstName}, your submission has been recorded! Your account is being created right now. You can safely leave this page.\n\nA confirmation will be sent to {client.Email} within five business days.", "Succesful Submission", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
