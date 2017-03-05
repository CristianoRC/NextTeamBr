using System;
using System.IO;
using System.Net;

namespace SincronizadorDeCargas
{
    internal static class ControleArquivoDeCargas
    {
        internal static string ObterCaminhoArquivoDeCargas()
        {
            return String.Format("{0}Cargas.json", Path.GetTempPath());
        }

        internal static void SalvarArquivoAtualizado()
        {
            String caminhoDoArquivo = String.Format(@"{0}Cargas.json", Path.GetTempPath());

            using (StreamWriter sw = new StreamWriter(caminhoDoArquivo))
            {
                try
                {
                    sw.Write(ObterArquivoAtualizado());
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private static string ObterArquivoAtualizado()
        {
            using (var wb = new WebClient())
            {
                try
                {
                    return wb.DownloadString(@"http://painel.nextteambr.com.br/syncApp.php");
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar fazer a requisição: " + ex.Message);
                }

            }
        }
    }
}
