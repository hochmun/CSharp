/*
 2023/05/29 // 심규영 // 무한 for문 예시
 */
namespace InfiniteFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            for (; ; )
            {
                Console.WriteLine(i++);
            }
        }
    }
}