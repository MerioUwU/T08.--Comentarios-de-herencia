using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            RepoBank r = new RepoBank();//instancia del repo, donde se hace todo el jale
            r.Principal();//llamado del metodo, todo lo que necesitas en el main
        }
    }
}
