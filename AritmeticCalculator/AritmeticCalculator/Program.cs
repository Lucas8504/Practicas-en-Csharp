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

                switch (operation)
                {

                case 1:
                    //suma
                    firsData = GetIntegerDataFromUser("Proporciona el primer operando, debe ser entero:");
                    secondData = GetIntegerDataFromUser("Proporciona el segundo operando, debe ser entero:");
                    Console.WriteLine($"El resultado de {firsData} + {secondData} = {firsData + secondData}");
                    break;


                case 2:
                    //Resta
                    firsData = GetIntegerDataFromUser("proporciona el primer operando, debe ser entero:");
                    secondData = GetIntegerDataFromUser("Proporciona el segundo operdando, debe ser entero");
                    Console.WriteLine($"El resultado de {firsData} + {secondData} = {firsData - secondData}");
                    break;
                default:
                    Console.WriteLine("la opcion seleccionada no existe.");
                    break;


                }

            Console.WriteLine("Precione cualquier tecla para salir...");
            Console.Read();

            } 
            
            private static int GetIntegerDataFromUser(string message)
            {
            string userData;
            int data = 0;            bool isDataValid = false;
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
