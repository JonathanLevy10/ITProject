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
            public Level SelectedLevel { get => listBox_Level.SelectedItem as Level; }
        #region Click Functions

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Fill all the mandatory fields!", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            else
            {
                Level level = FormToLevel();

                if (level.Id == 0)
                {
                    LevelArr oldLevelArr = new LevelArr();
                    oldLevelArr.Fill();
                    if (!oldLevelArr.IsContains(level.Name))
                    {
                        if (level.Insert())
                        {
                            MessageBox.Show("Added successfully");
                            label_id.Text = "0";
                            textBox_Name.Text = "";
                            //עדכון תיבת הרשימה
                            LevelArrToForm();
                            LevelArr levelArr = new LevelArr();
                            levelArr.Fill();
                            level = levelArr.GetLevelWithMaxId();
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
                    if (level.Update())
                    {
                        MessageBox.Show("Updated successfully");
                        LevelArrToForm();

                        label_id.Text = "0";
                        textBox_Name.Text = "";
                    }
                    else
                        MessageBox.Show("Error updating");
                }
                LevelArrToForm(level);
            }
        }
            private void button_Clear_Click(object sender, EventArgs e)
            {
                LevelToForm(null);
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
                        MessageBox.Show("You can’t delete a background martial art that is related to a product");
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
    }
        #endregion
    
}
