using System;
using System.Windows.Forms;

namespace NextteamBr
{
    public partial class Frm_Escolha : Form
    {
        int IdUsuario;

        public Frm_Escolha(int p_id)
        {
            InitializeComponent();

            IdUsuario = p_id;
        }

        private void Btm_LogBook_Click(object sender, EventArgs e)
        {
            using (var frm_Principal = new Frm_Principal(IdUsuario))
            {
                this.Visible = false;
                frm_Principal.ShowDialog();
                this.Dispose();
            }
        }

        private void Btm_JobSync_Click(object sender, EventArgs e)
        {
            var frm_Ranking = new Frm_Ranking();

            frm_Ranking.ShowDialog();
        }
    }
}