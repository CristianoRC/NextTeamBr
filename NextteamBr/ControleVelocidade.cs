using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NextteamBr
{
    static public class ControleVelocidade
    {
        static public void SalvarVelocidade(string Velocidade)
        {
            StreamWriter sr = null;

            try
            {
                sr = new StreamWriter("Velocidade.cfg");

                sr.WriteLine(Velocidade);
            }
            finally
            {
                if (sr != null)
                {
                    sr.Close();
                }
            }
        }

        static private bool VerificarArquivo()
        {
            if (File.Exists("Velocidade.cfg"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static public int VelocidadeMaxima()
        {
            int saida = 0;

            StreamReader sr = null;

            try
            {
                sr = new StreamReader("Velocidade.cfg");

                saida = Convert.ToInt32(sr.ReadLine());
            }
            finally
            {
                if(sr != null)
                {
                    sr.Close();
                }
            }

            return saida;
        }
    }
}
