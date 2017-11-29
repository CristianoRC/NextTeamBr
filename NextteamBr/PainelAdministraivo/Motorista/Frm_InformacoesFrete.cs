using System;
using NextteamBr;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace NextteamBr.PainelAdministraivo
{
    public partial class Frm_InformacoesFrete : Form
    {
        List<Motorista> listaDemotoristas;

        public Frm_InformacoesFrete()
        {
            InitializeComponent();
        }

        private void Frm_Ativar_Load(object sender, EventArgs e)
        {
            listaDemotoristas = MotoristaService.Listar().ToList();
            AtualizarComboBox();
        }

        private void Btm_Ativar_Click(object sender, EventArgs e)
        {
            if (comboMotoristas.Text.Length != 0)
            {
                var motorista = listaDemotoristas[comboMotoristas.SelectedIndex];

                var frmInfo = new Frm_InformacoesPessoais(motorista.ID);

                frmInfo.Show();
            }
            else
            {
                MessageBox.Show("Selecione um motoristas para ver as informações", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarComboBox()
        {
            foreach (var item in listaDemotoristas)
            {
                var valorCombobox = $"{item.ID} - {item.Nome}";

                comboMotoristas.Items.Add(valorCombobox);
            }
        }
    }
}
