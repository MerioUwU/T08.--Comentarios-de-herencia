using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class PensionAccount:Account
    {
        public DateTime Expiration { get; set; }
        public int Quotation { get; set; }
        public int NoAccountPrincipal { get; set; }
    }
}
