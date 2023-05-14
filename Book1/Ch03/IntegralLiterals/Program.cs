namespace IntegralLiterals
{
    /**
     * 2023/05/14 // 심규영 // 2진수, 10진수, 16진수 리터럴
     * 사용 접두사
     *  - 2진수 : 0b
     *  - 16진수 : 0X(또는 0x)
     *  - 접두사를 붙이지 않는 경우 10진수로 간주
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 240; // 10진수 리터럴
            Console.WriteLine($"a={a}");

            byte b = 0b1111_0000; // 2진수 리터럴
            Console.WriteLine($"b={b}");

            byte c = 0XF0; // 16진수 리터럴
            Console.WriteLine($"c={c}");

            uint d = 0x1234_abcd; // 16진수 리터럴
            Console.WriteLine($"d={d}");
        }
    }
}