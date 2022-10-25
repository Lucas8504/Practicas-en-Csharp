using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Recursividad1
{
    public class Recursividad
    {

        void Repetir()
        {
            Repetir();
        }

        static void Main(string[] args)
        {
            Recursividad re = new Recursividad();
            re.Repetir();
        }

    }
}