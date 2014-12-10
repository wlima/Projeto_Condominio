/*Interface padrão da regra de negocio tratando as ações que serão realizadas na base de dados*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface iDAL<O>
    {
        //Metódo responsavél por fazer uma inserção no banco
        void Inserir(O Obj);
        //Metódo responsavél por fazer uma alteração no registro especifico no banco
        void Alterar(O obj);
        //Metódo responsavél por fazer uma exclusão do registro especifico no banco
        void Excluir(O obj);        
        //Metódo responsavél por fazer uma busca na base de dados pelo campo nome do registro
        O PesquisaNome(String pNome);
        //Metódo responsavél por carregar todos os registros da base de dados
        List<O> LerRegistros();
    }
}
