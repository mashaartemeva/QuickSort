using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    public class ClassSort
    {
        public static void QuickSort(int[] array)
        {
            if (array is null) return;
            QuickSort(array, 0, array.Length - 1);
        }
        public static void QuickSort(int[] array, int first, int last)
        {
            int p = array[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (array[i] < p && i <= last) ++i;
                while (array[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) QuickSort(array, first, j);
            if (i < last) QuickSort(array, i, last);
        }
        static void Main()
        {

            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 5);
                Console.WriteLine(array[i]);
            }
            QuickSort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
        static Random random = new Random();

    }
}
