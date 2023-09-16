using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the low number
            Console.Write("Enter the low number: ");
            int low = GetIntegerInput();

            // Prompt the user to enter the high number
            Console.Write("Enter the high number: ");
            int high = GetIntegerInput();

            // Calculate difference between low and high
            int difference = high - low;

            // Print the difference
            Console.WriteLine($"The difference between {low} and {high} is: {difference}");

            
            Console.ReadLine();
        }

        // in order to get integer input from the user with validation
        static int GetIntegerInput()
        {
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput))
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                Console.Write("Enter a valid number: ");
            }
            return userInput;
        }
    }
}
