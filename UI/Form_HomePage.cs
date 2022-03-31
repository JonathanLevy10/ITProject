using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFP_GOS.UI;


namespace WFP_GOS.UI
{
    public partial class Form_HomePage : Form
    {
        public Form_HomePage()
        {
            InitializeComponent();
        }
        private void button_Location_Click(object sender, EventArgs e)
        {
           Form_Location form_location = new Form_Location();
           form_location.ShowDialog();
        }
        private void button_Client_Click(object sender, EventArgs e)
        {
            Form1 form_Client = new Form1();
            form_Client.ShowDialog();
        }
        private void button_Category_Click(object sender, EventArgs e)
        {
            Form_Category form_Category = new Form_Category();
            form_Category.ShowDialog();
        }
        private void button_Product_Click(object sender, EventArgs e)
        {
            Form_Product form_Product = new Form_Product();
            form_Product.ShowDialog();
        }
        private void button_Order_Click(object sender, EventArgs e)
        {
            Form_Order form_Order = new Form_Order();
            form_Order.ShowDialog();
        }
        private void button_Level_Click(object sender, EventArgs e)
        {
            Form_Level form_Level = new Form_Level();
            form_Level.ShowDialog();
        }

        private void button_Doc_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1aEz3OcxcfvGaca0H71H6XxXNM6tHz9GQMaorIohZ50c/edit#");
        }
        private void button_Comp_Click(object sender, EventArgs e)
        {
            Form_Comp form_Comp = new Form_Comp();
            form_Comp.ShowDialog();
        }

        private void EasterEgg_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/rony-%D7%A8%D7%95%D7%A0%D7%99-walden-%D7%95%D7%9C%D7%93%D7%9F-08839268/overlay/photo/");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/document/d/1aEz3OcxcfvGaca0H71H6XxXNM6tHz9GQMaorIohZ50c/edit#");
        }
    }
}
