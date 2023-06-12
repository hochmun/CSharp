/*
2023/06/11 // 심규영 // 분할 클래스 예시

실행 결과
Method1
Method2
Method3
Method4

 - 분할 클래스는 그 자체로 특별한 기능을 하는 것은 아니고,
   클래스의 구현이 길어질 경우 여러 파일에 나눠서 구현할 수 있게 함으로써
   소스 코드 관리의 편의를 제공하는 데 의미가 있음
 - partial 키워드를 사용
 */
namespace PartialClass
{
    partial class MyClass
    {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }

        public void Method2()
        {
            Console.WriteLine("Method2");
        }
    }

    partial class MyClass
    {
        public void Method3()
        {
            Console.WriteLine("Method3");
        }

        public void Method4()
        {
            Console.WriteLine("Method4");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();
            obj.Method1();
            obj.Method2();
            obj.Method3();
            obj.Method4();
        }
    }
}