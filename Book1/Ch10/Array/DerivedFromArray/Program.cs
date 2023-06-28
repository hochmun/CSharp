/*
2023/06/23 // System.Array 예제

실행 결과
Type Of array : System.Int32[]
Base type of array : System.Array
 */
namespace DerivedFromArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 10, 30, 20, 7, 1 };
            Console.WriteLine($"Type Of array : {array.GetType()}");
            Console.WriteLine($"Base type of array : {array.GetType().BaseType}");
        }
    }
}