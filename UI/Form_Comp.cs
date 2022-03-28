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

            listBox_Clients.DataSource = clientArr;
        }
        private void listBox_Clients_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(listBox_Clients.SelectedItem as Client);
        }
        private void ClientToForm(Client client) //Puts specific client info into form
        {

            //ממירה את המידע בטנ"מ לקוח לטופס
            if (client != null)
            {
                label_Client.Text = client.FirstName + " " + client.LastName;
            }
            else
            {
                label_Client.Text = "None";
            }
        }
        private void ClientArrToForm()
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            listBox_Clients.DataSource = clientArr;
        }
        #endregion

        #region Make/Choose Comp
        private Comp FormToComp()
        {
            Comp comp = new Comp();
            comp.Id = int.Parse(label_Comp_id.Text);
            comp.Category = comboBox_Comp_Category.SelectedItem as Category; ;
            comp.Name = textBox_Comp_Name.Text;
            comp.Date = dtp_Comp_Date.Value;

            return comp;
        }
        private void listBox_Category_DoubleClick(object sender, EventArgs e)
        {
            CompToForm(listBox_Comp.SelectedItem as Comp);
        }
        private void CompToForm(Comp comp) //Puts specific client info into form
        {

            //ממירה את המידע בטנ"מ לקוח לטופס
            if (comp != null)
            {
                label_Comp_id.Text = comp.Id.ToString();
                textBox_Comp_Name.Text = comp.Name;
                comboBox_Comp_Category.SelectedItem = comp.Category;
                dtp_Comp_Date.Value = comp.Date;
            }
            else
            {
                label_Comp_id.Text = "0";
                textBox_Comp_Name.Text = "";
                comboBox_Comp_Category.Text = "";
                dtp_Comp_Date.Text = "";
            }
        }
        private void CompArrToForm()
        {
            CompArr compArr = new CompArr();
            compArr.Fill();
            listBox_Clients.DataSource = compArr;
        }
        #endregion
    }
}
