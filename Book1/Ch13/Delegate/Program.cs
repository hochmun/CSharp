/*
2023/07/01 // 대리자 예시

실행 결과
7
2
 */
namespace Delegate
{
    // 대리자 선언
    delegate int MyDelegate(int a, int b);

    class Calculator
    {
        // 대리자는 인스턴스 메소드도 참조할 수 있고
        public int Plus(int a, int b)
        {
            return a + b;
        }

        // 대리자는 정적 메소드도 참조할 수 있습니다.
        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator Calc = new Calculator();
            MyDelegate Callback;

            // 대리자를 메소드를 호출하듯 사용하면,
            // 참조하고 있는 메소드가 실행됩니다.
            Callback = new MyDelegate(Calc.Plus);
            Console.WriteLine(Callback(3, 4));

            Callback = new MyDelegate(Calculator.Minus);
            Console.WriteLine(Callback(7, 5));
        }
    }
}