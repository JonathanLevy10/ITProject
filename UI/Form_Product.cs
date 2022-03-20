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
        private void textBox_Product_Filter_KeyUp(object sender, KeyEventArgs e)
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
            if(ValidateForm())
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
            
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            ProductToForm(null);
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (label_Id.Text == "0")
                MessageBox.Show("You must select a product");
            else
            {
                if (MessageBox.Show("Warning", "Are you sure you want to delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Product product = FormToProduct();

                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    OrderProductArr orderProductArr = new OrderProductArr();
                    orderProductArr.Fill();
                    if (orderProductArr.DoesExist(product))
                        MessageBox.Show("You can’t delete a product that is related to an order");
                    else
                    if (product.Delete())
                    {
                        MessageBox.Show("Deleted");
                        ProductToForm(null);
                        ProductArrToForm();
                    }
                    else
                        MessageBox.Show("Error");

                }
            }
        }
        private void listBox_Products_DoubleClick(object sender, EventArgs e)
        {
            ProductToForm(listBox_Products.SelectedItem as Product);
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
                comboBox_Category.SelectedItem = product.Category; //Why does this not display?
                comboBox_Level.SelectedItem = product.Level; //Why does this not display?
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
        private bool ValidateForm()
        {
            // Product Name Validation
            if ("" == (textBox_ProductName.Text))
            {
                textBox_ProductName.BackColor = Color.OrangeRed;
                MessageBox.Show("Product name cannot be empty!", "Error creating user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }

            else
                textBox_ProductName.BackColor = Color.White;

            // Category Validation
            if ("" == (comboBox_Category.Text))
            {
                comboBox_Category.BackColor = Color.OrangeRed;
                MessageBox.Show("Category cannot be empty!", "Error creating user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }

            else
                comboBox_Category.BackColor = Color.White;

            // Level Validation
            if ("" == (comboBox_Level.Text))
            {
                comboBox_Level.BackColor = Color.OrangeRed;
                MessageBox.Show("Level cannot be empty!", "Error creating user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }

            else
                comboBox_Category.BackColor = Color.White;

            // Place Validation
            if ("" == (nUD_Places.Text))
            {
                nUD_Places.BackColor = Color.OrangeRed;
                MessageBox.Show("Places cannot be empty!", "Error creating user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }

            else
                nUD_Places.BackColor = Color.White;


            return true;
        }
    }
}

