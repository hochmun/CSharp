// 2023/05/16 // 심규영 // 오버플로우 예시
namespace Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint a = uint.MaxValue;

            Console.WriteLine(a);

            a = a + 1;

            Console.WriteLine(a);
        }
    }
}