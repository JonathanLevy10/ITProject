
namespace WFP_GOS.UI
{
    partial class Form_Level
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.listBox_Level = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(300, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 16;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(381, 44);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Name.TabIndex = 15;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(378, 12);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(16, 17);
            this.label_id.TabIndex = 14;
            this.label_id.Text = "0";
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(179, 44);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(45, 17);
            this.Name_Label.TabIndex = 13;
            this.Name_Label.Text = "Name";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(208, 319);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 65);
            this.save.TabIndex = 12;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(300, 348);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 36);
            this.clear.TabIndex = 11;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // listBox_Level
            // 
            this.listBox_Level.FormattingEnabled = true;
            this.listBox_Level.ItemHeight = 16;
            this.listBox_Level.Location = new System.Drawing.Point(12, 12);
            this.listBox_Level.Name = "listBox_Level";
            this.listBox_Level.Size = new System.Drawing.Size(161, 372);
            this.listBox_Level.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            // 
            // Form_Level
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
            this.Controls.Add(this.listBox_Level);
            this.Controls.Add(this.label1);
            this.Name = "Form_Level";
            this.Text = "Form_Level";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.ListBox listBox_Level;
        private System.Windows.Forms.Label label1;
    }
}