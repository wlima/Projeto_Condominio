using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public abstract class clsPessoa:clsID
    {
        public String Nome { set; get;}
        public String CPF { set; get; }
        public String RG { set; get; }
    }
}
