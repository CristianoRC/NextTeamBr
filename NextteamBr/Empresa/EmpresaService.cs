using System;
using System.Collections.Generic;
using Dapper;

namespace NextteamBr
{
    public static class EmpresaService
    {
        public static IEnumerable<Empresa> Listar()
        {
            try
            {
                BancoDeDados.abrirConexao();
                var Empresas = BancoDeDados.conexao.Query<Empresa>("SELECT * FROM Empresa");
                BancoDeDados.fecharConexao();

                foreach (var item in Empresas)
                {
                    item.KM = ObterKMRodadosAnual(item.ID);
                    item.Motoristas = ObterNumeroDeMembros(item.ID);
                }

                return Empresas;
            }
            catch (Exception ex)
            {
                throw new Exception($"Ocorreu um erro, entre em contato com o desenvolvedor:{ex.Message}");
            }
        }

        public static int ObterNumeroDeMembros(int Empresa)
        {
            var sql = "SELECT count(*) FROM Motorista WHERE IDEmpresa = @Empresa";
            try
            {
                BancoDeDados.abrirConexao();
                var numeroDeMotoristas = BancoDeDados.conexao.QueryFirst<int>(sql, new { Empresa = Empresa });
                BancoDeDados.fecharConexao();

                return numeroDeMotoristas;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro! entre em conato com o desenvolvedor:{ex.Message}");
            }
        }

        public static int ObterKMRodadosMensal(int Empresa)
        {
            var sql = "SELECT sum(f.KM) FROM Motorista m  inner JOIN Ranking f on f.IDMotorista = m.ID WHERE m.IDEmpresa = @Empresa";
            try
            {
                BancoDeDados.abrirConexao();
                var numeroDeMotoristas = BancoDeDados.conexao.QueryFirst<int>(sql, new { Empresa = Empresa });
                BancoDeDados.fecharConexao();

                return numeroDeMotoristas;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro! entre em conato com o desenvolvedor:{ex.Message}");
            }
        }

        public static int ObterKMRodadosAnual(int Empresa)
        {
            var sql = "SELECT sum(f.KM) FROM Motorista m  inner JOIN RankingAno f on f.IDMotorista = m.ID WHERE m.IDEmpresa = @Empresa";
            try
            {
                BancoDeDados.abrirConexao();
                var numeroDeMotoristas = BancoDeDados.conexao.QueryFirst<int>(sql, new { Empresa = Empresa });
                BancoDeDados.fecharConexao();

                return numeroDeMotoristas;
            }
            catch (Exception ex)
            {
                throw new Exception($"Erro! entre em conato com o desenvolvedor:{ex.Message}");
            }
        }
    }
}
