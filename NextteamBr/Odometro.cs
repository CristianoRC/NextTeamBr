using System;
namespace NextteamBr
{
	public class Odometro
	{
		public Double ValorInicial
		{
			get;
			set;
		}

		public Double ValorAtual
		{
			get;
			set;
		}

		public Double ObterKilometroRodados()
		{
			return ValorAtual - ValorInicial;
		}
	}
}
