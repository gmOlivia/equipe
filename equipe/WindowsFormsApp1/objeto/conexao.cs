using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.objeto
{
    public class conexao
    {
        private static string servidor = "localhost";
        private static string banco = "gerenciamento";
        private static string usuario = "root";
        private static string senha = "";

        private static string conexaobd = $"server={servidor};database={banco};user id={usuario};password={senha};";

        // Retorna uma conexão nova
        public MySqlConnection getConexao()
        {
            return new MySqlConnection(conexaobd);
        }

        // Executa SELECT e retorna resultado em DataTable
        public DataTable obterdados(string sql)
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = getConexao())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
            }

            return dt;
        }

        // Executa INSERT com parâmetros
        public int cadastrar(string[] campos, object[] valores, string sql)
        {
            int resultado = 0;

            using (MySqlConnection conn = getConexao())
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                for (int i = 0; i < campos.Length; i++)
                {
                    cmd.Parameters.AddWithValue(campos[i], valores[i]);
                }

                resultado = cmd.ExecuteNonQuery();
            }

            return resultado;
        }
    }
}
