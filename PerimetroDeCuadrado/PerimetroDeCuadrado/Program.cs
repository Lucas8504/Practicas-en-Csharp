using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimetroDeCuadrado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado;
            int perimetro;
            String linea;
            Console.Write("Ingrese el valor del lado del cuadrado:");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            perimetro = lado + lado + lado + lado;
            Console.Write("El perimetro del cuadrado es:");
            Console.Write(perimetro);
            Console.ReadKey();
        }
    }
}
