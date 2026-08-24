using System;
using System.Runtime.CompilerServices;

namespace GradeDesciption
{
    class GradeDescription
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Grade: ");
            char letter = Convert.ToChar(Console.ReadLine());
            switch (letter)
            {
                case 'A':
                    Console.WriteLine("Performance: Excellent");
                    break;
                case 'B':
                    Console.WriteLine("Performance: Very Good");
                    break;
                case 'C':
                    Console.WriteLine("Performance: Good");
                    break;
                case 'D':
                    Console.WriteLine("Performance: Good");
                    break;
                case 'F':
                    Console.WriteLine("Performance: Failed");
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
                    


            }
        }
    }
}