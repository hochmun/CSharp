using static System.Console;

/*
 * 2023/05/26 // 심규영 // 숫자 서식화
 */
namespace StringFormatNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // D : 10진수
            WriteLine("10진수 : {0:D}", 123); // 123
            WriteLine("10진수 : {0:D5}", 123); // 00123

            // X : 16진수
            WriteLine("16진수 : 0x{0:X}", 0xFF1234); // 0xFF1234
            WriteLine("16진수 : 0x{0:X8}", 0xFF1234); // 0x00FF1234

            // N : 숫자
            WriteLine("숫자 : {0:N}", 123456789); // 123,456,789.00
            WriteLine("숫자 : {0:N0}", 123456789); // 자릿수 0은 소숫점 이하를 제거함 // 123,456,789

            // F : 고정소수점
            WriteLine("고정소수점 : {0:F}", 123.45); // 123.45
            WriteLine("고정소수점 : {0:F5}", 123.456); // 123.45600

            // E : 공학용
            WriteLine("공학 : {0:E}", 123.456789); // 1.2345678E+002
        }
    }
}