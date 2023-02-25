using System;





namespace AritmeticCalculator
    {
        class Program
        {
            static void Main(string[] args)
            {
                int operation;
                int firsData;
                int secondData;

                Console.WriteLine("Biemvenido a tu calculadora");
                Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            operation = GetIntegerDataFromUser("proporciona la operacion que deseas ejecutar:");
            }
            
            private static int GetIntegerDataFromUser(string message)
            {
            string userData;
            int data = 0;
            bool isDataValid = false;
            while(!isDataValid)
            {

                Console.WriteLine(message);
                userData = Console.ReadLine();
                if(!int.TryParse(userData, out data))
                {
                    Console.WriteLine("El dato que proporcionasteno es valido. Vuelve a intentarlo");
                }
                else
                {
                   isDataValid = true;
                }

            }
            return data;

            }
        }
    }
