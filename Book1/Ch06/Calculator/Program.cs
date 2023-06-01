/*
2023/05/30 // 심규영 // 메소드 예제
 */
namespace Calculator
{
    class Calculator
    {
        public static int Plus (int a, int b)
        {
            return a + b;
        }

        public static int Minus (int a, int b)
        {
            return a - b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Calculator.Plus(3, 4);
            Console.WriteLine(result); // 7

            result = Calculator.Minus(5, 2);
            Console.WriteLine(result); // 3
        }
    }
}