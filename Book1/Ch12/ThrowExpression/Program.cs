/*
2023/06/30 // 예외 던지기 예제 2

실행 결과
System.ArgumentNullException: Value cannot be null.
   at ThrowExpression.Program.Main(String[] args) in D:\eclipse-workspace\C#\Book1\Ch12\ThrowExpression\Program.cs:line 10
System.IndexOutOfRangeException: Index was outside the bounds of the array.
   at ThrowExpression.Program.Main(String[] args) in D:\eclipse-workspace\C#\Book1\Ch12\ThrowExpression\Program.cs:line 21
 */
namespace ThrowExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int? a = null;
                int b = a ?? throw new ArgumentNullException();
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }

            try
            {
                int[] array = new[] { 1, 2, 3 };
                int index = 4;
                int value = array[
                    index >= 0 && index < 3
                    ? index : throw new IndexOutOfRangeException()
                    ];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}