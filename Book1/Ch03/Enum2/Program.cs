namespace Enum2
{
    /*
     * 2023/05/17 // 심규영 // 열거 형식 예제2
     */
    internal class Program
    {
        enum DialogResult { YES, NO, CANCEL, CONFIRM, OK }

        static void Main(string[] args)
        {
            DialogResult result = DialogResult.YES;

            Console.WriteLine(result == DialogResult.YES);
            Console.WriteLine(result == DialogResult.NO);
            Console.WriteLine(result == DialogResult.CANCEL);
            Console.WriteLine(result == DialogResult.CONFIRM);
            Console.WriteLine(result == DialogResult.OK);
        }
    }
}