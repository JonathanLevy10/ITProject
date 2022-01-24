
namespace ClientSignup.UI
{
    partial class Form_Category
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
            this.button_delete = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.Name_Label = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.listBox_Category = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_delete.Location = new System.Drawing.Point(300, 319);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 34);
            this.button_delete.TabIndex = 16;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = false;
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
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(208, 319);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 65);
            this.button_save.TabIndex = 12;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(300, 348);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 36);
            this.button_clear.TabIndex = 11;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            // 
            // listBox_Category
            // 
            this.listBox_Category.FormattingEnabled = true;
            this.listBox_Category.ItemHeight = 16;
            this.listBox_Category.Location = new System.Drawing.Point(12, 12);
            this.listBox_Category.Name = "listBox_Category";
            this.listBox_Category.Size = new System.Drawing.Size(161, 372);
            this.listBox_Category.TabIndex = 10;
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
            // Form_Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.listBox_Category);
            this.Controls.Add(this.label1);
            this.Name = "Form_Category";
            this.Text = "Form_Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.ListBox listBox_Category;
        private System.Windows.Forms.Label label1;
    }
}