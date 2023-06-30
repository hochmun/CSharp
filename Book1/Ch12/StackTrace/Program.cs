/*
2023/06/30 // 예외 처리 다시 생각해보기 예제

실행 결과
    at StackTrace.Program.Main(String[] args) in D:\eclipse-workspace\C#\Book1\Ch12\StackTrace\Program.cs:line 10
 */
namespace StackTrace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 1;
                Console.WriteLine(3 / --a);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}