using Newtonsoft.Json;

namespace NextteamBr
{
	class ControllerFrete
	{
		public static string SalvarFrete(Frete InformacoesFrete)
		{
			string Saida;

			Saida = JsonConvert.SerializeObject(InformacoesFrete);

			System.IO.StreamWriter sw;
			sw = new System.IO.StreamWriter("Informacoes.JSON");

			sw.WriteLine(Saida);

			return Saida;
		}
	}
}