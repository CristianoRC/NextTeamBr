using System.Diagnostics;
using System.Threading;
using Spartacus.Database;
using System.Linq;

namespace NextteamBr
{
	public static class Ferramentas
	{
		/// <summary>
		/// Verificando se é ATS ou ETS2
		/// </summary>
		/// <returns></returns>
		public static string VerificarGame()
		{
			string saida = "";

			Process[] processes = Process.GetProcesses();
			for (int i = 0; i < processes.Length; i++)
			{
				Process process = processes[i];
				if (process.MainWindowTitle.Contains("Euro Truck Simulator 2"))
				{
					saida = "Euro Truck Simulator 2";
				}
				if (process.MainWindowTitle.Contains("American Truck Simulator"))
				{
					saida = "American Truck Simulator";
				}
			}

			return saida;
		}

		public static double CalcularPontuacao(double KmRodado, double Dano, uint Infracoes)
		{
			//A cada 20 infrações perde 1 KM.
			//A cada 30 KM 1 ponto
			// a cada 0.05 de dano perde 1 KM.

			double saida;
			double KmPerdido;

			KmPerdido = (Dano / 0.05);
			KmPerdido += (Infracoes / 20);

			double KmFinal = KmRodado - KmPerdido;
			saida = (KmFinal / 30);

			return saida;
		}
	}
}
