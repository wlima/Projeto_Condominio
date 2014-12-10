/*Classe da camada de negocio que trata a interação da aplicacação com a base de 
 dados cuidando da conexão fazendo a abertura e o fechamento*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DAL
{
    class dalConexao
    {
       // public static String strConexao =@"Data Source=LocalHost\SQLEXPRESS; Initial Catalog=dbGerCon; User Id=sa; Password=@rtur10Mike11;";
        public static String strConexao = @"Data Source=NOTBOOK;Initial Catalog=dbGerCon; Integrated Security=True;";
        public static SqlCommand ComandoSql{set;get;}
        public static SqlConnection Conector{get;set;}
    }
}
