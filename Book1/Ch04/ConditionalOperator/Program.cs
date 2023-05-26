/*
 * 2023/05/26 // 심규영 // 조건 연산자
 */
namespace ConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수";

            Console.WriteLine(result); // 짝수
        }
    }
}