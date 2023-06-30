/*
2023/06/30 // 예외에 대하여 예제

실행 결과
1
2
3
Unhandled exception. System.IndexOutOfRangeException: Index was outside the bounds of the array.
   at KillingProgram.Program.Main(String[] args) in D:\eclipse-workspace\C#\Book1\Ch12\KillingProgram\Program.cs:line 10

 */
namespace KillingProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            for (int i = 0; i < 5; i++)
                Console.WriteLine(arr[i]);

            Console.WriteLine("종료");
        }
    }
}