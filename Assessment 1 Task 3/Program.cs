using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment_1_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];

            // Prompt the user to enter 10 numbers
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    numbers[i] = num;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    i--; // Decrement i to re-prompt for the same index.
                }
            }

            // Modify the values of the array
            for (int i = 0; i < 10; i++)
            {
                numbers[i] /= (i + 1);
            }

            // Print the modified values
            Console.WriteLine("Modified Array:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Value {i + 1}: {numbers[i]}");
                Console.ReadKey();
            }
        }
    }
}