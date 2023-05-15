/*
 * 2023/05/16 // 심규영 // 부호 있는 정수와 부호 없는 정수
 * 2의 보수법
 */
namespace SignedUsigned
{
    class MainApp
    {
        static void Main(string[] args)
        {
            byte a = 255;
            sbyte b = (sbyte)a;

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}