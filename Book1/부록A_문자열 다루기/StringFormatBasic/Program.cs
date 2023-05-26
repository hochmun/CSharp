using static System.Console;

/*
 * 2023/05/25 // 심규영 // 왼쪽/오른쪽 맞춤
 */
namespace StringFormatBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fmt = "{0,-20}{1,-15}{2, 30}";

            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "Sanghyun", "C# 7.0 Programming");
            WriteLine(fmt, "Prentice Hail", "K&R", "The C# Programming Language");
        }
    }
}