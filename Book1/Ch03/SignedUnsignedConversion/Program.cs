/*
    2023/05/17 // 심규영 // 부호 있는 형식과 부호 없는 형식 사이의 변환
 */
namespace SignedUnsignedConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 500;
            Console.WriteLine(a);

            uint b = (uint)a;
            Console.WriteLine(b);

            int x = -30;
            Console.WriteLine(x);

            uint y = (uint)x;       // 언더플로우
            Console.WriteLine(y);
        }
    }
}