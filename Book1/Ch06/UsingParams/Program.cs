/*
2023/06/01 // 심규영 // 가변길이 매개 변수 parmas 사용 예제

실행
Summing...3, 4, 5, 6, 7, 8, 9, 10
Sum : 52
 */
namespace UsingParams
{
    internal class Program
    {
        static int Sum (params int[] args)
        {
            Console.Write("Summing...");

            int sum = 0;

            for(int i = 0; i < args.Length; i++)
            {
                if (i > 0) Console.Write(", ");

                Console.Write(args[i]);

                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 9, 10);

            Console.WriteLine($"Sum : {sum}");
        }
    }
}