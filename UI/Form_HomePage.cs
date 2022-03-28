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
            Application.Run(new Form_Category());
        }
        private void button_Product_Click(object sender, EventArgs e)
        {
            Application.Run(new Form_Product());
        }

    }
}
