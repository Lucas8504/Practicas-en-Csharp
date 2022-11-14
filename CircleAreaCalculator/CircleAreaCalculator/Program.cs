using System;

namespace CircleAreaCalculator
{
    class program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;
            string userData;
            double radius;
            double circleArea;

            Console.WriteLine("proporciona el radio de tu circulo");
            userData = Console.ReadLine();

            if (double.TryParse(userData, out radius))
            {
                circleArea = PI * Math.Pow(radius, 2);
                Console.WriteLine($"El area de tu circulo es: {circleArea}");
            }
            else
            {
                Console.WriteLine("los datos proporcionaos no son correctos");
                Console.ReadKey();

            }

        }

    }

}
