
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
            this.label_FirstName = new System.Windows.Forms.Label();
            this.label_LastName = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_PwdConfirm = new System.Windows.Forms.Label();
            this.label_Pwd = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.checkBox_AgreeToTerms = new System.Windows.Forms.CheckBox();
            this.checkBox_isPro = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_BackgroundMA = new System.Windows.Forms.ComboBox();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.label_id = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.GroupBox_Filter = new System.Windows.Forms.GroupBox();
            this.textBox_FilterEmail = new System.Windows.Forms.TextBox();
            this.textBox_FilterLastName = new System.Windows.Forms.TextBox();
            this.textBox_FilterId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GroupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(423, 49);
            this.textBox_FirstName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(172, 22);
            this.textBox_FirstName.TabIndex = 0;
            // 
            // textBox_Pwd
            // 
            this.textBox_Pwd.Location = new System.Drawing.Point(423, 156);
            this.textBox_Pwd.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Pwd.MaxLength = 32;
            this.textBox_Pwd.Name = "textBox_Pwd";
            this.textBox_Pwd.PasswordChar = '*';
            this.textBox_Pwd.Size = new System.Drawing.Size(172, 22);
            this.textBox_Pwd.TabIndex = 4;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(604, 49);
            this.textBox_LastName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(172, 22);
            this.textBox_LastName.TabIndex = 1;
            // 
            // textBox_PwdConfirm
            // 
            this.textBox_PwdConfirm.Location = new System.Drawing.Point(604, 156);
            this.textBox_PwdConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_PwdConfirm.MaxLength = 32;
            this.textBox_PwdConfirm.Name = "textBox_PwdConfirm";
            this.textBox_PwdConfirm.PasswordChar = '*';
            this.textBox_PwdConfirm.Size = new System.Drawing.Size(172, 22);
            this.textBox_PwdConfirm.TabIndex = 5;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(423, 104);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(353, 22);
            this.textBox_Email.TabIndex = 3;
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
            this.comboBox_Gender.Location = new System.Drawing.Point(423, 211);
            this.comboBox_Gender.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(353, 24);
            this.comboBox_Gender.TabIndex = 6;
            this.comboBox_Gender.Text = "Not Specified";
            // 
            // button_Signup
            // 
            this.button_Signup.Location = new System.Drawing.Point(421, 370);
            this.button_Signup.Margin = new System.Windows.Forms.Padding(4);
            this.button_Signup.Name = "button_Signup";
            this.button_Signup.Size = new System.Drawing.Size(355, 28);
            this.button_Signup.TabIndex = 8;
            this.button_Signup.Text = "Sign Up";
            this.button_Signup.UseVisualStyleBackColor = true;
            this.button_Signup.Click += new System.EventHandler(this.button_Signup_Click);
            // 
            // label_FirstName
            // 
            this.label_FirstName.AutoSize = true;
            this.label_FirstName.Location = new System.Drawing.Point(419, 29);
            this.label_FirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_FirstName.Name = "label_FirstName";
            this.label_FirstName.Size = new System.Drawing.Size(144, 17);
            this.label_FirstName.TabIndex = 7;
            this.label_FirstName.Text = "First Name (i.e. John)";
            // 
            // label_LastName
            // 
            this.label_LastName.AutoSize = true;
            this.label_LastName.Location = new System.Drawing.Point(600, 30);
            this.label_LastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_LastName.Name = "label_LastName";
            this.label_LastName.Size = new System.Drawing.Size(139, 17);
            this.label_LastName.TabIndex = 8;
            this.label_LastName.Text = "Last Name (i.e. Doe)";
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Location = new System.Drawing.Point(419, 84);
            this.label_Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(272, 17);
            this.label_Email.TabIndex = 9;
            this.label_Email.Text = "E-Mail Address (i.e. john.doe@gmail.com)";
            // 
            // label_PwdConfirm
            // 
            this.label_PwdConfirm.AutoSize = true;
            this.label_PwdConfirm.Location = new System.Drawing.Point(600, 136);
            this.label_PwdConfirm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PwdConfirm.Name = "label_PwdConfirm";
            this.label_PwdConfirm.Size = new System.Drawing.Size(152, 17);
            this.label_PwdConfirm.TabIndex = 10;
            this.label_PwdConfirm.Text = "Password Confirmation";
            // 
            // label_Pwd
            // 
            this.label_Pwd.AutoSize = true;
            this.label_Pwd.Location = new System.Drawing.Point(419, 136);
            this.label_Pwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Pwd.Name = "label_Pwd";
            this.label_Pwd.Size = new System.Drawing.Size(180, 17);
            this.label_Pwd.TabIndex = 11;
            this.label_Pwd.Text = "Password (at least 8 chars)";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Location = new System.Drawing.Point(419, 191);
            this.label_Gender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(123, 17);
            this.label_Gender.TabIndex = 12;
            this.label_Gender.Text = "Gender (Optional)";
            // 
            // checkBox_AgreeToTerms
            // 
            this.checkBox_AgreeToTerms.AutoSize = true;
            this.checkBox_AgreeToTerms.Location = new System.Drawing.Point(422, 341);
            this.checkBox_AgreeToTerms.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_AgreeToTerms.Name = "checkBox_AgreeToTerms";
            this.checkBox_AgreeToTerms.Size = new System.Drawing.Size(351, 21);
            this.checkBox_AgreeToTerms.TabIndex = 7;
            this.checkBox_AgreeToTerms.Text = "I consent to the Terms of Usage and Privacy Policy";
            this.checkBox_AgreeToTerms.UseVisualStyleBackColor = true;
            // 
            // checkBox_isPro
            // 
            this.checkBox_isPro.AutoSize = true;
            this.checkBox_isPro.Location = new System.Drawing.Point(422, 313);
            this.checkBox_isPro.Name = "checkBox_isPro";
            this.checkBox_isPro.Size = new System.Drawing.Size(193, 21);
            this.checkBox_isPro.TabIndex = 17;
            this.checkBox_isPro.Text = "I am a professional fighter";
            this.checkBox_isPro.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(418, 256);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Speacialist/Background Martial Art";
            // 
            // comboBox_BackgroundMA
            // 
            this.comboBox_BackgroundMA.FormattingEnabled = true;
            this.comboBox_BackgroundMA.Items.AddRange(new object[] {
            "Grappling",
            "Striking",
            "Jiu Jitsu",
            "Muay Thai",
            "Boxing",
            "Karate",
            "Judo",
            "Tae Kwon Do"});
            this.comboBox_BackgroundMA.Location = new System.Drawing.Point(421, 276);
            this.comboBox_BackgroundMA.Name = "comboBox_BackgroundMA";
            this.comboBox_BackgroundMA.Size = new System.Drawing.Size(352, 24);
            this.comboBox_BackgroundMA.TabIndex = 18;
            // 
            // listBox_Clients
            // 
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 16;
            this.listBox_Clients.Location = new System.Drawing.Point(12, 170);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(391, 340);
            this.listBox_Clients.TabIndex = 19;
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.listBox_Clients_DoubleClick);
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(455, 409);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(16, 17);
            this.label_id.TabIndex = 20;
            this.label_id.Text = "0";
            this.label_id.Click += new System.EventHandler(this.label_id_Click);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(423, 448);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 62);
            this.Save.TabIndex = 21;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "ID: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(504, 448);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 33);
            this.Clear.TabIndex = 23;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Location = new System.Drawing.Point(504, 482);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(75, 28);
            this.Delete.TabIndex = 24;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // GroupBox_Filter
            // 
            this.GroupBox_Filter.Controls.Add(this.textBox_FilterEmail);
            this.GroupBox_Filter.Controls.Add(this.textBox_FilterLastName);
            this.GroupBox_Filter.Controls.Add(this.textBox_FilterId);
            this.GroupBox_Filter.Controls.Add(this.label3);
            this.GroupBox_Filter.Controls.Add(this.label4);
            this.GroupBox_Filter.Controls.Add(this.label5);
            this.GroupBox_Filter.Location = new System.Drawing.Point(12, 22);
            this.GroupBox_Filter.Name = "GroupBox_Filter";
            this.GroupBox_Filter.Size = new System.Drawing.Size(391, 142);
            this.GroupBox_Filter.TabIndex = 25;
            this.GroupBox_Filter.TabStop = false;
            this.GroupBox_Filter.Text = "Filter";
            // 
            // textBox_FilterEmail
            // 
            this.textBox_FilterEmail.Location = new System.Drawing.Point(121, 107);
            this.textBox_FilterEmail.Name = "textBox_FilterEmail";
            this.textBox_FilterEmail.Size = new System.Drawing.Size(100, 22);
            this.textBox_FilterEmail.TabIndex = 30;
            this.textBox_FilterEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GroupBox_Filter_KeyUp);
            // 
            // textBox_FilterLastName
            // 
            this.textBox_FilterLastName.Location = new System.Drawing.Point(121, 70);
            this.textBox_FilterLastName.Name = "textBox_FilterLastName";
            this.textBox_FilterLastName.Size = new System.Drawing.Size(100, 22);
            this.textBox_FilterLastName.TabIndex = 29;
            this.textBox_FilterLastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GroupBox_Filter_KeyUp);
            // 
            // textBox_FilterId
            // 
            this.textBox_FilterId.Location = new System.Drawing.Point(121, 29);
            this.textBox_FilterId.Name = "textBox_FilterId";
            this.textBox_FilterId.Size = new System.Drawing.Size(100, 22);
            this.textBox_FilterId.TabIndex = 26;
            this.textBox_FilterId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GroupBox_Filter_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 544);
            this.Controls.Add(this.GroupBox_Filter);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.listBox_Clients);
            this.Controls.Add(this.comboBox_BackgroundMA);
            this.Controls.Add(this.checkBox_isPro);
            this.Controls.Add(this.label2);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "ClientSignup";
            this.GroupBox_Filter.ResumeLayout(false);
            this.GroupBox_Filter.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBox_isPro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_BackgroundMA;
        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.GroupBox GroupBox_Filter;
        private System.Windows.Forms.TextBox textBox_FilterEmail;
        private System.Windows.Forms.TextBox textBox_FilterLastName;
        private System.Windows.Forms.TextBox textBox_FilterId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

