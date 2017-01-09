using System;

namespace SincronizadorDeCargas
{
    public static class Ferramentas
    {
        public static string ObterCaminhoDoArquivo()
        {
            String Caminho;
            String MeusDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Caminho = String.Format(@"{0}\Euro Truck Simulator 2\profiles\436C6F736368265\save\autosave\game.sii", MeusDocumentos);

            return Caminho;
        }
    }
}
