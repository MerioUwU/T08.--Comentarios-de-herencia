using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class DataAccount
    {
        public List<PensionAccount> pensions()//creas metodo lista, sera lo mismo para las otras dos, metodo para cada clase de cuenta
        {
            List<PensionAccount> pensions = new List<PensionAccount>();//creas lista aqui, ya que arriba solo eliges el tipo de dato, ahora solo crea 5 objetos con todos los atributos llenos
            pensions.Add(new PensionAccount { Expiration = new DateTime(2024, 08, 30), HeadLine = "Mario Silva", Balance = 1234.34m, Interest = 12.3434, AccNo = 12345, Quotation = 500, NoAccountPrincipal = 12341234 });//Llenar una linea en chinga
            pensions.Add(new PensionAccount { Expiration = new DateTime(2024, 07, 29), HeadLine = "Izary Jimenez", Balance = 1232344.23m, Interest = 2143, AccNo = 23456, Quotation = 500, NoAccountPrincipal = 231231234 });
            pensions.Add(new PensionAccount { Expiration = new DateTime(2024, 06, 28), HeadLine = "Mario Obregon", Balance = 314.40m, Interest = 1234, AccNo = 34567, Quotation = 500, NoAccountPrincipal = 1234123413 });
            pensions.Add(new PensionAccount { Expiration = new DateTime(2024, 05, 27), HeadLine = "Izael Silva", Balance = 98328754.32m, Interest = 12.3434, AccNo= 45678, Quotation = 500, NoAccountPrincipal = 123412342 });
            pensions.Add(new PensionAccount { Expiration = new DateTime(2024, 04, 26), HeadLine = "Kenneth Castaneda", Balance = 123434124.32m, Interest = 187634, AccNo= 56789, Quotation = 500, NoAccountPrincipal = 12341234 });
            return pensions;//envias la lista creada a donde llamen el metodo
        }
        public List<SavingsAccount> savings()//same as above
        {
            List<SavingsAccount> savings = new List<SavingsAccount>();
            savings.Add(new SavingsAccount { Expiration = new DateTime(2025, 01, 01), HeadLine = "Byron Ayala", Balance = 123.45m, Interest = 12.3, AccNo = 67890});
            savings.Add(new SavingsAccount { Expiration = new DateTime(2024, 02, 02), HeadLine = "Marco Melgar", Balance = 234.56m, Interest = 23.4, AccNo = 78901 });
            savings.Add(new SavingsAccount { Expiration = new DateTime(2023, 03, 03), HeadLine = "Frida Salcido", Balance = 345.67m, Interest = 34.5, AccNo = 89012 });
            savings.Add(new SavingsAccount { Expiration = new DateTime(2022, 04, 04), HeadLine = "Aram Guzman", Balance = 456.78m, Interest = 45.6, AccNo = 90123});
            savings.Add(new SavingsAccount { Expiration = new DateTime(2021, 05, 05), HeadLine = "Josa Yanez", Balance = 567.89m, Interest = 56.7, AccNo = 01234});
            return savings;
        }
        public List<CurrentAccount> current()//same as above
        {
            List<CurrentAccount> current = new List<CurrentAccount>();
            current.Add(new CurrentAccount { HeadLine = "Isaias Paniagua", Balance = 100m, Interest = 15, AccNo = 54321 });
            current.Add(new CurrentAccount { HeadLine = "Alan Garcia", Balance = 700m, Interest = 15, AccNo = 65432 });
            current.Add(new CurrentAccount { HeadLine = "Vicente Cazares", Balance = 300m, Interest = 14, AccNo = 76543 });
            current.Add(new CurrentAccount { HeadLine = "Miguel Gonzales", Balance = 90m, Interest = 32, AccNo = 87654 });
            current.Add(new CurrentAccount { HeadLine = "Juan Pithaya", Balance = 666m, Interest = 66, AccNo = 98765 });
            return current;
        }
    }
}
