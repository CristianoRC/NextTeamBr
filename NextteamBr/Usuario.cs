using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace NextteamBr
{
    internal class Usuario
    {
        private string login { get; set; }
        private string senha { get; set; }

        public Usuario(String p_Login, String p_Senha)
        {
            login = p_Login;
            senha = p_Senha;
        }

        public string Logar()
        {

            bool saida;
            string StrJSON;
            try
            {
                Usuario uso = new Usuario(this.login, this.senha);

                StrJSON = JsonConvert.SerializeObject(uso);

                string url = @"http://painel.nextteambr.com.br/loginapp.php";
                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(StrJSON);
                ASCIIEncoding encoding = new ASCIIEncoding();
                string postData = StrJSON;
                byte[] data = encoding.GetBytes(postData); httpWReq.Method = "POST";
                httpWReq.ContentType = "application/x-www-form-urlencoded";
                httpWReq.ContentLength = data.Length;
                using (Stream stream = httpWReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();
                string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return responseString;

                /*
                if ()
                {
                    saida = true;
                }
                else
                {
                    saida = false;
                }

                */
            }
            catch (System.Exception e)
            {
                return "Erro:" + e.Message;
            }
        }
    }
}
