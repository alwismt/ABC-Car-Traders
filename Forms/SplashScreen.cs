using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_traders.Forms
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = this.picLogo.BackColor;
            this.TransparencyKey = this.picLogo.BackColor;

            SplashTimer.Enabled = true;
            SplashTimer.Interval = 1000;
        }

        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
