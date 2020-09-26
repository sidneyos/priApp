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
    public partial class frmvisualisadordeimagem : Form
    {
        public frmvisualisadordeimagem()
        {
            InitializeComponent();
        }

        private void btnmostrarimagem_Click(object sender, EventArgs e)
        {
            if (ofdimagem.ShowDialog() ==DialogResult.OK)
            {
                pbimagem.Load(ofdimagem.FileName);
                btnlimparimagem.Enabled = false;
            }
        }

        private void btnlimparimagem_Click(object sender, EventArgs e)
        {
            pbimagem.Image = null;
        }

        private void rbstretch_CheckedChanged(object sender, EventArgs e)
        {
            if (rbstretch.Checked == true)
            {
                pbimagem.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void rbnormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbnormal.Checked == true)
            {
                pbimagem.SizeMode = PictureBoxSizeMode.Normal;
            }
        }
        private void btnlimpar_Click(object sender, EventArgs e)
        {
            btnlimparimagem.Text = "";
            btnlimparimagem.Text = "";
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            frmprincipal novo = new frmprincipal();
            novo.ShowDialog();
        }
    }
}
