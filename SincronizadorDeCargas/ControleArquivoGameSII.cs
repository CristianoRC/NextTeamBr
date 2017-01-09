using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace SincronizadorDeCargas
{
    internal static class ControleArquivoGameSII
    {
        private static String ObterArquivoAtualizado()
        {
            return "Olá Mundo";
        }

        internal static void SalvarArquivoAtualizado()
        {
            using (StreamWriter sw = new StreamWriter(Ferramentas.ObterCaminhoDoArquivo()))
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
