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
    public partial class Form_Comp : Form
    {
        public Form_Comp()
        {
            InitializeComponent();
            ClientArrToForm();
            CompArrToForm();
        }
        #region Client
        private void GroupBox_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;

            if (textBox_FilterId.Text != "")
                id = int.Parse(textBox_FilterId.Text);

            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            clientArr = clientArr.Filter(id, textBox_FilterLastName.Text, textBox_FilterEmail.Text);

            listBox_Potential_Fighters.DataSource = clientArr;
        }
        private void listBox_Fighters_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(listBox_Potential_Fighters.SelectedItem as Client);
        }
        private void ClientToForm(Client client) //Puts specific client info into form
        {

            //ממירה את המידע בטנ"מ לקוח לטופס
            if (client != null)
            {
                label_Client.Text = client.FirstName + " " + client.LastName;
                label_Client2.Text = client.FirstName + " " + client.LastName;
            }
            else
            {
                label_Client.Text = "None";
                label_Client2.Text = "None";
            }
        }

        private void ClientArrToForm()
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Potential_Fighters.DataSource = clientArr;
        }
        #endregion

        #region Make/Choose Comp
        private Comp FormToComp()
        {
            Comp comp = new Comp();
            comp.Id = int.Parse(label_Comp_id.Text);
            comp.Category = comboBox_Comp_Category.SelectedItem as Category; 
            comp.Name = textBox_Comp_Name.Text;
            comp.Date = dtp_Comp_Date.Value;

            return comp;
        }
        private void CompArrToForm()
        {
            CompArr compArr = new CompArr();
            compArr.Fill();
            listBox_Comp.DataSource = compArr;
        }
        private void CompToForm(Comp comp) //Puts specific comp info into form
        {

            //ממירה את המידע בטנ"מ לקוח לטופס
            if (comp != null)
            {
                label_Comp_id.Text = comp.Id.ToString();
                textBox_Comp_Name.Text = comp.Name;
                label_Comp_Name.Text = comp.Name;
                label_Comp2_Name.Text = comp.Name;
                comboBox_Comp_Category.SelectedItem = comp.Category;
                label_Comp_Type.Text = comp.Name;
                dtp_Comp_Date.Value = comp.Date;
                label_Comp_Date.Text = comp.Date.ToString();
            }
            else
            {
                label_Comp_id.Text = "0";
                textBox_Comp_Name.Text = "None";
                label_Comp_Name.Text = "None";
                label_Comp2_Name.Text = "None";
                comboBox_Comp_Category.Text = "";
                label_Comp_Type.Text = "None";
                dtp_Comp_Date.Text = "";
                label_Comp_Date.Text = "None";
            }
        }
        private void listBox_Comp_DoubleClick(object sender, EventArgs e)
        {
            CompToForm(listBox_Comp.SelectedItem as Comp);
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            CompToForm(null);
        }
       

        /*
        private void listBox_Category_DoubleClick(object sender, EventArgs e)
        {
            CompToForm(listBox_Comp.SelectedItem as Comp);
        }
        
        private void CompArrToForm()
        {
            CompArr compArr = new CompArr();
            compArr.Fill();
            listBox_Clients.DataSource = compArr;
        }

        #endregion
        
        private void button_Send_Click(object sender, EventArgs e)
        {

        }
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
            CompToForm(null);
        }

        private void button_Delete_Comp_Click(object sender, EventArgs e)
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
        */
        #endregion


    }
}
