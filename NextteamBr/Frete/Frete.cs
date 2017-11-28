using System;

namespace NextteamBr
{
    class Frete
    {
        public int Id { get; private set; }
        public int IdMotorista { get; set; }
        public string CidadeInicial { get; set; }
        public string CidadeDestino { get; set; }
        public double KmRodado { get; set; }
        public string Carga { get; set; }
        public double Dano { get; set; }
        public DateTime DataFinalFrete { get; private set; }
        public double Pontuacao { get; set; }

        public bool Cadastrar()
        {
            DataFinalFrete = DateTime.Now;

            return FreteService.SalvarFrete(this);
        }

        public double CalcularPontuacao(double Dano, int NumeroDeMultas)
        {
            double saida;
            double KmPerdido = 0;

            KmPerdido += NumeroDeMultas;
            KmPerdido += Dano;

            var KmFinal = KmRodado - KmPerdido;
            saida = (KmFinal * 0.005);

            if (NumeroDeMultas == 0 && Dano < 3)
            {
                KmFinal += (KmFinal * 5) / 100;
            }

            return saida;
        }
    }
}
