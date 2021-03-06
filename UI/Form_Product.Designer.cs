
namespace WFP_GOS.UI
{
    partial class Form_Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Product));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.listBox_Products = new System.Windows.Forms.ListBox();
            this.GroupBox_Filter = new System.Windows.Forms.GroupBox();
            this.comboBox_FilterLevel = new System.Windows.Forms.ComboBox();
            this.comboBox_FilterCategory = new System.Windows.Forms.ComboBox();
            this.textBox_FilterID = new System.Windows.Forms.TextBox();
            this.label_level = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.label_Id = new System.Windows.Forms.Label();
            this.comboBox_Level = new System.Windows.Forms.ComboBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nUD_Places = new System.Windows.Forms.NumericUpDown();
            this.button_Delete = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.GroupBox_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Places)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(438, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Level:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(438, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Category:";
            // 
            // button_Clear
            // 
            this.button_Clear.FlatAppearance.BorderSize = 0;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(549, 327);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 42);
            this.button_Clear.TabIndex = 8;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Save
            // 
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(655, 327);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(77, 42);
            this.button_Save.TabIndex = 9;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // listBox_Products
            // 
            this.listBox_Products.FormattingEnabled = true;
            this.listBox_Products.ItemHeight = 16;
            this.listBox_Products.Location = new System.Drawing.Point(12, 252);
            this.listBox_Products.Name = "listBox_Products";
            this.listBox_Products.Size = new System.Drawing.Size(391, 244);
            this.listBox_Products.TabIndex = 20;
            this.listBox_Products.DoubleClick += new System.EventHandler(this.listBox_Products_DoubleClick);
            // 
            // GroupBox_Filter
            // 
            this.GroupBox_Filter.Controls.Add(this.comboBox_FilterLevel);
            this.GroupBox_Filter.Controls.Add(this.comboBox_FilterCategory);
            this.GroupBox_Filter.Controls.Add(this.textBox_FilterID);
            this.GroupBox_Filter.Controls.Add(this.label_level);
            this.GroupBox_Filter.Controls.Add(this.label10);
            this.GroupBox_Filter.Controls.Add(this.label11);
            this.GroupBox_Filter.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Filter.Location = new System.Drawing.Point(12, 104);
            this.GroupBox_Filter.Name = "GroupBox_Filter";
            this.GroupBox_Filter.Size = new System.Drawing.Size(253, 142);
            this.GroupBox_Filter.TabIndex = 26;
            this.GroupBox_Filter.TabStop = false;
            this.GroupBox_Filter.Text = "Filter";
            // 
            // comboBox_FilterLevel
            // 
            this.comboBox_FilterLevel.FormattingEnabled = true;
            this.comboBox_FilterLevel.Location = new System.Drawing.Point(121, 103);
            this.comboBox_FilterLevel.Name = "comboBox_FilterLevel";
            this.comboBox_FilterLevel.Size = new System.Drawing.Size(100, 25);
            this.comboBox_FilterLevel.TabIndex = 30;
            this.comboBox_FilterLevel.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // comboBox_FilterCategory
            // 
            this.comboBox_FilterCategory.FormattingEnabled = true;
            this.comboBox_FilterCategory.Location = new System.Drawing.Point(121, 66);
            this.comboBox_FilterCategory.Name = "comboBox_FilterCategory";
            this.comboBox_FilterCategory.Size = new System.Drawing.Size(100, 25);
            this.comboBox_FilterCategory.TabIndex = 29;
            this.comboBox_FilterCategory.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_TextChanged);
            // 
            // textBox_FilterID
            // 
            this.textBox_FilterID.Location = new System.Drawing.Point(121, 29);
            this.textBox_FilterID.Name = "textBox_FilterID";
            this.textBox_FilterID.Size = new System.Drawing.Size(100, 23);
            this.textBox_FilterID.TabIndex = 26;
            this.textBox_FilterID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_Product_Filter_KeyUp);
            // 
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.Location = new System.Drawing.Point(6, 110);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(44, 19);
            this.label_level.TabIndex = 26;
            this.label_level.Text = "Level";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Category";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 19);
            this.label11.TabIndex = 28;
            this.label11.Text = "ID";
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_ProductName.Location = new System.Drawing.Point(565, 134);
            this.textBox_ProductName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(156, 23);
            this.textBox_ProductName.TabIndex = 27;
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(675, 87);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(17, 19);
            this.label_Id.TabIndex = 31;
            this.label_Id.Text = "0";
            // 
            // comboBox_Level
            // 
            this.comboBox_Level.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Level.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Level.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Level.FormattingEnabled = true;
            this.comboBox_Level.Items.AddRange(new object[] {
            "Not Specified",
            "Male",
            "Female",
            "Non-Binary",
            "Prefer Not To Say"});
            this.comboBox_Level.Location = new System.Drawing.Point(565, 233);
            this.comboBox_Level.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Level.Name = "comboBox_Level";
            this.comboBox_Level.Size = new System.Drawing.Size(156, 25);
            this.comboBox_Level.TabIndex = 32;
            this.comboBox_Level.Text = "Choose Level";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_Category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Category.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Items.AddRange(new object[] {
            "Not Specified",
            "Male",
            "Female",
            "Non-Binary",
            "Prefer Not To Say"});
            this.comboBox_Category.Location = new System.Drawing.Point(565, 186);
            this.comboBox_Category.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(156, 25);
            this.comboBox_Category.TabIndex = 33;
            this.comboBox_Category.Text = "Choose Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(438, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Places:";
            // 
            // nUD_Places
            // 
            this.nUD_Places.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUD_Places.Location = new System.Drawing.Point(565, 281);
            this.nUD_Places.Name = "nUD_Places";
            this.nUD_Places.Size = new System.Drawing.Size(156, 23);
            this.nUD_Places.TabIndex = 35;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Red;
            this.button_Delete.FlatAppearance.BorderSize = 0;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Delete.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Delete.ForeColor = System.Drawing.Color.Black;
            this.button_Delete.Location = new System.Drawing.Point(441, 327);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 42);
            this.button_Delete.TabIndex = 37;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = false;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(245, 85);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 530);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 17);
            this.label6.TabIndex = 40;
            this.label6.Text = "© 2022 Apex MMA, Incorporated";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(-6, 502);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(815, 93);
            this.pictureBox3.TabIndex = 39;
            this.pictureBox3.TabStop = false;
            // 
            // Form_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 573);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.nUD_Places);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.comboBox_Level);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.textBox_ProductName);
            this.Controls.Add(this.GroupBox_Filter);
            this.Controls.Add(this.listBox_Products);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Product";
            this.Text = "Product";
            this.GroupBox_Filter.ResumeLayout(false);
            this.GroupBox_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUD_Places)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.ListBox listBox_Products;
        private System.Windows.Forms.GroupBox GroupBox_Filter;
        private System.Windows.Forms.TextBox textBox_FilterID;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_ProductName;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.ComboBox comboBox_Level;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ComboBox comboBox_FilterLevel;
        private System.Windows.Forms.ComboBox comboBox_FilterCategory;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUD_Places;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}