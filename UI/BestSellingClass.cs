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
    public partial class BestSellingClass : Form
    {
        Bitmap m_bitmap;
        private int m_LastColumnSortBy = -1;
        private SortOrder m_LastSortOrder = SortOrder.Ascending;
        public BestSellingClass()
        {
            InitializeComponent();

            LevelArrToForm(comboBox_FilterLevel, false);
            CategoryArrToForm(comboBox_FilterCategory, false);

            FillListView();
        }

        private bool IsEnglishLetter(char c)
        {
            return (c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z');
        }

        private void textBox_Text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!IsEnglishLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
                e.KeyChar = char.MinValue;
        }

        private void FillListView()
        {
            //מוסיף נתונים לפקד תיבת התצוגה

            //ניקוי הרשימה מערכים קודמים
            listView_Products.Items.Clear();

            //יצירת מקור הנתונים
            ProductArr productArr = new ProductArr();
            productArr.Fill();
            OrderProductArr orderProductArr = new OrderProductArr();
            orderProductArr.Fill();

            // New Filter Start
            productArr = orderProductArr.FilterByMostSales();
            int[] sales = CountListViewSales(productArr, ScanListView(productArr));
            productArr = ScanListView(productArr);
            // End New Filter

            //מסננים את אוסף המוצרים לפי שדות הסינון שרשם המשתמש
            productArr = productArr.Filter(textBox_FilterName.Text,
            comboBox_FilterCategory.SelectedItem as Category, comboBox_FilterLevel.SelectedItem as Level);

            Product p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה
            for (int i = 0; i < productArr.Count; i++)
            {
                p = productArr[i] as Product;
                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.Name, sales[i].ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listView_Products.Items.Add(listViewItem);
            }

            // Start from up to down
            SortByMostSold();
        }
        private void SortByMostSold()
        {
            ListViewSorter sorter = new ListViewSorter();
            listView_Products.ListViewItemSorter = sorter;
            sorter = listView_Products.ListViewItemSorter as ListViewSorter;
            sorter.ByColumn = 1;

            // אם לחצו שוב על אותה עמודה - המיון יהיה בסדר הפוך לקודם

            sorter.SortOrder = SortOrder.Descending;

            // אחרת - זוהי עמודה חדשה - המיון יהיה בסדר עולה

            listView_Products.Sort();

            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון

            m_LastColumnSortBy = 1;

            // שומרים את סדר המיון האחרון

            m_LastSortOrder = sorter.SortOrder;
        }

        private int[] CountListViewSales(ProductArr p, ProductArr finalPArr)
        {
            ProductArr productArr = new ProductArr();
            productArr.Fill();
            int[] salesArr = new int[finalPArr.Count];
            for (int i = 0; i < finalPArr.Count; i++)
            {
                for (int j = 0; j < p.Count; j++)
                {
                    if ((finalPArr[i] as Product) == (p[j] as Product))
                    {
                        salesArr[i]++;
                    }
                }
            }

            return salesArr;
        }

        private ProductArr ScanListView(ProductArr p)
        {
            int index = 0;
            ProductArr productArr_New = new ProductArr();
            Product placeHolder = p[0] as Product;
            productArr_New.Add(p[0]);
            for (int j = index + 1; j < p.Count; j++)
            {
                if (p[j] != placeHolder)
                {
                    productArr_New.Add(p[j]);
                    placeHolder = p[j] as Product;
                }

            }

            return productArr_New;
        }

        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //מגדיר את העמוד שיודפס - כולל מרחק מהשמאל ומלמעלה

            e.Graphics.DrawImage(m_bitmap, -110, 40);
        }

        private void CaptureScreen()
        {
            //תפיסת החלק של הטופס להדפסה כולל הרשימה והכותרת שמעליה - לתוך תמונת הסיביות

            int addAboveListView = 50;
            int moveLeft = 150;
            Graphics graphics = listView_Products.CreateGraphics();
            Size curSize = listView_Products.Size;
            curSize.Height += addAboveListView;
            curSize.Width += moveLeft;
            m_bitmap = new Bitmap(curSize.Width, curSize.Height, graphics);
            graphics = Graphics.FromImage(m_bitmap);
            Point panelLocation = PointToScreen(listView_Products.Location);
            graphics.CopyFromScreen(panelLocation.X, panelLocation.Y - addAboveListView,
            moveLeft, 0, curSize);
        }

        public void CategoryArrToForm(ComboBox comboBox, bool isMustChoose, Category curCategory = null)
        {
            //ממירה את הטנ "מ אוסף קטגורייות לטופס

            CategoryArr categoryArr = new CategoryArr();

            //הוספת קטגוריית ברירת מחדל - בחר קטגורייה/ כל הקטגוריות

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

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curCategory != null)
                comboBox.SelectedValue = curCategory.Id;
        }

        public void LevelArrToForm(ComboBox comboBox, bool isMustChoose, Level curLevel = null)
        {
            //ממירה את הטנ "מ אוסף חברות לטופס

            LevelArr levelArr = new LevelArr();

            //הוספת חברת ברירת מחדל - בחר חברה/ כל החברות

            Level levelDefault = new Level();
            levelDefault.Id = -1;
            if (isMustChoose)
                levelDefault.Name = "Choose a level";
            else
                levelDefault.Name = "All companies";
            levelArr.Add(levelDefault);
            levelArr.Fill();
            comboBox.DataSource = levelArr;
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";

            //אם נשלח לפעולה טיפוס , הצבתו בתיבת הבחירה של הטיפוס בטופס

            if (curLevel != null)
                comboBox.SelectedValue = curLevel.Id;
        }

        private void listView_Products_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listView_Products.ListViewItemSorter = sorter;
            sorter = listView_Products.ListViewItemSorter as ListViewSorter;
            sorter.ByColumn = e.Column;

            // אם לחצו שוב על אותה עמודה - המיון יהיה בסדר הפוך לקודם

            if (m_LastColumnSortBy == e.Column)
                if (m_LastSortOrder == SortOrder.Ascending)
                    sorter.SortOrder = SortOrder.Descending;
                else
                    sorter.SortOrder = SortOrder.Ascending;

            // אחרת - זוהי עמודה חדשה - המיון יהיה בסדר עולה

            else
                sorter.SortOrder = SortOrder.Ascending;
            listView_Products.Sort();

            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון

            m_LastColumnSortBy = e.Column;

            // שומרים את סדר המיון האחרון

            m_LastSortOrder = sorter.SortOrder;
        }

        private void button_Print_Click(object sender, System.EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Width = 600; printPreviewDialog1.Height = 800;
            printPreviewDialog1.ShowDialog();
        }

        private void button_Home_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        private void button_Clear_Click(object sender, System.EventArgs e)
        {
            // Clearing product filter boxes
            textBox_FilterName.Text = "";
            comboBox_FilterCategory.SelectedIndex = 0;
            comboBox_FilterLevel.SelectedIndex = 0;

            // Loading the form again
            FillListView();
        }

        private void textBox_FilterName_KeyUp(object sender, KeyEventArgs e)
        {
            FillListView();
        }

        private void comboBox_FilterCategory_TextChanged(object sender, System.EventArgs e)
        {
            FillListView();
        }

        private void comboBox_FilterLevel_TextChanged(object sender, System.EventArgs e)
        {
            FillListView();
        }

        private void numericUpDown_MaxPrice_ValueChanged(object sender, System.EventArgs e)
        {
            FillListView();
        }

    }
}