using MyExtension;

/*
2023/06/12 // 심규영 // 확장 메소드 예시

실행 결과
3^2 : 9
3^4 : 81
2^10 : 1024

 - 확장 메소드를 선언하는 방법은 
 - 메소드를 선언하되 static 한정자로 수식해야 한다.
 - 메소드의 첫 번째 매개변수는 반드시 this 키워드와 함께 확장하고자 하는 클래스(형식)의 인스턴스여야 한다.
 - 그 뒤의 매개변수는 실제로 확장 메소드를 호출할 때 입력되는 매개 변수 이다.
 */
namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^4 : {3.Power(4)}");
            Console.WriteLine($"2^10 : {2.Power(10)}");

            // 비타민 퀴즈 7-1
            string hello = "Hello";
            Console.WriteLine(hello.Append(", World!"));
        }
    }
}