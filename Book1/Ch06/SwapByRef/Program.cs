/*
2023/05/30 // 심규영 // 참조에 의한 매개 변수 전달, ref 사용 예시

출력
x:3, y:4
x:4, y:3
 */
namespace SwapByRef
{
    internal class Program
    {
        static void Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a; 
            a = temp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x:{x}, y:{y}");

            Swap( ref x, ref y );

            Console.WriteLine($"x:{x}, y:{y}");
        }
    }
}