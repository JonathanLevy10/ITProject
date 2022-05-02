
namespace WFP_GOS.UI
{
    partial class Form_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Order));
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.OrderItems = new System.Windows.Forms.TabPage();
            this.listBox_Potential = new System.Windows.Forms.ListBox();
            this.listBox_InOrderProducts = new System.Windows.Forms.ListBox();
            this.GroupBox_Filter = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label_level = new System.Windows.Forms.Label();
            this.textBox_FilterID = new System.Windows.Forms.TextBox();
            this.comboBox_FilterCategory = new System.Windows.Forms.ComboBox();
            this.comboBox_FilterLevel = new System.Windows.Forms.ComboBox();
            this.listBox_InOrderProductsCount = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OrderClient = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Email_Filter = new System.Windows.Forms.Label();
            this.textBox_Filter_LastName = new System.Windows.Forms.TextBox();
            this.textBox_Filter_Email = new System.Windows.Forms.TextBox();
            this.listBox_Client = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label_LastName_Chosen = new System.Windows.Forms.Label();
            this.label_Email_Chosen = new System.Windows.Forms.Label();
            this.label_FirstName_Chosen = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_Id_Chosen = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label_Name_Chosen = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.OrderDetails = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Filter_OrderDetails_ID = new System.Windows.Forms.TextBox();
            this.client_TextBox_Filter = new System.Windows.Forms.TextBox();
            this.dateTimePicker_From = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_To = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBox_Orders = new System.Windows.Forms.ListBox();
            this.textBox_Note = new System.Windows.Forms.TextBox();
            this.label_Client = new System.Windows.Forms.Label();
            this.Date_DateTime = new System.Windows.Forms.DateTimePicker();
            this.tabControl_Order = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.OrderItems.SuspendLayout();
            this.GroupBox_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.OrderClient.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.OrderDetails.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl_Order.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Save
            // 
            this.button_Save.BackColor = System.Drawing.Color.White;
            this.button_Save.FlatAppearance.BorderSize = 0;
            this.button_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Save.Location = new System.Drawing.Point(638, 440);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(75, 52);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = false;
            // 
            // button_Clear
            // 
            this.button_Clear.BackColor = System.Drawing.Color.White;
            this.button_Clear.FlatAppearance.BorderSize = 0;
            this.button_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Clear.Location = new System.Drawing.Point(713, 440);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 52);
            this.button_Clear.TabIndex = 2;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = false;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 17);
            this.label5.TabIndex = 32;
            this.label5.Text = "© 2022 Apex MMA, Incorporated";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(0, 440);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(856, 93);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // OrderItems
            // 
            this.OrderItems.AccessibleName = "";
            this.OrderItems.Controls.Add(this.pictureBox1);
            this.OrderItems.Controls.Add(this.listBox_InOrderProductsCount);
            this.OrderItems.Controls.Add(this.GroupBox_Filter);
            this.OrderItems.Controls.Add(this.listBox_InOrderProducts);
            this.OrderItems.Controls.Add(this.listBox_Potential);
            this.OrderItems.Location = new System.Drawing.Point(4, 25);
            this.OrderItems.Name = "OrderItems";
            this.OrderItems.Padding = new System.Windows.Forms.Padding(3);
            this.OrderItems.Size = new System.Drawing.Size(852, 410);
            this.OrderItems.TabIndex = 2;
            this.OrderItems.Text = "Order Items";
            this.OrderItems.UseVisualStyleBackColor = true;
            // 
            // listBox_Potential
            // 
            this.listBox_Potential.FormattingEnabled = true;
            this.listBox_Potential.ItemHeight = 16;
            this.listBox_Potential.Location = new System.Drawing.Point(289, 18);
            this.listBox_Potential.Name = "listBox_Potential";
            this.listBox_Potential.Size = new System.Drawing.Size(232, 372);
            this.listBox_Potential.TabIndex = 0;
            this.listBox_Potential.DoubleClick += new System.EventHandler(this.Potential_ListBox_DoubleClick);
            // 
            // listBox_InOrderProducts
            // 
            this.listBox_InOrderProducts.FormattingEnabled = true;
            this.listBox_InOrderProducts.ItemHeight = 16;
            this.listBox_InOrderProducts.Location = new System.Drawing.Point(527, 18);
            this.listBox_InOrderProducts.Name = "listBox_InOrderProducts";
            this.listBox_InOrderProducts.Size = new System.Drawing.Size(232, 372);
            this.listBox_InOrderProducts.TabIndex = 1;
            this.listBox_InOrderProducts.DoubleClick += new System.EventHandler(this.InOrder_ListBox_DoubleClick);
            // 
            // GroupBox_Filter
            // 
            this.GroupBox_Filter.Controls.Add(this.comboBox_FilterLevel);
            this.GroupBox_Filter.Controls.Add(this.comboBox_FilterCategory);
            this.GroupBox_Filter.Controls.Add(this.textBox_FilterID);
            this.GroupBox_Filter.Controls.Add(this.label_level);
            this.GroupBox_Filter.Controls.Add(this.label16);
            this.GroupBox_Filter.Controls.Add(this.label18);
            this.GroupBox_Filter.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox_Filter.Location = new System.Drawing.Point(23, 18);
            this.GroupBox_Filter.Name = "GroupBox_Filter";
            this.GroupBox_Filter.Size = new System.Drawing.Size(245, 166);
            this.GroupBox_Filter.TabIndex = 27;
            this.GroupBox_Filter.TabStop = false;
            this.GroupBox_Filter.Text = "Filter";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(22, 19);
            this.label18.TabIndex = 28;
            this.label18.Text = "ID";
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
            // label_level
            // 
            this.label_level.AutoSize = true;
            this.label_level.Location = new System.Drawing.Point(6, 110);
            this.label_level.Name = "label_level";
            this.label_level.Size = new System.Drawing.Size(44, 19);
            this.label_level.TabIndex = 26;
            this.label_level.Text = "Level";
            // 
            // textBox_FilterID
            // 
            this.textBox_FilterID.Location = new System.Drawing.Point(84, 29);
            this.textBox_FilterID.Name = "textBox_FilterID";
            this.textBox_FilterID.Size = new System.Drawing.Size(137, 23);
            this.textBox_FilterID.TabIndex = 26;
            this.textBox_FilterID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GroupBox_Filter_KeyUp);
            // 
            // comboBox_FilterCategory
            // 
            this.comboBox_FilterCategory.FormattingEnabled = true;
            this.comboBox_FilterCategory.Location = new System.Drawing.Point(84, 66);
            this.comboBox_FilterCategory.Name = "comboBox_FilterCategory";
            this.comboBox_FilterCategory.Size = new System.Drawing.Size(137, 25);
            this.comboBox_FilterCategory.TabIndex = 29;
            this.comboBox_FilterCategory.SelectedValueChanged += new System.EventHandler(this.comboBox_FilterProduct_SelectedValueChanged);
            // 
            // comboBox_FilterLevel
            // 
            this.comboBox_FilterLevel.FormattingEnabled = true;
            this.comboBox_FilterLevel.Location = new System.Drawing.Point(84, 103);
            this.comboBox_FilterLevel.Name = "comboBox_FilterLevel";
            this.comboBox_FilterLevel.Size = new System.Drawing.Size(137, 25);
            this.comboBox_FilterLevel.TabIndex = 30;
            this.comboBox_FilterLevel.SelectedValueChanged += new System.EventHandler(this.comboBox_FilterProduct_SelectedValueChanged);
            // 
            // listBox_InOrderProductsCount
            // 
            this.listBox_InOrderProductsCount.FormattingEnabled = true;
            this.listBox_InOrderProductsCount.ItemHeight = 16;
            this.listBox_InOrderProductsCount.Location = new System.Drawing.Point(765, 18);
            this.listBox_InOrderProductsCount.Name = "listBox_InOrderProductsCount";
            this.listBox_InOrderProductsCount.Size = new System.Drawing.Size(57, 372);
            this.listBox_InOrderProductsCount.TabIndex = 33;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // OrderClient
            // 
            this.OrderClient.Controls.Add(this.pictureBox2);
            this.OrderClient.Controls.Add(this.label_Name_Chosen);
            this.OrderClient.Controls.Add(this.label15);
            this.OrderClient.Controls.Add(this.groupBox3);
            this.OrderClient.Controls.Add(this.listBox_Client);
            this.OrderClient.Controls.Add(this.groupBox2);
            this.OrderClient.Location = new System.Drawing.Point(4, 25);
            this.OrderClient.Name = "OrderClient";
            this.OrderClient.Padding = new System.Windows.Forms.Padding(3);
            this.OrderClient.Size = new System.Drawing.Size(852, 410);
            this.OrderClient.TabIndex = 1;
            this.OrderClient.Text = "Order Client";
            this.OrderClient.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_Filter_Email);
            this.groupBox2.Controls.Add(this.textBox_Filter_LastName);
            this.groupBox2.Controls.Add(this.label_Email_Filter);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(8, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Last Name";
            // 
            // label_Email_Filter
            // 
            this.label_Email_Filter.AutoSize = true;
            this.label_Email_Filter.Location = new System.Drawing.Point(6, 62);
            this.label_Email_Filter.Name = "label_Email_Filter";
            this.label_Email_Filter.Size = new System.Drawing.Size(46, 19);
            this.label_Email_Filter.TabIndex = 2;
            this.label_Email_Filter.Text = "Email";
            // 
            // textBox_Filter_LastName
            // 
            this.textBox_Filter_LastName.Location = new System.Drawing.Point(90, 24);
            this.textBox_Filter_LastName.Name = "textBox_Filter_LastName";
            this.textBox_Filter_LastName.Size = new System.Drawing.Size(94, 23);
            this.textBox_Filter_LastName.TabIndex = 1;
            this.textBox_Filter_LastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Names_KeyPress);
            this.textBox_Filter_LastName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxClient_Filter_KeyUp);
            // 
            // textBox_Filter_Email
            // 
            this.textBox_Filter_Email.Location = new System.Drawing.Point(90, 59);
            this.textBox_Filter_Email.Name = "textBox_Filter_Email";
            this.textBox_Filter_Email.Size = new System.Drawing.Size(94, 23);
            this.textBox_Filter_Email.TabIndex = 3;
            this.textBox_Filter_Email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Email_KeyPress);
            this.textBox_Filter_Email.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxClient_Filter_KeyUp);
            // 
            // listBox_Client
            // 
            this.listBox_Client.FormattingEnabled = true;
            this.listBox_Client.ItemHeight = 16;
            this.listBox_Client.Location = new System.Drawing.Point(8, 114);
            this.listBox_Client.Name = "listBox_Client";
            this.listBox_Client.Size = new System.Drawing.Size(200, 276);
            this.listBox_Client.TabIndex = 1;
            this.listBox_Client.DoubleClick += new System.EventHandler(this.listBox_Client_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_Id_Chosen);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label_FirstName_Chosen);
            this.groupBox3.Controls.Add(this.label_Email_Chosen);
            this.groupBox3.Controls.Add(this.label_LastName_Chosen);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(251, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(404, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chosen Client Details";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 19);
            this.label12.TabIndex = 3;
            this.label12.Text = "Last";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 19);
            this.label13.TabIndex = 4;
            this.label13.Text = "Email";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(247, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(33, 19);
            this.label14.TabIndex = 5;
            this.label14.Text = "First";
            // 
            // label_LastName_Chosen
            // 
            this.label_LastName_Chosen.AutoSize = true;
            this.label_LastName_Chosen.Location = new System.Drawing.Point(82, 29);
            this.label_LastName_Chosen.Name = "label_LastName_Chosen";
            this.label_LastName_Chosen.Size = new System.Drawing.Size(102, 19);
            this.label_LastName_Chosen.TabIndex = 7;
            this.label_LastName_Chosen.Text = "None Chosen";
            // 
            // label_Email_Chosen
            // 
            this.label_Email_Chosen.AutoSize = true;
            this.label_Email_Chosen.Location = new System.Drawing.Point(82, 64);
            this.label_Email_Chosen.Name = "label_Email_Chosen";
            this.label_Email_Chosen.Size = new System.Drawing.Size(102, 19);
            this.label_Email_Chosen.TabIndex = 8;
            this.label_Email_Chosen.Text = "None Chosen";
            // 
            // label_FirstName_Chosen
            // 
            this.label_FirstName_Chosen.AutoSize = true;
            this.label_FirstName_Chosen.Location = new System.Drawing.Point(303, 29);
            this.label_FirstName_Chosen.Name = "label_FirstName_Chosen";
            this.label_FirstName_Chosen.Size = new System.Drawing.Size(102, 19);
            this.label_FirstName_Chosen.TabIndex = 9;
            this.label_FirstName_Chosen.Text = "None Chosen";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(247, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 19);
            this.label7.TabIndex = 10;
            this.label7.Text = "ID";
            // 
            // label_Id_Chosen
            // 
            this.label_Id_Chosen.AutoSize = true;
            this.label_Id_Chosen.Location = new System.Drawing.Point(303, 64);
            this.label_Id_Chosen.Name = "label_Id_Chosen";
            this.label_Id_Chosen.Size = new System.Drawing.Size(102, 19);
            this.label_Id_Chosen.TabIndex = 11;
            this.label_Id_Chosen.Text = "None Chosen";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(248, 114);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(105, 19);
            this.label15.TabIndex = 3;
            this.label15.Text = "Client Chosen";
            // 
            // label_Name_Chosen
            // 
            this.label_Name_Chosen.AutoSize = true;
            this.label_Name_Chosen.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name_Chosen.Location = new System.Drawing.Point(361, 114);
            this.label_Name_Chosen.Name = "label_Name_Chosen";
            this.label_Name_Chosen.Size = new System.Drawing.Size(102, 19);
            this.label_Name_Chosen.TabIndex = 4;
            this.label_Name_Chosen.Text = "None Chosen";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(558, 265);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(288, 145);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // OrderDetails
            // 
            this.OrderDetails.Controls.Add(this.Date_DateTime);
            this.OrderDetails.Controls.Add(this.label_Client);
            this.OrderDetails.Controls.Add(this.textBox_Note);
            this.OrderDetails.Controls.Add(this.listBox_Orders);
            this.OrderDetails.Controls.Add(this.label9);
            this.OrderDetails.Controls.Add(this.label8);
            this.OrderDetails.Controls.Add(this.label_Id);
            this.OrderDetails.Controls.Add(this.label6);
            this.OrderDetails.Controls.Add(this.label2);
            this.OrderDetails.Controls.Add(this.groupBox1);
            this.OrderDetails.Location = new System.Drawing.Point(4, 25);
            this.OrderDetails.Name = "OrderDetails";
            this.OrderDetails.Padding = new System.Windows.Forms.Padding(3);
            this.OrderDetails.Size = new System.Drawing.Size(852, 410);
            this.OrderDetails.TabIndex = 0;
            this.OrderDetails.Text = "Order Details";
            this.OrderDetails.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_To);
            this.groupBox1.Controls.Add(this.dateTimePicker_From);
            this.groupBox1.Controls.Add(this.client_TextBox_Filter);
            this.groupBox1.Controls.Add(this.textBox_Filter_OrderDetails_ID);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 178);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Client";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "From";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 19);
            this.label11.TabIndex = 11;
            this.label11.Text = "Id";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 19);
            this.label10.TabIndex = 10;
            this.label10.Text = "To";
            // 
            // textBox_Filter_OrderDetails_ID
            // 
            this.textBox_Filter_OrderDetails_ID.Location = new System.Drawing.Point(104, 30);
            this.textBox_Filter_OrderDetails_ID.Name = "textBox_Filter_OrderDetails_ID";
            this.textBox_Filter_OrderDetails_ID.Size = new System.Drawing.Size(100, 23);
            this.textBox_Filter_OrderDetails_ID.TabIndex = 11;
            this.textBox_Filter_OrderDetails_ID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxOrderGroup_Filter_KeyUp);
            // 
            // client_TextBox_Filter
            // 
            this.client_TextBox_Filter.Location = new System.Drawing.Point(104, 145);
            this.client_TextBox_Filter.Name = "client_TextBox_Filter";
            this.client_TextBox_Filter.Size = new System.Drawing.Size(100, 23);
            this.client_TextBox_Filter.TabIndex = 14;
            this.client_TextBox_Filter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Names_KeyPress);
            this.client_TextBox_Filter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxOrderGroup_Filter_KeyUp);
            // 
            // dateTimePicker_From
            // 
            this.dateTimePicker_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_From.Location = new System.Drawing.Point(104, 66);
            this.dateTimePicker_From.Name = "dateTimePicker_From";
            this.dateTimePicker_From.Size = new System.Drawing.Size(100, 23);
            this.dateTimePicker_From.TabIndex = 15;
            this.dateTimePicker_From.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker_From.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxOrderGroup_Filter_KeyUp);
            // 
            // dateTimePicker_To
            // 
            this.dateTimePicker_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_To.Location = new System.Drawing.Point(104, 106);
            this.dateTimePicker_To.Name = "dateTimePicker_To";
            this.dateTimePicker_To.Size = new System.Drawing.Size(100, 23);
            this.dateTimePicker_To.TabIndex = 16;
            this.dateTimePicker_To.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxOrderGroup_Filter_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(333, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(333, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Client";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(492, 39);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(46, 19);
            this.label_Id.TabIndex = 7;
            this.label_Id.Text = "None";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 19);
            this.label8.TabIndex = 8;
            this.label8.Text = "Note";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(333, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "Date";
            // 
            // listBox_Orders
            // 
            this.listBox_Orders.FormattingEnabled = true;
            this.listBox_Orders.ItemHeight = 16;
            this.listBox_Orders.Location = new System.Drawing.Point(8, 208);
            this.listBox_Orders.Name = "listBox_Orders";
            this.listBox_Orders.Size = new System.Drawing.Size(247, 180);
            this.listBox_Orders.TabIndex = 10;
            this.listBox_Orders.DoubleClick += new System.EventHandler(this.listBox_Orders_DoubleClick);
            // 
            // textBox_Note
            // 
            this.textBox_Note.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Note.Location = new System.Drawing.Point(495, 164);
            this.textBox_Note.Multiline = true;
            this.textBox_Note.Name = "textBox_Note";
            this.textBox_Note.Size = new System.Drawing.Size(253, 141);
            this.textBox_Note.TabIndex = 1;
            // 
            // label_Client
            // 
            this.label_Client.AutoSize = true;
            this.label_Client.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Client.Location = new System.Drawing.Point(492, 321);
            this.label_Client.Name = "label_Client";
            this.label_Client.Size = new System.Drawing.Size(46, 19);
            this.label_Client.TabIndex = 11;
            this.label_Client.Text = "None";
            // 
            // Date_DateTime
            // 
            this.Date_DateTime.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_DateTime.Location = new System.Drawing.Point(495, 72);
            this.Date_DateTime.Name = "Date_DateTime";
            this.Date_DateTime.Size = new System.Drawing.Size(253, 23);
            this.Date_DateTime.TabIndex = 12;
            // 
            // tabControl_Order
            // 
            this.tabControl_Order.Controls.Add(this.OrderDetails);
            this.tabControl_Order.Controls.Add(this.OrderClient);
            this.tabControl_Order.Controls.Add(this.OrderItems);
            this.tabControl_Order.Location = new System.Drawing.Point(0, -1);
            this.tabControl_Order.Name = "tabControl_Order";
            this.tabControl_Order.SelectedIndex = 0;
            this.tabControl_Order.Size = new System.Drawing.Size(860, 439);
            this.tabControl_Order.TabIndex = 0;
            this.tabControl_Order.TabStop = false;
            // 
            // Form_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 492);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.tabControl_Order);
            this.Controls.Add(this.pictureBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Order";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.OrderItems.ResumeLayout(false);
            this.GroupBox_Filter.ResumeLayout(false);
            this.GroupBox_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.OrderClient.ResumeLayout(false);
            this.OrderClient.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.OrderDetails.ResumeLayout(false);
            this.OrderDetails.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl_Order.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TabPage OrderItems;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox_InOrderProductsCount;
        private System.Windows.Forms.GroupBox GroupBox_Filter;
        private System.Windows.Forms.ComboBox comboBox_FilterLevel;
        private System.Windows.Forms.ComboBox comboBox_FilterCategory;
        private System.Windows.Forms.TextBox textBox_FilterID;
        private System.Windows.Forms.Label label_level;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ListBox listBox_InOrderProducts;
        private System.Windows.Forms.ListBox listBox_Potential;
        private System.Windows.Forms.TabPage OrderClient;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_Name_Chosen;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label_Id_Chosen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_FirstName_Chosen;
        private System.Windows.Forms.Label label_Email_Chosen;
        private System.Windows.Forms.Label label_LastName_Chosen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox_Client;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Filter_Email;
        private System.Windows.Forms.TextBox textBox_Filter_LastName;
        private System.Windows.Forms.Label label_Email_Filter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage OrderDetails;
        private System.Windows.Forms.DateTimePicker Date_DateTime;
        private System.Windows.Forms.Label label_Client;
        private System.Windows.Forms.TextBox textBox_Note;
        private System.Windows.Forms.ListBox listBox_Orders;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_To;
        private System.Windows.Forms.DateTimePicker dateTimePicker_From;
        private System.Windows.Forms.TextBox client_TextBox_Filter;
        private System.Windows.Forms.TextBox textBox_Filter_OrderDetails_ID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl_Order;
    }
}