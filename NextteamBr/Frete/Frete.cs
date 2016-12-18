using System;

namespace NextteamBr
{
	class Frete
	{
		public int    IdMotorista { get; set; }
		public double KmRodado { get; set; }
		public double Dano { get; set; }
        public double Pontuacao { get; set; }
        public string Carga { get; set; }
		public string CidadeInicial { get; set; }
		public string CidadeDestino { get; set; }
		public string DataFinalFrete { get; set; }
	}
}
