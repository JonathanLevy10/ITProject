
namespace ClientSignup.UI
{
    partial class Form_BackgroundMA
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
            this.listBox_BackgroundMA = new System.Windows.Forms.ListBox();
            this.clear = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.Name_Label = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
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
            // listBox_BackgroundMA
            // 
            this.listBox_BackgroundMA.FormattingEnabled = true;
            this.listBox_BackgroundMA.ItemHeight = 16;
            this.listBox_BackgroundMA.Location = new System.Drawing.Point(15, 28);
            this.listBox_BackgroundMA.Name = "listBox_BackgroundMA";
            this.listBox_BackgroundMA.Size = new System.Drawing.Size(161, 372);
            this.listBox_BackgroundMA.TabIndex = 2;
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(303, 377);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 3;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(198, 377);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 4;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(182, 60);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(152, 17);
            this.Name_Label.TabIndex = 5;
            this.Name_Label.Text = "Background Martial Art";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(381, 28);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(38, 17);
            this.label_id.TabIndex = 6;
            this.label_id.Text = "label";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(384, 60);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(100, 22);
            this.textBox_Name.TabIndex = 7;
            // 
            // Form_BackgroundMA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.Name_Label);
            this.Controls.Add(this.save);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.listBox_BackgroundMA);
            this.Controls.Add(this.label1);
            this.Name = "Form_BackgroundMA";
            this.Text = "Form_BackgroundMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox_BackgroundMA;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBox_Name;
    }
}