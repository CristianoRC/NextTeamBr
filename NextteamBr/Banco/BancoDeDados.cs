using MySql.Data.MySqlClient;

namespace NextteamBr
{
    public static class BancoDeDados
    {

        public static readonly MySqlConnection conexao = new MySqlConnection(
             @"Server=50.116.87.68;Port=3306;Database=zeroh537_LogBook;
                      Uid=zeroh537_LogBook; Pwd=F)K#KzE62oiO;");


        public static void abrirConexao()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
                conexao.Open();
        }
        public static void fecharConexao()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
                conexao.Close();
        }
    }
}
