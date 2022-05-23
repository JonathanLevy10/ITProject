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
            CategoryArrToForm(comboBox_FilterCategory, false);
            CategoryArrToForm(comboBox_Comp_Category, false);

        }
        #region Client
        private void textBox_Product_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            SetProductsByFilter();
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            SetProductsByFilter();
        }

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

            private void SetProductsByFilter()
        {

            //מייצרים אוסף של כלל המוצרים

            CompArr compArr = new CompArr();
            compArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            compArr = compArr.Filter(textBox_NameFilter.Text,
            comboBox_FilterCategory.SelectedItem as Category);

            //מציבים בתיבת הרשימה את אוסף המוצרים
            listBox_Comp.DataSource = compArr;
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
                label_Comp_Name.Text = comp.Name; //Doesnt work
                if (comp.Name == null)
                {
                    MessageBox.Show("null");
                }
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
            ClientArrToForm(listBox_Potential_Fighters);
            listBox_Fighters_Comp.DataSource = null;

        }


        private void listBox_Category_DoubleClick(object sender, EventArgs e)
        {
            CompToForm(listBox_Comp.SelectedItem as Comp);
        }


        #endregion

        private bool CheckForm()
        {
            bool flag = true;


            if (label_Comp2_Name.Text == "None") //בחר משתמש
            {
                flag = false;
                label_Comp2_Name.BackColor = Color.Red;
            }


            if (listBox_Fighters_Comp.Items.Count == 0)
            {
                flag = false;
                listBox_Fighters_Comp.BackColor = Color.Red;
            }
            else
                listBox_Fighters_Comp.BackColor = Color.White;
            if (label_Comp_Name.Text == "None")
            {
                flag = false;
                label_Comp_Name.BackColor = Color.Red;
                label_Comp_Type.BackColor = Color.Red;
                label_Comp_Date.BackColor = Color.Red;
            }
            


            return flag;
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

                Comp comp = FormToComp();

                //הוספת ההזמנה למסד הנתונים

                CompClientArr compClientArr_New;
                if (comp.Id == 0)
                {
                    if (comp.Insert())
                    {

                        //מוצאים את ההזמנה החדשה - לפי המזהה הגבוה ביותר

                        CompArr compArr = new CompArr();
                        compArr.Fill();
                        comp = compArr.GetCompWithMaxId();
                        compClientArr_New = FormToCompClientArr(comp);
                        //מעדכנים את מלאי הפריטים שהוזמנו

                        //מוסיפים את הפריטים החדשים להזמנה

                        if (compClientArr_New.Insert())
                            MessageBox.Show("Successfully saved");
                        else
                            MessageBox.Show("Error in insert");
                        CompArrToForm();
                        ResetForm();
                        //לא לשכוח כאן לנקות את הטופס ולטעון מחדש ערכים לתיבת הרשימה של ההזמנות

                    }

                }
                else
                {
                    if (comp.Update())
                    {

                        //מוחקים את הפריטים הקודמים של ההזמנה
                        //אוסף כלל הזוגות - הזמנה-פריט

                        CompClientArr compClientArr_Old = new CompClientArr();
                        compClientArr_Old.Fill();

                        //סינון לפי ההזמנה הנוכחית

                        compClientArr_Old = compClientArr_Old.Filter(comp);

                        //מחיקת כל הפריטים באוסף ההזמנה-פריט של ההזמנה הנוכחית

                        compClientArr_Old.Delete();

                        //מוסיפים את הפריטים לפי העדכני להזמנה

                        compClientArr_New = FormToCompClientArr(comp);
                        compClientArr_New.Insert();
                        //מעדכנים את מלאי הפריטים, אלו שהוזמנו ואלו שבפוטנציאל

                        MessageBox.Show("Updated successfully");
                        CompArrToForm();


                        ResetForm();
                    }
                    else
                        MessageBox.Show("Error updating");
                }
            }
        }
        private void ResetForm()
        {
            ClientToForm(null);
            CompArrToForm();
            CompToForm(null);
            ClientArrToForm();
            ClientArrToForm(listBox_Potential_Fighters);
            listBox_Fighters_Comp.DataSource = null;
            CategoryArrToForm(comboBox_FilterCategory, false);
        }
        private void ClientArrToForm(ListBox listBox, ClientArr clientArr = null)
        {

            //מקבלת אוסף פריטים ותיבת רשימה לפריטים ומציבה את האוסף בתוך התיבה
            //אם האוסף ריק - מייצרת אוסף חדש מלא בכל הערכים מהטבלה

            listBox.DataSource = null;
            if (clientArr == null)
            {
                clientArr = new ClientArr();
                clientArr.Fill();
            }
            listBox.DataSource = clientArr;
        }
        private CompClientArr FormToCompClientArr(Comp curComp)
        {

            // יצירת אוסף המוצרים להזמנה מהטופס
            // מייצרים זוגות של הזמנה-מוצר , ההזמנה - תמיד אותה הזמנה )הרי מדובר על הזמנה אחת(, המוצר - מגיע מרשימת המוצרים שנבחרו
            CompClientArr compClientArr = new CompClientArr();
            CompClient compClient;

            //סורקים את כל הערכים בתיבת הרשימה של המוצרים שנבחרו להזמנה
            for (int i = 0; i < listBox_Fighters_Comp.Items.Count; i++)
            {
                compClient = new CompClient();

                //ההזמנה הנוכחית היא ההזמנה לכל הזוגות באוסף

                compClient.Comp = curComp;

                //מוצר נוכחי לזוג הזמנה-מוצר

                compClient.Client = listBox_Fighters_Comp.Items[i] as Client;

                //הוספת הזוג הזמנה -מוצר לאוסף

                compClientArr.Add(compClient);
            }
            return compClientArr;
        }

        /*
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
                levelDefault.Name = "All Levels";
            levelArr.Add(levelDefault);

            levelArr.Fill();
            comboBox.DataSource = levelArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            if (curLevel != null)
                comboBox.SelectedValue = curLevel.Id;
        }
        public void Comp_Save_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Comp comp = FormToComp();
                if (comp.Id == 0)
                {
                    if (comp.Insert())
                    {
                        MessageBox.Show("Added Successfully");
                    }
                    else
                        MessageBox.Show("Error adding");
                }
                else
                {
                    if (comp.Update())
                    {
                        MessageBox.Show("Updated Successfully");
                        CompArrToForm();
                    }
                    else
                        MessageBox.Show("Error update");
                }
                CompArrToForm();
            }
        }
        public bool ValidateForm()
        {
                if ("" == (textBox_Comp_Name.Text))
                {
                    textBox_Comp_Name.BackColor = Color.OrangeRed;
                    MessageBox.Show("Competition name cannot be empty!", "Error creating competition", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }

                else
                    textBox_Comp_Name.BackColor = Color.White;

                if ("" == (dtp_Comp_Date.Text))
                {
                    dtp_Comp_Date.BackColor = Color.OrangeRed;
                    MessageBox.Show("Date cannot be empty!", "Error creating competition", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }

                else
                    dtp_Comp_Date.BackColor = Color.White;

                if ("" == (comboBox_Comp_Category.Text))
                {
                    comboBox_Comp_Category.BackColor = Color.OrangeRed;
                    MessageBox.Show("Category cannot be empty!", "Error creating competition", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    return false;
                }

                else
                    comboBox_Comp_Category.BackColor = Color.White;



                return true;
        }
        private void listBox_Potential_Fighters_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(listBox_Potential_Fighters, listBox_Fighters_Comp, true);
        }
        private void InComp_ListBox_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(listBox_Fighters_Comp, listBox_Potential_Fighters, false);
        }
        private void MoveSelectedItemBetweenListBox(ListBox listBox_From, ListBox listBox_To, bool isToOrder)
        {
            ClientArr arrList = null;

            //מוצאים את הפריט הנבחר

            Client selectedItem = listBox_From.SelectedItem as Client;
            //עדכון הכמות במלאי של הפריט

            //מוסיפים את הפריט הנבחר לרשימת הפריטים הפוטנציאליים
            //אם כבר יש פריטים ברשימת הפוטנציאליים

            if (listBox_To.DataSource != null)
                arrList = listBox_To.DataSource as ClientArr;
            else
                arrList = new ClientArr();
            arrList.Add(selectedItem);
            ClientArrToForm(listBox_To, arrList);
            ///הסרת הפריט הנבחר מרשימת הפריטים הנבחרים

            arrList = listBox_From.DataSource as ClientArr;
            arrList.Remove(selectedItem);
            ClientArrToForm(listBox_From, arrList);
            //בסוף הפעולה
            //אם זאת הוספה לתיבת המוצרים בהזמנה - סימון שתי השורה האחרונה בה וגם בתיבת הרשימה של הכמויות

        }
        private void CompArrToForm(ListBox listBox, CompArr compArr = null)
        {

            //מקבלת אוסף פריטים ותיבת רשימה לפריטים ומציבה את האוסף בתוך התיבה
            //אם האוסף ריק - מייצרת אוסף חדש מלא בכל הערכים מהטבלה

            listBox.DataSource = null;
            if (compArr == null)
            {
                compArr = new CompArr();
                compArr.Fill();
            }
            listBox.DataSource = compArr;
        }


    }
        
}
