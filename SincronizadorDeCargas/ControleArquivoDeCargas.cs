using System;
using System.Diagnostics;
using System.IO;
using System.Net;

namespace SincronizadorDeCargas
{
    internal static class ControleArquivoDeCargas
    {
        private static string ObterArquivoAtualizado()
        {
            using (var wb = new WebClient())
            {
                try
                {
                    return wb.DownloadString(@"http://cristianoprogramador.com/LogBook/game.sii");
                }
                catch (Exception ex)
                {
                    throw new Exception("Ocorreu um erro ao tentar fazer a requisição: " + ex.Message);
                }

            }
        }

        private static void SalvarArquivoAtualizado()
        {
            using (StreamWriter sw = new StreamWriter(SaveGame.ObterCaminhoDoArquivoGameSII()))
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

        internal static void Sincronizar()
        {

        }
    }
}
