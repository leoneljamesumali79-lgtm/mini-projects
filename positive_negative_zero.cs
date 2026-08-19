using System;

namespace PositiveNegativeZero
{
    class PositiveNegativeZero
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("Output: Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("Output: Negative");
            }
            else
            {
                Console.WriteLine("Output: Zero");
            }
        }
    }
}