using System;
using System.Linq;

namespace Progam
{
    class HighestScore
    {
        static void Main()
        {
            int[] score = {85, 92, 78, 95, 88};
            Console.WriteLine("Scores:");
            foreach(int i in score)
            {
                
                Console.WriteLine(i + " ");
            }

            Console.Write("Highest Score: ");
            Console.WriteLine(score.Max());
            
        }
    }
}