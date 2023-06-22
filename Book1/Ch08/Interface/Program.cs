/*
2023/06/18 // 심규영 // 인터페이스 예제

실행 결과
온도를 입력해주세요. : 34
온도를 입력해주세요. : 28
온도를 입력해주세요. : 77
온도를 입력해주세요. :

MyLog.txt의 내용
오전 9:43 현재 온도 : 34
오전 9:43 현재 온도 : 28
오전 9:43 현재 온도 : 77

인터페이스 작명법
 - 대개 인터페이스의 이름 앞에 'I'를 붙이는 것이 관례
 */
namespace Interface
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(
                "{0} {1}",
                DateTime.Now.ToString(), message
                );
        }
    }

    class FileLogger : ILogger
    {
        private StreamWriter writer;

        public FileLogger(string path)
        {
            writer = File.CreateText(path);
            writer.AutoFlush = true;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine("{0} {1}", DateTime.Now.ToShortTimeString(), message);
        }
    }

    class ClimateMonitor
    {
        private ILogger logger;

        public ClimateMonitor(ILogger logger)
        {
            this.logger = logger;
        }

        public void start()
        {
            while (true)
            {
                Console.Write("온도를 입력해주세요. : ");
                string temperature = Console.ReadLine();
                if (temperature == "") break;
                logger.WriteLog("현재 온도 : " + temperature);
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ClimateMonitor monitor = new ClimateMonitor(
                    new FileLogger("MyLog.txt")
                );

            monitor.start();
        }
    }
}