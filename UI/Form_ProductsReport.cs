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
    public partial class Form_ProductsReport : Form
    {
        public Form_ProductsReport()
        {
            InitializeComponent();
            FillListView();
        }
        Bitmap m_bitmap;
        private void FillListView()
        {

            //מוסיף נתונים לפקד תיבת התצוגה
            //יצירת מקור הנתונים

            ProductArr productArr = new ProductArr();
            productArr.Fill();
            Product p;
            ListViewItem listViewItem;

            //מעבר על כל הפריטים במקור הנתונים והוספה שלהם לתיבת התצוגה

            for (int i = 0; i < productArr.Count; i++)
            {
                p = productArr[i] as Product;

                //יצירת פריט-תיבת-תצוגה
                listViewItem = new ListViewItem(new[] { p.Name,
                p.Category.Name, p.Level.Name, p.Count.ToString() });
                //הוספת פריט-תיבת-תצוגה לתיבת תצוגה
                listViewProducts.Items.Add(listViewItem);
            }
        }
        
        private void document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //מגדיר את העמוד שיודפס - כולל מרחק מהשמאל ומלמעלה
            e.Graphics.DrawImage(m_bitmap, 100, 100);
        }
        private void CaptureScreen()
        {
            //תפיסת החלק של הטופס להדפסה כולל הרשימה והכותרת שמעליה - לתוך תמונת הסיביות
            int addAboveListView = 30;
            int moveLeft = 150;
            Graphics graphics = listViewProducts.CreateGraphics();
            Size curSize = listViewProducts.Size;
            curSize.Height += addAboveListView;
            curSize.Width += moveLeft;
            m_bitmap = new Bitmap(curSize.Width, curSize.Height, graphics);
            graphics = Graphics.FromImage(m_bitmap);
            Point panelLocation = PointToScreen(listViewProducts.Location);
            graphics.CopyFromScreen(panelLocation.X, panelLocation.Y - addAboveListView,
            moveLeft, 0, curSize);
        }
        private void button_Print_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Width = 600; printPreviewDialog1.Height = 800;
            printPreviewDialog1.ShowDialog();
        }
        private int m_LastColumnSortBy = -1;
        private SortOrder m_LastSortOrder = SortOrder.Ascending;
        private void listView_Products_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            ListViewSorter sorter = new ListViewSorter();
            listViewProducts.ListViewItemSorter = sorter;
            sorter = listViewProducts.ListViewItemSorter as ListViewSorter;
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
            listViewProducts.Sort();
            // שומרים את העמודה הנוכחית כאחרונה שלפיה היה המיון
            m_LastColumnSortBy = e.Column;
            // שומרים את סדר המיון האחרון
            m_LastSortOrder = sorter.SortOrder;
        }
    }
}
