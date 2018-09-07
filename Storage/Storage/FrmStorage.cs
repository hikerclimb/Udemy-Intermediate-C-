using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Storage
{
    public partial class FrmStorage : Form
    {
        public FrmStorage()
        {
            InitializeComponent();
        }

        //declaration of variables section
        int age;
        string yourname;
        double pay;

        private void BtnGo_Click(object sender, EventArgs e)
        {
            //assignment statements
            age = 15;
            yourname = "Aniket";
            pay = 230.75;

            //display the results ... output
            MessageBox.Show("your ages is " + age.ToString());
            MessageBox.Show("your name is " + yourname);
            MessageBox.Show("your pay is " + pay.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("your name is " + yourname);
        }
    }
}
