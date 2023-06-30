/*
2023/06/30 // try ~ catch로 예외 받기 예제

실행 결과
1
2
3
예외가 발생했습니다. : Index was outside the bounds of the array.
종료
 */
namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3 };

            try
            {
                for (int i = 0; i < 5; i++)
                    Console.WriteLine(arr[i]);
            }
            catch (IndexOutOfRangeException e )
            {
                Console.WriteLine($"예외가 발생했습니다. : {e.Message}");
            }

            Console.WriteLine("종료");
        }
    }
}