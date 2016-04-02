using System;

namespace NextteamBr
{
    class Frete
    {
        public uint ID { get; set; }
        public double KmRodado { get; set; }
        public double DistanciaInicial { get; set; }
        public double DistanciaFinal { get; set; }
        public double Dano { get; set; }
        public DateTime DataFinalFrete { get; set; }
    }
}
