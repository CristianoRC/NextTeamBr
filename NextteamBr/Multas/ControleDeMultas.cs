using System.Collections.Generic;

namespace NextteamBr
{
    public class ControleDeMultas
    {
        
        private List<Multa> ListaDeMultas = new List<Multa>();

        public void AdicionarNovaMulta(Multa p_Multa)
        {
            ListaDeMultas.Add(p_Multa);
        }

        public void LimparListaDeMultas()
        {
            ListaDeMultas.Clear();
        }

        public List<Multa> ObterListaDeMultas()
        {
            return ListaDeMultas;
        }
    }
}
