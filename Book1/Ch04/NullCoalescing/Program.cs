/*
 * 2023/05/26 // 심규영 // Null 병합 연산자
 */
namespace NullCoalescing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num = null;
            Console.WriteLine($"{num ?? 0}");
            // 0

            num = 99;
            Console.WriteLine($"{num ?? 0}");
            // 99

            string str = null;
            Console.WriteLine($"{str ?? "Default"}");
            // Default

            str = "Specific";
            Console.WriteLine($"{str ?? "Default"}");
            // Specific
        }
    }
}