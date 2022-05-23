
namespace WFP_GOS.UI
{
    partial class BestSellingClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestSellingClass));
            this.comboBox_FilterLevel = new System.Windows.Forms.ComboBox();
            this.comboBox_FilterCategory = new System.Windows.Forms.ComboBox();
            this.textBox_FilterName = new System.Windows.Forms.TextBox();
            this.label_level = new System.Windows.Forms.Label();
            this.Label_Name = new System.Windows.Forms.Label();
            this.GroupBox_Filter = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button1 = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.AmntSold = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClassName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView_Products = new System.Windows.Forms.ListView();
            this.GroupBox_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox_FilterLevel
            // 
            this.comboBox_FilterLevel.FormattingEnabled = true;
            this.comboBox_FilterLevel.Location = new System.Drawing.Point(106, 103);
            this.comboBox_FilterLevel.Name = "comboBox_FilterLevel";
            this.comboBox_FilterLevel.Size = new System.Drawing.Size(133, 25);
            this.comboBox_FilterLevel.TabIndex = 30;
            this.comboBox_FilterLevel.TextChanged += new System.EventHandler(this.comboBox_FilterLevel_TextChanged);
            // 
            // comboBox_FilterCategory
            // 
            this.comboBox_FilterCategory.FormattingEnabled = true;
            this.comboBox_FilterCategory.Location = new System.Drawing.Point(106, 66);
            this.comboBox_FilterCategory.Name = "comboBox_FilterCategory";
            this.comboBox_FilterCategory.Size = new System.Drawing.Size(133, 25);
            this.comboBox_FilterCategory.TabIndex = 29;
            this.comboBox_FilterCategory.TextChanged += new System.EventHandler(this.comboBox_FilterCategory_TextChanged);
            // 
            // textBox_FilterName
            // 
            this.textBox_FilterName.Location = new System.Drawing.Point(106, 29);
            this.textBox_FilterName.Name = "textBox_FilterName";
            this.textBox_FilterName.Size = new System.Drawing.Size(133, 23);
            this.textBox_FilterName.TabIndex = 26;
            this.textBox_FilterName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Text_KeyPress);
            this.textBox_FilterName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox_FilterName_KeyUp);
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
            // Label_Name
            // 
            this.Label_Name.AutoSize = true;
            this.Label_Name.Location = new System.Drawing.Point(6, 32);
            this.Label_Name.Name = "Label_Name";
            this.Label_Name.Size = new System.Drawing.Size(51, 19);
            this.Label_Name.TabIndex = 28;
            this.Label_Name.Text = "Name";
            // 
            // GroupBox_Filter
            // 
            this.GroupBox_Filter.Controls.Add(this.comboBox_FilterLevel);
            this.GroupBox_Filter.Controls.Add(this.comboBox_FilterCategory);
            this.GroupBox_Filter.Controls.Add(this.textBox_FilterName);
            this.GroupBox_Filter.Controls.Add(this.label_level);
            this.GroupBox_Filter.Controls.Add(this.label16);
            this.GroupBox_Filter.Controls.Add(this.Label_Name);
            this.GroupBox_Filter.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Filter.Location = new System.Drawing.Point(729, 12);
            this.GroupBox_Filter.Name = "GroupBox_Filter";
            this.GroupBox_Filter.Size = new System.Drawing.Size(260, 156);
            this.GroupBox_Filter.TabIndex = 31;
            this.GroupBox_Filter.TabStop = false;
            this.GroupBox_Filter.Text = "Filter";
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
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(723, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 55);
            this.button1.TabIndex = 30;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Print_Click);
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.document_PrintPage);
            // 
            // AmntSold
            // 
            this.AmntSold.Text = "Amount Sold";
            this.AmntSold.Width = 411;
            // 
            // ClassName
            // 
            this.ClassName.Text = "ClassName";
            this.ClassName.Width = 309;
            // 
            // listView_Products
            // 
            this.listView_Products.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ClassName,
            this.AmntSold});
            this.listView_Products.HideSelection = false;
            this.listView_Products.Location = new System.Drawing.Point(20, 12);
            this.listView_Products.Name = "listView_Products";
            this.listView_Products.Size = new System.Drawing.Size(697, 426);
            this.listView_Products.TabIndex = 29;
            this.listView_Products.UseCompatibleStateImageBehavior = false;
            this.listView_Products.View = System.Windows.Forms.View.Details;
            // 
            // BestSellingClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 509);
            this.Controls.Add(this.GroupBox_Filter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView_Products);
            this.Name = "BestSellingClass";
            this.Text = "BestSellingClass";
            this.GroupBox_Filter.ResumeLayout(false);
            this.GroupBox_Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox_FilterLevel;
        private System.Windows.Forms.ComboBox comboBox_FilterCategory;
        private System.Windows.Forms.TextBox textBox_FilterName;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label Label_Name;
        private System.Windows.Forms.GroupBox GroupBox_Filter;
        private System.Windows.Forms.Label label16;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ColumnHeader AmntSold;
        private System.Windows.Forms.ColumnHeader ClassName;
        private System.Windows.Forms.ListView listView_Products;
    }
}