using NextteamBr.PainelAdministraivo;
using System;
using System.Windows.Forms;

namespace NextteamBr
{
    public partial class Frm_Escolha : Form
    {
        int IdUsuario;
        bool Admin;

        public Frm_Escolha(int p_id, bool admin)
        {
            InitializeComponent();
            Admin = admin;
            IdUsuario = p_id;
        }

        private void Btm_LogBook_Click(object sender, EventArgs e)
        {
            var frm_Principal = new Frm_Principal(IdUsuario);

            frm_Principal.Show();
        }

        private void Btm_JobSync_Click(object sender, EventArgs e)
        {
            var frm_informacoes = new Frm_InformacoesPessoais(IdUsuario);

            frm_informacoes.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frm_rankings = new Frm_RankingMotoristas();

            frm_rankings.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Admin)
            {
                var frm_ADM = new Frm_MDI();

                frm_ADM.Show();
            }
            else
            {
                MessageBox.Show("Somente administradores podem ter acesso a essa funcionalidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}