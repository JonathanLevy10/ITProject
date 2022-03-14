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
    public partial class Form_Location : Form
    {
        public Form_Location(Location location = null)
        {
            InitializeComponent();

            if (location != null && location.Id <= 0)
                location = null;
            LocationArrToForm(location);
            LocationToForm(location);

        }
        private Location FormToLocation()
        {
            Location location = new Location();
            location.Id = int.Parse(label_id.Text);
            location.Name = textBox_Name.Text;

            return location;
        }
        private void LocationArrToForm(Location curLocation = null)
        {
            LocationArr locationArr = new LocationArr();

            locationArr.Fill();
            //Location curLocation = null;
            //LocationArr locationArr = new LocationArr();

            listBox_Location.DataSource = locationArr;
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
                Location location = FormToLocation();


                LocationArr oldLocationArr = new LocationArr();
                oldLocationArr.Fill();
                location = oldLocationArr.GetLocationWithMaxId(); //why error?
                LocationArrToForm(location);
                if (!oldLocationArr.IsContains(location.Name))//
                {
                    if (location.Insert())
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




                if (location.Id == 0)
                {
                    //הוספת לקוח חדש

                    if (location.Insert())
                    {
                        MessageBox.Show("Added successfully");
                    }
                    else
                        MessageBox.Show("Error adding");
                }
                else
                {

                    //עדכון לקוח קיים

                    if (location.Update())
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
        private void LocationToForm(Location location)
        {
            if (location != null)
            {
                //ממירה את המידע בטנ "מ לקוח לטופס

                label_id.Text = location.Id.ToString();
                textBox_Name.Text = location.Name;
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
                    Location location = FormToLocation();

                    //לפני המחיקה - בדיקה שהישוב לא בשימוש בישויות אחרות
                    //בדיקה עבור לקוחות

                    ClientArr clientArr = new ClientArr();
                    clientArr.Fill();
                    if (clientArr.DoesExist(location))
                        MessageBox.Show("You can’t delete a background martial art that is related to a client");
                    else
                    if (location.Delete())
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
