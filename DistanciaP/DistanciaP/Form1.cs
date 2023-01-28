using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DistanciaP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcula_Click(object sender, EventArgs e)
        {
            double x1, x2, y1, y2;
         
            x1 = Convert.ToDouble(txtx1.Text);
            x2 = Convert.ToDouble(txtx2.Text);
            y1 = Convert.ToDouble(txty1.Text);
            y2 = Convert.ToDouble(txty2.Text);

            var Distancia = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            txtD.Text = Distancia.ToString();

        }

        private void PbLimpiar_Click(object sender, EventArgs e)
        {
            txtx1.Clear();
            txtx2.Clear();
            txty1.Clear();
            txty2.Clear();
            txtD.Clear ();
        }
    }
}
