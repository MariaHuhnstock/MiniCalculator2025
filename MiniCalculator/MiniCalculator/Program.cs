using System;

namespace MyApp
{
    internal class MiniCalculator
    {
        static void Main(string[] args)
        {
            // Task: Create a simple calculator that can add, subtract, or multiply two numbers based on user input.

            // Get calculation method from user
            Console.WriteLine("Choose calculation method: add, sub, mul");
            string method = Console.ReadLine();

            // Get two numbers from user
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Initialize result variable
            int result = 0;

            // Perform calculation based on selected method
            switch (method)
            {
                case "add":
                    result = (num1 + num2);
                    Console.WriteLine("Result: " + result);
                    break;

                case "sub":
                    result = (num1 - num2);
                    Console.WriteLine("Result: " + result);
                    break;

                case "mul":
                    result = (num1 * num2);
                    Console.WriteLine("Result: " + result);
                    break;
                default:
                    Console.WriteLine("Invalid method selected.");
                    break;
            }
        }
    }
}