using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoBrasileirao
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            frmTelaConsultar novaJanela = new frmTelaConsultar();
            novaJanela.FormClosed += (s, args) => Application.Exit();
            novaJanela.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTelaAtualizar novaJanela = new frmTelaAtualizar();
            novaJanela.FormClosed += (s, args) => Application.Exit();
            novaJanela.Show();
            this.Hide();
        }
    }
}
