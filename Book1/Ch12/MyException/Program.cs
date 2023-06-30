/*
2023/06/30 // 사용자 정의 예외 클래스 만들기 예제

실행 결과
0xFF6F6F6F
0x141C080
Exception of type 'MyException.InvalidArgumentException' was thrown.
Argument:300, Range:0~255
 */
namespace MyException
{
    class InvalidArgumentException : Exception
    {
        public InvalidArgumentException() { }

        public InvalidArgumentException(string message) : base(message) { }

        public object Argment { get; set; }
        public string Range { get; set; }
    }

    internal class Program
    {
        static uint MergeARGB(uint alpha, uint red, uint green, uint blue)
        {
            uint[] args = new uint[] { alpha, red, green, blue };

            foreach (uint arg in args)
            {
                if (arg > 255)
                    throw new InvalidArgumentException()
                    {
                        Argment = arg,
                        Range = "0~255"
                    };
            };

            return (alpha << 24 & 0xFF000000) |
                   (red   << 16 & 0x00FF0000) |
                   (green << 8  & 0x0000FF00) |
                   (blue        & 0x000000FF);
        }


        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("0x{0:X}", MergeARGB(255, 111, 111, 111));
                Console.WriteLine("0x{0:X}", MergeARGB(1, 65, 192, 128));
                Console.WriteLine("0x{0:X}", MergeARGB(0, 255, 255, 300));
            }
            catch (InvalidArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine($"Argument:{e.Argment}, Range:{e.Range}");
            }
        }
    }
}