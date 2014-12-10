using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class clsFuncionario:clsPessoa
    {
        public String Cargo { set; get; }
        public String Salario { set; get; }
        private clsCondominio lotacao = new clsCondominio();

        public clsCondominio Lotacao
        {
            get { return lotacao; }
            set { lotacao = value; }
        }



            
    }
}
