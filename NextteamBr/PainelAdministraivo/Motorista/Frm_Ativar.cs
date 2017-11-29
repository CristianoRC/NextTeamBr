using System;
using NextteamBr;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace NextteamBr.PainelAdministraivo
{
    public partial class Frm_Ativar : Form
    {
        List<Motorista> listaDemotoristas;

        public Frm_Ativar()
        {
            InitializeComponent();
        }

        private void Frm_Ativar_Load(object sender, EventArgs e)
        {
            listaDemotoristas = MotoristaService.ListarInativos().ToList();
            AtualizarComboBox();
        }

        private void Btm_Ativar_Click(object sender, EventArgs e)
        {
            if (comboMotoristas.Text.Length != 0)
            {
                var motorista = listaDemotoristas[comboMotoristas.SelectedIndex];
                MotoristaService.Ativar(motorista.ID);
                listaDemotoristas.Remove(motorista);
                MessageBox.Show("Motorista ativado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarComboBox();
            }
            else
            {
                MessageBox.Show("Selecione um motoristas para ativar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarComboBox()
        {
            comboMotoristas.Items.Clear();

            foreach (var item in listaDemotoristas)
            {
                var valorCombobox = $"{item.ID} - {item.Nome}";

                comboMotoristas.Items.Add(valorCombobox);
            }
        }
    }
}
