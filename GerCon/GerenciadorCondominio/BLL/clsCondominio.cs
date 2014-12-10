using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class clsCondominio:clsID
    {
        public String Nome { set; get; }
        public String Endereco { set; get; }
        public clsMorador Sindico { set; get; }
    }
}
