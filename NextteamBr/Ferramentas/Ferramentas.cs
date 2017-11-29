using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace NextteamBr
{
    public static class Ferramentas
    {

        public static string getMD5Hash(string input)
        {
            var md5Hash = MD5.Create();
            // Converter a String para array de bytes, que é como a biblioteca trabalha.
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Cria-se um StringBuilder para recompôr a string.
            var sBuilder = new StringBuilder();

            // Loop para formatar cada byte como uma String em hexadecimal
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        public static bool VerificarETS2MP()
        {
            var saida = false;

            var processes = Process.GetProcesses();

            foreach (var item in processes)
            {
                if (item.MainWindowTitle.Contains("Euro Truck Simulator 2 Multiplayer"))
                {
                    return true;
                }
            }
            return saida;
        }

        public static bool VerificarTeamSpeak()
        {
            var processes = Process.GetProcesses();

            foreach (var item in processes)
            {
                if (item.ProcessName.Contains("ts3client"))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
