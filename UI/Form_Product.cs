using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientSignup.BL;
using ClientSignup.UI;



namespace ClientSignup.UI
{
    public partial class Form_Product : Form
    {
        public Form_Product()
        {
            InitializeComponent();
        }
        public void CategoryArrToFormy(ComboBox comboBox, bool isMustChoose, Category curCategory = null)
        {
            CategoryArr categoryArr = new CategoryArr();

            Category categoryDefault = new Category();
            categoryDefault.Id = -1;
            if (isMustChoose)
                categoryDefault.Name = "Choose a category";
            else
                categoryDefault.Name = "All categories";
            categoryArr.Add(categoryDefault);

            categoryArr.Fill();
            comboBox.DataSource = categoryArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            if (curCategory != null)
                comboBox.SelectedValue = curCategory.Id;
        }
        public void LevelArrToFormy(ComboBox comboBox, bool isMustChoose, Level curLevel = null)
        {
            LevelArr levelArr = new LevelArr();

            Level levelDefault = new Level();
            levelDefault.Id = -1;
            if (isMustChoose)
                levelDefault.Name = "Choose a level";
            else
                levelDefault.Name = "All levels";
            levelArr.Add(levelDefault);

            levelArr.Fill();
            comboBox.DataSource = levelArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            if (curLevel != null)
                comboBox.SelectedValue = curLevel.Id;
        }

        #region Filters
        private void textBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            SetProductsByFilter();
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            SetProductsByFilter();
        }
        private void SetProductsByFilter()
        {

            //מייצרים אוסף של כלל המוצרים

            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            productArr = productArr.Filter(textBox_FilterID.Text,
            comboBox_FilterCategory.SelectedItem as Category,
            comboBox_FilterLevel.SelectedItem as Level);

            //מציבים בתיבת הרשימה את אוסף המוצרים
            listBox_Products.DataSource = productArr;
        }
        #endregion Filters
    }
}
