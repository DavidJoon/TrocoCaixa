using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrocoCaixa
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            decimal compra = 0;
            decimal dinheiro = 0;
            decimal troco = 0;

            compra = Convert.ToDecimal(textBoxCompra.Text);
            dinheiro = Convert.ToDecimal(textBoxDinheiro.Text);
            troco = dinheiro - compra;

            textBoxTroco.Text = Convert.ToString(troco);

            int moeda1 = (int)(troco / 1);
            troco = troco % 1;
            label100.Text = moeda1.ToString();

            int moeda2 = (int)(troco / 0.50m);
            troco = troco % 0.50m;
            label050.Text = moeda2.ToString();

            int moeda3 = (int)(troco / 0.25m);
            troco = troco % 0.25m;
            label025.Text = moeda3.ToString();

            int moeda4 = (int)(troco / 0.10m);
            troco = troco % 0.10m;
            label010.Text = moeda4.ToString();

            int moeda5 = (int)(troco / 0.05m);
            troco = troco % 0.05m;
            label005.Text = moeda5.ToString();

            int moeda6 = (int)(troco / 0.01m);
            troco = troco % 0.01m;
            label001.Text = moeda6.ToString();

        }
    }
}
