using System;
using System.Collections.Generic;
using System.ComponentModel;
using DataBase.UI;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFP_GOS.BL;
using WFP_GOS.UI;
using System.Windows.Forms.DataVisualization.Charting;

namespace DataBase.UI
{
    public partial class Form_ClassesByLevel : Form
    {
        public Form_ClassesByLevel()
        {
            InitializeComponent();
            Graph1();
        }

        public void Graph1()
        {
            chart1.Palette = ChartColorPalette.EarthTones;
            chart1.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            ProductArr pArr = new ProductArr();
            pArr.Fill();
            LevelArr cArr = new LevelArr();
            cArr.Fill();
            string[] Arr = new string[cArr.Count];
            for (int i = 0; i < cArr.Count; i++)
                Arr[i] = (cArr[i] as Level).Name;

            for (int j = 0; j < Arr.Length; j++)
            {
                for (int i = 0; i < pArr.Count; i++)
                {
                    Product p = pArr[i] as Product;
                    if ((p.Level.Name == Arr[j]))
                    {
                        if (dictionary.ContainsKey(Arr[j]))
                        {
                            dictionary[Arr[j]] += 1;
                        }
                        else
                        {
                            dictionary.Add(Arr[j], 1);
                        }
                    }
                }
            }
            Series series = new Series("");
            chart1.Series.Clear();
            series.ChartType = SeriesChartType.Pie;
            series.Palette = ChartColorPalette.SeaGreen;
            series.Label = "#VALX" + " " + "(#VAL)";
            
            series.Points.DataBindXY(dictionary.Keys, dictionary.Values);
            
            /*
            series.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.No;
            series.SetCustomProperty("PieLabelStyle", "outside");

            Font font = new Font("Microsoft JhengHei", 0, FontStyle.Bold);
            series.Font = font;
            series.LabelForeColor = Color.Red;*/

            chart1.Series.Add(series);
        }

        private void button_Home_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        Bitmap m_bitmap;
        private void CaptureScreen()
        {

            //תפיסת החלק של הטופס להדפסה כולל הרשימה והכותרת שמעליה - לתוך תמונת הסיביות

            //was 0, -100
            int addAboveListView = 65;
            int moveLeft = -130;
            Graphics graphics = chart1.CreateGraphics();
            Size curSize = chart1.Size;
            curSize.Height += addAboveListView;
            curSize.Width += moveLeft;
            m_bitmap = new Bitmap(curSize.Width, curSize.Height, graphics);
            graphics = Graphics.FromImage(m_bitmap);
            Point panelLocation = PointToScreen(chart1.Location);
            graphics.CopyFromScreen(panelLocation.X, panelLocation.Y - addAboveListView,
            moveLeft, 0, curSize);
        }
        private void button_Print_Click(object sender, System.EventArgs e)
        {
            CaptureScreen();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Width = 600; printPreviewDialog1.Height = 800;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(m_bitmap, 50, 50);
        }
    }
}
