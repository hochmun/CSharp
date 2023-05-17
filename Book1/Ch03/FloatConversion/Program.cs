/*
    2023/05/17 // 심규영 // 크기가 서로 다른 부동 소수점 형식 사이의 변환
     - 부동 소수점 형식의 특성상 오버플로우가 존재하지 않음
     - 그러나 정밀성에 손상을 입힘
 */
namespace FloatConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 69.6875f;
            Console.WriteLine("a : {0}", a);

            double b = (double)a;
            Console.WriteLine("b : {0}", b);

            Console.WriteLine("69.6875 == b : {0}", 69.6875 == b);

            float x = 0.1f;
            Console.WriteLine("x : {0}", x);

            double y = (double)x;
            Console.WriteLine("y : {0}", y);

            Console.WriteLine("0.1 == y : {0}", 0.1 == y);
        }
    }
}