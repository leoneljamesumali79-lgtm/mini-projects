using System;

namespace Program
{
    class SortNum
    {
        static void Main()
        {
            int[] nums = {45, 12, 89, 23, 5, 67};
            foreach (int n in nums)
            {
                Console.WriteLine(n);
            }
            
            Array.Sort(nums);
            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }
        }
    }
}