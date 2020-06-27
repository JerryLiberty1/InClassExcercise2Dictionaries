using System;
using System.Diagnostics;

namespace InClassExcercise2Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // parsing to specific data types      
            int[] x = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Please enter a number ");

                string userInput = Console.ReadLine();
                int inputNumber = Convert.ToInt32(userInput);
                x[i] = inputNumber;
                Console.WriteLine(i);
            }
            Console.WriteLine("Please give me a final number ");
            string userInput2 = Console.ReadLine();
            int userInput3 = Convert.ToInt32(userInput2);
            for (int i = 0; i < 10; i++)
            {
                if (userInput3 == x[i])

                {
                    Console.WriteLine("True");
                    break;
                }
            }
        }
    }
}
