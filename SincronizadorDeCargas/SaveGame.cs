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
            Caminho = String.Format(@"{0}\Euro Truck Simulator 2\profiles\436C6F736368265\save\autosave\game.sii", MeusDocumentos);

            return Caminho;
        }

        public static string ObterCaminhoDoDiretorioSaveNext()
        {
            String Caminho;
            String MeusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Caminho = String.Format(@"{0}\Euro Truck Simulator 2\profiles\436C6F736368265\save\autosave", MeusDocumentos);

            return Caminho;
        }

        public static string ObterCaminhoDoDiretorioSaves()
        {
            String Caminho;
            String MeusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Caminho = String.Format(@"{0}\Euro Truck Simulator 2\profiles\", MeusDocumentos);

            return Caminho;
        }

        public static bool VerificarDiretorioDoSave()
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
            String ArquivoTemporario = String.Format(@"{0}\SaveNextTeamBr.rar", Path.GetTempPath());

            EfetuarDownloadDoSave();

            using (ZipFile zip = ZipFile.Read(ArquivoTemporario))
            {
                foreach (ZipEntry e in zip)
                {
                    e.Extract(ObterCaminhoDoDiretorioSaves());
                }
            }

        }

        private static void EfetuarDownloadDoSave()
        {
            string fileName = String.Format(@"{0}\SaveNextTeamBr.rar", Path.GetTempPath());

            WebClient myWebClient = new WebClient();

            myWebClient.DownloadFile(@"https://git.io/vMlUm", fileName);
        }
    }
}
