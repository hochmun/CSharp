/*
2023/06/21 // 심규영 // 인터페이스를 상속하는 인터페이스

실행 결과
2023-06-21 오후 5:11:04 The world is no flat.
2023-06-21 오후 5:11:04 1 + 1 = 2

인터페이스를 상속하는 인터페이스를 만드는 이유
 - 인터페이스를 수정할 수 없을 때에는 인터페이스를 상속하는 인터페이스를 이용 해야함.
 */
namespace DerivedInterface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    interface IFormattableLogger : ILogger
    {
        void WriteLog(string format, params object[] args);
    }

    class ConsoleLogger2 : IFormattableLogger
    {
        public void WriteLog (string message)
        {
            Console.WriteLine ("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }

        public void WriteLog (string format, params object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine ("{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            IFormattableLogger logger = new ConsoleLogger2();
            logger.WriteLog("The world is no flat.");
            logger.WriteLog("{0} + {1} = {2}", 1, 1, 2);
        }
    }
}