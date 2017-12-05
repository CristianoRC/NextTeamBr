using System;
using System.Collections.Generic;
using Dapper;

namespace NextteamBr
{
    class RankingService
    {
        public static void AtualizarPontuacao(int IDMotorista, double Pontuacao, double KM)
        {
            var antigaPontuacaoMes = ObterPontuacao(IDMotorista, ERanking.Mensal);
            var pontuacaoMes = Pontuacao + antigaPontuacaoMes;
            var antigoKMMes = ObterKM(IDMotorista, ERanking.Mensal);
            var KMMes = KM + antigoKMMes;

            var antigaPontuacaoAno = ObterPontuacao(IDMotorista, ERanking.Anual);
            var pontuacaoAno = Pontuacao + antigaPontuacaoAno;
            var antigoKMAno = ObterKM(IDMotorista, ERanking.Mensal);
            var KMAno = KM + antigoKMAno;

            var sqlMes = "UPDATE Ranking SET Pontos=@pontuacao,KM=@KM WHERE IDMotorista = @IDMotorista";
            var sqlAno = "UPDATE RankingAno SET Pontos=@pontuacao,KM=@KM WHERE IDMotorista = @IDMotorista";


            BancoDeDados.abrirConexao();
            BancoDeDados.conexao.Execute(sqlMes, new { IDMotorista = IDMotorista, pontuacao = pontuacaoMes, KM = KMMes });
            BancoDeDados.conexao.Execute(sqlAno, new { IDMotorista = IDMotorista, pontuacao = pontuacaoAno, KM = KMAno });
            BancoDeDados.fecharConexao();
        }

        public static double ObterPontuacao(int IdUsuario, ERanking tipo)
        {
            if (tipo == ERanking.Mensal)
            {
                return obterPontuacaoMes(IdUsuario);
            }

            return obterPontuacaoAno(IdUsuario);
        }

        public static uint ObterKM(int IdUsuario, ERanking tipo)
        {
            if (tipo == ERanking.Mensal)
            {
                return obterKMMes(IdUsuario);
            }

            return obterKMAno(IdUsuario);
        }

        private static double obterPontuacaoMes(int idUsuario)
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

        private static double obterPontuacaoAno(int idUsuario)
        {
            var sql = $"SELECT Pontos FROM RankingAno WHERE IDMotorista = @id";
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

        private static uint obterKMMes(int idUsuario)
        {
            var sql = $"SELECT KM FROM Ranking WHERE IDMotorista = @id";
            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.QueryFirst<uint>(sql, new { id = idUsuario });
                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static uint obterKMAno(int idUsuario)
        {
            var sql = $"SELECT KM FROM RankingAno WHERE IDMotorista = @id";
            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.QueryFirst<uint>(sql, new { id = idUsuario });
                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static IEnumerable<Ranking> ObterRanking(ERanking tipo)
        {
            if (tipo == ERanking.Mensal)
            {
                return obterRankingMes();
            }
            return obterRankingAno();
        }

        private static IEnumerable<Ranking> obterRankingMes()
        {
            var sql = $"SELECT m.Nome as Motorista,r.Pontos,r.KM FROM Ranking r inner JOIN Motorista m on r.IDMotorista = m.ID where m.Ativo = 1 order by r.Pontos DESC";

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

        private static IEnumerable<Ranking> obterRankingAno()
        {
            var sql = $"SELECT m.Nome as Motorista,r.Pontos,r.KM FROM RankingAno r inner JOIN Motorista m on r.IDMotorista = m.ID where m.Ativo = 1 order by r.Pontos DESC";
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

        public static IEnumerable<Ranking> ObterRankingEmpresa(ERanking tipo, int IDempresa)
        {
            if (tipo == ERanking.Mensal)
            {
                return obterRankingMesEmpresa(IDempresa);
            }
            return obterRankingAnoEmpresa(IDempresa);
        }

        private static IEnumerable<Ranking> obterRankingMesEmpresa(int IDempresa)
        {
            var sql = $"SELECT m.Nome as Motorista,r.Pontos,r.KM FROM Ranking r inner JOIN Motorista m on r.IDMotorista = m.ID where m.Ativo = 1 AND IDEmpresa = @empresa order by r.Pontos DESC";

            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.Query<Ranking>(sql, new { empresa = IDempresa });
                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private static IEnumerable<Ranking> obterRankingAnoEmpresa(int IDempresa)
        {
            var sql = $"SELECT m.Nome as Motorista,r.Pontos,r.KM FROM RankingAno r inner JOIN Motorista m on r.IDMotorista = m.ID where m.Ativo = 1 AND IDEmpresa = @empresa order by r.Pontos DESC";
            try
            {
                BancoDeDados.abrirConexao();
                var usuario = BancoDeDados.conexao.Query<Ranking>(sql, new { empresa = IDempresa });

                BancoDeDados.fecharConexao();

                return usuario;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public static void Resetar(ERanking tipo)
        {
            if (tipo == ERanking.Mensal)
            {
                ResetarMes();
            }
            else
            {
                ResetarAno();
            }
        }

        private static void ResetarMes()
        {
            var sql = "UPDATE Ranking SET Pontos=0,KM=0";

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

        private static void ResetarAno()
        {
            var sql = "UPDATE RankingAno SET Pontos=0,km=0";

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
