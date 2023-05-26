using System.Collections;

/*
 * 2023/05/26 // 심규영 // 널 조건부 연산자
 */
namespace NullConditionalOperator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구"); // a?.이 null을 반환하므로 Add() 메소드는 호출되지 않음
            a?.Add("축구");
            Console.WriteLine($"Count : {a?.Count}"); // Count :
            Console.WriteLine($"{a?[0]}"); //
            Console.WriteLine($"{a?[1]}"); // 

            a = new ArrayList(); // a는 이제 더 이상 null이 아닙니다.
            a?.Add("야구");
            a?.Add("축구");
            Console.WriteLine($"Count : {a?.Count}"); // Count: 2
            Console.WriteLine($"{a?[0]}"); // 야구
            Console.WriteLine($"{a?[1]}"); // 축구
        }
    }
}