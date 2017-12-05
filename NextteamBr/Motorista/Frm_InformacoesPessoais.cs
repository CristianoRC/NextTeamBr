using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NextteamBr
{
    public partial class Frm_InformacoesPessoais : Form
    {
        Motorista usuarioInfo;
        public Frm_InformacoesPessoais(int id)
        {
            usuarioInfo = MotoristaService.ObterInformacoes(id);
            InitializeComponent();
        }

        private void Frm_InformacoesPessoais_Load(object sender, EventArgs e)
        {
            lbl_nome.Text = usuarioInfo.Nome;
            lbl_fretes.Text = FreteService.NumeroDeFretesPorMotorista(usuarioInfo.ID).ToString();

            dataFretes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            var listaFretes = FreteService.ListarFretesPorMotorista(usuarioInfo.ID, 15);

            preencherGrid(listaFretes);

            atualizarPontos();
        }

        private void dataFretes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.RowIndex % 2 == 0)
                {
                    e.CellStyle.BackColor = Color.White;
                }
                else
                {
                    e.CellStyle.BackColor = Color.DarkGray;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private void dataFretes_SelectionChanged(object sender, EventArgs e)
        {
            this.dataFretes.ClearSelection();
        }

        private void preencherGrid(IEnumerable<Frete> fretes)
        {
            foreach (var item in fretes)
            {
                item.Dano = Math.Round(item.Dano, 2);
            }

            dataFretes.DataSource = fretes;
            dataFretes.Columns.Remove("IdMotorista");

            dataFretes.Columns[0].HeaderText = "ID Frete";
            dataFretes.Columns[1].HeaderText = "Cidade inicial";
            dataFretes.Columns[2].HeaderText = "Cidade destino";
            dataFretes.Columns[3].HeaderText = "KM Rodado";
            dataFretes.Columns[4].HeaderText = "Carga";
            dataFretes.Columns[5].HeaderText = "Dano %";
            dataFretes.Columns[6].HeaderText = "Data";
            dataFretes.Columns[7].HeaderText = "Pontuação";
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            var fretes = FreteService.ListarFretesPorMotorista(usuarioInfo.ID, 15);
            preencherGrid(fretes);

            atualizarPontos();
        }

        private void btn_listarTodos_Click(object sender, EventArgs e)
        {
            var fretes = FreteService.ListarFretesPorMotorista(usuarioInfo.ID);
            preencherGrid(fretes);
        }

        private void atualizarPontos()
        {
            var pontos = RankingService.ObterPontuacao(usuarioInfo.ID, ERanking.Anual);

            lbl_pontuacao.Text = Math.Round(pontos, 2).ToString();
        }

        private void redefinirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_redefinirSenha = new Frm_RedefinirSenha(usuarioInfo.ID);

            frm_redefinirSenha.ShowDialog();
        }

        private void alterarNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm_redefinirNome = new Frm_AlterarNome(usuarioInfo.ID);

            frm_redefinirNome.ShowDialog();
        }
    }
}
