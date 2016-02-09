using System.Diagnostics;
using System.Media;

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

        /// <summary>
        ///Finalizando o servidor 
        /// </summary>
        public static void ZerarInformacoes()
        {
            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                Process process = processes[i];

                if (process.ProcessName == "Ets2Telemetry")
                {
                    process.Kill();
                }
            }
        }

        //TODO: Para verificar o inicio da viagem verificar se esta com carga e se a distancia e != de 0 KM
    }
}
