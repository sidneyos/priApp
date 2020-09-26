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
    public partial class frmpropriedadescheckbox : Form
    {
        public frmpropriedadescheckbox()
        {
            InitializeComponent();
        }

        private void chkpessoafisica_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpessoafisica.Checked == true)
            {
                pnlpessoafisica.Visible = true;
            }
            else
            {
                pnlpessoafisica.Visible = false;
            }
        }

        private void chkpessoajuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (chkpessoajuridica.Checked == true)
            {
                pnlpessoajuridica.Visible = true;
            }
            else
            {
                pnlpessoajuridica.Visible = false;
            }
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            frmprincipal novo = new frmprincipal();
            novo.ShowDialog();
        }
    }
 }

