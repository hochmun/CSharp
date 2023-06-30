﻿/*
2023/06/28 // 심규영 // 가변 배열 예제

실행 결과
Length : 5, 12345
Length : 3, 102030
Length : 2, 100200

Length : 2, 1000 2000
Length : 4, 6 7 8 9
 */
namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged = new int[3][];
            jagged[0] = new int[5] { 1, 2, 3, 4, 5 };
            jagged[1] = new int[] { 10, 20, 30 };
            jagged[2] = new int[] { 100, 200 };

            foreach (int[] arr in jagged)
            {
                Console.Write($"Length : {arr.Length}, ");
                foreach (int e in arr) Console.Write($"{e}");
                Console.WriteLine("");
            }

            Console.WriteLine("");

            int[][] jagged2 = new int[2][]
            {
                new int[] { 1000, 2000},
                new int[] { 6, 7, 8, 9 }
            };

            foreach (int[] arr in jagged2)
            {
                Console.Write($"Length : {arr.Length}, ");
                foreach (int e in arr) Console.Write($"{e} ");
                Console.WriteLine();
            }
        }
    }
}