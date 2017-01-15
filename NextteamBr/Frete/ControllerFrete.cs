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
                StrJSON = JsonConvert.SerializeObject(InformacoesFrete);
                //string url = "http://painel.nextteambr.com.br/registroapp.php";

                string url = "http://192.168.0.250/next/painel/";

                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(url);
                UTF8Encoding encoding = new UTF8Encoding();

                string postData = StrJSON;
                byte[] data = encoding.GetBytes(postData);
                httpWReq.Method = "POST";
                //httpWReq.ContentType = "application/x-www-form-urlencoded";
                httpWReq.ContentType = "application / json; charset = utf-8";
                httpWReq.ContentLength = data.Length;
                using (Stream stream = httpWReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();
                saida = true;
            }
            catch
            {
                saida = false;
            }
            return saida;
        }
    }
}
