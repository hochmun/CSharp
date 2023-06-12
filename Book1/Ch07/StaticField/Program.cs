/*
2023/06/05 // 심규영 // 정적 필드와 메소드 예제

실행
Global.Count : 0
Global.Count : 4

정적 메소드의 반대는 인스턴스 메소드
 */
namespace StaticField
{
    class Global
    {
        public static int Count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.Count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.Count++;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Global.Count : {Global.Count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            Console.WriteLine($"Global.Count : {Global.Count}");
        }
    }
}