/*
2023/07/04 // Action 대리자 예시

Action 대리자는 Func 대리자와 거의 같다.
Action 대리자는 반환 형식이 없으며 
Func 대리자와 같이 17개 버전이 .NET 프레임워크에서 선언 되어 있다.

실행 결과
Action()
result : 9
Action<T1, T2>(22, 7) : 3.142857142857143
 */
namespace ActionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action act1 = () => Console.WriteLine("Action()");
            act1();

            int result = 0;
            Action<int> act2 = (x) => result = x * x;

            act2(3);
            Console.WriteLine($"result : {result}");

            Action<double, double> act3 = (x, y) =>
            {
                double pi = x / y;
                Console.WriteLine($"Action<T1, T2>({x}, {y}) : {pi}");
            };

            act3(22.0, 7.0);
        }
    }
}