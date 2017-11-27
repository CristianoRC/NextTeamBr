using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace NextteamBr
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Btm_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btm_Logar_Click(object sender, EventArgs e)
        {


            if (!String.IsNullOrWhiteSpace(Txt_Login.Text) && !String.IsNullOrWhiteSpace(Txt_Senha.Text))
            {
                var usuario = new Usuario(Txt_Login.Text, Txt_Senha.Text);

                var resultado = usuario.Logar();

                if (resultado == "1")
                {
                    Usuario.SalvarUltimoLogin(Txt_Login.Text);

                    var usuarioTemp = UsuarioRepository.ObterInformacoes(Txt_Login.Text);

                    ChamarFormularioDeEscolha(usuarioTemp.ID, usuarioTemp.Admin);
                }
                else
                {
                    MessageBox.Show("Login ou senha inválidos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Insira seu login e senha!", "Alterta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void ChamarFormularioDeEscolha(int p_ID, bool admin)
        {
            var frm_Principal = new Frm_Escolha(p_ID, admin);
            this.Visible = false;
            frm_Principal.ShowDialog();
            this.Dispose();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            Lbl_Versao.Text = "Versão: " + Application.ProductVersion;


            var Resultado = ControleVersao.VerificarAtualizacoes();

            if (Resultado.Contains("Erro ao tentar fazer a requisição:"))
            {
                MessageBox.Show("Verifique a sua conexão, para poder continuar utilizando o software", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Btm_Logar.Enabled = false;
            }
            else if (Resultado != String.Empty && !Resultado.Contains("Erro ao tentar fazer a requisição:"))
            {
                MessageBox.Show("Atualize o seu Software para poder continuar Utilizando!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Btm_Logar.Enabled = false;
                Process.Start(Resultado);
            }

            Txt_Login.Text = Usuario.ObterUltimoLogin();
        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            var frm_Cadastro = new Frm_Cadastro();

            frm_Cadastro.ShowDialog();
        }
    }
}
