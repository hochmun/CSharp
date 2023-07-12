using System.Runtime.CompilerServices;

/*
2023/07/12 // 호출자 정보 애트리뷰트 예시

실행 결과
D:\eclipse-workspace\C#\Book1\Ch16\CallerInfo\Program.cs(Line : 26) Main : 즐거운 프로그래밍!
 */
namespace CallerInfo
{
    public static class Trace
    {
        public static void WriteLine(string message,
            [CallerFilePath] string file = "",
            [CallerLineNumber] int line = 0,
            [CallerMemberName] string member = "") 
        {
            Console.WriteLine($"{file}(Line : {line}) {member} : {message}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Trace.WriteLine("즐거운 프로그래밍!");
        }
    }
}