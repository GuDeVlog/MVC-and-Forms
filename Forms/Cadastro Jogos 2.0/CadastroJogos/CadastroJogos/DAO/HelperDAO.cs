using DAO;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
namespace CadjogosWF.DAO
{
    public static class HelperDAO
    {
        public static void ExecutaSQL(string sql, SqlParameter[] p)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    if (p != null)
                        cmd.Parameters.AddRange(p);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ExecutaSQL(string sql, SqlParameter p)
        {
            using (SqlConnection conexao = ConexaoBD.GetConexao())
            {
                using (SqlCommand cmd = new SqlCommand(sql, conexao))
                {
                    if (p != null)
                        cmd.Parameters.Add(p);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}