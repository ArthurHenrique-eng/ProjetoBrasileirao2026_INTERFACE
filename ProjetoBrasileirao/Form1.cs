using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoBrasileirao
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();

            path.AddArc(0, 0, 20, 20, 180, 90);
            path.AddArc(btn_entrar.Width - 20, 0, 20, 20, 270, 90);
            path.AddArc(btn_entrar.Width - 20, btn_entrar.Height - 20, 20, 20, 0, 90);
            path.AddArc(0, btn_entrar.Height - 20, 20, 20, 90, 90);
            path.CloseFigure();

            btn_entrar.Region = new Region(path);
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            frmPrincipal novaJanela = new frmPrincipal();
            novaJanela.FormClosed += (s, args) => Application.Exit();
            novaJanela.Show();
            this.Hide();
        }
    }
}