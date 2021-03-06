
namespace ClientSignup
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_Pwd = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_PwdConfirm = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.button_Signup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(12, 24);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(100, 20);
            this.textBox_FirstName.TabIndex = 0;
            this.textBox_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Name_KeyPress);
            // 
            // textBox_Pwd
            // 
            this.textBox_Pwd.Location = new System.Drawing.Point(12, 106);
            this.textBox_Pwd.MaxLength = 32;
            this.textBox_Pwd.Name = "textBox_Pwd";
            this.textBox_Pwd.PasswordChar = '*';
            this.textBox_Pwd.Size = new System.Drawing.Size(100, 20);
            this.textBox_Pwd.TabIndex = 4;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(118, 24);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(100, 20);
            this.textBox_LastName.TabIndex = 1;
            this.textBox_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Name_KeyPress);
            // 
            // textBox_PwdConfirm
            // 
            this.textBox_PwdConfirm.Location = new System.Drawing.Point(118, 106);
            this.textBox_PwdConfirm.MaxLength = 32;
            this.textBox_PwdConfirm.Name = "textBox_PwdConfirm";
            this.textBox_PwdConfirm.PasswordChar = '*';
            this.textBox_PwdConfirm.Size = new System.Drawing.Size(100, 20);
            this.textBox_PwdConfirm.TabIndex = 5;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(12, 65);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(206, 20);
            this.textBox_Email.TabIndex = 3;
            this.textBox_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Email_KeyPress);
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Prefer not to say",
            "Male",
            "Female"});
            this.comboBox_Gender.Location = new System.Drawing.Point(12, 148);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(206, 21);
            this.comboBox_Gender.TabIndex = 6;
            this.comboBox_Gender.Text = "Choose Gender";
            // 
            // button_Signup
            // 
            this.button_Signup.Location = new System.Drawing.Point(12, 181);
            this.button_Signup.Name = "button_Signup";
            this.button_Signup.Size = new System.Drawing.Size(206, 23);
            this.button_Signup.TabIndex = 7;
            this.button_Signup.Text = "Sign Up";
            this.button_Signup.UseVisualStyleBackColor = true;
            this.button_Signup.Click += new System.EventHandler(this.button_Signup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "E-Mail Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password Confirmation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Gender";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 218);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Signup);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_PwdConfirm);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_Pwd);
            this.Controls.Add(this.textBox_FirstName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_Pwd;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_PwdConfirm;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.Button button_Signup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

