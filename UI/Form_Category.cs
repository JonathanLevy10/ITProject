using WFP_GOS.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFP_GOS.UI
{
    public partial class Form_Category : Form
    {
        public Form_Category(Category category = null)
        {
            InitializeComponent();

            if (category != null && category.Id <= 0)
                category = null;
            CategoryArrToForm(category);
            CategoryToForm(category);

        }
        public Category SelectedCategory { get => listBox_Category.SelectedItem as Category; }
        private Category FormToCategory()
        {
            Category category = new Category();
            category.Id = int.Parse(label_id.Text);
            category.Name = textBox_Name.Text;

            return category;
        }
        private void CategoryArrToForm(Category curCategory = null)
        {
            CategoryArr categoryArr = new CategoryArr();

            categoryArr.Fill();
            //Category curCategory = null;
            //CategoryArr categoryArr = new CategoryArr();

            listBox_Category.DataSource = categoryArr;
            listBox_Category.ValueMember = "Id";
            listBox_Category.DisplayMember = "Name";

        }
        private void listBox_Category_DoubleClick(object sender, EventArgs e)
        {
            CategoryToForm(listBox_Category.SelectedItem as Category);
        }
        private bool CheckForm()
        {

            //מחזירה האם הטופס תקין - שדות חובה ורשות

            bool flag = true;

            if (textBox_Name.Text.Length < 2)
            {
                flag = false;
                textBox_Name.BackColor = Color.Red;
            }
            else
                textBox_Name.BackColor = Color.White;

            return flag;
        }
        #region Click Funtions
        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                Category category = FormToCategory();

                if (category.Id == 0)
                {
                    CategoryArr oldCategoryArr = new CategoryArr();
                    oldCategoryArr.Fill();
                    if (!oldCategoryArr.IsContains(category.Name))
                    {
                        if (category.Insert())
                        {
                            MessageBox.Show("Added successfully");
                            label_id.Text = "0";
                            textBox_Name.Text = "";
                            //עדכון תיבת הרשימה
                            CategoryArrToForm();
                            CategoryArr categoryArr = new CategoryArr();
                            categoryArr.Fill();
                            category = categoryArr.GetCategoryWithMaxId();
                        }
                        else
                            MessageBox.Show("Error adding");
                    }
                    else
                        MessageBox.Show("Already exist");
                }
                else
                {
                    //עדכון לקוח קיים
                    if (category.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        CategoryArrToForm();

                        label_id.Text = "0";
                        textBox_Name.Text = "";
                    }
                    else
                        MessageBox.Show("Error updating");
                }
                CategoryArrToForm(category);
            }
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            CategoryToForm(null);
        }
        private void CategoryToForm(Category category)
        {
            if (category != null)
            {
                //ממירה את המידע בטנ "מ לקוח לטופס

                label_id.Text = category.Id.ToString();
                textBox_Name.Text = category.Name;
            }
            else
            {
                label_id.Text = "0";
                textBox_Name.Text = "";
                textBox_Name.BackColor = Color.White;
            }
        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (label_id.Text == "0")
                MessageBox.Show("You must select a background martial art");
            else
            {
                if (MessageBox.Show("Warning", "Are you sure you want to delete?", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    Category category = FormToCategory();
                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות
                    ProductArr productArr = new ProductArr();
                    productArr.Fill();
                    if (productArr.DoesExist(category))
                        MessageBox.Show("You can’t delete a category that is related to a product");
                    else
                    if (category.Delete())
                    {
                        MessageBox.Show("Deleted");
                        CategoryToForm(null);
                        CategoryArrToForm();
                    }
                    else
                        MessageBox.Show("Error");
                }
            }
        }
        #endregion
    }
    
}
