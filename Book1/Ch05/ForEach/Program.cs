/*
 2023/05/29 // 심규영 // foreach 문 예시

출력
0
1
2
3
4
 */
namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };

            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}