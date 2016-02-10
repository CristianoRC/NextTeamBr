using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace NextteamBr
{
    public class ControllerTelemetry
    {

        //TODO:Converter métodos para assíncronos.

        /// <summary>
        /// Classe usada para gerar arquivo de informações da viajem
        /// </summary>
        public static void GerarInformacoes()
        {

        }

        /// <summary>
        /// Pegando as informações da API e transformando no "código JSON"
        /// </summary>
        /// <returns></returns>
        public static string GetJSON()
        {


            WebRequest req = WebRequest.Create("http://localhost:25555/api/ets2/telemetry");
            WebResponse res = req.GetResponse();
            Stream dataStream = res.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);

            string Resposta = reader.ReadToEnd();
            reader.Close();
            res.Close();

            return Resposta;
        }

        /// <summary>
        /// Deserializando o Json
        /// </summary>
        /// <returns></returns>
        public static RootObject ConvertJSON()
        {
            RootObject telemetry = JsonConvert.DeserializeObject<RootObject>(GetJSON());

            //RootObject = objeto raiz de todo o mapeamento do JSON

            return telemetry;
        }
    }
}
