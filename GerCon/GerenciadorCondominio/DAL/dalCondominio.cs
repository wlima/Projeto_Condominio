using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BLL;
namespace DAL
{
    class dalCondominio:iDAL<clsCondominio>
    {



        public void Inserir(clsCondominio obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOCONDOMINIO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 0;
            dalConexao.ComandoSql.Parameters.Add("@IDCONDOMINIO", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@NOME", SqlDbType.VarChar).Value = obj.Nome;
            dalConexao.ComandoSql.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = obj.Endereco;
            dalConexao.ComandoSql.Parameters.Add("@SINDICO", SqlDbType.Int).Value = obj.Sindico.ID;  
            try
            {
                dalConexao.Conector.Open();
                dalConexao.ComandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dalConexao.Conector.Close();
            }
        }

        public void Alterar(clsCondominio obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOCONDOMINIO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 1;
            dalConexao.ComandoSql.Parameters.Add("@IDCONDOMINIO", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@NOME", SqlDbType.VarChar).Value = obj.Nome;
            dalConexao.ComandoSql.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = obj.Endereco;
            dalConexao.ComandoSql.Parameters.Add("@SINDICO", SqlDbType.Int).Value = obj.Sindico.ID; 
            try
            {
                dalConexao.Conector.Open();
                dalConexao.ComandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dalConexao.Conector.Close();
            }
        }

        public void Excluir(clsCondominio obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOCONDOMINIO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 2;
            dalConexao.ComandoSql.Parameters.Add("@IDCONDOMINIO", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@NOME", SqlDbType.VarChar).Value = obj.Nome;
            dalConexao.ComandoSql.Parameters.Add("@ENDERECO", SqlDbType.VarChar).Value = obj.Endereco;
            dalConexao.ComandoSql.Parameters.Add("@SINDICO", SqlDbType.Int).Value = obj.Sindico.ID; 
            try
            {
                dalConexao.Conector.Open();
                dalConexao.ComandoSql.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dalConexao.Conector.Close();
            }
        }

        public clsCondominio PesquisaNome(string pNome)
        {
            throw new NotImplementedException();
        }

        public List<clsCondominio> LerRegistros()
        {
            SqlDataReader leitor;
            clsCondominio c;
            List<clsCondominio> listaCondominio = new List<clsCondominio>();
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspCONSULTACONDOMINIO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;           
            dalConexao.Conector.Open();
            leitor = dalConexao.ComandoSql.ExecuteReader();
            while (leitor.Read())
            {
               c = new clsCondominio();
               c.ID = leitor.GetInt32(0);
               c.Nome = leitor.GetString(1);
               c.Endereco = leitor.GetString(2);
               c.Sindico.ID = leitor.GetInt32(3);              

                listaCondominio.Add(c);
            }
            dalConexao.Conector.Close();
            return listaCondominio;
        }
    }
}
