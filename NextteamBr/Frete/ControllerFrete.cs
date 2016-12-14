using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;

namespace NextteamBr
{
    class ControllerFrete
    {
        public static bool SalvarFrete(Frete InformacoesFrete)
        {

            bool saida;
            string StrJSON;
            try
            {

                InformacoesFrete.Dano = double.Parse(InformacoesFrete.Dano.ToString("0.00"));
                InformacoesFrete.KmRodado = double.Parse(InformacoesFrete.KmRodado.ToString("0.00"));
                InformacoesFrete.Pontuacao = double.Parse(InformacoesFrete.Pontuacao.ToString("0.00"));

                StrJSON = JsonConvert.SerializeObject(InformacoesFrete);

                string url = "http://nextteambr.com.br/nxt.php";
                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(url);
                ASCIIEncoding encoding = new ASCIIEncoding();
                string postData = StrJSON;
                byte[] data = encoding.GetBytes(postData);
                httpWReq.Method = "POST";
                httpWReq.ContentType = "application/x-www-form-urlencoded";
                // httpWReq.ContentType = "application / json; charset = utf-8";
                httpWReq.ContentLength = data.Length;
                using (Stream stream = httpWReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();
                string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                saida = true;
            }
            catch (System.Exception)
            {
                saida = false;
            }
            return saida;
        }
    }
}