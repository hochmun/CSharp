// 2023/05/16 // 심규영 // decimal
// 숫자 뒤에 f를 붙이면 float 형식
// 아무것도 없으면 double
// m을 붙이면 decimal
namespace Decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846_2643_3832_79f;
            double b = 3.1415_9265_3589_7932_3846_2643_3832_79;
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832_79m;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}