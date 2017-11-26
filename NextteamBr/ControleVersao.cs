using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace NextteamBr
{
    public static class ControleVersao
    {
        public static String VerificarAtualizacoes()
        {
            String Saida;

            try
            {
                string versao, Link;

                var request =
                (HttpWebRequest)WebRequest.Create(@"http://painel.nextteambr.com.br/app/version.txt");

                var response = request.GetResponse();

                using (Stream stream = response.GetResponseStream())
                {
                    var reader = new StreamReader(stream, Encoding.UTF8);
                    var temp = (reader.ReadToEnd()).Split(';');

                    versao = temp[0];
                    Link = temp[1];
                }

                if (versao != Application.ProductVersion)
                {
                    Saida = Link;
                }
                else
                {
                    Saida = string.Empty;
                }
            }
            catch (Exception ex)
            {
                Saida = string.Format("Erro ao tentar fazer a requisição: {0}", ex.Message);
            }

            return Saida;
        }

        public static bool VerificarSoftwareAtivo()
        {
            try
            {
                var request =
                (HttpWebRequest)WebRequest.Create(@"http://painel.nextteambr.com.br/app/appStatus.txt");

                var response = request.GetResponse();

                using (Stream stream = response.GetResponseStream())
                {
                    var reader = new StreamReader(stream, Encoding.UTF8);
                    var Resultado = reader.ReadToEnd();

                    return Resultado == "ativo" ? true : false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
