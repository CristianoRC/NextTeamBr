using System.Diagnostics;

namespace NextteamBr
{
    public static class Ferramentas
    {

        public static string getMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }


        public static bool VerificarTeamSpeak()
        {
            bool saida = false;

            Process[] processes = Process.GetProcesses();
            for (int i = 0; i < processes.Length; i++)
            {
                Process process = processes[i];
                if (process.MainWindowTitle.Contains("TeamSpeak 3"))
                {
                    saida = true;
                }
            }

            return saida;
        }

        public static double CalcularPontuacao(double KmRodado, double Dano)
        {
            //A cada 20 infrações perde 1 KM.
            //A cada 1 KM 0.01 ponto
            // a cada 0.02 de dano perde 1 KM.

            double saida;
            double KmPerdido;

            KmPerdido = (Dano / 0.02);

            double KmFinal = KmRodado - KmPerdido;
            saida = (KmFinal * 0.01);

            return saida;
        }
    }
}
