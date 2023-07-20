using System;
using System.Collections;
using System.Collections.Generic;

namespace Sorting.BubleSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 3, 5, 2, 11, 6, 7, 4, 8, 33 };

            BubleSort(numbers);
            Console.WriteLine(string.Join(",", numbers));

            Console.ReadLine();

        }

        static void BubleSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j])>0)
                    {
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;

                    }
                }
            }

        }
    }
}
