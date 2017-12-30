using System;
using System.Windows.Forms;

namespace NextteamBr.PainelAdministraivo
{
    public partial class Frm_ResetarRanking : Form
    {
        public Frm_ResetarRanking()
        {
            InitializeComponent();
        }

        private void btn_Zerar_Click(object sender, EventArgs e)
        {
            var senha = Ferramentas.getMD5Hash(txt_Senha.Text);
            if (senha == "67f683b2b9d5b0eecfe46f0d9119961d" && radioMes.Checked)
            {
                RankingService.Resetar(ERanking.Mensal);
                MessageBox.Show("O ranking mensal foi resetado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (senha == "496f366709619f761f5802d1ece99e7d" && radioAnual.Checked)
            {
                RankingService.Resetar(ERanking.Anual);
                MessageBox.Show("O ranking anual foi resetado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Senha inválida", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_ResetarRanking_Load(object sender, EventArgs e)
        {

        }
    }
}
