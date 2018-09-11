using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioBtnGrp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbRain_CheckedChanged(object sender, EventArgs e)
        {
            pbRain.Visible = true;
            pbSnow.Visible = false;
            pbSun.Visible = false;

        }

        private void rbSun_CheckedChanged(object sender, EventArgs e)
        {
            pbRain.Visible = false;
            pbSnow.Visible = false;
            pbSun.Visible = true;
        }

        private void rbSnow_CheckedChanged(object sender, EventArgs e)
        {
            pbRain.Visible = false;
            pbSnow.Visible = true;
            pbSun.Visible = false;
        }

        private void rbCanada_CheckedChanged(object sender, EventArgs e)
        {
            pbCanada.Visible = true;
            pbItaly.Visible = false;
            pbUK.Visible = false;
        }

        private void rbItaly_CheckedChanged(object sender, EventArgs e)
        {
            pbCanada.Visible = false;
            pbItaly.Visible = true;
            pbUK.Visible = false;
        }

        private void rbUK_CheckedChanged(object sender, EventArgs e)
        {
            pbCanada.Visible = false;
            pbItaly.Visible = false;
            pbUK.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
