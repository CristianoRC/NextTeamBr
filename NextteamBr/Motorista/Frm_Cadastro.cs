using System;
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
            if (string.IsNullOrEmpty(Txt_Login.Text) || string.IsNullOrEmpty(txt_Nome.Text) || string.IsNullOrEmpty(Txt_Senha.Text))
            {
                MessageBox.Show("Você não pode deixar nem um dos campos em branco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                try
                {
                    var usuario = new Motorista(Txt_Login.Text, Txt_Senha.Text, txt_Nome.Text);

                    usuario.Cadastrar();

                    MessageBox.Show("Usuário Cadastrado com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Exception ex)
                {
                    if (ex.Message.Contains("Login"))
                    {
                        MessageBox.Show($"Já existe um usuário com esse Login", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void Frm_Cadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
