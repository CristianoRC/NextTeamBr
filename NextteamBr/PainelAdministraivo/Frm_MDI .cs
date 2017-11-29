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

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
