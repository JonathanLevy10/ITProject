
namespace WFP_GOS.UI
{
    partial class Form_Comp
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
            this.GroupBox_Filter = new System.Windows.Forms.GroupBox();
            this.textBox_FilterEmail = new System.Windows.Forms.TextBox();
            this.textBox_FilterLastName = new System.Windows.Forms.TextBox();
            this.textBox_FilterId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_Clients = new System.Windows.Forms.ListBox();
            this.label_Client = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_Comp_Name = new System.Windows.Forms.TextBox();
            this.label_Comp_id = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.listBox_Comp = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.comboBox_FilterLevel = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.comboBox_FilterCategory = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtp_Comp_Date = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Comp_Category = new System.Windows.Forms.ComboBox();
            this.GroupBox_Filter.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Filter
            // 
            this.GroupBox_Filter.Controls.Add(this.textBox_FilterEmail);
            this.GroupBox_Filter.Controls.Add(this.textBox_FilterLastName);
            this.GroupBox_Filter.Controls.Add(this.textBox_FilterId);
            this.GroupBox_Filter.Controls.Add(this.label3);
            this.GroupBox_Filter.Controls.Add(this.label4);
            this.GroupBox_Filter.Controls.Add(this.label5);
            this.GroupBox_Filter.Location = new System.Drawing.Point(12, 40);
            this.GroupBox_Filter.Name = "GroupBox_Filter";
            this.GroupBox_Filter.Size = new System.Drawing.Size(236, 142);
            this.GroupBox_Filter.TabIndex = 27;
            this.GroupBox_Filter.TabStop = false;
            this.GroupBox_Filter.Text = "Filter Client";
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
            // listBox_Clients
            // 
            this.listBox_Clients.FormattingEnabled = true;
            this.listBox_Clients.ItemHeight = 16;
            this.listBox_Clients.Location = new System.Drawing.Point(12, 188);
            this.listBox_Clients.Name = "listBox_Clients";
            this.listBox_Clients.Size = new System.Drawing.Size(247, 292);
            this.listBox_Clients.TabIndex = 26;
            this.listBox_Clients.DoubleClick += new System.EventHandler(this.listBox_Clients_DoubleClick);
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Location = new System.Drawing.Point(173, 502);
            this.label_Client.Name = "label_Client";
            this.label_Client.Size = new System.Drawing.Size(42, 17);
            this.label_Client.TabIndex = 29;
            this.label_Client.Text = "None";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 502);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Client:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Choose Client:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Make/Choose Competition:";
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_delete.Location = new System.Drawing.Point(586, 203);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 34);
            this.button_delete.TabIndex = 39;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
            // 
            // textBox_Comp_Name
            // 
            this.textBox_Comp_Name.Location = new System.Drawing.Point(589, 95);
            this.textBox_Comp_Name.Name = "textBox_Comp_Name";
            this.textBox_Comp_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Comp_Name.TabIndex = 38;
            // 
            // label_Comp_id
            // 
            this.label_Comp_id.AutoSize = true;
            this.label_Comp_id.Location = new System.Drawing.Point(586, 63);
            this.label_Comp_id.Name = "label_Comp_id";
            this.label_Comp_id.Size = new System.Drawing.Size(16, 17);
            this.label_Comp_id.TabIndex = 37;
            this.label_Comp_id.Text = "0";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(505, 100);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(45, 17);
            this.Name_Label.TabIndex = 36;
            this.Name_Label.Text = "Name";
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(505, 203);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 65);
            this.button_save.TabIndex = 35;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(586, 232);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 36);
            this.button_clear.TabIndex = 34;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            // 
            // listBox_Comp
            // 
            this.listBox_Comp.FormattingEnabled = true;
            this.listBox_Comp.ItemHeight = 16;
            this.listBox_Comp.Location = new System.Drawing.Point(265, 216);
            this.listBox_Comp.Name = "listBox_Comp";
            this.listBox_Comp.Size = new System.Drawing.Size(229, 260);
            this.listBox_Comp.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 17);
            this.label7.TabIndex = 32;
            this.label7.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Category";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(505, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 42;
            this.label9.Text = "Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_To);
            this.groupBox1.Controls.Add(this.comboBox_FilterLevel);
            this.groupBox1.Controls.Add(this.dateTimePicker_From);
            this.groupBox1.Controls.Add(this.comboBox_FilterCategory);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label_level);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(265, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 172);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter Competition";
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_To.Location = new System.Drawing.Point(76, 145);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker_To.TabIndex = 48;
            // 
            // comboBox_FilterLevel
            // 
            this.comboBox_FilterLevel.FormattingEnabled = true;
            this.comboBox_FilterLevel.Location = new System.Drawing.Point(76, 86);
            this.comboBox_FilterLevel.Name = "comboBox_FilterLevel";
            this.comboBox_FilterLevel.Size = new System.Drawing.Size(100, 24);
            this.comboBox_FilterLevel.TabIndex = 30;
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_From.Location = new System.Drawing.Point(76, 117);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(100, 22);
            this.dateTimePicker_From.TabIndex = 47;
            this.dateTimePicker_From.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // comboBox_FilterCategory
            // 
            this.comboBox_FilterCategory.FormattingEnabled = true;
            this.comboBox_FilterCategory.Location = new System.Drawing.Point(76, 55);
            this.comboBox_FilterCategory.Name = "comboBox_FilterCategory";
            this.comboBox_FilterCategory.Size = new System.Drawing.Size(100, 24);
            this.comboBox_FilterCategory.TabIndex = 29;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(5, 138);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(25, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "To";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(76, 27);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 17);
            this.label13.TabIndex = 45;
            this.label13.Text = "From";
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.Location = new System.Drawing.Point(5, 86);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(42, 17);
            this.label_level.TabIndex = 26;
            this.label_level.Text = "Level";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "Category";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(5, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(21, 17);
            this.label11.TabIndex = 28;
            this.label11.Text = "ID";
            // 
            // dtp_Comp_Date
            // 
            this.dtp_Comp_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Comp_Date.Location = new System.Drawing.Point(589, 133);
            this.dtp_Comp_Date.Name = "dtp_Comp_Date";
            this.dtp_Comp_Date.Size = new System.Drawing.Size(100, 22);
            this.dtp_Comp_Date.TabIndex = 48;
            this.dtp_Comp_Date.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // comboBox_Comp_Category
            // 
            this.comboBox_Comp_Category.FormattingEnabled = true;
            this.comboBox_Comp_Category.Location = new System.Drawing.Point(589, 167);
            this.comboBox_Comp_Category.Name = "comboBox_Comp_Category";
            this.comboBox_Comp_Category.Size = new System.Drawing.Size(100, 24);
            this.comboBox_Comp_Category.TabIndex = 49;
            // 
            // Form_Comp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 531);
            this.Controls.Add(this.comboBox_Comp_Category);
            this.Controls.Add(this.dtp_Comp_Date);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_Comp_Name);
            this.Controls.Add(this.label_Comp_id);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.listBox_Comp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Client);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GroupBox_Filter);
            this.Controls.Add(this.listBox_Clients);
            this.Name = "Form_Comp";
            this.Text = "Form_Comp";
            this.GroupBox_Filter.ResumeLayout(false);
            this.GroupBox_Filter.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBox_Filter;
        private System.Windows.Forms.TextBox textBox_FilterEmail;
        private System.Windows.Forms.TextBox textBox_FilterLastName;
        private System.Windows.Forms.TextBox textBox_FilterId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_Clients;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_Comp_Name;
        private System.Windows.Forms.Label label_Comp_id;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.ListBox listBox_Comp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_FilterLevel;
        private System.Windows.Forms.ComboBox comboBox_FilterCategory;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp_Comp_Date;
        private System.Windows.Forms.ComboBox comboBox_Comp_Category;
    }
}