using System;

/**
 *  2023/05/14 // 심규영 // 정수 형식 예제 프로그램
 *  데이터 형식  : 담을 수 있는 값의 범위
 *  byte         : 0 ~ 255
 *  sbyte        : -128 ~ 127
 *  short        : -32,768 ~ 32,767
 *  ushort       : 0 ~ 65,535
 *  int          : -2,147,483,648 ~ 2,147,483,647
 *  uint         : 0 ~ 4,294,967,295
 *  long         : -922,337,203,685,477,508 ~ 922,337,203,685,477,507
 *  ulong        : 0 ~ 18,446,744,073,709,551,615
 *  char         : 
 */
namespace IntegralTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sbyte a = -10;
            byte b = 40;

            Console.WriteLine($"a={a}, b={b}");

            short c = -30000;
            ushort d = 60000;

            Console.WriteLine($"c={c}, d={d}");

            int e = -1000_0000; // 0이 7개
            uint f = 3_0000_0000; // 0이 8개

            Console.WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000; // 0이 11개
            ulong h = 200_0000_0000_0000_0000; // 0이 18개

            Console.WriteLine($"g={g}, h={h}");
        }
    }
}