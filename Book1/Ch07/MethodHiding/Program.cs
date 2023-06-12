/*
2023/06/11 // 심규영 // 메소드 숨기기 예시

실행
Base.MyMethod()
Derived.MyMethod()
Base.MyMethod()

 - new 를 통해 메소드를 새로 작성 하는 방법
 */
namespace MethodHiding
{
    class Base
    {
        public void MyMethod()
        {
            Console.WriteLine("Base.MyMethod()");
        }
    }

    class Derived : Base
    {
        public new void MyMethod()
        {
            Console.WriteLine("Derived.MyMethod()");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Base baseObj = new Base();
            baseObj.MyMethod();

            Derived derivedObj = new Derived();
            derivedObj.MyMethod();

            Base baseOrDerived = new Derived();
            baseOrDerived.MyMethod();
        }
    }
}