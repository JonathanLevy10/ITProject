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
            ClientArrToForm();
        }

        // Form client from data collected by the form
        private Client FormToClient()
        {
            Client client = new Client();
            client.id = int.Parse(label_id.Text);

            client.FirstName = textBox_FirstName.Text;
            client.LastName = textBox_LastName.Text;
            client.Email = textBox_Email.Text;
            client.Pwd = textBox_Pwd.Text;
            client.IsPro = checkBox_isPro.Checked;
            client.BackgroundMA = comboBox_BackgroundMA.Text;
            if (comboBox_Gender.Text != "Not Specified")
                client.Gender = comboBox_Gender.Text;

            return client;
        }

        private void ClientToForm(Client client) //Puts specific client info into form
        {

            //ממירה את המידע בטנ"מ לקוח לטופס
            if (client != null)
            {
                label_id.Text = client.id.ToString();
                textBox_FirstName.Text = client.FirstName;
                textBox_LastName.Text = client.LastName;
                textBox_Email.Text = client.Email;
                textBox_Pwd.Text = client.Pwd;
                comboBox_Gender.Text = client.Gender;
                comboBox_BackgroundMA.Text = client.BackgroundMA;
                checkBox_isPro.Checked = client.IsPro;
            }
            else
            {
                label_id.Text = "0";
                textBox_FirstName.Text = "";
                textBox_LastName.Text = "";
                textBox_Email.Text = "";
                textBox_Pwd.Text = "";
                comboBox_Gender.Text = null;
                comboBox_BackgroundMA.Text = null;
                //checkBox_isPro.Checked = null; check why it cannot be null
            }
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

        private void ClientArrToForm()
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Clients.DataSource = clientArr;
        }

        private void listBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(listBox_Clients.SelectedItem as Client); 
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {


                Client client = FormToClient();


                if (client.id == 0)
                {
                    if (client.Insert())
                    {
                        MessageBox.Show("Added Successfully");
                    }
                    else
                        MessageBox.Show("Error adding");
                }

                else
                {
                    if (client.Update())
                    {
                        MessageBox.Show("Updated Successfully");
                        ClientArrToForm();
                    }
                    else
                        MessageBox.Show("Error update");
                }
                ClientArrToForm();
            }


        }

        private void label_id_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            Client client = FormToClient();

            if (client.id == 0)
                MessageBox.Show("You need to choose a client");
            else
            {
                if (MessageBox.Show("Are you sure?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (client.Delete())
                        MessageBox.Show("Success! Your account has been deleted");
                    else
                        MessageBox.Show("Error, please enter a client you would like to delete");

                    ClientToForm(null);
                    ClientArrToForm();
                }

            }
        }

        private void GroupBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            if (textBox_FilterId.Text != "")
                id = int.Parse(textBox_FilterId.Text);

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            clientArr = clientArr.Filter(id, textBox_FilterLastName.Text, textBox_FilterEmail.Text);

            listBox_Clients.DataSource = clientArr;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            ClientToForm(null);
        }
    }
}
