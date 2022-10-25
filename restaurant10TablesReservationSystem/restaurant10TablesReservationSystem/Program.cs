using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant10TablesReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[10]{ "1", "2", "3", "4", "5", "6", "7", "8", "9", "" };
            int arrayCurrentIndex = 9;
            bool userType;

            Console.WriteLine("Wolcome to the best restaurant in the world!");
           
            while(arrayCurrentIndex < 10)
            {
                Console.WriteLine("\n \n Are you registered user? write true, or write false to register");
                    userType = Convert.ToBoolean(Console.ReadLine());
                    if(userType == true)
                    {
                        Console.WriteLine("Hello, you are registered user");
                        string userTosearch = Console.ReadLine();
                        Console.WriteLine("The user you searched is  {0}", userTosearch);
                        int index = Array.IndexOf(userNames, userTosearch);
                        if (index == -1)
                        {
                            Console.WriteLine("User not found, try again or registered");
                        }
                        else
                        {
                            Console.WriteLine("Welcome {0}, it`s a pleasure to give you food", userNames[index]);
                        }
                    }
                    else if(userType == false)
                    {
                    Console.WriteLine("Please write and remember your user name");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("Your User has ben saved succesfully\n" +
                        "your User Name is {0}", userNames[arrayCurrentIndex]);
                    arrayCurrentIndex++;
                     Console.WriteLine("Clients: {0} ", arrayCurrentIndex);
                    }
            }
            Console.WriteLine("The restaurant is full, try again next day");
            Console.ReadLine();
            Environment.Exit(0);
           
        }
    }
}
