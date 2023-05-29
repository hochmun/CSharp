/*
 * 2023/05/29 // 심규영 // while 문 예시
 * 
 * 출력
 * i : 10
 * i : 9
 * i : 8
 * i : 7
 * i : 6
 * i : 5
 * i : 4
 * i : 3
 * i : 2
 * i : 1
 * 
 */
namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            while (i > 0)
            {
                Console.WriteLine($"i : {i--}");
            }
        }
    }
}