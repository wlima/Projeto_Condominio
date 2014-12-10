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
    public class dalMorador:iDAL<clsMorador>
    {

        public void Inserir(clsMorador obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);
                        
            dalConexao.ComandoSql.CommandText = "uspACAOMORADOR";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@Acao", SqlDbType.Int).Value = 0;
            dalConexao.ComandoSql.Parameters.Add("@Nome",SqlDbType.VarChar).Value = obj.Nome;
            dalConexao.ComandoSql.Parameters.Add("@CPF", SqlDbType.VarChar).Value = obj.CPF;
            dalConexao.ComandoSql.Parameters.Add("@RG", SqlDbType.VarChar).Value = obj.RG;            
            
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

        public void Alterar(clsMorador obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOMORADOR";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 1;
            dalConexao.ComandoSql.Parameters.Add("@IDMORADOR", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@NOME", SqlDbType.VarChar).Value = obj.Nome;
            dalConexao.ComandoSql.Parameters.Add("@CPF", SqlDbType.VarChar).Value = obj.CPF;
            dalConexao.ComandoSql.Parameters.Add("@RG", SqlDbType.VarChar).Value = obj.RG;

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

        public void Excluir(clsMorador obj)
        {

            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOMORADOR";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 2;
            dalConexao.ComandoSql.Parameters.Add("@IDMORADOR", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@NOME", SqlDbType.VarChar).Value = obj.Nome;
            dalConexao.ComandoSql.Parameters.Add("@CPF", SqlDbType.VarChar).Value = obj.CPF;
            dalConexao.ComandoSql.Parameters.Add("@RG", SqlDbType.VarChar).Value = obj.RG;

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

        public clsMorador PesquisaNome(string pNome)
        {
            throw new NotImplementedException();
        }

        public List<clsMorador> LerRegistros()
        {
            SqlDataReader leitor;
            clsMorador m;
            List<clsMorador> listaMorador = new List<clsMorador>();
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = @"Select * from tbMorador order by Nome";
            dalConexao.Conector.Open();
            leitor = dalConexao.ComandoSql.ExecuteReader();
            while(leitor.Read())
            {
                m = new clsMorador();
                m.ID = leitor.GetInt32(0);
                m.Nome = leitor.GetString(1);
                m.CPF = leitor.GetString(2);
                m.RG = leitor.GetString(3);
                listaMorador.Add(m);
            }
            dalConexao.Conector.Close();
            return listaMorador;
        }
    }
}
