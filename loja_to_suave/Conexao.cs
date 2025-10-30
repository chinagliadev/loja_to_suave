using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace loja_to_suave
{
    internal class Conexao
    {
        private const string ConexaoString = "server=localhost;user=root;database=db_tosuave;port=3306;password=;";

        private MySqlConnection conexao;

        public MySqlConnection AbrirConexao()
        {
            try
            {
                conexao = new MySqlConnection(ConexaoString);

                conexao.Open();

                return conexao;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
                throw;
            }
        }

        public void FecharConexao(MySqlConnection conn)
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
            }
        }
    }
}