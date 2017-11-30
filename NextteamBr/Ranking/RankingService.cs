using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;

namespace NextteamBr
{
    class RankingService
    {
        public static void AtualizarPontuacao(int IDMotorista, double Pontuacao)
        {
            var antigaPontuacao = ObterPontuacao(IDMotorista);
            Pontuacao += antigaPontuacao;
            var sql = "UPDATE Ranking SET Pontos=@pontuacao WHERE IDMotorista = @IDMotorista";
            BancoDeDados.abrirConexao();
            BancoDeDados.conexao.Execute(sql, new { IDMotorista = IDMotorista, pontuacao = Pontuacao });
            BancoDeDados.fecharConexao();
        }

        public static double ObterPontuacao(int idUsuario)
        {
            var sql = $"SELECT sum(Pontos)FROM Ranking WHERE IDMotorista = @id";
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

        public static IEnumerable<Ranking> ObterRanking()
        {
            var sql = $"SELECT m.Nome as Motorista,r.Pontos FROM Ranking r inner JOIN Motorista m on r.IDMotorista = m.ID where m.Ativo = 1 order by r.Pontos DESC";
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
        public static void Resetar()
        {
            var sql = "UPDATE Ranking SET Pontos=0";

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
