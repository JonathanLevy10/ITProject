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
using DataBase.UI;


namespace WFP_GOS.UI
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            Form_ClassesByCategory form_ClassesByCategory = new Form_ClassesByCategory();
            form_ClassesByCategory.ShowDialog();
        }
        private void button_7_Click(object sender, EventArgs e)
        {
            Form_ClassesByLevel form_ClassesByLevel = new Form_ClassesByLevel();
            form_ClassesByLevel.ShowDialog();
        }
        private void button_2_Click(object sender, EventArgs e)
        {
            Form_ProductsReport form_ProductsReport = new Form_ProductsReport();
            form_ProductsReport.ShowDialog();
        }
        private void button_3_Click(object sender, EventArgs e)
        {
            BestSellingClass bestSellingClass = new BestSellingClass();
            bestSellingClass.ShowDialog();
        }



    }
}
