using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Recursividad8
{
    public class Recursividad
    {

        public void Leer(string inicio)
        {
            String[] archivos = Directory.GetFiles(inicio);
            Console.WriteLine(inicio + " (Directorio)");
            for (int f = 0; f < archivos.Length; f++)
            {
                Console.WriteLine(archivos[f] + " (Archivo)");
            }
            String[] directorios = Directory.GetDirectories(inicio);
            for (int f = 0; f < directorios.Length; f++)
            {
                Leer(directorios[f]);
            }
        }

        static void Main(string[] args)
        {
            Recursividad rec = new Recursividad();
            rec.Leer("c:\\archivos\\");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
