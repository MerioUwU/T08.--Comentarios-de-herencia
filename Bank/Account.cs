using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account//cuenta padre, de aqui se van los metodos
    {
        public int AccNo { get; set; }//numero de cuenta
        public string HeadLine { get; set; }//nombre del dueno
        public decimal Balance { get; set; }//dinero que tiene la cuenta
        public double Interest { get; set; }//intereses que el banco mete

        public bool Income()
        {
            return false;
        }
        public double MonthInterest(Account account)//checas el interes mensual con una operacion
        {
            var iTotal = account.Interest / 100 * Convert.ToDouble(account.Balance);//convierte balance a double para poder operar
            return iTotal;//devuelves un solo valor en decimal, se despliega en el menu cuenta
        }
        public void BalanceCheck(Account account)
        {

            Console.WriteLine("El saldo Actual de su cuenta es: ${0}",account.Balance);//splo pides un dato del objeto que trabajas en accout number
            Console.ReadKey();//enter pa seguir 
        }
        public Account Transfer()
        {

        }
    }
}
