/*
2023/07/04 // Func 대리자 예시

Func 대리자는 결과를 반환하는 메소드를 참조하기 위해 만들어짐
.Net 프레임워크에는 모두 17가지 버전의 Func대리자가 준비되어 있음

모든 Func 대리자의 형식 매개 변수 중 가장 마지막에 있는 것이 반환 형식이다.

실행 결과
func1() : 10
func2(4) : 8
func3(22, 7) : 3.142857142857143
 */
namespace FuncTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int> func1 = () => 10;
            Console.WriteLine($"func1() : {func1()}");

            Func<int, int> func2 = (x) => x * 2;
            Console.WriteLine($"func2(4) : {func2(4)}");

            Func<double, double, double> func3 =
                (x, y) => x / y;
            Console.WriteLine($"func3(22, 7) : {func3(22, 7)}");
        }
    }
}