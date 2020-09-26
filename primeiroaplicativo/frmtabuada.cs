using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroaplicativo
{
    public partial class frmtabuada : Form
    {
        public frmtabuada()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            if (txtnumero.Text == "") 
            {
                MessageBox.Show("voçê precisa digitar o número para calcular a tabuada",
                                 "informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                double numero, resultado;
                numero = double.Parse(txtnumero.Text);

                for (int i = 0; i <= 10; i++)
                    {

                    resultado = numero * 1;
                    txttabuada.Text += numero + "x" + i + "=" + resultado + "\r\n";
                }
            }

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            txtnumero.Text = "";
            txttabuada.Text = "";
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            frmprincipal novo = new frmprincipal();
            novo.ShowDialog();
        }
    }
}
