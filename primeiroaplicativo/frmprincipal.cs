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
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }

        private void lblmensagem_Click(object sender, EventArgs e)
        {
            lblmensagem.Text = "primeiroaplicativo";
            lblmensagem.ForeColor = Color.RoyalBlue;
            
        }

        private void btnmostrarmensagem_Click(object sender, EventArgs e)
        {
            lblmensagem.Text = "primeiro aplicativo em c#";
            lblmensagem.ForeColor = Color.RoyalBlue;
            btnclick.Enabled = true;
            btnimagem.Enabled = true;
            btntabuada.Enabled = true;
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            frmpropriedadescheckbox propriedades = new frmpropriedadescheckbox(); // instanciando o formulario
            propriedades.ShowDialog(); //o formulario é exibido através do método showdialog

        }

        private void btnimagem_Click(object sender, EventArgs e)
        {
            frmvisualisadordeimagem propriedades = new frmvisualisadordeimagem();
            propriedades.ShowDialog();
        }

        private void btntabuada_Click(object sender, EventArgs e)
        {
            frmtabuada tabuada = new frmtabuada(); //instaciando o formulario frmtabuada
            tabuada.ShowDialog(); // o formulario é exibido pelo método showdialog
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
