using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class PensionAccount:Account//herencia de clase padre
    {
        public DateTime Expiration { get; set; }//atributo extra de expiracion
        public int Quotation { get; set; }//atributo extra de cotizacion
        public int NoAccountPrincipal { get; set; }//atributo extra de cuenta origen
    }
}
