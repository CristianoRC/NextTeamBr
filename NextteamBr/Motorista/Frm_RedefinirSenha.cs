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
    public partial class Frm_RedefinirSenha : Form
    {
        int IDMotorista;
        public Frm_RedefinirSenha(int id)
        {
            InitializeComponent();

            IDMotorista = id;
        }

        private void Btn_Redefinir_Click(object sender, EventArgs e)
        {


            if (txt_confirmacao.Text == txt_senha.Text)
            {
                MotoristaService.RedefinirSenha(IDMotorista, txt_senha.Text);
                MessageBox.Show("Sua senha foi redefinida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                this.Dispose();
                this.Close();
            }
            else
            {
                MessageBox.Show("As senhas não coincidem, verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
