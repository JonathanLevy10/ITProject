using ClientSignup.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientSignup.UI
{
    public partial class Form_BackgroundMA : Form
    {
        public Form_BackgroundMA()
        {
            InitializeComponent();
        }

        private BackgroundMA FormToBackgroundMA()
        {
            BackgroundMA backgroundMA = new BackgroundMA();
            backgroundMA.Id = int.Parse(label_id.Text);
            backgroundMA.Name = textBox_Name.Text;

            return backgroundMA;
        }
       
        private void BackgroundMAArrToForm()
        {
            BackgroundMAArr backgroundMAArr = new BackgroundMAArr();
            backgroundMAArr.Fill();
            listBox_BackgroundMA.DataSource = backgroundMAArr; //edit listbox name to get rid of error
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
                BackgroundMA backgroundMA = FormToBackgroundMA();


                BackgroundMAArr oldBackgroundMAArr = new BackgroundMAArr();
                oldBackgroundMAArr.Fill();
                if (!oldBackgroundMAArr.IsContains(backgroundMA.Name))
                {
                    if (backgroundMA.Insert())
                    {
                        MessageBox.Show("Ok");

                        //עדכון תיבת הרשימה

                        BackgroundMAArrToForm();
                    }
                    else
                        MessageBox.Show("Not Ok");

                }
                else
                    MessageBox.Show("Already exist");




                if (backgroundMA.Id == 0)
                {
                    //הוספת לקוח חדש

                    if (backgroundMA.Insert())
                    {
                        MessageBox.Show("Added successfully");
                    }
                    else
                        MessageBox.Show("Error adding");
                }
                else
                {

                    //עדכון לקוח קיים

                    if (backgroundMA.Update())
                    {
                        MessageBox.Show("Updated successfully");
                    }
                    else
                        MessageBox.Show("Error updating");
                }
                BackgroundMAArrToForm();
            }
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            BackgroundMAToForm(null);
        }
        private void BackgroundMAToForm(BackgroundMA backgroundMA)
        {
            if (backgroundMA != null)
            {
                //ממירה את המידע בטנ "מ לקוח לטופס

                label_id.Text = backgroundMA.Id.ToString();
                textBox_Name.Text = backgroundMA.Name;
            }
            else
            {
                label_id.Text = "0";
                textBox_Name.Text = "";
                textBox_Name.BackColor = Color.White;
            }


        }


    }

    
}
