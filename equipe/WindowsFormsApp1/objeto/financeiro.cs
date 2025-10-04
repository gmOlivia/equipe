using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.objeto
{
    public class financeiro
    {
        public int id { get; set; }
        public string produto { get; set; }
        public DateTime data { get; set; }
        public string status { get; set; }
        public string nome { get; set; }

        // Método para cadastrar
        public bool cadastrar(conexao conexao)
        {
            string[] campos = { "@produto", "@data", "@status", "@nome" };
            object[] valores = { this.produto, this.data.ToString("yyyy-MM-dd"), this.status, this.nome };

            string sql = "INSERT INTO financeiro (produto, data, status, nome) VALUES (@produto, @data, @status, @nome)";

            try
            {
                int resultado = conexao.cadastrar(campos, valores, sql);
                return resultado > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao cadastrar: " + ex.Message);
            }
        }

        public bool excluir(conexao conexao)
        {
            string sql = "DELETE FROM financeiro WHERE id = @id";

            try
            {
                using (MySqlConnection conn = conexao.getConexao())
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", this.id);
                    int resultado = cmd.ExecuteNonQuery();
                    return resultado > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao excluir: " + ex.Message);
            }
        }
    }
}
