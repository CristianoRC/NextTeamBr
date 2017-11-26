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

                var IDusuarioTemp = BancoDeDados.conexao.QueryFirst<int>("select ID from Motorista where Login = @login", new { login = usuario.Login });

                InsetirNoRanking(IDusuarioTemp);

                BancoDeDados.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception("Erro:" + e.Message);
            }
        }

        public static Usuario ObterInformacoes(string login)
        {
            var sql = $"SELECT * FROM Motorista WHERE Login = @login";
            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.QueryFirst<Usuario>(sql, new { login = login });
                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static Usuario ObterInformacoes(int id)
        {
            var sql = $"SELECT * FROM Motorista WHERE ID = @id";
            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.QueryFirst<Usuario>(sql, new { id = id });
                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        private static void InsetirNoRanking(int IDusuario)
        {
            var sql = $@"INSERT INTO Ranking(IDMotorista, Pontos) VALUES (@IDMotorista,0)";
            try
            {
                BancoDeDados.abrirConexao();
                BancoDeDados.conexao.Execute(sql, new { IDMotorista = IDusuario });

                BancoDeDados.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception("Erro:" + e.Message);
            }
        }

    }
}
