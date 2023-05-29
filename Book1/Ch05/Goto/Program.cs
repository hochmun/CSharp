/*
 2023/05/29 // 심규영 // Goto 문 예시

실행
종료 조건(숫자)을 입력하세요 : 5
1
2
3
4
5

Exit nested for ...
Exit program ...

실행 2
종료 조건(숫자)을 입력하세요 : 13
1
2
3
4
5
6
7
8
9
10
11
12
Exit program ...
 */
namespace Goto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("종료 조건(숫자)을 입력하세요 : ");

            string input = Console.ReadLine();

            int input_number = Convert.ToInt32(input);

            int exit_number = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        // 조건이 참이면 EXIT_FOR 레이블로 점프
                        if (exit_number++ == input_number)
                            goto EXIT_FOR;

                        Console.WriteLine(exit_number);
                    }
                }
            }

            // EXIT_FOR레이블을 만나지 않기 위해 점프
            goto EXIT_PROGRAM;

        EXIT_FOR:
            Console.WriteLine("\nExit nested for ... ");

        EXIT_PROGRAM:
            Console.WriteLine("Exit program ... ");
        }
    }
}