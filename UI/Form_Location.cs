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
    public partial class Form_Location : Form
    {
        public Form_Location(Location backgroundMA = null)
        {
            InitializeComponent();

            if (backgroundMA != null && backgroundMA.Id <= 0)
                backgroundMA = null;
            LocationArrToForm(backgroundMA);
            LocationToForm(backgroundMA);

        }

        private Location FormToLocation()
        {
            Location backgroundMA = new Location();
            backgroundMA.Id = int.Parse(label_id.Text);
            backgroundMA.Name = textBox_Name.Text;

            return backgroundMA;
        }

        private void LocationArrToForm(Location curLocation = null)
        {
            LocationArr backgroundMAArr = new LocationArr();

            backgroundMAArr.Fill();
            //Location curLocation = null;
            //LocationArr backgroundMAArr = new LocationArr();
            
            listBox_Location.DataSource = backgroundMAArr;
            listBox_Location.ValueMember = "Id";
            listBox_Location.DisplayMember = "Name";
           
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
                Location backgroundMA = FormToLocation();


                LocationArr oldLocationArr = new LocationArr();
                oldLocationArr.Fill();
                backgroundMA = oldLocationArr.GetLocationWithMaxId(); //why error?
                LocationArrToForm(backgroundMA);
                if (!oldLocationArr.IsContains(backgroundMA.Name))//
                {
                    if (backgroundMA.Insert())
                    {
                        MessageBox.Show("Ok");

                        //עדכון תיבת הרשימה

                        LocationArrToForm();
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
                LocationArrToForm();
            }
        }
        private void button_Clear_Click(object sender, EventArgs e)
        {
            LocationToForm(null);
        }
        private void LocationToForm(Location backgroundMA)
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
        private void listBox_Location_DoubleClick(object sender, EventArgs e)
        {
            LocationToForm(listBox_Location.SelectedItem as Location);
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
                    Location backgroundMA = FormToLocation();

                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    ClientArr clientArr = new ClientArr();
                    clientArr.Fill();
                    if (clientArr.DoesExist(backgroundMA))
                        MessageBox.Show("You can’t delete a background martial art that is related to a client");
                    else
                    if (backgroundMA.Delete())
                    {
                        MessageBox.Show("Deleted");
                        LocationToForm(null);
                        LocationArrToForm();
                    }
                    else
                        MessageBox.Show("Error");

                }
            }
        }

        public Location SelectedLocation { get => listBox_Location.SelectedItem as Location; }

       
    }
}
