/*
2023/06/30 // try ~ catch와 finally 예제

실행 결과
>Finally
제수를 입력하세요. :40
피제수를 입력하세요 :십일
에러 : The input string '십일' was not in a correct format.
프로그램을 종료합니다.

>Finally
제수를 입력하세요. :7
피제수를 입력하세요 :0
Divide() 시작
Divide() 예외 발생
Divide() 끝
에러 : Attempted to divide by zero.
프로그램을 종료합니다.

>Finally
제수를 입력하세요. :12
피제수를 입력하세요 :4
Divide() 시작
Divide() 끝
12/4 = 3
프로그램을 종료합니다.
 */
namespace Finally
{
    internal class Program
    {
        static int Divide(int divisor, int dividend)
        {
            try
            {
                Console.WriteLine("Divide() 시작");
                return divisor / dividend;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide() 예외 발생");
                throw e;
            }
            finally
            {
                Console.WriteLine("Divide() 끝");
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.Write("제수를 입력하세요. :");
                string temp = Console.ReadLine();
                int divisor = Convert.ToInt32(temp);

                Console.Write("피제수를 입력하세요 :");
                temp = Console.ReadLine();
                int dividend = Convert.ToInt32(temp);

                Console.WriteLine("{0}/{1} = {2}",
                    divisor, dividend, Divide(divisor, dividend));
            }
            catch (FormatException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("에러 : " + e.Message);
            }
            finally
            {
                Console.WriteLine("프로그램을 종료합니다.");
            }
        }
    }
}