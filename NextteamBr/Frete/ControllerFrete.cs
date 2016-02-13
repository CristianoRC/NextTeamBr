using Spartacus.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static string SalvarFrete(Frete InformacoesFrete, string NomeArquivo) //TODO:Mudar o nome do parâmetro
        {
            Cryptor cr;
            string Saida = "";

            StreamWriter sw = null;
            cr = new Cryptor("p@$$w0rdNxtBrC#");

            try
            {
                sw = new StreamWriter($"Fretes/{NomeArquivo}.Nxt");

                sw.WriteLine(cr.Encrypt(InformacoesFrete.KmRodado.ToString()));
                sw.WriteLine(cr.Encrypt(InformacoesFrete.Dano.ToString()));
                sw.WriteLine(cr.Encrypt(InformacoesFrete.DataFinalFrete.ToString()));

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
