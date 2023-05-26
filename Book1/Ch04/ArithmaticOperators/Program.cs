/*
 * 2023/05/26 // 심규영 // 산술 연산자
 */
namespace ArithmaticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 111 + 222;
            Console.WriteLine($"a : {a}"); // a : 333

            int b = a - 100;
            Console.WriteLine($"b : {b}"); // b : 233

            int c = b * 10;
            Console.WriteLine($"c : {c}"); // c : 2330

            double d = c / 6.3;
            Console.WriteLine($"d : {d}"); // d : 369.8412698412699

            Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7})"); // 22 / 7 = 3(1)
        }
    }
}