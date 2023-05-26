using System.Globalization;

namespace _08._Condense_Array_to_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfIntegers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            

            while (arrayOfIntegers.Length > 0)
            {

                if (arrayOfIntegers.Length == 1)
                {
                    Console.WriteLine(arrayOfIntegers[0]);
                    break;
                }
                int[] condensed = new int[arrayOfIntegers.Length - 1];
                
                for (int i = 0; i < arrayOfIntegers.Length - 1; i++)
                {
                    condensed[i] = arrayOfIntegers[i] + arrayOfIntegers[i + 1];
                    arrayOfIntegers[i] = condensed[i];
                }
                arrayOfIntegers = condensed;
                
            }
            

        }
    }
}