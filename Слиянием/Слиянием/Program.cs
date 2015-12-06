using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Слиянием
{
    class Program
    {
        private static int count;
        static int[] GetRandomArr(int len)
        {
            Random r = new Random();
            int[] a = new int[len];
            for (int i = 0; i < a.Length; i++)
                a[i] = r.Next(0, 10);
            return a;
        }
        static int[] GetAscArr(int len)
        {
            int[] a = new int[len];
            for (int i = 0; i < a.Length; i++)
                a[i] = i;
            return a;
        }
        static int[] GetDescArr(int len)
        {
            int[] a = new int[len];
            for (int i = a.Length - 1, j = 0; j < a.Length; j++, i--)
                a[j] = i;
            return a;
        }
        static void Main(string[] args)
        {
            Console.Write("N = ");
            int len = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[] {6, 5, 3, 1, 8, 7, 2, 4 };
            Array.ForEach(a, (x) => Console.Write(x + " "));
            Console.WriteLine();

            count = 0;
            a = MergeSort(a);

            Console.WriteLine();
            Array.ForEach(a, (x) => Console.Write(x + " "));
            Console.WriteLine("\n\nКоличество сравнений = {0}", count);
            Console.ReadKey();
        }
        private static int[] MergeSort(int[] a)
        {
            if (a.Length == 1)
                return a;
            int mid = a.Length / 2;
            return Merge(MergeSort(a.Take(mid).ToArray()), MergeSort(a.Skip(mid).ToArray()));
        }
        private static int[] Merge(int[] arr1, int[] arr2)
        {
            int a = 0, b = 0;
            int[] merged = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length + arr2.Length; i++)
            {
                if (b < arr2.Length && a < arr1.Length)
                {
                    count++; //

                    if (arr2[b] < arr1[a])
                    {
                        merged[i] = arr2[b++];
                    }
                    else
                    {
                        merged[i] = arr1[a++];
                    }
                }
                else
                {
                    if (b < arr2.Length)
                    {
                        merged[i] = arr2[b++];
                    }
                    else
                    {
                        merged[i] = arr1[a++];
                    }
                }
            }
            return merged;
        }
    }
}
