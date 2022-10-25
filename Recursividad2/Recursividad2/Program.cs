using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad2
{
    public class Recursividad
    {

        void Imprimir(int x)
        {
            Console.Write(x + " ");
            Imprimir(x - 1);
        }

        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            re.Imprimir(5);
        }
    }
}
