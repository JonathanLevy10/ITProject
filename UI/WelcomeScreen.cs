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
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
            LoadLab.Parent = pictureBox1;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide(); //hides loading screen
            Form_HomePage form = new Form_HomePage();
            form.ShowDialog(); //opens home page
            Close();
        }

        private void WelcomeScreen_Load(object sender, EventArgs e)
        {
            
        }
    }
}
