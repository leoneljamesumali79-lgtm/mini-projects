using System;

namespace DayOfTheWeek
{
    class Week
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int day = Convert.ToInt32(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Day: Monday");
                    break;
                case 2:
                    Console.WriteLine("Day: Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Day: Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Day: Thursday");
                    break;
                case 5:
                    Console.WriteLine("Day: Friday");
                    break;
                case 6:
                    Console.WriteLine("Day: Saturday");
                    break;
                default:
                    Console.WriteLine("Day: Sunday");
                    break;
                

            }
            
        }
    }
}