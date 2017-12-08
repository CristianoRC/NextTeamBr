using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace NextteamBr.PainelAdministraivo
{
    public partial class Frm_SetarEmpresa : Form
    {
        List<Motorista> Motoristas;
        List<Empresa> Empresas;

        public Frm_SetarEmpresa()
        {
            InitializeComponent();
        }

        private void Frm_Ativar_Load(object sender, EventArgs e)
        {
            Motoristas = MotoristaService.ListarSemEmpresa().ToList();
            Empresas = EmpresaService.Listar().ToList();

            AtualizarComboEmpresas();
            AtualizarComboMotoristas();
        }

        private void AtualizarComboEmpresas()
        {
            foreach (var item in Empresas)
            {
                comboEmpresa.Items.Add(item.Nome);
            }
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
                var empresa = Empresas[comboEmpresa.SelectedIndex];

                if (empresa.ID == 1)
                {
                    if (Ferramentas.getMD5Hash(txt_senha.Text) == "1b780e134393c9e42d8fa00950f4823b")
                    {
                        MotoristaService.SetarEmpresa(motorista.ID, empresa.ID);

                        MessageBox.Show("Empresa setada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Senha inválida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (empresa.ID == 2)
                {
                    if (Ferramentas.getMD5Hash(txt_senha.Text) == "4dfb85a70638e689d8bbd141b53fa22f")
                    {
                        MotoristaService.SetarEmpresa(motorista.ID, empresa.ID);

                        MessageBox.Show("Empresa setada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Senha inválida!", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else
            {
                MessageBox.Show("Selecione um motoristas para setar a empresa!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
