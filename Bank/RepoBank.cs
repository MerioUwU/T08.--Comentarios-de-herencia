using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class RepoBank
    {
        DataAccount data;//objeto global para trabajarlo en todos lados
        public RepoBank()
        {
            data = new DataAccount();//constructor para poder traer todas las listas al repositorio con la instancia, asi trabajarlas sin tener que hacer instancia de esta en cada metodo
        }
        internal void Principal()
        {
            Console.WriteLine("Quihubole bergas, dale algo para entrar al menu");//saludo, esto es lo que llama el main
            Console.ReadKey();//dale enter para acceder al menu, clasico y util para darle seguimiento
            Console.Clear();//limpia y sigue
            Menu();
        }
        private void Menu()
        {
            Console.WriteLine("Seleccione con un numero el area a accesar: \n\n1.-Cuentas de Ahorro\n2.-Pensiones\n3.-Cuentas Corrientes");//menu para accesar a una cuenta especifica
            switch (int.Parse(Console.ReadLine()))//switch para elegir, capturas el numero directamente sin crear variable
            {
                case 1://acceso a un metodo para capturar informacion de la cuenta
                    Console.WriteLine("Bienvenido a Cuentas de Ahorro");//saludp
                    GetDataSavings();//el acceso al metodo, igual para las otras 2 opciones
                    break;
                case 2:
                    Console.WriteLine("Bienvenido a Pensiones");
                    GetDataPension();
                    break;
                case 3:
                    Console.WriteLine("Bienvenido a Cuenta Corriente");
                    GetDataCurrent();
                    break;
                default:
                    Console.WriteLine("Seleccione una opcion valida por favor");//por si la opcion no es valida, devuelve al usuario al menu
                    Console.ReadLine();
                    Console.Clear();
                    Menu();
                    break;
            }
        }
        private int GetData()//capturas numero en un solo metodo para usarlo en los 3 metodos diferentes que te pide
        {
            Console.WriteLine("Ingrese su numero de cuenta");
            string res = Console.ReadLine();//inicializas y capturas string
            return Convert.ToInt32(res);//mandas el string pero convirtiendolo en int porque el atributo accno es int
        }
        private void GetDataCurrent()//metodo para capturar cuenta corriente
        {
            int number = GetData();//llamas metodo get data, asi no escribes tanto 
            var list = data.current();//creas una lista usando la instancia del constructor y el objeto creado global
            CurrentAccount current = new CurrentAccount();//instancia de objeto para acceder a el
            foreach (var account in list)//for each para convertir el numero que el usuario digito en un objeto de la lista traida
            {
                if (number == account.AccNo)//solo funcionara si el numero existe en las listas
                {
                    current = account;//cuando se cumple la condicion se crea el objeto
                }
            }
            Console.WriteLine("Bienvenido, {0}",current.HeadLine);//se trabaja con el objeto instanciado porque ya esta unificado con account
            Console.ReadKey();//dale enter pa seguir
            Console.Clear();//limpia pantalla despues de cada metodo, sera mucho texto si no lo haces
            MenuUser(current);//mandas current al metodo menu usuario con el objeto current, usaste el foreach para este objeto en especifico
        }
        private void GetDataPension()//igual que arriba
        {
            int number = GetData();//usas el metodo get data para no escribir tanto
            var list = data.pensions();//creas una lista con ayuda del objeto global, usando el metodo de pensions porque estamos trabajando con pensioens
            PensionAccount pension = new PensionAccount();//instancia pensions para la fusion de objeto
            foreach (var account in list)//for each para solo trabajar con objetos existentes en las listas
            {
                if (number == account.AccNo)//condicion para fusionar o no las listas
                {
                    pension = account;//momento en el que las slistas significan lo mismo
                }
            }
            Console.WriteLine("Bienvenido, {0}!",pension.HeadLine);//saludo, trabajas con pension instanciada porque es lo mismo que la info que creamos en le foreach
            Console.ReadKey();//dale enter pa seguir
            Console.Clear();//limpia pantalla para no llenar de texto que no usas
            MenuUser(pension);//accedes al menu de usuario, mandando el objeto pensiones que jalaste de la lista con el foreach
        }
        private void MenuUser(Account account)//menu usuario, recibiendo el objeto de uno de los 3 metodos, usando la llave de sobrecarga de enviar un solo objeto
        {
            Console.WriteLine("Bienvenido a su cuenta, {0}",account.HeadLine);//saludas con el nombre del usuario trabajado
            Console.WriteLine("Seleccione con el numero asignado la accion a realizar: \n1.-Consultar Saldo\n2.-Transferir\n3.-Interes por mes\n4.-Ingreso");//menu, trabajas con cuatro opciones donde todos los metodos estan dentro de la clase cuenta
            switch (int.Parse(Console.ReadLine()))//otro switch sin crear variable
            {
                case 1://caso de chequedo del balance de la cuenta
                    account.BalanceCheck(account);//se manda el objeto pension current o savings, pero se trabaja uno del os metodos que account le mando, ya que al ser hija recibe lso metodos igual
                    break;
                case 2:
                    break;
                case 3:
                    Console.WriteLine("El interes generado es {0}",account.MonthInterest(account));//llamas al metodo dentro account que es de interes por mes
                    Console.ReadLine();
                    break;
                case 4:
                    break;
                default:
                    break;
            }
        }
        private void GetDataSavings()//same as above, metodo para trabajar con cuenta de ahorros
        {
            int number = GetData();//usas el getdata para capturar numero
            var list = data.savings();//traes lista con la instancia global del ctor
            SavingsAccount savings = new SavingsAccount();//instancias savings para acceder a los atributos
            foreach(var account in list)//foreach para seleccionar cuenta especifica
            {
                if (number == account.AccNo)//condicion para fusionar la cuenta que el usuario pone con el objeto con el atributo accno que sea igual
                {
                    savings = account;//aqui se fusionan el objeto con le numero digitado
                }
            }
            Console.WriteLine("Bienvenido, {0}",savings.HeadLine);//le dices hola y lo mandas al menu usuario abajo
            Console.ReadKey();//dale enter pa seguir
            Console.Clear();//limpia tu pantalla porfi, esta muy cochino todo el texto encimado
            MenuUser(savings);//accedes al metodo mandando el objeto savings seleccionado con el foreach
        }
    }
}
