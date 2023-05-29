/*
 2023/05/29 // 심규영 // break 예시

출력
계속할가요?(예/아니요) :
계속할가요?(예/아니요) :
계속할가요?(예/아니요) : 아니요
 */
namespace Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("계속할가요?(예/아니요) : ");
                string answer = Console.ReadLine();

                if (answer == "아니요")
                {
                    break;
                }
            }
        }
    }
}