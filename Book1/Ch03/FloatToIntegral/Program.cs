/*
    2023/05/17 // 심규영 // 부동 소수점 형식과 정수 형식 사이의 변환
     - 부동 소수점 형식의 변수를 정수 형식으로 변환하면
       데이터에서 소수점 아래는 버리고 소수점 위만 남김
 */
namespace FloatToIntegral
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 0.9f;
            int b = (int)a;
            Console.WriteLine(b);

            float c = 1.1f;
            int d = (int)c;
            Console.WriteLine(d);
        }
    }
}