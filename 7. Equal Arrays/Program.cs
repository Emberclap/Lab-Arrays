using System;

namespace _7._Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOne = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] arrayTwo = Console.ReadLine().Split().Select(int.Parse).ToArray();
            bool notEqual = false;
            int sum = 0;
            for (int i = 0; i < arrayOne.Length; i++)
            {
               if (arrayOne[i] != arrayTwo[i])
               {
                   Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                   notEqual = true;
                   break;
               }
               sum += arrayOne[i];
            }
            if (notEqual == false)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}