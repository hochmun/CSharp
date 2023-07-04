using System.Linq.Expressions;

/*
2023/07/04 // 식 트리 예제 2

실행 결과
1*2+(7-8) = 1
 */
namespace ExpressionTreeViaLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Expression<Func<int, int, int>> expression =
                (a, b) => 1 * 2 + (a - b);
            Func<int, int, int> func = expression.Compile();

            // x = 7, y = 8
            Console.WriteLine($"1*2+({7}-{8}) = {func(7, 8)}");
        }
    }
}