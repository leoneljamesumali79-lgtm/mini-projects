using System;

namespace Calculator
{
    class SimpleCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double firstNum = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            double secondNum = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            switch (op)
            {
                case '+':
                    Console.WriteLine($"Result: {firstNum + secondNum}");
                    break;

                case '-':
                    Console.WriteLine($"Result: {firstNum - secondNum}");
                    break;

                case '*':
                    Console.WriteLine($"Result: {firstNum * secondNum}");
                    break;

                case '/':
                    if (secondNum != 0)
                    {
                        Console.WriteLine($"Result: {firstNum / secondNum}");
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is undefined.");
                    }
                    break;

                default:
                    Console.WriteLine("Error: Invalid operator entered.");
                    break;
            }
        }
    }
}