using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace NextteamBr.PainelAdministraivo
{
    public partial class frm_ExcluirMotorista : Form
    {
        List<Motorista> Motoristas;

        public frm_ExcluirMotorista()
        {
            InitializeComponent();
        }

        private void Frm_Ativar_Load(object sender, EventArgs e)
        {
            Motoristas = MotoristaService.ListarSemEmpresa().ToList();
            AtualizarComboMotoristas();
        }

        private void AtualizarComboMotoristas()
        {
            comboMotoristas.Items.Clear();

            foreach (var item in Motoristas)
            {
                var valorCombobox = $"{item.ID} - {item.Nome}";

                comboMotoristas.Items.Add(valorCombobox);
            }
        }

        private void checkMotorista_CheckedChanged(object sender, EventArgs e)
        {
            if (checkMotorista.Checked)
            {
                Motoristas = MotoristaService.ListarSemEmpresa().ToList();
                AtualizarComboMotoristas();
            }
            else
            {
                Motoristas = MotoristaService.Listar().ToList();
                AtualizarComboMotoristas();
            }
        }

        private void Btm_Setar_Click(object sender, EventArgs e)
        {
            if (comboMotoristas.Text.Length != 0)
            {
                var motorista = Motoristas[comboMotoristas.SelectedIndex];
                MotoristaService.Deletar(motorista.ID);
                MessageBox.Show($"O motorista \"{motorista.Nome}\" foi deletado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Selecione um motoristas para setar a empresa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
