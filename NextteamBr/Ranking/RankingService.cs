using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;

namespace NextteamBr
{
    class RankingService
    {
        public static void AtualizarPontuacao(int IDMotorista, double Pontuacao, double KM)
        {
<<<<<<< HEAD
            var antigaPontuacao = ObterPontuacao(IDMotorista);
            Pontuacao += antigaPontuacao;
            var sql = "UPDATE Ranking SET Pontos=@pontuacao SET KM=@km WHERE IDMotorista = @IDMotorista";
            BancoDeDados.abrirConexao();
            BancoDeDados.conexao.Execute(sql, new { IDMotorista = IDMotorista, pontuacao = Pontuacao, KM = KM });
=======
            var antigaPontuacaoMes = ObterPontuacaoMes(IDMotorista);
            var pontuacaoMes Pontuacao + antigaPontuacaoMes;
            
            var antigaPontuacaoAno = ObterPontuacaoAno(IDMotorista);
            var pontuacaoMes Pontuacao + antigaPontuacaoAno;
            
            var sqlMes = "UPDATE RankingMes SET Pontos=@pontuacao WHERE IDMotorista = @IDMotorista";
            var sqlAno = "UPDATE RankingAno SET Pontos=@pontuacao WHERE IDMotorista = @IDMotorista";

            
            BancoDeDados.abrirConexao();
            BancoDeDados.conexao.Execute(sqlMes, new { IDMotorista = IDMotorista, pontuacao = Pontuacao });
            BancoDeDados.conexao.Execute(sqlAno, new { IDMotorista = IDMotorista, pontuacao = Pontuacao });
>>>>>>> master
            BancoDeDados.fecharConexao();
        }

        public static double ObterPontuacaoMes(int idUsuario)
        {
            var sql = $"SELECT Pontos FROM Ranking WHERE IDMotorista = @id";
            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.QueryFirst<double>(sql, new { id = idUsuario });
                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static double ObterPontuacaoAno(int idUsuario)
        {
<<<<<<< HEAD
            var sql = $"SELECT Pontos FROM Ranking WHERE IDMotorista = @id";
=======
            var sql = $"SELECT Pontos FROM RankingAno WHERE IDMotorista = @id";
>>>>>>> master
            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.QueryFirst<double>(sql, new { id = idUsuario });
                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static IEnumerable<Ranking> ObterRankingMes()
        {
<<<<<<< HEAD
            var sql = $"SELECT m.Nome as Motorista,r.KM,r.Pontos FROM Ranking r inner JOIN Motorista m on r.IDMotorista = m.ID where m.Ativo = 1 order by r.Pontos DESC";
=======
            var sql = $"SELECT m.Nome as Motorista,r.Pontos FROM RankingMes r inner JOIN Motorista m on r.IDMotorista = m.ID where m.Ativo = 1 order by r.Pontos DESC";
>>>>>>> master
            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.Query<Ranking>(sql);
                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
<<<<<<< HEAD

        public static void Resetar()
        {
            var sql = "UPDATE Ranking SET Pontos=0,SET KM=0";
=======
        
        public static IEnumerable<Ranking> ObterRankingAno()
        {
            var sql = $"SELECT m.Nome as Motorista,r.Pontos FROM RankingAno r inner JOIN Motorista m on r.IDMotorista = m.ID where m.Ativo = 1 order by r.Pontos DESC";
            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.Query<Ranking>(sql);
                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        
        public static void ResetarMes()
        {
            var sql = "UPDATE RankingMes SET Pontos=0";

            try
            {
                BancoDeDados.abrirConexao();
                BancoDeDados.conexao.Execute(sql);
                BancoDeDados.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro:{e.Message}");
            }
        }
        
        public static void ResetarAno()
        {
            var sql = "UPDATE RankingAno SET Pontos=0";
>>>>>>> master

            try
            {
                BancoDeDados.abrirConexao();
                BancoDeDados.conexao.Execute(sql);
                BancoDeDados.fecharConexao();
            }
            catch (Exception e)
            {
                throw new Exception($"Erro:{e.Message}");
            }
        }
    }
}
