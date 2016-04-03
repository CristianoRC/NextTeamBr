using System.Diagnostics;
using System.Threading;
using Spartacus.Database;

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
        public static void DesligarServidor()
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

        public static void LigarServidor()
        {
            Process processo = new Process();

            processo.StartInfo.FileName = @"ets2-telemetry-server-3.2.5\server\Ets2Telemetry.exe";
            processo.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            processo.Start();

            Thread.Sleep(2000);
        }
    }
}
