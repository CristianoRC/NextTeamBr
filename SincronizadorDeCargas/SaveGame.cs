using Ionic.Zip;
using System;
using System.IO;
using System.Net;

namespace SincronizadorDeCargas
{
	public static class SaveGame
	{
		public static string ObterCaminhoDoArquivoGameSII()
		{
			String Caminho;
			String MeusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			Caminho = String.Format(@"{0}\Euro Truck Simulator 2\profiles\4E6578745465616D4252\save\autosave\game.sii", MeusDocumentos);

			return Caminho;
		}

		public static string ObterCaminhoDoDiretorioSaveNext()
		{
			String Caminho;
			String MeusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			Caminho = String.Format(@"{0}\Euro Truck Simulator 2\profiles\4E6578745465616D4252\save\autosave", MeusDocumentos);

			return Caminho;
		}

		public static string ObterCaminhoDoDiretorioSavesEts2()
		{
			String Caminho;
			String MeusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			Caminho = String.Format(@"{0}\Euro Truck Simulator 2\profiles\", MeusDocumentos);

			return Caminho;
		}

		public static bool VerificarExistenciaSaveNxT()
		{
			if (Directory.Exists(ObterCaminhoDoDiretorioSaveNext()))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		public static void EfetuarInstalacaoDoSave()
		{
			String ArquivoTemporario = String.Format(@"{0}\4E6578745465616D4252.zip", Path.GetTempPath());

			EfetuarDownloadDoSave();

			using (ZipFile zip = ZipFile.Read(ArquivoTemporario))
			{
				foreach (ZipEntry e in zip)
				{
					e.Extract(ObterCaminhoDoDiretorioSavesEts2());
				}
			}

		}

		private static void EfetuarDownloadDoSave()
		{
			string fileName = String.Format(@"{0}\4E6578745465616D4252.zip", Path.GetTempPath());

			WebClient myWebClient = new WebClient();

			myWebClient.DownloadFile(@"https://github.com/CristianoRC/SiteNextTeam/releases/download/1/4E6578745465616D4252.zip", fileName);
		}

		internal static bool CopiarConfiguracoesSave(string CaminhoDaPastaPadrao)
		{
			String CaminhoArquivoCfg = String.Format(@"{0}\config.cfg", CaminhoDaPastaPadrao);
			String CaminhoArquivoControls = String.Format(@"{0}\controls.sii", CaminhoDaPastaPadrao);

			String DestinoArquivoCfg = String.Format(@"{0}\config.cfg", SaveGame.ObterCaminhoDoDiretorioSaveNext());
			String DestinoArquivoControls = String.Format(@"{0}\controls.sii", SaveGame.ObterCaminhoDoDiretorioSaveNext());


			File.Copy(CaminhoArquivoCfg, DestinoArquivoCfg, true);
			File.Copy(CaminhoArquivoControls, DestinoArquivoControls, true);

			return true;
		}
	}
}
