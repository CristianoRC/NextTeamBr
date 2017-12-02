using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NextteamBr
{
    public static class Plugin
    {
        public static string DiretorioPadraoETS = @"C:\Program Files (x86)\Steam\steamapps\Common\Euro Truck Simulator 2";

        public static bool VerificarPastaETS()
        {
            var diretorio = new DirectoryInfo(DiretorioPadraoETS);

            if (diretorio.Exists)
            {
                return true;
            }

            return false;
        }

        
        public static void Copiar(string strSource, string strDestination)
        {
            if (!Directory.Exists(strDestination))
            {
                Directory.CreateDirectory(strDestination);
            }

            DirectoryInfo dirInfo = new DirectoryInfo(strSource);
            FileInfo[] files = dirInfo.GetFiles();
            foreach (FileInfo tempfile in files)
            {
                tempfile.CopyTo(Path.Combine(strDestination, tempfile.Name),true);
            }

            DirectoryInfo[] directories = dirInfo.GetDirectories();
            foreach (DirectoryInfo tempdir in directories)
            {
                Copiar(Path.Combine(strSource, tempdir.Name), Path.Combine(strDestination, tempdir.Name));
            }

        }
    }
}
