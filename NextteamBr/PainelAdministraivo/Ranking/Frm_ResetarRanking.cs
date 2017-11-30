using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            if (txt_Senha.Text == "@#VBH51)(*")
            {
                RankingService.Resetar();
                MessageBox.Show("O ranking foi resetado com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Senha inválida","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
