using System;
using System.IO;
using Dapper;

namespace NextteamBr
{
    public static class UsuarioRepository
    {
        public static string Logar(Usuario usuario)
        {
            var sql = $"SELECT count(ID) FROM Motorista WHERE Login = @login and senha = @senha";
            try
            {
                BancoDeDados.abrirConexao();
                var Logado = BancoDeDados.conexao.QueryFirst<int>(sql, new { login = usuario.Login, senha = usuario.Senha });
                BancoDeDados.fecharConexao();

                if (Logado > 0)
                    return "1";
                else
                    return "-1";
            }
            catch (Exception e)
            {
                return "Erro:" + e.Message;
            }
        }

        public static void Cadastrar(Usuario usuario)
        {
            var sql = $@"INSERT INTO Motorista
                    (Nome, Login, Senha, Ativo, Admin) VALUES 
                    (@nome,@login,@senha,true,false)";
            try
            {
                BancoDeDados.abrirConexao();
                BancoDeDados.conexao.Execute(sql, new
                {
                    nome = usuario.Nome,
                    login = usuario.Login,
                    senha = usuario.Senha
                });

                BancoDeDados.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception("Erro:" + e.Message);
            }
        }
    }
}
