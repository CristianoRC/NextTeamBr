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
        public static bool SalvarFrete(Frete InformacoesFrete, RootObject informacoesGame)
        {
            //Cryptor cr;
            bool Saida = false;

            StreamWriter sw = null;
            //    cr = new Cryptor("p@$$w0rdNxtBrC#");

            try
            {
                sw = new StreamWriter($"Fretes/{InformacoesFrete.DataFinalFrete.ToFileTime()}.Nxt");
                /*

                    Salvando já criptografado

                sw.WriteLine(cr.Encrypt(InformacoesFrete.KmRodado.ToString("0.00")));
                sw.WriteLine(cr.Encrypt(InformacoesFrete.Dano.ToString("0.00")));
                sw.WriteLine(cr.Encrypt(informacoesGame.trailer.name));
                sw.WriteLine(cr.Encrypt(informacoesGame.trailer.mass.ToString()));
                sw.WriteLine(cr.Encrypt(informacoesGame.job.sourceCity));
                sw.WriteLine(cr.Encrypt(informacoesGame.job.sourceCompany));
                sw.WriteLine(cr.Encrypt(informacoesGame.job.destinationCity));
                sw.WriteLine(cr.Encrypt(informacoesGame.job.destinationCompany));
                sw.WriteLine(cr.Encrypt(InformacoesFrete.DataFinalFrete.ToString()));
                */

                sw.WriteLine(InformacoesFrete.KmRodado.ToString("0.00"));
                sw.WriteLine(InformacoesFrete.Dano.ToString("0.00"));
                sw.WriteLine(informacoesGame.trailer.name);
                sw.WriteLine(informacoesGame.trailer.mass.ToString());
                sw.WriteLine(informacoesGame.job.sourceCity);
                sw.WriteLine(informacoesGame.job.sourceCompany);
                sw.WriteLine(informacoesGame.job.destinationCity);
                sw.WriteLine(informacoesGame.job.destinationCompany);
                sw.WriteLine(InformacoesFrete.DataFinalFrete.ToString());

                Saida = true;
            }
            catch (System.Exception)
            {
                Saida = false;
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