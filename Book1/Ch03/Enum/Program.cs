namespace Enum
{
    /*
     * 2023/05/17 // 심규영 // 열거 형식
     * 
     *  형태
     *   - enum 열거 형식명 : 기반자료형 { 상수1, 상수2, 상수 3 ... }
     */
    internal class Program
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);
            Console.WriteLine((int)DialogResult.NO);
            Console.WriteLine((int)DialogResult.CANCEL);
            Console.WriteLine((int)DialogResult.CONFIRM);
            Console.WriteLine((int)DialogResult.OK);
        }
    }
}