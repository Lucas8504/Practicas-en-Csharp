using System;

namespace Calificaciones
{
    class Calificaciones
    {

        public static void Main(string[] args)
        {
            int notas, x, aprobados, desaprobados;
            x = 1;
            aprobados = 0;
            desaprobados = 0;

            while (x <= 10)
            {
                x++;
                Console.WriteLine("Ingrese nota: ");
                notas = int.Parse(Console.ReadLine());
                if (notas >= 7)
                {
                    aprobados = aprobados + 1;
                    
                }
                else
                {
                    desaprobados = desaprobados + 1;
                    
                }

            }
            Console.WriteLine("");
            Console.WriteLine("Los aprobados son: ");
            Console.WriteLine(aprobados);
            Console.WriteLine("Los burros son: ");
            Console.WriteLine(desaprobados);

        }
    }

}
