/*
 * 2023/05/26 // 심규영 // 시프트 연산자 예시
 */
namespace ShiftOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing << ... ");

            int a = 1;
            Console.WriteLine("a      : {0:D5} (0x{0:X8})", a);      // a      : 00001 (0x00000001)
            Console.WriteLine("a << 1 : {0:D5} (0x{0:X8})", a << 1); // a << 1 : 00002 (0x00000002)
            Console.WriteLine("a << 2 : {0:D5} (0x{0:X8})", a << 2); // a << 2 : 00004 (0x00000004)
            Console.WriteLine("a << 5 : {0:D5} (0x{0:X8})", a << 5); // a << 5 : 00032 (0x00000020)

            Console.WriteLine("\nTesting >> ... ");

            int b = 255;
            Console.WriteLine("b      : {0:D5} (0x{0:X8})", b);      // b      : 00255 (0x000000FF)
            Console.WriteLine("b >> 1 : {0:D5} (0x{0:X8})", b >> 1); // b >> 1 : 00127 (0x0000007F)
            Console.WriteLine("b >> 2 : {0:D5} (0x{0:X8})", b >> 2); // b >> 2 : 00063 (0x0000003F)
            Console.WriteLine("b >> 5 : {0:D5} (0x{0:X8})", b >> 5); // b >> 5 : 00007 (0x00000007)

            Console.WriteLine("\nTesting >> 2 ... ");

            int c = -255;
            Console.WriteLine("c      : {0:D5} (0x{0:X8})", c);      // c      : -00255 (0xFFFFFF01)
            Console.WriteLine("c >> 1 : {0:D5} (0x{0:X8})", c >> 1); // c >> 1 : -00128 (0xFFFFFF80)
            Console.WriteLine("c >> 2 : {0:D5} (0x{0:X8})", c >> 2); // c >> 2 : -00064 (0xFFFFFFC0)
            Console.WriteLine("c >> 5 : {0:D5} (0x{0:X8})", c >> 5); // c >> 5 : -00008 (0xFFFFFFF8)
        }
    }
}