using System;
using System.Windows.Forms;

namespace NextteamBr.PainelAdministraivo
{
    public partial class Frm_MDI : Form
    {

        public Frm_MDI()
        {
            InitializeComponent();
        }

        private void ativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_Ativar = new Frm_Ativar();
            frm_Ativar.MdiParent = this;
            frm_Ativar.Show();
        }

        private void desativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_Desativar = new Frm_Desativar();
            frm_Desativar.MdiParent = this;
            frm_Desativar.Show();
        }

        private void resetarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_Desativar = new Frm_ResetarSenha();
            frm_Desativar.MdiParent = this;
            frm_Desativar.Show();

        }

        private void relatórioDeFretesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var infoFretes = new Frm_InformacoesFrete();
            infoFretes.MdiParent = this;
            infoFretes.Show();
        }

        private void resetarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_ResetarRanking = new Frm_ResetarRanking();
            frm_ResetarRanking.MdiParent = this;
            frm_ResetarRanking.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm_Empresa = new Frm_SetarEmpresa();
            frm_Empresa.MdiParent = this;
            frm_Empresa.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_ExcluirMotorista = new frm_ExcluirMotorista();

            frm_ExcluirMotorista.MdiParent = this;

            frm_ExcluirMotorista.Show();
        }
    }
}
