using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BLL;

namespace DAL
{
    class dalApartamento:iDAL<clsApartamento>
    {
        public void Inserir(clsApartamento obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOAPARTAMENTO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 0;
            dalConexao.ComandoSql.Parameters.Add("@IDAPARTAMENT", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@Numero", SqlDbType.VarChar).Value = obj.Numero;
            dalConexao.ComandoSql.Parameters.Add("@Bloco", SqlDbType.Int).Value = obj.Bloco.ID;
            dalConexao.ComandoSql.Parameters.Add("@Morador", SqlDbType.Int).Value = obj.Morador.ID;
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

        public void Alterar(clsApartamento obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOAPARTAMENTO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 1;
            dalConexao.ComandoSql.Parameters.Add("@IDAPARTAMENT", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@Numero", SqlDbType.VarChar).Value = obj.Numero;
            dalConexao.ComandoSql.Parameters.Add("@Bloco", SqlDbType.Int).Value = obj.Bloco.ID;
            dalConexao.ComandoSql.Parameters.Add("@Morador", SqlDbType.Int).Value = obj.Morador.ID;
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

        public void Excluir(clsApartamento obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOAPARTAMENTO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 2;
            dalConexao.ComandoSql.Parameters.Add("@IDAPARTAMENT", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@Numero", SqlDbType.VarChar).Value = obj.Numero;
            dalConexao.ComandoSql.Parameters.Add("@Bloco", SqlDbType.Int).Value = obj.Bloco.ID;
            dalConexao.ComandoSql.Parameters.Add("@Morador", SqlDbType.Int).Value = obj.Morador.ID;
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

        public clsApartamento PesquisaNome(string pNome)
        {
            throw new NotImplementedException();
        }

        public List<clsApartamento> LerRegistros()
        {
            SqlDataReader leitor;
            clsApartamento a;
            List<clsApartamento> listaApartamento = new List<clsApartamento>();
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspCONSULTAAPARTAMENTO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;
            dalConexao.Conector.Open();
            leitor = dalConexao.ComandoSql.ExecuteReader();
            while (leitor.Read())
            {
                a = new clsApartamento();
                a.ID = leitor.GetInt32(0);
                a.Numero= leitor.GetInt32(1);
                a.Bloco.ID = leitor.GetInt32(3);
                a.Morador.ID = leitor.GetInt32(3);
                listaApartamento.Add(a);
            }
            dalConexao.Conector.Close();
            return listaApartamento;
        }
    }
}
