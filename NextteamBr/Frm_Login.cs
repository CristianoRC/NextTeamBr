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
            Usuario uso = new Usuario(Txt_Login.Text, Txt_Senha.Text);

            MessageBox.Show(ControllerUsuario.Logar(uso));

            /*Frm_Principal frm_Principal = new Frm_Principal();
            this.Visible = false;
            frm_Principal.ShowDialog();
            this.Dispose(); */
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            Lbl_Versao.Text = "Versão: " + Application.ProductVersion;

            string Resultado = ControleVersao.VerificarAtualizacoes();

            if (Resultado.Contains("Erro ao tentar fazer a requisição:"))
            {
                MessageBox.Show("Verifique a sua conexão, para poder continuar utilizando o software", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Btm_Logar.Enabled = false;
            }
            else if (Resultado != String.Empty || Resultado.Contains("Erro ao tentar fazer a requisição:"))
            {
                MessageBox.Show("Atualize o seu Software para poder continuar Utilizando!", "Atualização", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Btm_Logar.Enabled = false;
                Process.Start(Resultado);
            }
        }
    }
}
