using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Net;

namespace SincronizadorDeCargas
{
    internal static class ControleArquivoGameSII
    {
        private static String ObterArquivoAtualizado()
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

        internal static void SalvarArquivoAtualizado()
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
    }
}
