using ControleCurriculos.Models;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System;

namespace ControleCurriculos.DAO
{
    public class CurriculosDAO
    {
        public void Inserir(CurriculosViewModel curriculo)
        {
            string sql =
            "insert into curriculo (Id, Nome, CPF, Endereco, Telefone, Email, PretensaoSalarial, CargoPretendido, Curso1, Curso2, Curso3, Curso4, Curso5, Experiencia1, Experiencia2, Experiencia3, Idioma1, idioma2, Idioma3)" +
            "values (@Id, @Nome, @CPF, @Endereco, @Telefone, @Email, @PretensaoSalarial, @CargoPretendido, @Curso1, @Curso2, @Curso3, @Curso4, @Curso5, @Experiencia1, @Experiencia2, @Experiencia3, @Idioma1, @idioma2, @Idioma3)";
            HelperDAO.ExecutaSQL(sql, CriaParametros(curriculo));
        }

        public void Alterar(CurriculosViewModel curriculo)
        {
            string sql =
               "update curriculo set Nome = @Nome, CPF = @CPF, Endereco = @Endereco, Telefone = @Telefone, Email = @Email, PretensaoSalarial = @PretensaoSalarial, CargoPretendido = @CargoPretendido, Curso1 = @Curso1, Curso2 = @Curso2, Curso3 = @Curso3, Curso4 = @Curso4, Experiencia1 = @Experiencia1, Experiencia2 = @Experiencia2, Experiencia3 = @Experiencia3, Idioma1 = @Idioma1, Idioma2 = @Idioma2, Idioma3 = @Idioma3"
           + " where id = @id";
            HelperDAO.ExecutaSQL(sql, CriaParametros(curriculo));
        }

        public void Excluir(int id)
        {
            string sql = "delete curriculo where id =" + id;
            HelperDAO.ExecutaSQL(sql, null);
        }

        private SqlParameter[] CriaParametros(CurriculosViewModel curriculo)
        {
            SqlParameter[] parametros = new SqlParameter[19];
            parametros[0] = new SqlParameter("@id", curriculo.Id);
            parametros[1] = new SqlParameter("@nome", curriculo.Nome);
            parametros[2] = new SqlParameter("@CPF", curriculo.CPF);
            parametros[3] = new SqlParameter("@Endereco", curriculo.Endereço);
            parametros[4] = new SqlParameter("@Telefone", curriculo.Telefone);
            parametros[5] = new SqlParameter("@Email", curriculo.Email);
            parametros[6] = new SqlParameter("@PretensaoSalarial", curriculo.PretensaoSalarial);
            parametros[7] = new SqlParameter("@CargoPretendido", curriculo.CargoPretendido);

            parametros[8] = new SqlParameter("@Curso1", string.IsNullOrEmpty(curriculo.Curso1) ? DBNull.Value : (object)curriculo.Curso1);
            parametros[9] = new SqlParameter("@Curso2", string.IsNullOrEmpty(curriculo.Curso2) ? DBNull.Value : (object)curriculo.Curso2);
            parametros[10] = new SqlParameter("@Curso3", string.IsNullOrEmpty(curriculo.Curso3) ? DBNull.Value : (object)curriculo.Curso3);
            parametros[11] = new SqlParameter("@Curso4", string.IsNullOrEmpty(curriculo.Curso4) ? DBNull.Value : (object)curriculo.Curso4);
            parametros[12] = new SqlParameter("@Curso5", string.IsNullOrEmpty(curriculo.Curso5) ? DBNull.Value : (object)curriculo.Curso5);

            parametros[13] = new SqlParameter("@Experiencia1", string.IsNullOrEmpty(curriculo.Experiencia1) ? DBNull.Value : (object)curriculo.Experiencia1);
            parametros[14] = new SqlParameter("@Experiencia2", string.IsNullOrEmpty(curriculo.Experiencia2) ? DBNull.Value : (object)curriculo.Experiencia2);
            parametros[15] = new SqlParameter("@Experiencia3", string.IsNullOrEmpty(curriculo.Experiencia3) ? DBNull.Value : (object)curriculo.Experiencia3);

            parametros[16] = new SqlParameter("@Idioma1", string.IsNullOrEmpty(curriculo.Idioma1) ? DBNull.Value : (object)curriculo.Idioma1);
            parametros[17] = new SqlParameter("@Idioma2", string.IsNullOrEmpty(curriculo.Idioma2) ? DBNull.Value : (object)curriculo.Idioma2);
            parametros[18] = new SqlParameter("@Idioma3", string.IsNullOrEmpty(curriculo.Idioma3) ? DBNull.Value : (object)curriculo.Idioma3);
            return parametros;
        }
        private CurriculosViewModel Montacurriculo(DataRow registro)
        {
            CurriculosViewModel a = new CurriculosViewModel();
            a.Id = Convert.ToInt32(registro["id"]);
            a.Nome = registro["nome"].ToString();
            a.CPF = registro["CPF"].ToString();
            a.Endereço = registro["Endereco"].ToString();
            a.Telefone = registro["telefone"].ToString();
            a.Email = registro["Email"].ToString();
            a.PretensaoSalarial = Convert.ToDouble(registro["PretensaoSalarial"]);
            a.CargoPretendido = registro["CargoPretendido"].ToString();

            a.Curso1 = registro["Curso1"] != DBNull.Value ? registro["Curso1"].ToString() : null;
            a.Curso2 = registro["Curso2"] != DBNull.Value ? registro["Curso2"].ToString() : null;
            a.Curso3 = registro["Curso3"] != DBNull.Value ? registro["Curso3"].ToString() : null;
            a.Curso4 = registro["Curso4"] != DBNull.Value ? registro["Curso4"].ToString() : null;
            a.Curso5 = registro["Curso5"] != DBNull.Value ? registro["Curso5"].ToString() : null;

            a.Experiencia1 = registro["Experiencia1"] != DBNull.Value ? registro["Experiencia1"].ToString() : null;
            a.Experiencia2 = registro["Experiencia2"] != DBNull.Value ? registro["Experiencia2"].ToString() : null;
            a.Experiencia3 = registro["Experiencia3"] != DBNull.Value ? registro["Experiencia3"].ToString() : null;

            a.Idioma1 = registro["Idioma1"] != DBNull.Value ? registro["Idioma1"].ToString() : null;
            a.Idioma2 = registro["Idioma2"] != DBNull.Value ? registro["Idioma2"].ToString() : null;
            a.Idioma3 = registro["Idioma3"] != DBNull.Value ? registro["Idioma3"].ToString() : null;
            return a;
        }

        public CurriculosViewModel Consulta(int id)
        {
            string sql = "select * from curriculo where id = " + id;
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            if (tabela.Rows.Count == 0)
                return null;
            else
                return Montacurriculo(tabela.Rows[0]);
        }
        public List<CurriculosViewModel> Listagem()
        {
            List<CurriculosViewModel> lista = new List<CurriculosViewModel>();
            string sql = "select * from curriculo order by nome";
            DataTable tabela = HelperDAO.ExecutaSelect(sql, null);
            foreach (DataRow registro in tabela.Rows)
                lista.Add(Montacurriculo(registro));
            return lista;
        }
    }
}