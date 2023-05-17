namespace Enum3
{
    /*
     * 2023/05/17 // 심규영 // Enum3 예제
     */
    internal class Program
    {
        enum DialogResult { YES = 10, NO , CANCEL, CONFIRM = 50, OK}

        static void Main(string[] args)
        {
            Console.WriteLine((int)DialogResult.YES);       // 10
            Console.WriteLine((int)DialogResult.NO);        // 11
            Console.WriteLine((int)DialogResult.CANCEL);    // 12
            Console.WriteLine((int)DialogResult.CONFIRM);   // 50
            Console.WriteLine((int)DialogResult.OK);        // 51
        }
    }
}