using Newtonsoft.Json;

namespace NextteamBr
{
    class ControllerFrete
    {
        public static string SalvarFrete(Frete InformacoesFrete)
        {
            string Saida;

            InformacoesFrete.Dano = double.Parse(InformacoesFrete.Dano.ToString("0.00"));
            InformacoesFrete.KmRodado = double.Parse(InformacoesFrete.KmRodado.ToString("0.00"));
            InformacoesFrete.Pontuacao = double.Parse(InformacoesFrete.Pontuacao.ToString("0.00"));

            Saida = JsonConvert.SerializeObject(InformacoesFrete);

            System.IO.StreamWriter sw;

            sw = new System.IO.StreamWriter("Informacoes.JSON");

            sw.WriteLine(Saida);

            sw.Close();

            return Saida;
        }
    }
}