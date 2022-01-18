
namespace ClientSignup.UI
{
    partial class Form_Location
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
            this.label1 = new System.Windows.Forms.Label();
            this.listBox_Location = new System.Windows.Forms.ListBox();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.Name_Label = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // listBox_Location
            // 
            this.listBox_Location.FormattingEnabled = true;
            this.listBox_Location.ItemHeight = 16;
            this.listBox_Location.Location = new System.Drawing.Point(15, 28);
            this.listBox_Location.Name = "listBox_Location";
            this.listBox_Location.Size = new System.Drawing.Size(161, 372);
            this.listBox_Location.TabIndex = 2;
            this.listBox_Location.DoubleClick += new System.EventHandler(this.listBox_Location_DoubleClick);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(303, 364);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 36);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(211, 335);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 65);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(182, 60);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(45, 17);
            this.Name_Label.TabIndex = 5;
            this.Name_Label.Text = "Name";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(381, 28);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(16, 17);
            this.label_id.TabIndex = 6;
            this.label_id.Text = "0";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(384, 60);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Name.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(303, 335);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // Form_Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.listBox_Location);
            this.Controls.Add(this.label1);
            this.Name = "Form_Location";
            this.Text = "Form_Location";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_Location;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button1;
    }
}