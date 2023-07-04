/*
2023/07/04 // 람다식 예시

실행 결과
3 + 4 : 7
 */
namespace SimpleLambda
{
    internal class Program
    {
        // delegate 대리자 선언
        delegate int Calculate(int a, int b);

        static void Main(string[] args)
        {
            Calculate calc = (a, b) => a + b;

            Console.WriteLine($"{3} + {4} : {calc(3, 4)}");
        }
    }
}