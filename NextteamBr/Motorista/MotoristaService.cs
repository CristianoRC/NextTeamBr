using System;
using Dapper;
using System.Collections.Generic;

namespace NextteamBr
{
    public static class MotoristaService
    {
        public static string Logar(Motorista usuario)
        {
            var sql = $"SELECT count(ID) FROM Motorista WHERE Login = @login and senha = @senha and Ativo = 1";
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

        public static void Cadastrar(Motorista usuario)
        {
            var sql = $@"INSERT INTO Motorista
                    (Nome, Login, Senha, Ativo, Admin) VALUES 
                    (@nome,@login,@senha,false,false)";
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

        public static Motorista ObterInformacoes(string login)
        {
            var sql = $"SELECT * FROM Motorista WHERE Login = @login";
            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.QueryFirst<Motorista>(sql, new { login = login });
                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static Motorista ObterInformacoes(int id)
        {
            var sql = $"SELECT * FROM Motorista WHERE ID = @id";
            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.QueryFirst<Motorista>(sql, new { id = id });
                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static IEnumerable<Motorista> Listar()
        {
            var sql = $"SELECT ID,Nome,Login,Ativo,Admin FROM Motorista";
            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.Query<Motorista>(sql);
                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static IEnumerable<Motorista> ListarAtivos()
        {
            var sql = $"SELECT ID,Nome,Login,Ativo,Admin FROM Motorista WHERE Ativo = 1";
            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.Query<Motorista>(sql);
                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static IEnumerable<Motorista> ListarInativos()
        {
            var sql = $"SELECT ID,Nome,Login FROM Motorista WHERE Ativo = 0";
            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.Query<Motorista>(sql);
                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void SetarEmpresa(int IDMotorista, int IDEmpresa)
        {
            var sql = $@"update Motorista set IDEmpresa=@Empresa where ID=@ID";
            try
            {
                BancoDeDados.abrirConexao();
                BancoDeDados.conexao.Execute(sql, new { ID = IDMotorista, Empresa = IDEmpresa });
                BancoDeDados.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception("Erro:" + e.Message);
            }
        }

        public static void Ativar(int id)
        {
            var sql = "update Motorista set Ativo=true where ID = @IDMotorista ";
            try
            {
                BancoDeDados.abrirConexao();
                BancoDeDados.conexao.Execute(sql, new { IDMotorista = id });

                BancoDeDados.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro! Tire uma print e mande para os ADM's. {ex.Message}");
            }
        }

        public static void Desativar(int id)
        {
            var sql = "update Motorista set Ativo=false where ID = @IDMotorista ";
            try
            {
                BancoDeDados.abrirConexao();
                BancoDeDados.conexao.Execute(sql, new { IDMotorista = id });

                BancoDeDados.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro! Tire uma print e mande para os ADM's. {ex.Message}");
            }
        }

        public static void RedefinirSenha(int id, string senha)
        {
            var sql = "update Motorista set senha=@senha where ID = @IDMotorista ";
            try
            {
                BancoDeDados.abrirConexao();
                BancoDeDados.conexao.Execute(sql, new { IDMotorista = id, senha = Ferramentas.getMD5Hash(senha) });

                BancoDeDados.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro! Tire uma print e mande para os ADM's. {ex.Message}");
            }
        }

        public static void ResetarSenha(int id)
        {
            var sql = "update Motorista set senha=@senha where ID = @IDMotorista ";
            try
            {
                BancoDeDados.abrirConexao();
                BancoDeDados.conexao.Execute(sql, new { IDMotorista = id, senha = Ferramentas.getMD5Hash("123456") });

                BancoDeDados.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro! Tire uma print e mande para os ADM's. {ex.Message}");
            }
        }

        public static void AletrarNome(int id, string Nome)
        {
            var sql = "update Motorista set Nome=@Nome where ID = @IDMotorista ";
            try
            {
                BancoDeDados.abrirConexao();
                BancoDeDados.conexao.Execute(sql, new { IDMotorista = id, Nome = Nome });

                BancoDeDados.fecharConexao();
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro! Tire uma print e mande para os ADM's. {ex.Message}");
            }
        }

        private static void InsetirNoRanking(int IDusuario)
        {
            var sqlMes = $@"INSERT INTO Ranking(IDMotorista, Pontos) VALUES (@IDMotorista,0)";
            var sqlAno = $@"INSERT INTO RankingAno(IDMotorista, Pontos) VALUES (@IDMotorista,0)";

            try
            {
                BancoDeDados.abrirConexao();
                BancoDeDados.conexao.Execute(sqlAno, new { IDMotorista = IDusuario });
                BancoDeDados.conexao.Execute(sqlMes, new { IDMotorista = IDusuario });
                BancoDeDados.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception("Erro:" + e.Message);
            }
        }
    }
}
