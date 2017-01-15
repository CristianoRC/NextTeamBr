using System.Collections.Generic;

namespace NextteamBr
{
    public class Multas
    {
        public string DataDaMulta { get; set; }
        public string StringTipo { get; set; }

        private List<Multas> ListaDeMultas = new List<Multas>();

        public void AdicionarNovaMulta(Multas p_Multa)
        {
            ListaDeMultas.Add(p_Multa);
        }

        public void LimparListaDeMultas()
        {
            ListaDeMultas.Clear();
        }

        public List<Multas> ObterListaDeMultas()
        {
            return ListaDeMultas;
        }
    }
}
