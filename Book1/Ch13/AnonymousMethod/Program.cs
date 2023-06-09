﻿/*
2023/07/01 // 익명 메소드 예시

실행 결과
Sorting ascending...
2 3 4 7 10
Sorting descending...
11 10 8 7 2
 */
namespace AnonymousMethod
{
    delegate int Compare(int a, int b);

    internal class Program
    {
        static void BubbleSort(int[] Dataset, Compare Comparer)
        {
            int i, j, temp = 0;

            for (i = 0; i < Dataset.Length - 1; i++)
            {
                for (j = 0; j < Dataset.Length - (i + 1); j++)
                {
                    if (Comparer(Dataset[j], Dataset[j + 1]) > 0)
                    {
                        temp = Dataset[j + 1];
                        Dataset[j + 1] = Dataset[j];
                        Dataset[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbleSort(array, delegate (int a, int b)
            {
                if (a > b)
                    return 1;
                else if (a == b)
                    return 0;
                else return -1;
            });

            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]} ");

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("\nSorting descending...");
            BubbleSort(array2, delegate (int a, int b)
            {
                if (a < b) return 1;
                else if (a == b) return 0;
                else return -1;
            });

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]} ");

            Console.WriteLine();
        }
    }
}