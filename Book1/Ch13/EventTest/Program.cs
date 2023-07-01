/*
2023/07/01 // 대리자 이벤트 : 객체에 일어난 사건 알리기 예시

실행 결과
3 : 짝
6 : 짝
9 : 짝
13 : 짝
16 : 짝
19 : 짝
23 : 짝
26 : 짝
29 : 짝
 */
namespace EventTest
{
    delegate void EventHandler(string message);

    class MyNotifier
    {
        public event EventHandler SomethingHappened;

        public void DoSomething(int number)
        {
            int temp = number % 10;

            if ( temp != 0 && temp % 3 == 0 )
            {
                SomethingHappened(String.Format("{0} : 짝", number));
            }
        }
    }

    internal class Program
    {
        static public void MyHandler(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            MyNotifier notifier = new MyNotifier();
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for (int i = 1; i < 30; i++)
                notifier.DoSomething(i);
        }
    }
}