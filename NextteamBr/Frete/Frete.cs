using System;

namespace NextteamBr
{
    class Frete
    {
        public uint IDMotirista { get; set; }
        public double KmRodado { get; set; }
        public double Dano { get; set; }
		public string Carga { get; set; }
		public string CidadeInicial { get; set;}
        public string CidadeDestino { get; set; }
		public DateTime DataFinalFrete { get; set; }
    }
}
