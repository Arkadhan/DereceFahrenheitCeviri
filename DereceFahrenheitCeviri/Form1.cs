using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DereceFahrenheitCeviri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            double derece = Convert.ToDouble(tbDerece.Text);
            lblDurum.Text = Convert.ToString(derece*1.8+32);
        }

        private void btnDerece_Click(object sender, EventArgs e)
        {
            double fahren = Convert.ToDouble(tbFahrenheit.Text);
            lblDurum.Text = Convert.ToString((fahren - 32)/1.8);
        }

        private void btnKelvin_Click(object sender, EventArgs e)
        {
            double kelvin = Convert.ToDouble(tbKelvin.Text);
            lblDurum.Text = Convert.ToString(kelvin - 273.15);
        }
    }
}
