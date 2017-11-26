using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dapper;

namespace NextteamBr
{
    public partial class Frm_Ranking : Form
    {
        public Frm_Ranking()
        {
            InitializeComponent();
        }

        private void Frm_Ranking_Load(object sender, EventArgs e)
        {
            BancoDeDados.abrirConexao();
            var resultado = BancoDeDados.conexao.Query<Frete>("Select * from Frete");
            BancoDeDados.fecharConexao();
            dataGridView1.DataSource = resultado;
        }
    }
}
