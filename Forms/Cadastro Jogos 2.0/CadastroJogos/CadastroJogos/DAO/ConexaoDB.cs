using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class ConexaoBD
    {
        public static SqlConnection GetConexao()
        {
            string strCon = "Data Source=LOCALHOST; Database=AULADB; user id=sa; password=123456";
            SqlConnection conexao = new SqlConnection(strCon);
            conexao.Open();
            return conexao;
        }
    }
}

