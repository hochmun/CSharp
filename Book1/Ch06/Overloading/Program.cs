/*
2023/06/01 // 심규영 // 메소드 오버로딩

실행
Calling int Plus(int,int)...
3
Calling int Plus(int,int,int)...
6
Calling double Plus(double,double)...
3.4
Calling double Plus(double,double)...
3.4
 */
namespace Overloading
{
    internal class Program
    {
        static int Plus (int a, int b)
        {
            Console.WriteLine("Calling int Plus(int,int)...");
            return a + b;
        }

        static int Plus(int a, int b, int c)
        {
            Console.WriteLine("Calling int Plus(int,int,int)...");
            return a + b + c;
        }

        static double Plus (double a, double b)
        {
            Console.WriteLine("Calling double Plus(double,double)...");
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Plus(1, 2));
            Console.WriteLine(Plus(1, 2, 3));
            Console.WriteLine(Plus(1.0, 2.4));
            Console.WriteLine(Plus(1, 2.4));
        }
    }
}