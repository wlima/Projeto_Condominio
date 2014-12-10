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
    class dalBloco:iDAL<clsBloco>
    {
        public void Inserir(clsBloco obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOBLOCO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 0;
            dalConexao.ComandoSql.Parameters.Add("@IDBLOCO", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = obj.Descricao;
            dalConexao.ComandoSql.Parameters.Add("@CONDOMINIO", SqlDbType.Int).Value = obj.Condominio.ID;            
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

        public void Alterar(clsBloco obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOBLOCO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 1;
            dalConexao.ComandoSql.Parameters.Add("@IDBLOCO", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = obj.Descricao;
            dalConexao.ComandoSql.Parameters.Add("@CONDOMINIO", SqlDbType.Int).Value = obj.Condominio.ID;
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

        public void Excluir(clsBloco obj)
        {
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspACAOBLOCO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;

            dalConexao.ComandoSql.Parameters.Add("@ACAO", SqlDbType.Int).Value = 2;
            dalConexao.ComandoSql.Parameters.Add("@IDBLOCO", SqlDbType.Int).Value = obj.ID;
            dalConexao.ComandoSql.Parameters.Add("@DESCRICAO", SqlDbType.VarChar).Value = obj.Descricao;
            dalConexao.ComandoSql.Parameters.Add("@CONDOMINIO", SqlDbType.Int).Value = obj.Condominio.ID;
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

        public clsBloco PesquisaNome(string pNome)
        {
            throw new NotImplementedException();
        }

        public List<clsBloco> LerRegistros()
        {
            SqlDataReader leitor;
            clsBloco b;
            List<clsBloco> listaBloco= new List<clsBloco>();
            dalConexao.Conector = new SqlConnection(dalConexao.strConexao);
            dalConexao.ComandoSql = new SqlCommand(dalConexao.strConexao, dalConexao.Conector);

            dalConexao.ComandoSql.CommandText = "uspCONSULTABLOCO";
            dalConexao.ComandoSql.CommandType = CommandType.StoredProcedure;
            dalConexao.Conector.Open();
            leitor = dalConexao.ComandoSql.ExecuteReader();
            while (leitor.Read())
            {
                b = new clsBloco();
                b.ID = leitor.GetInt32(0);
                b.Descricao = leitor.GetString(1);                
                b.Condominio.ID = leitor.GetInt32(3);
                listaBloco.Add(b);
            }
            dalConexao.Conector.Close();
            return listaBloco;
        }
    }
}
