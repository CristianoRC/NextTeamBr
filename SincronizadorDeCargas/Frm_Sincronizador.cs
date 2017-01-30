using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.IO;

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

		private void Btm_Sincronizar_Click(object sender, EventArgs e)
		{
			Thread.Sleep(500);

			Atualizar();
		}

		private void Atualizar()
		{
			try
			{
				Lbl_Informacao.ForeColor = Color.DarkRed;
				Lbl_Informacao.Text = "Sincronizando seu frete, isso pode levar um tempo.";

				Thread.Sleep(3000);

				ControleArquivoDeCargas.SalvarArquivoAtualizado();

				Lbl_Informacao.ForeColor = Color.Green;
				Lbl_Informacao.Text = "Sua frete foi sincronizado " + DateTime.Now;

				ExecutarJobSync();
			}
			catch (Exception ex)
			{
				Lbl_Informacao.Text = String.Empty;

				MessageBox.Show(@"Ocorreu um erro ao tentar sincronizar seu frete, verifique sua conexão." +
								 "\nSe o problema persistir entre em contato com a administração\n Erro:" + ex.Message,
								 "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void ExecutarJobSync()
		{
			string caminhoExecutavel = String.Format(@"#{0}JobSync\LoogBookSync.exe# -reset ",
			AppDomain.CurrentDomain.BaseDirectory.ToString());

			string argumentos = String.Format("#{0}# #{1}#",
				 ControleArquivoDeCargas.ObterCaminhoArquivoDeCargas(), Txt_Caminho.Text);

			string arquivoBat = String.Format("{0} {1}", caminhoExecutavel.Replace('#', '"'),
											  argumentos.Replace('#', '"'));

			string caminhoArquivoBat = String.Format(@"{0}\JobSync\Fretes.bat", AppDomain.CurrentDomain.BaseDirectory.ToString());

			File.WriteAllText(caminhoArquivoBat, arquivoBat);

			Process meuProcesso = new Process();
			meuProcesso.StartInfo.FileName = caminhoArquivoBat;
			meuProcesso.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			meuProcesso.Start();
		}

		private void Btm_Procurar_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.RestoreDirectory = true;
			ofd.Filter = "SII (*.sii*)|*.sii*";
			ofd.CheckPathExists = true;
			ofd.CheckFileExists = true;

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				Txt_Caminho.Text = ofd.FileName;
			}
		}
	}
}
