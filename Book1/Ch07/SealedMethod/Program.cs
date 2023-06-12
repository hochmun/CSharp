/*
2023/06/11 // 심규영 // 오버라이딩 봉인하기 예제

실행
'WantToOverride.SealMe()': 상속된 'Derived.SealMe()' 멤버는 봉인되어 있으므로 재정의할 수 없습니다.	
 */
namespace SealedMethod
{
    class Base
    {
        public virtual void SealMe()
        {
        }
    }

    class Derived : Base {
        public sealed override void SealMe() { }
    }

    class WantToOverride : Derived
    {
        public override void SealMe() { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}