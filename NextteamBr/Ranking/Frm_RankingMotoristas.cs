using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NextteamBr
{
    public partial class Frm_RankingMotoristas : Form
    {
        IEnumerable<Ranking> RankingMensal = new List<Ranking>();
        IEnumerable<Ranking> RankingAnual = new List<Ranking>();
        public Frm_RankingMotoristas()
        {
            InitializeComponent();
        }

        private void Frm_RankingMotoristas_Load(object sender, EventArgs e)
        {
            dataFretes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataFretes.Columns.Add("Posicao", "Posição");
            preencherGrid(ERanking.Mensal);
            formatarGrid();
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
                    e.CellStyle.BackColor = Color.DarkRed;
                    e.CellStyle.ForeColor = Color.White;
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
                if (RankingMensal.ToList().Count == 0)
                    RankingMensal = RankingService.ObterRanking(tipo);

                foreach (var item in RankingMensal)
                {
                    item.Pontos = Math.Round(item.Pontos, 2);
                    item.KM = Math.Round(item.KM, 2);
                }

                dataFretes.DataSource = RankingMensal;
            }
            else
            {
                if (RankingAnual.ToList().Count == 0)
                    RankingAnual = RankingService.ObterRanking(tipo);

                foreach (var item in RankingAnual)
                {
                    item.Pontos = Math.Round(item.Pontos, 2);
                    item.KM = Math.Round(item.KM, 2);
                }

                dataFretes.DataSource = RankingAnual;
            }

            formatarGrid();
        }

        private void formatarGrid()
        {
            dataFretes.Columns["Posicao"].DisplayIndex = 0;
            dataFretes.Columns["Posicao"].Width = 50;
            dataFretes.Columns[1].HeaderText = "Motorista";
            dataFretes.Columns[3].HeaderText = "Pontuação";

            for (int i = 0; i < dataFretes.Rows.Count; i++)
            {
                dataFretes.Rows[i].Height = 25;
                dataFretes.Rows[i].Cells["Posicao"].Value = (i + 1);
            }
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
