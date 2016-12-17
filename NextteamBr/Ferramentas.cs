using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace NextteamBr
{
    public static class Ferramentas
    {

        public static string getMD5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }


        public static bool VerificarTeamSpeak()
        {
            bool saida = false;

            Process[] processes = Process.GetProcesses();

            foreach (var item in processes)
            {
                if (item.MainWindowTitle.Contains("TeamSpeak 3"))
                {
                    return true;
                }
            }
            return saida;
        }

        public static double CalcularPontuacao(double KmRodado, double Dano)
        {
            //A cada 20 infrações perde 1 KM.
            //A cada 1 KM 0.005 ponto
            // a cada 0.02 de dano perde 1 KM.
            // 0,5 pts/  A cada 100 KM rodado.

            double saida;
            double KmPerdido;

            KmPerdido = (Dano / 0.001);

            double KmFinal = KmRodado - KmPerdido;
            //saida = (KmFinal * 0.01);
            saida = (KmFinal * 0.005);
            return saida;
        }
    }
}
