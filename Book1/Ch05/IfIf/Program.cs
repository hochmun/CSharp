/*
 * 2023/05/27 // 심규영 // if 중첩문 예시
 * 
 * 숫자를 입력하세요. : 11
 * 0보다 큰 홀수.
 * 
 * 숫자를 입력하세요. : 4
 * 0보다 큰 짝수.
 * 
 * 숫자를 입력하세요. : -10
 * 0보다 작거나 같은 수.
 */
namespace IfIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요. : ");

            string input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number > 0)
            {
                if (number % 2 == 0)
                    Console.WriteLine("0보다 큰 짝수.");
                else
                    Console.WriteLine("0보다 큰 홀수.");
            }
            else
            {
                Console.WriteLine("0보다 작거나 같은 수.");
            }
        }
    }
}