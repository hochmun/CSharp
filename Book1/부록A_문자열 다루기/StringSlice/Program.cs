/*
 * 2023/05/20 // 심규영 // 문자열 분할
 *  - Split()       - 현재 문자열을 지정된 문자를 기준으로 분리한 문자열의 배열을 반환합니다.
 *  - SubString()   - 현재 문자열을 지정된 위치로부터 지정된 수만큼의 문자로 이루어진 새 문자열을 반환합니다.
 */
namespace StringSlice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning.";

            Console.WriteLine(greeting.Substring(0, 5));    // Good
            Console.WriteLine(greeting.Substring(5));       // morning.
            Console.WriteLine();

            string[] arr = greeting.Split(
                new string[] {" "}, StringSplitOptions.None
                );
            Console.WriteLine("Word Count : {0}", arr.Length);  // Word Count : 2

            foreach (string element in arr)
            {
                Console.WriteLine("{0}", element);
            }
            // Good
            // morning.
        }
    }
}