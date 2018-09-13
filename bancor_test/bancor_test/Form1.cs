using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bancor_test
{
    public partial class Form1 : Form
    {
        double R = 0;
        double S = 0;
        double F = 0;
        double E = 0;
        double T = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void butRin_Click(object sender, EventArgs e)
        {
            R = double.Parse(txtR.Text);
            S = double.Parse(txtS.Text);
            F = double.Parse(txtF.Text);

            E = double.Parse(txtE.Text);

            txtT.Text = (S * (Math.Pow((1 + E/R),F) -1)).ToString();

            T = double.Parse(txtT.Text);

            txtR.Text = (R + E).ToString();
            txtS.Text = (S - T).ToString();
        }

        private void butRout_Click(object sender, EventArgs e)
        {
            R = double.Parse(txtR.Text);
            S = double.Parse(txtS.Text);
            F = double.Parse(txtF.Text);

            T = double.Parse(txtT.Text);

            txtE.Text = (R * (Math.Pow((1 + T / S), 1/F) - 1)).ToString();

            E = double.Parse(txtE.Text);
         
            txtS.Text = (S + T).ToString();
            txtR.Text = (R - E).ToString();
        }

        private void butGetP_Click(object sender, EventArgs e)
        {
            R = double.Parse(txtR.Text);
            S = double.Parse(txtS.Text);
            F = double.Parse(txtF.Text);

            txtP.Text = (R / (S * F)).ToString();
        }

        private void butReset_Click(object sender, EventArgs e)
        {
            txtR.Text = "100000";
            txtS.Text = "1000000000";
            txtF.Text = "0.1";
        }
    }
}
