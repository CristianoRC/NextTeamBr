using System;
using System.Windows.Forms;
using Dapper;

namespace NextteamBr
{
    class FreteRepository
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

                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }
    }
}
