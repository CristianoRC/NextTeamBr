using Spartacus.Utils;
using System.IO;

namespace NextteamBr
{
    class ControllerFrete
    {
        /// <summary>
        /// Salvando informações do frete em um arquivo criptografado
        /// </summary>
        /// <param name="InformacoesFrete"></param>
        /// <param name="NomeArquivo"></param>
        /// <returns></returns>
        public static string SalvarFrete(Frete InformacoesFrete)
        {
            Cryptor cr;
            string Saida = "";

            StreamWriter sw = null;
            cr = new Cryptor("p@$$w0rdNxtBrC#");

            try
            {
                sw = new StreamWriter($"Fretes/{InformacoesFrete.DataFinalFrete.ToFileTime()}.Nxt");

                sw.WriteLine(cr.Encrypt(InformacoesFrete.KmRodado.ToString()));
                sw.WriteLine(cr.Encrypt(InformacoesFrete.Dano.ToString()));
                sw.WriteLine(cr.Encrypt(InformacoesFrete.DataFinalFrete.ToString("0.00")));

                Saida = "Arquivo de configuração gerado com sucesso!";
            }
            catch (System.Exception exc)
            {
                Saida = $"Ocorreu um erro - {exc.Message} ";
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }

            return Saida;
        }
    }
}