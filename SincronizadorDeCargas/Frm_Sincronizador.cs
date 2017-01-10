using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace SincronizadorDeCargas
{
	public partial class Frm_Sincronizador : Form
	{
		bool ExecutarAtualizacao { get; set; }

		public Frm_Sincronizador()
		{
			InitializeComponent();
		}

		private void Frm_Sincronizador_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void Frm_Sincronizador_Load(object sender, EventArgs e)
		{
			VerificarStatusDoDiretorio();
		}

		private void Btm_Sincronizar_Click(object sender, EventArgs e)
		{
			VerificarStatusDoDiretorio();//Se o diretorios existir ele coloca executar atualização como true.

			if (ExecutarAtualizacao)
			{
				Lbl_Informacao.Visible = true;
				Lbl_Instalação.Visible = false;

                Thread.Sleep(500);

				Atualizar();
			}
			else
			{
				Lbl_Informacao.Visible = false;
				Lbl_Instalação.Visible = true;

                Lbl_Instalação.Text = "Efetuando download e a instalação";

				MessageBox.Show("O save game da NextTeamBr não foi encontrado, " +
								"será feito o download e a instalação, isso pode demorar um pouco."
								, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

				SaveGame.EfetuarInstalacaoDoSave();

				Thread.Sleep(2000);

				Lbl_Instalação.ForeColor = Color.Green;
				Lbl_Instalação.Text = "Instalação finalizada com sucesso!";

			}
		}

		private void Atualizar()
		{
			try
			{
				Lbl_Informacao.ForeColor = Color.DarkRed;
				Lbl_Informacao.Text = "Sincronizando seu frete, isso pode levar um tempo.";

				Thread.Sleep(3000);

				ControleArquivoGameSII.SalvarArquivoAtualizado();

				Lbl_Informacao.ForeColor = Color.Green;
				Lbl_Informacao.Text = "Sua frete foi sincronizado " + DateTime.Now;
			}
			catch (Exception ex)
			{
				Lbl_Informacao.Text = String.Empty;

				MessageBox.Show(@"Ocorreu um erro ao tentar sincronizar seu frete, verifique sua conexão." +
								 "\nSe o problema persistir entre em contato com a administração\n Erro:" + ex.Message,
								 "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void VerificarStatusDoDiretorio()
		{
			ExecutarAtualizacao = SaveGame.VerificarExistenciaSaveNxT();
		}
	}
}
