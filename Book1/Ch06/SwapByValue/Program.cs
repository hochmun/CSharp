/*
2023/05/30 // 심규영 // 매개 변수 예시

출력
x:3, y:4
x:3, y:4

메소드에 데이터를 넘길 때 변수가 이동 하는 것이 아닌 복사 되기 때문에
변수 값이 변하지 않는다.
 */
namespace SwapByValue
{
    internal class MainApp
    {
        public static void Swap(int a, int b)
        {
            int tmp = b;
            b = a;
            a = tmp;
        }

        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"x:{x}, y:{y}");

            Swap(x, y);

            Console.WriteLine($"x:{x}, y:{y}");
        }
    }
}