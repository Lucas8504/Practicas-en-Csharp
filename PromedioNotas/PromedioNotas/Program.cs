using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromedioNotas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, promedio;

            Console.WriteLine("Ingrese calificacion 1: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese calificacion 2: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese calificacion 3: ");
            nota3 = int.Parse(Console.ReadLine());

            promedio = nota1 + nota2 + nota3 /3;

            if (promedio > 10)
                {
                    promedio = 10;
                }

            Console.WriteLine("Su promedio es: " + promedio);

            
            if (promedio >= 7)
            {
                Console.WriteLine("Su promedio es excelente, Felicitaciones!!");
            }

            else
            {
                Console.WriteLine("Su nota no es aprobable, debe mejorar");
            }


        }
    }
}
