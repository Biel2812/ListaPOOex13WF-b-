using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PJ013
{
    public partial class frmTrianguloABC : Form
    {
        public frmTrianguloABC()
        {
            InitializeComponent();
        }

        private void Calcular(object sender, EventArgs e)
        {
            triangulo t;
            t = new triangulo();
            t.setVa(int.Parse(txtVa.Text));
            t.setVb(int.Parse(txtVb.Text));
            t.setVc(int.Parse(txtVc.Text));
            t.calcularValores();

            lblResultado.Text = t.calcularValores();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
