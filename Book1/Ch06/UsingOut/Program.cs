/*
2023/06/01 // 심규영 // 출력 전용 매개 변수 out 예제

실행
a:20, b:3, a/b:6, a%b:2
 */
namespace UsingOut
{
    internal class Program
    {
        static void Divide (int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;

            Divide(a, b, out int c, out int d);

            Console.WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");
        }
    }
}