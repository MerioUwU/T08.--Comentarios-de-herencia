using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class SavingsAccount:Account//herencia de clase padre
    {
        public DateTime Expiration { get; set; }//fecha de expiracion, atributo agregado
    }
}
