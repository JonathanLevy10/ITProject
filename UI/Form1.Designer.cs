
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_Pwd = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_PwdConfirm = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.button_Signup = new System.Windows.Forms.Button();
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_PwdConfirm = new System.Windows.Forms.Label();
            this.label_Pwd = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.checkBox_AgreeToTerms = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(12, 24);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(130, 20);
            this.textBox_FirstName.TabIndex = 0;
            this.textBox_FirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Name_KeyPress);
            // 
            // textBox_Pwd
            // 
            this.textBox_Pwd.Location = new System.Drawing.Point(12, 111);
            this.textBox_Pwd.MaxLength = 32;
            this.textBox_Pwd.Name = "textBox_Pwd";
            this.textBox_Pwd.PasswordChar = '*';
            this.textBox_Pwd.Size = new System.Drawing.Size(130, 20);
            this.textBox_Pwd.TabIndex = 4;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(148, 24);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(130, 20);
            this.textBox_LastName.TabIndex = 1;
            this.textBox_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Name_KeyPress);
            // 
            // textBox_PwdConfirm
            // 
            this.textBox_PwdConfirm.Location = new System.Drawing.Point(148, 111);
            this.textBox_PwdConfirm.MaxLength = 32;
            this.textBox_PwdConfirm.Name = "textBox_PwdConfirm";
            this.textBox_PwdConfirm.PasswordChar = '*';
            this.textBox_PwdConfirm.Size = new System.Drawing.Size(130, 20);
            this.textBox_PwdConfirm.TabIndex = 5;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(12, 69);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(266, 20);
            this.textBox_Email.TabIndex = 3;
            this.textBox_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Email_KeyPress);
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Not Specified",
            "Male",
            "Female",
            "Non-Binary",
            "Prefer Not To Say"});
            this.comboBox_Gender.Location = new System.Drawing.Point(12, 156);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(266, 21);
            this.comboBox_Gender.TabIndex = 6;
            this.comboBox_Gender.Text = "Not Specified";
            // 
            // button_Signup
            // 
            this.button_Signup.Location = new System.Drawing.Point(12, 214);
            this.button_Signup.Name = "button_Signup";
            this.button_Signup.Size = new System.Drawing.Size(266, 23);
            this.button_Signup.TabIndex = 7;
            this.button_Signup.Text = "Sign Up";
            this.button_Signup.UseVisualStyleBackColor = true;
            this.button_Signup.Click += new System.EventHandler(this.button_Signup_Click);
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(9, 8);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(106, 13);
            this.label_FirstName.TabIndex = 7;
            this.label_FirstName.Text = "First Name (i.e. John)";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(145, 9);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(104, 13);
            this.label_LastName.TabIndex = 8;
            this.label_LastName.Text = "Last Name (i.e. Doe)";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(9, 53);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(202, 13);
            this.label_Email.TabIndex = 9;
            this.label_Email.Text = "E-Mail Address (i.e. john.doe@gmail.com)";
            // 
            // label_PwdConfirm
            // 
            this.label_PwdConfirm.AutoSize = true;
            this.label_PwdConfirm.Location = new System.Drawing.Point(145, 95);
            this.label_PwdConfirm.Name = "label_PwdConfirm";
            this.label_PwdConfirm.Size = new System.Drawing.Size(114, 13);
            this.label_PwdConfirm.TabIndex = 10;
            this.label_PwdConfirm.Text = "Password Confirmation";
            // 
            // label_Pwd
            // 
            this.label_Pwd.AutoSize = true;
            this.label_Pwd.Location = new System.Drawing.Point(9, 95);
            this.label_Pwd.Name = "label_Pwd";
            this.label_Pwd.Size = new System.Drawing.Size(134, 13);
            this.label_Pwd.TabIndex = 11;
            this.label_Pwd.Text = "Password (at least 8 chars)";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Location = new System.Drawing.Point(9, 140);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(90, 13);
            this.label_Gender.TabIndex = 12;
            this.label_Gender.Text = "Gender (Optional)";
            // 
            // checkBox_AgreeToTerms
            // 
            this.checkBox_AgreeToTerms.AutoSize = true;
            this.checkBox_AgreeToTerms.Location = new System.Drawing.Point(12, 187);
            this.checkBox_AgreeToTerms.Name = "checkBox_AgreeToTerms";
            this.checkBox_AgreeToTerms.Size = new System.Drawing.Size(268, 17);
            this.checkBox_AgreeToTerms.TabIndex = 13;
            this.checkBox_AgreeToTerms.Text = "I consent to the Terms of Usage and Privacy Policy";
            this.checkBox_AgreeToTerms.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 251);
            this.Controls.Add(this.checkBox_AgreeToTerms);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_Pwd);
            this.Controls.Add(this.label_PwdConfirm);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_LastName);
            this.Controls.Add(this.label_FirstName);
            this.Controls.Add(this.button_Signup);
            this.Controls.Add(this.comboBox_Gender);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_PwdConfirm);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.textBox_Pwd);
            this.Controls.Add(this.textBox_FirstName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Daniel Naaman & Jonathan Levy: Clients";
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
        private System.Windows.Forms.Label label_FirstName;
        private System.Windows.Forms.Label label_LastName;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_PwdConfirm;
        private System.Windows.Forms.Label label_Pwd;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.CheckBox checkBox_AgreeToTerms;
    }
}

