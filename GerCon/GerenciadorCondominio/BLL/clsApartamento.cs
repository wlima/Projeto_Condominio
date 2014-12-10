using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class clsApartamento:clsID
    {
        public Int32 Numero { set; get; }
        public clsBloco Bloco { set; get; }
        public clsMorador Morador { set; get; }
    }
}
