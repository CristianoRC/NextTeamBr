using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NextteamBr
{
    public partial class Frm_RankingMotoristas : Form
    {
        int IDEmpresa;
        IEnumerable<Ranking> RankingMensal;
        IEnumerable<Ranking> RankingAnual;

        public Frm_RankingMotoristas(int empresa)
        {
            InitializeComponent();

            IDEmpresa = empresa;
        }

        private void Frm_RankingMotoristas_Load(object sender, EventArgs e)
        {
            RankingMensal = RankingService.ObterRankingEmpresa(ERanking.Mensal, IDEmpresa);
            RankingAnual = RankingService.ObterRankingEmpresa(ERanking.Anual, IDEmpresa);

            foreach (var item in RankingAnual)
            {
                item.Pontos = Math.Round(item.Pontos, 2);
            }

            foreach (var item in RankingMensal)
            {
                item.Pontos = Math.Round(item.Pontos, 2);
            }

            dataFretes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataFretes.Columns.Add("Posicao", "Posição");
            dataFretes.Columns.Add("Categoria", "Categoria");
            dataFretes.Columns.Add("Experiencia", "Experiência");

            preencherGrid(ERanking.Mensal);
            formatarGrid();
        }

        private void formatarGrid()
        {
            dataFretes.Columns["Posicao"].DisplayIndex = 0;
            dataFretes.Columns["Posicao"].Width = 50;

            dataFretes.Columns["Categoria"].DisplayIndex = 2;
            dataFretes.Columns["Categoria"].Width = 57;

            dataFretes.Columns["Experiencia"].DisplayIndex = 5;
            dataFretes.Columns[5].HeaderText = "Pontuação";

            formatarCor();

            for (int i = 0; i < dataFretes.Rows.Count; i++)
            {
                dataFretes.Rows[i].Height = 25;
                dataFretes.Rows[i].Cells["Posicao"].Value = (i + 1);

                var KM = Convert.ToDouble(dataFretes.Rows[i].Cells["KM"].Value);
                var corXP = Ranking.ObterCorExperiencia(KM);
                var corCAT = Ranking.ObterCorCategoria(KM);

                dataFretes.Rows[i].Cells["Experiencia"].Value = Ranking.ObterExperiencia(KM);
                dataFretes.Rows[i].Cells["Experiencia"].Style.BackColor = corXP;

                dataFretes.Rows[i].Cells["Categoria"].Value = Ranking.ObterCategoria(KM);
                dataFretes.Rows[i].Cells["Categoria"].Style.BackColor = corCAT;
            }
        }

        private void formatarCor()
        {
            for (int i = 0; i < dataFretes.Rows.Count; i++)
            {
                if (i % 2 == 0)
                {
                    dataFretes.Rows[i].Cells[0].Style.BackColor = Color.White;
                    dataFretes.Rows[i].Cells[1].Style.BackColor = Color.White;
                    dataFretes.Rows[i].Cells[2].Style.BackColor = Color.White;
                    dataFretes.Rows[i].Cells[3].Style.BackColor = Color.White;
                    dataFretes.Rows[i].Cells[4].Style.BackColor = Color.White;
                    dataFretes.Rows[i].Cells[5].Style.BackColor = Color.White;
                }
                else
                {
                    dataFretes.Rows[i].Cells[0].Style.BackColor = Color.Gray;
                    dataFretes.Rows[i].Cells[1].Style.BackColor = Color.Gray;
                    dataFretes.Rows[i].Cells[2].Style.BackColor = Color.Gray;
                    dataFretes.Rows[i].Cells[3].Style.BackColor = Color.Gray;
                    dataFretes.Rows[i].Cells[4].Style.BackColor = Color.Gray;
                    dataFretes.Rows[i].Cells[5].Style.BackColor = Color.Gray;
                }
            }
        }

        private void dataFretes_SelectionChanged(object sender, EventArgs e)
        {
            this.dataFretes.ClearSelection();
        }

        private void preencherGrid(ERanking tipo)
        {

            if (tipo == ERanking.Mensal)
            {
                dataFretes.Columns["Experiencia"].Visible = false;
                dataFretes.Columns["Categoria"].Visible = false;
                dataFretes.DataSource = RankingMensal;
            }
            else
            {
                dataFretes.DataSource = RankingAnual;
                dataFretes.Columns["Experiencia"].Visible = true;
                dataFretes.Columns["Categoria"].Visible = true;
            }

            formatarGrid();
        }

        private void radioAnual_Click(object sender, EventArgs e)
        {
            preencherGrid(ERanking.Anual);
        }

        private void radioMes_Click(object sender, EventArgs e)
        {
            preencherGrid(ERanking.Mensal);
        }
    }
}
