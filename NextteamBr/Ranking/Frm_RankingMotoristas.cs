using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NextteamBr
{
    public partial class Frm_RankingMotoristas : Form
    {
        public Frm_RankingMotoristas()
        {
            InitializeComponent();
        }

        private void Frm_RankingMotoristas_Load(object sender, EventArgs e)
        {
            dataFretes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            preencherGrid();
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

        private void preencherGrid()
        {
            dataFretes.DataSource = RankingRepository.ObterRanking();

            dataFretes.Columns.Add("Posicao", "Posição");
            dataFretes.Columns["Posicao"].DisplayIndex = 0;
            dataFretes.Columns["Posicao"].Width = 50;
            dataFretes.Columns[0].HeaderText = "Motorista";
            dataFretes.Columns[1].HeaderText = "Pontuação";

            for (int i = 0; i < dataFretes.Rows.Count; i++)
            {
                dataFretes.Rows[i].Height = 25;
                dataFretes.Rows[i].Cells[2].Value = (i + 1);
            }
        }
    }
}
