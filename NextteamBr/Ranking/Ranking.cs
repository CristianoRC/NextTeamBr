using System.Drawing;

namespace NextteamBr
{
    public class Ranking
    {
        public string Motorista { get; set; }
        public uint KM { get; set; }
        public double Pontos { get; set; }

        public static string ObterCategoria(double KM)
        {
            if (KM <= 20000)
            {
                return "A";
            }

            if (KM <= 50000)
            {
                return "T";
            }

            if (KM <= 80000)
            {
                return "1";
            }

            if (KM <= 150000)
            {
                return "2";
            }
            else
            {
                return "3";
            }
        }

        public static Color ObterCorCategoria(double KM)
        {
            if (KM <= 20000)
            {
                return Color.LightGreen;
            }

            if (KM <= 50000)
            {
                return Color.DeepSkyBlue ;
            }

            if (KM <= 80000)
            {
                return Color.SaddleBrown;
            }

            if (KM <= 150000)
            {
                return Color.Gray;
            }
            else
            {
                return Color.Gold;
            }
        }

        public static string ObterExperiencia(double KM)
        {
            if (KM <= 30000)
            {
                return "Novato";
            }

            if (KM <= 60000)
            {
                return "Entusiasta";
            }

            if (KM <= 100000)
            {
                return "Qualificado";
            }

            if (KM <= 145000)
            {
                return "Profissional";
            }

            if (KM <= 180000)
            {
                return "Mestre";
            }

            if (KM <= 230000)
            {
                return "Instrutor";
            }

            if (KM <= 365000)
            {
                return "Elite";
            }

            if (KM <= 450000)
            {
                return "Rei da Dstrada";
            }

            return "Lenda Viva";
        }

        public static Color ObterCorExperiencia(double KM)
        {
            if (KM <= 30000)
            {
                return Color.LawnGreen;
            }

            if (KM <= 60000)
            {
                return Color.Red;
            }

            if (KM <= 100000)
            {
                return Color.Blue;
            }

            if (KM <= 145000)
            {
                return Color.Brown;
            }

            if (KM <= 180000)
            {
                return Color.DarkOrange;
            }

            if (KM <= 230000)
            {
                return Color.Yellow;
            }

            if (KM <= 365000)
            {
                return Color.Gray;
            }

            if (KM <= 450000)
            {
                return Color.LightPink;
            }

            return Color.DarkOliveGreen;
        }
    }
}
