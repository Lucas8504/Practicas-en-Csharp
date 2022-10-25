using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orden_de_vector
{
    class PruevaVector13
    {
        private int[] sueldos;

        public void Cargar()
        {
            sueldos = new int[7];
            for(int f=0; f < sueldos.Length ; f++)
            {
                Console.WriteLine("Ingrese el sueldo: ");
                string linea = Console.ReadLine();
                sueldos[f] = int.Parse(linea);
            }

        }

        public void Ordenar()
        {
            for (int k = 0; k < sueldos.Length - 1; k++)
            {
                for(int f = 0; f < (sueldos.Length -1) - k; f++)
                {
                    if (sueldos[f] > sueldos[f + 1])
                    {
                        int aux;
                        aux = sueldos[f];
                        sueldos[f] = sueldos[f + 1];
                        sueldos[f + 1] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Sueldos ordenados de menor a mayor.");
            for(int f=0;f< sueldos.Length; f++)
            {
                Console.WriteLine(sueldos[f]);
            }
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            PruevaVector13 pv = new PruevaVector13();
            pv.Cargar();
            pv.Ordenar();
            pv.Imprimir();
        }
    }
}
