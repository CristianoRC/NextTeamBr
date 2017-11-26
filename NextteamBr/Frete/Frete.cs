using System;
using System.Collections.Generic;

namespace NextteamBr
{
    class Frete
    {
        public int Id { get; private set; }
        public int IdMotorista { get; set; }
        public double KmRodado { get; set; }
        public double Dano { get; set; }
        public double Pontuacao { get; set; }
        public string Carga { get; set; }
        public string CidadeInicial { get; set; }
        public string CidadeDestino { get; set; }
        public DateTime DataFinalFrete { get; private set; }

        public bool Cadastrar()
        {
            DataFinalFrete = DateTime.Now;

            return FreteRepository.SalvarFrete(this);
        }
    }
}
