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
    public partial class Form_Order : Form
    {
        public Form_Order()
        {
            InitializeComponent();
            OrderArrToForm();
            CapsLockCheck();
            ClientArrToForm();
            ProductArrToForm(listBox_Potential);
        }
        #region tab 1
        private void OrderToForm(Order order) //Puts specific order info into form
        {
            if (order != null)
            {
                label_Id.Text = order.Id.ToString();
                Date_DateTime.Value = order.Date;
                textBox_Note.Text = order.Notes;
                label_Client.Text = order.Client.LastName + " " + order.Client.FirstName;
            }
            else
            {
                label_Id.Text = "0";
                Date_DateTime.Value = DateTime.Today;
                textBox_Note.Text = "";
                label_Client.Text = "";
            }
        }
        private bool CheckForm()
        {
            bool flag = true;

            if (Date_DateTime.Value < DateTime.Today)
            {
                flag = false;
            }
            else

            if (label_Name_Chosen.Text == "None Chosen") //בחר משתמש
            {
                flag = false;
                label_Name_Chosen.BackColor = Color.Red;
            }
            else
                label_Name_Chosen.BackColor = Color.Black;

            if (listBox_InOrderProducts.Items.Count == 0)
            {
                flag = false;
                listBox_InOrderProducts.BackColor = Color.Red;
            }
            else
                listBox_InOrderProducts.BackColor = Color.White;

            return flag;
        }
        private void OrderArrToForm()
        {
            OrderArr orderArr = new OrderArr();
            orderArr.Fill();
            listBox_Orders.DataSource = orderArr;
        }
        private Order FormToOrder()
        {
            Order order = new Order();
            order.Id = int.Parse(label_Id.Text);
            order.Date = Date_DateTime.Value;
            order.Notes = textBox_Note.Text;

            return order;
        }
        private void textBoxOrder_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            SetProductsByFilter();
        }
        private void textBoxOrderGroup_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            SetOrdersByFilter();
        }
        private void listBox_Orders_DoubleClick(object sender, EventArgs e)
        {
            OrderToForm(listBox_Orders.SelectedItem as Order);
        }
        #endregion

        #region tab 2
        private void textBoxClient_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            int id = 0;
            //אם המשתמש רשם ערך בשדה המזהה
            if (textBox_Filter_OrderDetails_ID.Text != "")
                id = int.Parse(textBox_Filter_OrderDetails_ID.Text);
            //מייצרים אוסף של כלל הלקוחות
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();
            //מסננים את אוסף הלקוחות לפי שדות הסינון שרשם המשתמש
            clientArr = clientArr.Filter(id, textBox_Filter_LastName.Text, textBox_Filter_Email.Text);
            //מציבים בתיבת הרשימה את אוסף הלקוחות
            listBox_Client.DataSource = clientArr;
        }
        private void ClientArrToForm()
        {
            ClientArr clientArr = new ClientArr();
            clientArr.Fill();

            listBox_Client.DataSource = clientArr;
            listBox_Client.ValueMember = "ID";
            listBox_Client.DisplayMember = "";
        }
        private void listBox_Client_DoubleClick(object sender, EventArgs e)
        {
            ClientToForm(listBox_Client.SelectedItem as Client);
        }
        private void ClientToForm(Client client)
        {
            if (client != null)
            {
                //ממירה את המידע בטנ "מ לקוח לטופס

                label_Id_Chosen.Text = client.id.ToString();
                label_FirstName_Chosen.Text = client.FirstName;
                label_LastName_Chosen.Text = client.LastName;
                label_Email_Chosen.Text = client.Email;
                label_Name_Chosen.Text = client.FirstName + " " + client.LastName;
            }
            else
            {
                label_Id_Chosen.Text = "0";
                label_FirstName_Chosen.Text = "-";
                label_LastName_Chosen.Text = "-";
                label_Email_Chosen.Text = "-";
                label_Name_Chosen.Text = "None Chosen";
            }

        }

        #endregion

        #region tab 3
        private void MoveSelectedItemBetweenListBox(ListBox listBox_From, ListBox listBox_To)
        {
            ProductArr productarr = null;

            //מוצאים את הפריט הנבחר

            Product product = listBox_From.SelectedItem as Product;

            //מוסיפים את הפריט הנבחר לרשימת הפריטים הפוטנציאליים
            //אם כבר יש פריטים ברשימת הפוטנציאליים

            if (listBox_To.DataSource != null)
                productarr = listBox_To.DataSource as ProductArr;
            else
                productarr = new ProductArr();
            productarr.Add(product);
            ProductArrToForm(listBox_To, productarr);

            ///הסרת הפריט הנבחר מרשימת הפריטים הנבחרים
            productarr = listBox_From.DataSource as ProductArr;
            productarr.Remove(product);
            ProductArrToForm(listBox_From, productarr);
        }
        private void Potential_ListBox_DoubleClick(object sender, EventArgs e)
        {
            MoveSelectedItemBetweenListBox(listBox_Potential, listBox_InOrderProducts);
        }
        private void listbox_Orders_DoubleClick(object sender, EventArgs e)
        {
            Order order = listBox_Orders.SelectedItem as Order;

            //הצגת חלקי ההזמנה בלשוניות השונות
            //לשונית פרטי הזמנה

            OrderToForm(order);

            //לשונית לקוח להזמנה

            ClientToForm(order.Client);
            listBox_Client.SelectedValue = order.Client.id;

            //לשונית פריטים להזמנה
            //תיבת רשימה - פריטים בהזמנה
            //מוצאים את הפריטים בהזמנה הנוכחית
            //כל הזוגות פריט-הזמנה

            OrderProductArr orderProductArr = new OrderProductArr();
            orderProductArr.Fill();

            //סינון לפי הזמנה נוכחית

            orderProductArr = orderProductArr.Filter(order);

            //רק אוסף הפריטים מתוך אוסף הזוגות פריט-הזמנה

            ProductArr productArrInOrder = orderProductArr.GetProductArr();
            ProductArrToForm(listBox_InOrderProducts, productArrInOrder);


            //תיבת רשימה - פריטים פוטנציאלים
            //כל הפריטים - פחות אלו שכבר נבחרו

            ProductArr productArrNotInOrder = new ProductArr();
            productArrNotInOrder.Fill();

            //הורדת הפריטים שכבר קיימים בהזמנה

            productArrNotInOrder.Remove(productArrInOrder);
            ProductArrToForm(listBox_Potential, productArrNotInOrder);
        }
        #endregion
        private void CapsLockCheck()
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
                MessageBox.Show("Warning! You have enabled caps-lock");
        }
        
        private void button_Clear_Click(object sender, EventArgs e)
        {
            OrderToForm(null);
            ClientToForm(null);
            for (int i = 0; i < listBox_InOrderProducts.Items.Count; i++)
            {
                MoveSelectedItemBetweenListBox(listBox_InOrderProducts, listBox_Potential);
            }
        }
        private void button_Save_Click(object sender, EventArgs e)
        {
            if (!CheckForm())
            {
                MessageBox.Show("Please Fill The *Error* Fields Again", "Error", MessageBoxButtons.OK,
                MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading |
                MessageBoxOptions.RightAlign);
            }
            else
            {
                //יצירת הזמנה מהטופס
                Order order = FormToOrder();
                //הוספת ההזמנה למסד הנתונים
                OrderProductArr orderProductArr_New;
                if (order.Id == 0)
                {
                    if (order.Insert())
                    {
                        //מוצאים את ההזמנה החדשה - לפי המזהה הגבוה ביותר
                        OrderArr orderArr = new OrderArr();
                        orderArr.Fill();
                        order = orderArr.GetOrderWithMaxId();
                        orderProductArr_New = FormToOrderProductArr(order);
                        //מוסיפים את הפריטים החדשים להזמנה
                        if (orderProductArr_New.Insert())
                            MessageBox.Show("Successfully saved");
                        else
                            MessageBox.Show("Error in insert");
                        //לא לשכוח כאן לנקות את הטופס ולטעון מחדש ערכים לתיבת הרשימה של ההזמנות
                    }
                    else
                    {
                        if (order.Update())
                        {
                            //מוחקים את הפריטים הקודמים של ההזמנה
                            //אוסף כלל הזוגות - הזמנה-פריט

                            OrderProductArr orderProductArr_Old = new OrderProductArr();
                            orderProductArr_Old.Fill();

                            //סינון לפי ההזמנה הנוכחית

                            orderProductArr_Old = orderProductArr_Old.Filter(order);

                            //מחיקת כל הפריטים באוסף ההזמנה-פריט של ההזמנה הנוכחית

                            orderProductArr_Old.Delete();

                            //מוסיפים את הפריטים לפי העדכני להזמנה

                            orderProductArr_New = FormToOrderProductArr(order);
                            orderProductArr_New.Insert();
                        }
                        else
                            MessageBox.Show("Error in update");
                    }
                }
                else
                    MessageBox.Show("Error");
            }
        }
        private void comboBoxFilter_TextChanged(object sender, EventArgs e)
        {
            SetProductsByFilter();
        }
        private void SetProductsByFilter()
        {
            //מייצרים אוסף של כלל המוצרים

            ProductArr productArr = new ProductArr();
            productArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש
            productArr = productArr.Filter(textBox_FilterID.Text,
            comboBox_FilterCategory.SelectedItem as Category,
            comboBox_FilterLevel.SelectedItem as Level);

            //אחרי שמסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש 
            if (listBox_InOrderProducts.DataSource != null)
                productArr.Remove(listBox_InOrderProducts.DataSource as ProductArr);

            //מציבים בתיבת הרשימה את אוסף המוצרים
            ProductArrToForm(listBox_Potential, productArr);
        }

        private void SetOrdersByFilter()
        {

            //מייצרים אוסף של כלל המוצרים

            OrderArr orderArr = new OrderArr();
            orderArr.Fill();

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש

            orderArr = orderArr.Filter(int.Parse(textBox_Filter_OrderDetails_ID.Text), 
            Convert.ToDateTime(dateTimePicker_From.Text), 
            Convert.ToDateTime(dateTimePicker_To.Text), 
            client_TextBox_Filter.Text);

            //מציבים בתיבת הרשימה את אוסף המוצרים
            listBox_Orders.DataSource = orderArr;
        }
        private void ProductArrToForm(ListBox listBox, ProductArr productArr = null)
        {

            //מקבלת אוסף פריטים ותיבת רשימה לפריטים ומציבה את האוסף בתוך התיבה
            //אם האוסף ריק - מייצרת אוסף חדש מלא בכל הערכים מהטבלה

            listBox.DataSource = null;
            if (productArr == null)
            {
                productArr = new ProductArr();
                productArr.Fill();
            }
            listBox.DataSource = productArr;
        }
        private OrderProductArr FormToOrderProductArr(Order curOrder)
        {

            // יצירת אוסף המוצרים להזמנה מהטופס
            // מייצרים זוגות של הזמנה-מוצר , ההזמנה - תמיד אותה הזמנה )הרי מדובר על הזמנה אחת(, המוצר - מגיע מרשימת המוצרים שנבחרו
            OrderProductArr orderProductArr = new OrderProductArr();
            OrderProduct orderProduct;

            //סורקים את כל הערכים בתיבת הרשימה של המוצרים שנבחרו להזמנה
            for (int i = 0; i < listBox_InOrderProducts.Items.Count; i++)
            {
                orderProduct = new OrderProduct();

                //ההזמנה הנוכחית היא ההזמנה לכל הזוגות באוסף

                orderProduct.Order = curOrder;

                //מוצר נוכחי לזוג הזמנה-מוצר

                orderProduct.Product = listBox_InOrderProducts.Items[i] as Product;

                //הוספת הזוג הזמנה -מוצר לאוסף

                orderProductArr.Add(orderProduct);
            }
            return orderProductArr;
        }
        #region Text Validators
        private void textBox_Names_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsENGMLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.KeyChar = char.MinValue;
        }
        private void textBox_Email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEngLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ' && !char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '@')
                e.KeyChar = char.MinValue;
        }
        private bool IsEngLetter(char c)
        {
            return ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'));
        }
        private bool IsENGMLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z') || (c == '-') || (c == ' ');
        }
        #endregion
    }
}
