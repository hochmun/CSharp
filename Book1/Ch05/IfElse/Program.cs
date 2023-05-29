/*
 * 2023/05/27 // 심규영 // if 분기문 예시
 * 
 * 숫자를 입력하세요. : 33
 * 양수
 * 홀수
 * 
 * 숫자를 입력하세요. : -12
 * 음수
 * 짝수
 */
namespace IfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자를 입력하세요. : ");

            string input = Console.ReadLine();
            int number = Int32.Parse(input);

            if (number < 0)
                Console.WriteLine("음수");
            else if (number > 0)
                Console.WriteLine("양수");
            else
                Console.WriteLine("0");

            if (number % 2 == 0)
                Console.WriteLine("짝수");
            else
                Console.WriteLine("홀수");
        }
    }
}