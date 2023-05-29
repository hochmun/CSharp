/*
 2023/05/29 // 심규영 // 무한 while문 예시
 */
namespace InfiniteWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine(i++);
            }
        }
    }
}