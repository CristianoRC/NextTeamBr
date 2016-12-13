using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NextteamBr
{
    public class Usuario
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public Usuario(String p_Login, String p_Senha)
        {
            Login = p_Login;
            Senha = p_Senha;
        }
    }
}
