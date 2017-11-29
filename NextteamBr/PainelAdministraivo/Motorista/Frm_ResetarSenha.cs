using System;
using NextteamBr;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace NextteamBr.PainelAdministraivo
{
    public partial class Frm_ResetarSenha : Form
    {
        List<Motorista> listaDemotoristas;

        public Frm_ResetarSenha()
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
                MotoristaService.ResetarSenha(motorista.ID);
                MessageBox.Show($"Senha do motorista {motorista.Nome} foi resetada com sucesso para: 123456", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
