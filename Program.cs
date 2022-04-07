using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFP_GOS.UI;

namespace WFP_GOS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Form_Level());
            //Application.Run(new Form_Category());
            //Application.Run(new Form_Order());
            //Application.Run(new Form_Product());
            //Application.Run(new Form_Location());
            //Application.Run(new Form_HomePage());
            //Application.Run(new WelcomeScreen());
            //Application.Run(new Form_Comp());
            Application.Run(new Form_ProductsReport());
        }
    }
}
