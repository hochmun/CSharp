/*
2023/06/30 // 예외 필터 하기

실행 결과
Enter Number Between 0 - 10
5
Output : 5

Enter Number Between 0 - 10
-1
Negative input is not allowed.

Enter Number Between 0 - 10
15
Too big number is not allowed.
 */
namespace ExceptionFiltering
{
    class FilterableException : Exception
    {
        public int ErrorNo { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Between 0 - 10");
            string input = Console.ReadLine();

            try
            {
                int num = Int32.Parse(input);

                if (num < 0 || num > 10)
                    throw new FilterableException() { ErrorNo = num };
                else
                    Console.WriteLine($"Output : {num}");
            }
            catch (FilterableException e ) when (e.ErrorNo < 0)
            {
                Console.WriteLine("Negative input is not allowed.");
            }
            catch (FilterableException e) when (e.ErrorNo > 10)
            {
                Console.WriteLine("Too big number is not allowed.");
            }
        }
    }
}