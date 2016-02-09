using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

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
        /// Verificando se a distancia para chegar até o ponto de entrega é menos a 3KM (3000 m)
        /// </summary>
        /// <returns></returns>
        public static void VerificarDistancia(int DistanciaEstimada)
        {
            if (DistanciaEstimada <= 3000)
            {
                SoundPlayer EstaProximo = new SoundPlayer(@"Media\EstaProximo.wav");
                EstaProximo.Play();
            }
        }
    }
}
