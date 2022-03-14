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
       public partial class Form_Level : Form
        {
            public Form_Level(Level level = null)
            {
                InitializeComponent();

                if (level != null && level.Id <= 0)
                    level = null;
                LevelArrToForm(level);
                LevelToForm(level);

            }
            private Level FormToLevel()
            {
                Level level = new Level();
                level.Id = int.Parse(label_id.Text);
                level.Name = textBox_Name.Text;

                return level;
            }
            private void LevelArrToForm(Level curLevel = null)
            {
                LevelArr levelArr = new LevelArr();

                levelArr.Fill();

                listBox_Level.DataSource = levelArr;
                listBox_Level.ValueMember = "Id";
                listBox_Level.DisplayMember = "Name";

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
            private void button_Save_Click(object sender, EventArgs e)
            {

                if (!CheckForm())
                {
                    MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading |
                    MessageBoxOptions.RightAlign);
                }
                else
                {
                    Level level = FormToLevel();


                    LevelArr oldLevelArr = new LevelArr();
                    oldLevelArr.Fill();
                    level = oldLevelArr.GetLevelWithMaxId(); //why error?
                    LevelArrToForm(level);
                    if (!oldLevelArr.IsContains(level.Name))//
                    {
                        if (level.Insert())
                        {
                            MessageBox.Show("Ok");

                            //עדכון תיבת הרשימה

                            LevelArrToForm();
                        }
                        else
                            MessageBox.Show("Not Ok");

                    }
                    else
                        MessageBox.Show("Already exist");




                    if (level.Id == 0)
                    {
                        //הוספת לקוח חדש

                        if (level.Insert())
                        {
                            MessageBox.Show("Added successfully");
                        }
                        else
                            MessageBox.Show("Error adding");
                    }
                    else
                    {

                        //עדכון לקוח קיים

                        if (level.Update())
                        {
                            MessageBox.Show("Updated successfully");
                        }
                        else
                            MessageBox.Show("Error updating");
                    }
                    LevelArrToForm();
                }
            }
            private void button_Clear_Click(object sender, EventArgs e)
            {
                LevelToForm(null);
            }
            private void LevelToForm(Level level)
            {
                if (level != null)
                {
                    //ממירה את המידע בטנ "מ לקוח לטופס

                    label_id.Text = level.Id.ToString();
                    textBox_Name.Text = level.Name;
                }
                else
                {
                    label_id.Text = "0";
                    textBox_Name.Text = "";
                    textBox_Name.BackColor = Color.White;
                }


            }
            private void listBox_Level_DoubleClick(object sender, EventArgs e)
            {
                LevelToForm(listBox_Level.SelectedItem as Level);
            }
            private void button_Delete_Click(object sender, EventArgs e)
            {
                if (label_id.Text == "0")
                    MessageBox.Show("You must select a level");
                else
                {
                    if (MessageBox.Show("Warning", "Are you sure you want to delete?", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        Level level = FormToLevel();

                        //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                        //בדיקה עבור לקוחות

                        ProductArr productArr = new ProductArr();
                        productArr.Fill();
                        if (productArr.DoesExist(level))
                            MessageBox.Show("You can’t delete a level that is related to a product");
                        else
                        if (level.Delete())
                        {
                            MessageBox.Show("Deleted");
                            LevelToForm(null);
                            LevelArrToForm();
                        }
                        else
                            MessageBox.Show("Error");

                    }
                }
            }
            public Level SelectedLevel { get => listBox_Level.SelectedItem as Level; }
        }
}
