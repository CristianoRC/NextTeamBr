using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace NextteamBr
{
    public partial class Frm_Empresas : Form
    {
        List<Empresa> Empresas;

        public Frm_Empresas()
        {
            InitializeComponent();

            Empresas = EmpresaService.Listar().ToList();
        }

        private void Frm_Empresas_Load(object sender, EventArgs e)
        {
            foreach (var item in Empresas)
            {
                comboEmpresas.Items.Add(item.Nome);
            }

            dataRanking.DataSource = Empresas;

            dataRanking.Columns[0].Width = 20;
            dataRanking.Columns[2].HeaderText = "Nº de motoristas";
            dataRanking.Columns[3].HeaderText = "KM Anual";
        }

        private void comboEmpresas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var idEmpresa = Empresas[comboEmpresas.SelectedIndex].ID;

            if (idEmpresa == 1)
            {
                pictureEmpresa.BackgroundImage = NextteamBr.Properties.Resources.Logo;
            }
            else if (idEmpresa == 2)
            {
                pictureEmpresa.BackgroundImage = NextteamBr.Properties.Resources.Ftt;
            }
            else
            {
                pictureEmpresa.BackgroundImage = NextteamBr.Properties.Resources.TC_Log;
            }

            lbl_NumeroMotoristas.Text = EmpresaService.ObterNumeroDeMembros(idEmpresa).ToString();
            lbl_KMRodado.Text = EmpresaService.ObterKMRodadosMensal(idEmpresa).ToString();
            lbl_KmRodadoAnual.Text = EmpresaService.ObterKMRodadosAnual(idEmpresa).ToString();
        }

        private void dataRanking_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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

        private void dataRanking_SelectionChanged(object sender, EventArgs e)
        {
            this.dataRanking.ClearSelection();
        }
    }
}
