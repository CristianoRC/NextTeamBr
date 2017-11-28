using System;
using System.Windows.Forms;
using Dapper;
using System.Collections.Generic;

namespace NextteamBr
{
    class FreteService
    {
        public static bool SalvarFrete(Frete InformacoesFrete)
        {
            var sql = @"INSERT INTO Frete (IdMotorista, KmRodado, Dano, Pontuacao, Carga, CidadeInicial, CidadeDestino, DataFinalFrete) VALUES
                                        (@IdMotorista, @KmRodado, @Dano, @Pontuacao, @Carga, @CidadeInicial, @CidadeDestino, @DataFinalFrete)";
            try
            {
                BancoDeDados.abrirConexao();
                BancoDeDados.conexao.Execute(sql, new
                {
                    IdMotorista = InformacoesFrete.IdMotorista,
                    KmRodado = InformacoesFrete.KmRodado,
                    Dano = InformacoesFrete.Dano,
                    Pontuacao = InformacoesFrete.Pontuacao,
                    Carga = InformacoesFrete.Carga,
                    CidadeInicial = InformacoesFrete.CidadeInicial,
                    CidadeDestino = InformacoesFrete.CidadeDestino,
                    DataFinalFrete = InformacoesFrete.DataFinalFrete
                });
                BancoDeDados.fecharConexao();

                RankingService.AtualizarPontuacao(InformacoesFrete.IdMotorista, InformacoesFrete.Pontuacao);

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public static int NumeroDeFretesPorMotorista(int IDMotorista)
        {
            var sql = @"select count(ID) from Frete where IdMotorista = @id ";
            try
            {
                BancoDeDados.abrirConexao();
                var NumeroDeFretes = BancoDeDados.conexao.QueryFirst<int>(sql, new { id = IDMotorista });
                BancoDeDados.fecharConexao();

                return NumeroDeFretes;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return -1;
            }
        }

        public static IEnumerable<Frete> ListarFretesPorMotorista(int IDMotorista, int Registros)
        {
            var sql = @"SELECT ID,CidadeInicial, CidadeDestino, KmRodado, Carga, Dano, DataFinalFrete, Pontuacao 
                            FROM Frete WHERE IdMotorista = @id order by DataFinalFrete DESC Limit @registros";
            try
            {
                BancoDeDados.abrirConexao();
                var fretes = BancoDeDados.conexao.Query<Frete>(sql, new { id = IDMotorista, registros = Registros });
                BancoDeDados.fecharConexao();

                return fretes;
            }
            catch (Exception ex)
            {
                throw new Exception($"Entre em contato com os administradores! {ex.Message}");
            }
        }

        public static IEnumerable<Frete> ListarFretesPorMotorista(int IDMotorista)
        {
            var sql = @"SELECT ID,CidadeInicial, CidadeDestino, KmRodado, Carga, Dano, DataFinalFrete, Pontuacao 
                            FROM Frete WHERE IdMotorista = @id order by DataFinalFrete DESC";
            try
            {
                BancoDeDados.abrirConexao();
                var fretes = BancoDeDados.conexao.Query<Frete>(sql, new { id = IDMotorista });
                BancoDeDados.fecharConexao();

                return fretes;
            }
            catch (Exception ex)
            {
                throw new Exception($"Entre em contato com os administradores! {ex.Message}");
            }
        }
    }
}
