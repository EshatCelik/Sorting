using System;

namespace Sorting.SelectionSort
{
    public class Program
    {

        /*
         * Listedeki en küçük olanı başa alacağız 
         * Kısaca ilk başta bir elemanı bulup değer elemanlar ile kıyaslayacağız
         * En küçüğünü en başa alacağız
        */


        static void Main(string[] args)
        {
            int[] numbers = { 9, 3, 6, 8, 2, 4, 0, 5, 7, 1 };
            string[] names = { "Ahmet", "Ayşe", "Ali", "Zekiye", "Murat" };

            SelectionSort(numbers);
            Console.WriteLine(string.Join(", ", numbers));

            SelectionSort(names);

            Console.WriteLine(string.Join(", ", names));

            Console.ReadLine();
        }

        static void SelectionSort<T>(T[] array) where T : IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                var minValue = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minValue])<0)
                    {
                        minValue = j;
                    }                   
                }

                var temp = array[i];
                array[i] = array[minValue];
                array[minValue] = temp;
            }
        }
    }
}
