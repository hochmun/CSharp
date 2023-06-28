/*
2023/06/23 // 배열을 초기화하는 방법 세 가지 예제

실행 결과
array1...
 안녕
 Hello
 Halo

array2...
 안녕
 Hello
 Halo

array3...
 안녕
 Hello
 Halo
 */
namespace InitializingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = new string[3] { "안녕", "Hello", "Halo" };

            Console.WriteLine("array1...");
            foreach (string greeting in array1)
                Console.WriteLine($" {greeting}");

            string[] array2 = new string[] { "안녕", "Hello", "Halo" };

            Console.WriteLine("\narray2...");
            foreach (string greeting in array2)
                Console.WriteLine($" {greeting}");

            string[] array3 = { "안녕", "Hello", "Halo" };

            Console.WriteLine("\narray3...");
            foreach (string greeting in array3)
                Console.WriteLine($" {greeting}");
        }
    }
}