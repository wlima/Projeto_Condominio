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
    class dalCusto:iDAL<clsCusto>
    {


        public void Inserir(clsCusto obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOCUSTO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 0;
            dalConexao.ComandoSql.Parameters.Add("@IDCUSTO", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@APARTAMENTO", SqlDbType.VarChar).Value = obj.Apartamento;
            dalConexao.ComandoSql.Parameters.Add("@DESCRICAO", SqlDbType.Int).Value = obj.Descricao;
            dalConexao.ComandoSql.Parameters.Add("@DATAVENCIMENTO", SqlDbType.Date).Value = obj.DataVencimento;
            dalConexao.ComandoSql.Parameters.Add("@VALOR", SqlDbType.VarChar).Value = obj.Valor;
            dalConexao.ComandoSql.Parameters.Add("@PAGO", SqlDbType.VarChar).Value = obj.Pago;
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

        public void Alterar(clsCusto obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOCUSTO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 1;
            dalConexao.ComandoSql.Parameters.Add("@IDCUSTO", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@APARTAMENTO", SqlDbType.VarChar).Value = obj.Apartamento;
            dalConexao.ComandoSql.Parameters.Add("@DESCRICAO", SqlDbType.Int).Value = obj.Descricao;
            dalConexao.ComandoSql.Parameters.Add("@DATAVENCIMENTO", SqlDbType.Date).Value = obj.DataVencimento;
            dalConexao.ComandoSql.Parameters.Add("@VALOR", SqlDbType.VarChar).Value = obj.Valor;
            dalConexao.ComandoSql.Parameters.Add("@PAGO", SqlDbType.VarChar).Value = obj.Pago;
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

        public void Excluir(clsCusto obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOCUSTO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 2;
            dalConexao.ComandoSql.Parameters.Add("@IDCUSTO", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@APARTAMENTO", SqlDbType.VarChar).Value = obj.Apartamento;
            dalConexao.ComandoSql.Parameters.Add("@DESCRICAO", SqlDbType.Int).Value = obj.Descricao;
            dalConexao.ComandoSql.Parameters.Add("@DATAVENCIMENTO", SqlDbType.Date).Value = obj.DataVencimento;
            dalConexao.ComandoSql.Parameters.Add("@VALOR", SqlDbType.VarChar).Value = obj.Valor;
            dalConexao.ComandoSql.Parameters.Add("@PAGO", SqlDbType.VarChar).Value = obj.Pago;
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

        public clsCusto PesquisaNome(string pNome)
        {
            throw new NotImplementedException();
        }

        public List<clsCusto> LerRegistros()
        {
            SqlDataReader leitor;
            clsCusto c ;
            List<clsCusto> listaCusto = new List<clsCusto>();
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspCONSULTACUSTO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;
            dalConexao.Conector.Open();
            leitor = dalConexao.ComandoSql.ExecuteReader();
            while (leitor.Read())
            {
                c = new clsCusto();
                c.ID = leitor.GetInt32(0);
                c.DataLancamento= leitor.GetDateTime(1);
                c.Descricao = leitor.GetString(2);
                c.DataVencimento = leitor.GetDateTime(3);
                c.Valor = leitor.GetString(4);
                c.Pago = leitor.GetInt32(5);
                c.Apartamento.ID = leitor.GetInt32(7);
                c.Apartamento.Numero = leitor.GetInt32(8);
                c.Apartamento.Bloco.ID = leitor.GetInt32(9);
                c.Apartamento.Morador.ID = leitor.GetInt32(10);
                listaCusto.Add(c);
            }
            dalConexao.Conector.Close();
            return listaCusto;
        }
    }
}
