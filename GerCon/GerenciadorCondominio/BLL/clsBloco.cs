using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class clsBloco:clsID
    {
        public String Descricao { set; get; }
        public clsCondominio Condominio { set; get; }
    }
}
