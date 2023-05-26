/*
 * 2023/05/26 // 심규영 // 비트 논리 연산자
 */
namespace BitwiseOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 10;

            Console.WriteLine($"{a} & {b} : {a & b}"); // 9 & 10 : 8
            // 9(1001) & 10(1010) => 8(1000)
            // 둘다 1(true) 인 것

            Console.WriteLine($"{a} | {b} : {a | b}"); // 9 | 10 : 11
            // 9(1001) | 10(1010) => 11(1011)
            // 둘중 하나라도 1(true) 인 것

            Console.WriteLine($"{a} ^ {b} : {a ^ b}"); // 9 ^ 10 : 3
            // 9(1001) ^ 10(1010) => 3(0011)
            // 진리 값이 서로 달라야 true

            int c = 255;
            Console.WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:X8})", c, ~c); // ~255(0x000000FF) : -256(0xFFFFFF00)
        }
    }
}