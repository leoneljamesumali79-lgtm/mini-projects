using System;

namespace Program
{
    class CountEvenNumbers
    {
        static void Main()
        {
            int[] numbers = {12, 7, 4, 9, 10, 15, 6, 3, 8, 11};
            Console.WriteLine("Numbers:");
            int even = 0;
            foreach(int i in numbers)
            {
                Console.WriteLine(i + " ");

                if (i % 2 == 0)
            {
                even++;
            }
            }

            

            Console.Write("\nHighest Score: ");
            Console.WriteLine(even);
        }
    }
}