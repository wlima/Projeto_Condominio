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
    public class dalFuncionario:iDAL<clsFuncionario>
    {
        public void Inserir(clsFuncionario obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOFUNCIONARIO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 1;
            dalConexao.ComandoSql.Parameters.Add("@IDFuncionario", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@Nome", SqlDbType.VarChar).Value = obj.Nome;
            dalConexao.ComandoSql.Parameters.Add("@CPF", SqlDbType.VarChar).Value = obj.CPF;
            dalConexao.ComandoSql.Parameters.Add("@RG", SqlDbType.VarChar).Value = obj.RG;
            dalConexao.ComandoSql.Parameters.Add("@CARGO", SqlDbType.VarChar).Value = "geral";// obj.Salario;
            dalConexao.ComandoSql.Parameters.Add("@Salario", SqlDbType.VarChar).Value = "1000.00";// obj.Lotacao.ID;
            dalConexao.ComandoSql.Parameters.Add("@Condominio", SqlDbType.Int).Value = obj.Lotacao.ID;


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

        public void Alterar(clsFuncionario obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOFUNCIONARIO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 1;
            dalConexao.ComandoSql.Parameters.Add("@IDFuncionario", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@NOME", SqlDbType.VarChar).Value = obj.Nome;
            dalConexao.ComandoSql.Parameters.Add("@CPF", SqlDbType.VarChar).Value = obj.CPF;
            dalConexao.ComandoSql.Parameters.Add("@RG", SqlDbType.VarChar).Value = obj.RG;
            dalConexao.ComandoSql.Parameters.Add("@CARGO", SqlDbType.VarChar).Value = "geral";// obj.Salario;
            dalConexao.ComandoSql.Parameters.Add("@SALARIO", SqlDbType.VarChar).Value = "1000.00";// obj.Lotacao.ID;
            dalConexao.ComandoSql.Parameters.Add("@CONDOMINIO", SqlDbType.Int).Value = obj.Lotacao.ID;

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

        public void Excluir(clsFuncionario obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOFUNCIONARIO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 2;
            dalConexao.ComandoSql.Parameters.Add("@IDFuncionario", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@Nome", SqlDbType.VarChar).Value = obj.Nome;
            dalConexao.ComandoSql.Parameters.Add("@CPF", SqlDbType.VarChar).Value = obj.CPF;
            dalConexao.ComandoSql.Parameters.Add("@RG", SqlDbType.VarChar).Value = obj.RG;
            dalConexao.ComandoSql.Parameters.Add("@CARGO", SqlDbType.VarChar).Value = "geral";// obj.Salario;
            dalConexao.ComandoSql.Parameters.Add("@Salario", SqlDbType.VarChar).Value = "1000.00";// obj.Lotacao.ID;
            dalConexao.ComandoSql.Parameters.Add("@Condominio", SqlDbType.Int).Value = obj.Lotacao.ID;

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

        public clsFuncionario PesquisaNome(string pNome)
        {
            throw new NotImplementedException();
        }

        public List<clsFuncionario> LerRegistros()
        {
            SqlDataReader leitor;
            clsFuncionario f;
            List<clsFuncionario> listaFuncionario = new List<clsFuncionario>();
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspCONSULTAFUNCIONARIO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;
            //dalConexao.ComandoSql.CommandText = @"select f.*, c.Nome,c.Endereco from tbFuncionario f join tbCondominio c on(f.Condominio=c.idCondominio) order by f.Nome;";
            dalConexao.Conector.Open();
            leitor = dalConexao.ComandoSql.ExecuteReader();
            while (leitor.Read())
            {
               f = new clsFuncionario();
               f.ID = leitor.GetInt32(0);
               f.Nome = leitor.GetString(1);
               f.CPF = leitor.GetString(2);
               f.RG = leitor.GetString(3);
               f.Cargo = leitor.GetString(4);
               f.Salario = leitor.GetString(5);
               f.Lotacao.ID = leitor.GetInt32(6);               
               f.Lotacao.Nome = leitor.GetString(8);
               f.Lotacao.Endereco = leitor.GetString(9);               
               
               listaFuncionario.Add(f);
            }
            dalConexao.Conector.Close();
            return listaFuncionario;
        }
    }
}
