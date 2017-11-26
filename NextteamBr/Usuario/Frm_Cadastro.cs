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
    public partial class Frm_Cadastro : Form
    {
        public Frm_Cadastro()
        {
            InitializeComponent();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new Usuario(Txt_Login.Text, Txt_Senha.Text, txt_Nome.Text);

                usuario.Cadastrar();

                MessageBox.Show("Usuário Cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                if (ex.Message.Contains("Login"))
                {
                    MessageBox.Show($"Já existe um usuário com esse Login", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show($"Erro ao cadastrar usuário! Entre em contato com um administrador. {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
