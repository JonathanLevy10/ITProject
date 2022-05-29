
namespace WFP_GOS.UI
{
    partial class Form_ProductsReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ProductsReport));
            this.listView_Products = new System.Windows.Forms.ListView();
            this.Names = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Level = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.GroupBox_Filter = new System.Windows.Forms.GroupBox();
            this.textBox_CountTo = new System.Windows.Forms.TextBox();
            this.textBox_CountFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_FilterLevel = new System.Windows.Forms.ComboBox();
            this.comboBox_FilterCategory = new System.Windows.Forms.ComboBox();
            this.textBox_FilterName = new System.Windows.Forms.TextBox();
            this.label_level = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.GroupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView_Products
            // 
            this.listView_Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Names,
            this.Category,
            this.Level,
            this.Count});
            this.listView_Products.HideSelection = false;
            this.listView_Products.Location = new System.Drawing.Point(12, 12);
            this.listView_Products.Name = "listView_Products";
            this.listView_Products.Size = new System.Drawing.Size(697, 426);
            this.listView_Products.TabIndex = 0;
            this.listView_Products.UseCompatibleStateImageBehavior = false;
            this.listView_Products.View = System.Windows.Forms.View.Details;
            this.listView_Products.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_Products_ColumnClick);
            // 
            // Names
            // 
            this.Names.Text = "Name";
            this.Names.Width = 89;
            // 
            // Category
            // 
            this.Category.Text = "Category";
            this.Category.Width = 143;
            // 
            // Level
            // 
            this.Level.Text = "Level";
            this.Level.Width = 119;
            // 
            // Count
            // 
            this.Count.Text = "Count";
            this.Count.Width = 52;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(715, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 55);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Print_Click);
            // 
            // GroupBox_Filter
            // 
            this.GroupBox_Filter.Controls.Add(this.textBox_CountTo);
            this.GroupBox_Filter.Controls.Add(this.textBox_CountFrom);
            this.GroupBox_Filter.Controls.Add(this.label2);
            this.GroupBox_Filter.Controls.Add(this.label1);
            this.GroupBox_Filter.Controls.Add(this.comboBox_FilterLevel);
            this.GroupBox_Filter.Controls.Add(this.comboBox_FilterCategory);
            this.GroupBox_Filter.Controls.Add(this.textBox_FilterName);
            this.GroupBox_Filter.Controls.Add(this.label_level);
            this.GroupBox_Filter.Controls.Add(this.label16);
            this.GroupBox_Filter.Controls.Add(this.Label_Name);
            this.GroupBox_Filter.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Filter.Location = new System.Drawing.Point(812, 30);
            this.GroupBox_Filter.Name = "GroupBox_Filter";
            this.GroupBox_Filter.Size = new System.Drawing.Size(245, 243);
            this.GroupBox_Filter.TabIndex = 28;
            this.GroupBox_Filter.TabStop = false;
            this.GroupBox_Filter.Text = "Filter";
            // 
            // textBox_CountTo
            // 
            this.textBox_CountTo.Location = new System.Drawing.Point(106, 188);
            this.textBox_CountTo.Name = "textBox_CountTo";
            this.textBox_CountTo.Size = new System.Drawing.Size(133, 23);
            this.textBox_CountTo.TabIndex = 34;
            this.textBox_CountTo.Text = "100";
            // 
            // textBox_CountFrom
            // 
            this.textBox_CountFrom.Location = new System.Drawing.Point(106, 144);
            this.textBox_CountFrom.Name = "textBox_CountFrom";
            this.textBox_CountFrom.Size = new System.Drawing.Size(133, 23);
            this.textBox_CountFrom.TabIndex = 33;
            this.textBox_CountFrom.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 32;
            this.label2.Text = "Count (from)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 31;
            this.label1.Text = "Count (to)";
            // 
            // comboBox_FilterLevel
            // 
            this.comboBox_FilterLevel.FormattingEnabled = true;
            this.comboBox_FilterLevel.Location = new System.Drawing.Point(106, 103);
            this.comboBox_FilterLevel.Name = "comboBox_FilterLevel";
            this.comboBox_FilterLevel.Size = new System.Drawing.Size(133, 25);
            this.comboBox_FilterLevel.TabIndex = 30;
            // 
            // comboBox_FilterCategory
            // 
            this.comboBox_FilterCategory.FormattingEnabled = true;
            this.comboBox_FilterCategory.Location = new System.Drawing.Point(106, 66);
            this.comboBox_FilterCategory.Name = "comboBox_FilterCategory";
            this.comboBox_FilterCategory.Size = new System.Drawing.Size(133, 25);
            this.comboBox_FilterCategory.TabIndex = 29;
            // 
            // textBox_FilterName
            // 
            this.textBox_FilterName.Location = new System.Drawing.Point(106, 29);
            this.textBox_FilterName.Name = "textBox_FilterName";
            this.textBox_FilterName.Size = new System.Drawing.Size(133, 23);
            this.textBox_FilterName.TabIndex = 26;
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
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 73);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 19);
            this.label16.TabIndex = 27;
            this.label16.Text = "Category";
            // 
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(6, 32);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(51, 19);
            this.Label_Name.TabIndex = 28;
            this.Label_Name.Text = "Name";
            // 
            // Form_ProductsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 446);
            this.Controls.Add(this.GroupBox_Filter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView_Products);
            this.Name = "Form_ProductsReport";
            this.Text = "Products Report";
            this.GroupBox_Filter.ResumeLayout(false);
            this.GroupBox_Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_Products;
        private System.Windows.Forms.ColumnHeader Names;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader Level;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox GroupBox_Filter;
        private System.Windows.Forms.TextBox textBox_CountTo;
        private System.Windows.Forms.TextBox textBox_CountFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_FilterLevel;
        private System.Windows.Forms.ComboBox comboBox_FilterCategory;
        private System.Windows.Forms.TextBox textBox_FilterName;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label Label_Name;
    }
}