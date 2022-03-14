using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFP_GOS.BL;
using WFP_GOS.UI;

namespace WFP_GOS.UI
{
    public partial class Form_Product : Form
    {
        public Form_Product()
        {
            InitializeComponent();
            CategoryArrToForm(comboBox_Category, true);
            CategoryArrToForm(comboBox_FilterCategory, false);
            LevelArrToForm(comboBox_Level, true);
            LevelArrToForm(comboBox_FilterLevel, false);

        }
        public void CategoryArrToForm(ComboBox comboBox, bool isMustChoose, Category curCategory = null)
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
        public void LevelArrToForm(ComboBox comboBox, bool isMustChoose, Level curLevel = null)
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

        private void button_Save_Click(object sender, EventArgs e)
        {
            Product product = FormToProduct();
            if (product.Id == 0)
            {
                if (product.Insert())
                {
                    MessageBox.Show("Added Successfully");
                }
                else
                    MessageBox.Show("Error adding");
            }
            else
            {
                if (product.Update())
                {
                    MessageBox.Show("Updated Successfully");
                    ProductArrToForm();
                }
                else
                    MessageBox.Show("Error update");
            }
            ProductArrToForm();
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            ProductToForm(null);
        }
        private Product FormToProduct()
        {
            Product product = new Product();
            product.Id = int.Parse(label_Id.Text);

            product.Name = textBox_ProductName.Text;
            product.Category = comboBox_Category.SelectedItem as Category;
            product.Level = comboBox_Level.SelectedItem as Level;
            product.Count = int.Parse(nUD_Places.Text);

            return product;
        }
        private void ProductToForm(Product product) //Puts specific product info into form
        {

            //ממירה את המידע בטנ"מ לקוח לטופס
            if (product != null)
            {
                label_Id.Text = product.Id.ToString();
                textBox_ProductName.Text = product.Name;
                comboBox_Category.SelectedItem = product.Category;
                comboBox_Level.SelectedItem = product.Level;
                nUD_Places.Text = product.Count.ToString();
            }
            else
            {
                label_Id.Text = "0";
                textBox_ProductName.Text = "";
                comboBox_Category.Text = "";
                comboBox_Level.Text = "";
                nUD_Places.Text = "";
            }
        }
        private void ProductArrToForm()
        {
            ProductArr productArr = new ProductArr();
            productArr.Fill();
            listBox_Products.DataSource = productArr;
        }
    }
}

