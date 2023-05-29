/*
2023/05/29 // 심규영 // continue 문 예시

실행
1 : 홀수
3 : 홀수
5 : 홀수
7 : 홀수
9 : 홀수
 */
namespace Continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for( int i = 0; i < 10; i++ )
            {
                if (i % 2 == 0)
                    continue;

                Console.WriteLine($"{i} : 홀수");
            }
        }
    }
}