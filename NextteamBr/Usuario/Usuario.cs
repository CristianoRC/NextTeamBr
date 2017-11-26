using System;
using System.IO;

namespace NextteamBr
{
    public class Usuario
    {
        public int ID { get; private set; }
        public string Nome { get; set; }
        public string Login { get; private set; }
        public string Senha { get; private set; }
        public bool Admin { get; private set; }

        public Usuario(string login, string senha, string nome)
        {
            Nome = nome;
            Login = login.Trim();
            Senha = Ferramentas.getMD5Hash(senha);
        }

        public Usuario(string login, String senha)
        {
            Login = login.Trim();
            Senha = Ferramentas.getMD5Hash(senha);
        }

        public string Logar()
        {
            return UsuarioRepository.Logar(this);
        }

        public void Cadastrar()
        {
            UsuarioRepository.Cadastrar(this);
        }



        public static void SalvarUltimoLogin(String Login)
        {
            StreamWriter sw = null;
            try
            {
                using (sw = new StreamWriter("Login.dat"))
                {
                    sw.WriteLine(Login);
                }
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }
        }

        public static string ObterUltimoLogin()
        {
            var Saida = String.Empty;

            if (File.Exists("Login.dat"))
            {
                StreamReader sr = null;

                try
                {
                    using (sr = new StreamReader("Login.dat"))
                    {
                        Saida = sr.ReadLine();
                    }
                }
                finally
                {
                    if (sr != null)
                    {
                        sr.Close();
                    }
                }
            }

            return Saida;
        }
    }
}
