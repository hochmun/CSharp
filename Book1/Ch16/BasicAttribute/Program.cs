/*
2023/07/12 // 애트리뷰트 예시

애트리뷰트(Attribute)
 - 애트리뷰트는 코드에 대한 부가 정보를 기록하고 읽을 수 있는 기능

실행 결과
I'm old
I'm new
 */
namespace BasicAttribute
{
    class MyClass
    {
        // 애트리뷰트를 이용하여 사용하는 않는 코드라는 정보를 컴퓨터에 제공
        // 오류 목록에 해당 경고가 출력됨
        [Obsolete("OldMethod는 폐기되었습니다. NewMethod()를 이용하세요.")]
        public void OldMethod()
        {
            Console.WriteLine("I'm old");
        }

        public void NewMethod()
        {
            Console.WriteLine("I'm new");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            obj.OldMethod();
            obj.NewMethod();
        }
    }
}