using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz1
{
    class Matriz1
    {
        private int[,] mat;
        
        public void Cargar()
        {
            mat = new int[3, 5];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write("Ingrese componente: ");
                    string linea;
                    linea = Console.ReadLine();
                    mat[f,c] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for(int f = 0;f < 3; f++)
            {
                for (int c = 0;c < 5; c++)
                {
                    Console.Write(mat[f,c]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            Matriz1 ma = new Matriz1();
            ma.Cargar();
            ma.Imprimir();
        }
    }
}
