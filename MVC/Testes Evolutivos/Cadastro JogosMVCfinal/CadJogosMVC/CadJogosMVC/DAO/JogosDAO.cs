using CadJogosMVC.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

namespace CadJogosMVC.DAO
{
    public class JogosDAO
    {
        public void Inserir(JogosViewModel jogo)
        {
            string sql =
            "insert into jogos(id, nome, ValorLocacao, CPUID, DataAquisicao)" +
            "values ( @id, @nome, @ValorLocacao, @CPUID, @DataAquisicao)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(jogo));
        }

        public void Alterar(JogosViewModel jogo)
        {
            string sql =
            "update jogos set nome = @nome, " +
            "ValorLocacao = @ValorLocacao, " +
            "CPUID = @CPUID," +
            "DataAquisicao = @DataAquisicao where id = @id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(jogo));
        }

        public void Excluir(int id)
        {
            string sql = "delete jogos where id =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        private SqlParameter[] CriaParametros(JogosViewModel jogo)
        {
            SqlParameter[] parametros = new SqlParameter[5];
            parametros[0] = new SqlParameter("id", jogo.Id);
            parametros[1] = new SqlParameter("nome", jogo.Nome);
            parametros[2] = new SqlParameter("ValorLocacao", jogo.Valor_Locacao);
            parametros[3] = new SqlParameter("CPUID", jogo.CPU_ID);
            parametros[4] = new SqlParameter("DataAquisicao", jogo.Data_Aquisicao);
            return parametros;
        }
        private JogosViewModel MontaJogo(DataRow registro)
        {
            JogosViewModel a = new JogosViewModel();
            a.Id = Convert.ToInt32(registro["id"]);
            a.Nome = registro["nome"].ToString();
            a.CPU_ID = Convert.ToInt32(registro["CPUID"]);
            a.Valor_Locacao = Convert.ToDouble(registro["ValorLocacao"]);
            a.Data_Aquisicao = Convert.ToDateTime(registro["DataAquisicao"]);
            return a;
        }

        public JogosViewModel Consulta(int id)
        {
            string sql = "select * from jogos where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaJogo(tabela.Rows[0]);
        }
        public List<JogosViewModel> Listagem()
        {
            List<JogosViewModel> lista = new List<JogosViewModel>();
            string sql = "select * from jogos order by nome";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(MontaJogo(registro));
            return lista;
        }
    }
}