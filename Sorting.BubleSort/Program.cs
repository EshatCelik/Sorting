using System;

namespace Sorting.BubleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 5, 2, 11, 6, 7, 4, 8, 33,1 };
           //               { 2, 5, 3, 11, 6, 7, 4, 8, 33 };
           //               { 2, 3, 5, 11, 6, 7, 4, 8, 33 };
           //               { 2, 3, 4, 11, 6, 7, 5, 8, 33 };
           //               { 2, 3, 4, 11, 6, 7, 5, 8, 33 };


            for (int i = 0; i < numbers.Length-1; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;

                    }
                }
            }

            Console.WriteLine(string.Join(",",numbers));

            Console.ReadLine();

        }
    }
}
