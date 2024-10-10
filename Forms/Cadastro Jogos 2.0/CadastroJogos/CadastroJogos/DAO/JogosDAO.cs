using CadjogosWF.DAO;
using CadjogosWF.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class JogosDAO
    {
        private SqlParameter[] CriaParametros(JogosViewModel jogos)
        {

            SqlParameter[] p = new SqlParameter[]
                {

                    new SqlParameter("id", jogos.Id),
                    new SqlParameter("nome", jogos.Nome),
                    new SqlParameter("CPUID", jogos.CPU_ID),
                    new SqlParameter("ValorLocacao", jogos.Valor_Locacao),
                    new SqlParameter("DataAquisicao", jogos.Data_Aquisicao)

                };

            return p;

        }

        public void InserirJogos(JogosViewModel jogos)
        {
            string sql =
            "insert into jogos(id, nome, ValorLocacao, CPUID, DataAquisicao)" +
            "values ( @id, @nome, @ValorLocacao, @CPUID, @DataAquisicao)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(jogos));
        }

        public void AlterarJogos(JogosViewModel jogos)
        {
            string sql = "update jogos set " +
            "nome=@nome,CPUID=@CPUID,ValorLocacao=@ValorLocacao," + "DataAquisicao=@DataAquisicao where id=@id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(jogos));
        }

        public void ExcluirJogos(int id)
        {
            string sql = $"delete jogos where id =@id";
            HelperDAO.ExecutaSQL(sql, new SqlParameter("id", id));
        }

        public List<JogosViewModel> ConsultarTodosJogos()
        {
            using (SqlConnection cx = ConexaoBD.GetConexao())
            {
                string sql = "select * from jogos order by nome ";
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, cx))
                {
                    DataTable tabela = new DataTable();
                    adapter.Fill(tabela);
                    List<JogosViewModel> lista = new List<JogosViewModel>();

                    foreach (DataRow registro in tabela.Rows)
                    {
                        var jogos = new JogosViewModel();
                        jogos.Id = Convert.ToInt32(registro["id"]);
                        jogos.Nome = registro["nome"].ToString();
                        jogos.CPU_ID = Convert.ToInt32(registro["CPUID"]);
                        jogos.Valor_Locacao = Convert.ToDouble(registro["ValorLocacao"]);
                        jogos.Data_Aquisicao = Convert.ToDateTime(registro["DataAquisicao"]);
                        lista.Add(jogos);
                    }
                    return lista;
                }

            }

        }


    }
}
