/*
2023/06/22 // 심규영 // 추상 클래스 예시

실행 결과
Derived.AbstractMethodA()
AbstractBase.PrivateMethodA()
AbstractBase.PublicMethodA()

 - 추상 클래스는 인터페이스와 달리 "구현"을 가질 수 있다.
 - 하지만 클래스와는 달리 인스턴스를 가질 수는 없다.

추상 클래스가 또 다른 추상 클래스를 상속하는 경우
 - 추상 클래스는 또 다른 추상 클래스를 상속할 수 있으며
 - 이 경우 자식 추상 클래스는 부모 추상 클래스의 추상메소드를 구현 하지 않아도 된다.
 - 추상 메소드는 인스턴스를 생성할 클래스에서 구현 하면 되어서.
 */
namespace AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethodA()
        {
            Console.WriteLine("AbstractBase.PrivateMethodA()");
        }

        public void PublicMethodA()
        {
            Console.WriteLine("AbstractBase.PublicMethodA()");
        }

        public abstract void AbstractMethodA();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethodA()
        {
            Console.WriteLine("Derived.AbstractMethodA()");
            PrivateMethodA();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethodA();
            obj.PublicMethodA();
        }
    }
}