using CadLivrosMVC.DAO;
using CadLivrosMVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
namespace DAO
{
    public class LivrosDAO
    {
        private SqlParameter[] CriaParametros(LivrosViewModel livros)
        {

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("id", livros.Id),
                new SqlParameter("Titulo", livros.Titulo),
                new SqlParameter("Autor1", livros.Autor1),
                new SqlParameter("AnoLancamento", livros.Ano),
                new SqlParameter("Edicao", livros.Edicao),
                new SqlParameter("Editora", livros.Editora),
                new SqlParameter("PrecoSugerido", livros.PrecoSugerido)
            };

            // Verificando Autor2 e adicionando o valor correto
            if (livros.Autor2 == null)
            {
                parametros.Add(new SqlParameter("Autor2", DBNull.Value));
            }
            else
            {
                parametros.Add(new SqlParameter("Autor2", livros.Autor2));
            }

            // Convertendo para array
            SqlParameter[] p = parametros.ToArray();

            return p;

        }

        public void InserirLivros(LivrosViewModel livros)
        {
            string sql =
            "insert into tbLivros(id, Titulo, Autor1, Autor2, Editora, AnoLancamento, Edicao, PrecoSugerido)" +
            "values (@id, @Titulo, @Autor1, @Autor2, @Editora, @AnoLancamento, @Edicao, @PrecoSugerido)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(livros));
        }

        public void AlterarLivros(LivrosViewModel livros)
        {
            string sql = "update tbLivros set " +
            "Titulo = @Titulo,Autor1 = @Autor1, Autor2 = Autor2, Editora = @Editora, Edicao = @Edicao, PrecoSugerido = @PrecoSugerido, AnoLancamento=@AnoLancamento where id=@id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(livros));
        }

        private LivrosViewModel MontaLivro(DataRow registro)
        {
            LivrosViewModel livros = new LivrosViewModel();
            livros.Id = Convert.ToInt32(registro["id"]);
            livros.Titulo = registro["Titulo"].ToString();
            livros.Autor1 = registro["Autor1"].ToString();
            if (registro["Autor2"] != DBNull.Value)
                livros.Autor2 = registro["Autor2"].ToString();
            livros.Editora = registro["Editora"].ToString();
            livros.Edicao = Convert.ToInt32(registro["Edicao"]);
            livros.PrecoSugerido = Convert.ToDouble(registro["PrecoSugerido"]);
            livros.Ano = Convert.ToInt32(registro["Anolancamento"]);
            return livros;
        }

        public LivrosViewModel Consulta(int id)
        {
            string sql = "select * from tbLivros where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return MontaLivro(tabela.Rows[0]);
        }

        public void ExcluirLivros(int id)
        {
            string sql = "delete tbLivros where id =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }


    }
}
