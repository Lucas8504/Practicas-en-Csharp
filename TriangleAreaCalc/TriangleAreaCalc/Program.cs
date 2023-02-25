using System;

namespace TriangleAreaCalculator
{
    class program
    {
        static void Main(string[] args)
        {
            string userData;
            string userData2;
            double width;
            double height;
            double TriangleArea;


            Console.WriteLine("Calculadora de area en triangulo");
            Console.WriteLine(@"  /\ ");
            Console.WriteLine(@" /  \");
            Console.WriteLine(@"/____\");

            Console.WriteLine("Proporciona la base de tu triangulo");
            userData = Console.ReadLine();

            Console.WriteLine("proporciona la altura de tu triangulo");
            userData2 = Console.ReadLine();


            if (double.TryParse(userData, out width) && double.TryParse(userData2, out height))
            {
                TriangleArea = (width * height) / 2 ;
                Console.WriteLine($"El area de tu triangulo es: {TriangleArea}");
            }
            else
            {
                Console.WriteLine("los datos proporcionaos no son correctos");
                Console.ReadKey();

            }

        }

    }

}

