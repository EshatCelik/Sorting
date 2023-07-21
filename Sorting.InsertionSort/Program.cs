using System;

namespace Sorting.InsertionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 3, 6, 8, 2, 4, 0, 5, 7, 1 };
            //         1-   { 3, 9, 6, 8, 2, 4, 0, 5, 7, 1 };
            //              { 3, 6, 9, 8, 2, 4, 0, 5, 7, 1 };
            //              { 3, 6, 8, 9, 2, 4, 0, 5, 7, 1 };
            //              { 3, 6, 8, 2, 9, 4, 0, 5, 7, 1 };
            InsertionSort(numbers);
            Console.WriteLine(string.Join(",", numbers));



            string[] names = { "Ahmet", "Ayşe", "Ali", "Zekiye", "Murat" };
        }

        static void InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                try
                {
                    int bas = array[i];
                    int son = array[i + 1];
                    int j = i + 1;
                    int index = i;


                    while (j >= 0 && array[j] < array[i])
                    {
                        var temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        j--;
                        i--;
                    }
                    i = index;
                }
                catch
                {

                }

            }
        }
    }
}
