using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class clsCusto:clsID
    {
        public DateTime DataLancamento { set; get; }
        public String Descricao { set; get; }
        public DateTime DataVencimento { set; get; }
        public String Valor { set; get; }
        public Int32 Pago { set; get; }
        public clsApartamento Apartamento { set; get; }

    }
}
