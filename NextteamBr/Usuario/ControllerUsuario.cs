using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace NextteamBr
{
    public static class ControllerUsuario
    {
        public static string Logar(Usuario uso)
        {
            string StrJSON;
            try
            {
                StrJSON = JsonConvert.SerializeObject(uso);

                string url = "http://painel.nextteambr.com.br/loginapp.php";
                HttpWebRequest httpWReq = (HttpWebRequest)WebRequest.Create(url);
                ASCIIEncoding encoding = new ASCIIEncoding();
                string postData = StrJSON;
                byte[] data = encoding.GetBytes(postData);
                httpWReq.Method = "POST";
                httpWReq.ContentType = "application / json; charset = utf-8";
                httpWReq.ContentLength = data.Length;
                httpWReq.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
                using (Stream stream = httpWReq.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                HttpWebResponse response = (HttpWebResponse)httpWReq.GetResponse();
                string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                return responseString;
            }
            catch (System.Exception e)
            {
                return "Erro:" + e.Message;
            }
        }

        public static void SalvarUltimoLogin(String Login)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter("Login.dat");
                sw.WriteLine(Login);
            }
            catch (Exception)
            {

            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        public static string ObterUltimoLogin()
        {
            String Saida = String.Empty;

            if (File.Exists("Login.dat"))
            {
                StreamReader sr = null;

                try
                {
                    sr = new StreamReader("Login.dat");

                    Saida = sr.ReadLine();
                }
                catch (Exception)
                {

                }
                finally
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }
            }

            return Saida;
        }
    }
}
