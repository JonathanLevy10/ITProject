using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientSignup.BL;
using ClientSignup.UI;

namespace ClientSignup.UI
{
    public partial class Form_Order : Form
    {
        public Form_Order()
        {
            InitializeComponent();
            OrderArrToForm();
            CapsLockCheck();
        }

        private void CapsLockCheck()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                MessageBox.Show("Warning! You have enabled caps-lock");

        }

        private Order FormToOrder()
        {
            Order order = new Order();
            order.Id = int.Parse(label_id.Text);
            order.Date = Date_DateTime.Value;
            order.Notes = textBox_Note.Text;
            
            return order;
        }
        private void OrderToForm(Order order) //Puts specific client info into form
        {
            if (order != null)
            {
                label_id.Text = order.Id.ToString();
                Date_DateTime.Value = order.Date;
                textBox_Note.Text = order.Notes;
            }
            else
            {
                label_id.Text = "0";
                Date_DateTime.Value = DateTime.Today;
                textBox_Note.Text = "";
            }
        }

        private void OrderArrToForm()
        {
            OrderArr orderArr = new OrderArr();
            orderArr.Fill();
            listBox_Orders.DataSource = orderArr;
        }

        private void listBox_Orders_DoubleClick(object sender, EventArgs e)
        {
            OrderToForm(listBox_Orders.SelectedItem as Order);
        }

    }
}
