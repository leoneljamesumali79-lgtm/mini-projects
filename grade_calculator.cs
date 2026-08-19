using System;

namespace GradeCalculator
{
    class GradeCalculator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int score = Convert.ToInt32(Console.ReadLine());

            if (score >= 90)
            {
                Console.WriteLine("Grade: A");

            }
            else if(score <= 89)
            {
                Console.WriteLine("Grade: B");
            }
        }
    }
}