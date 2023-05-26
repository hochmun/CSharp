using static System.Console;

/*
 * 2023/05/20 // 심규영 // 문자열 메소드 종류
 *  - IndexOf()     - 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 찾습니다.
 *  - LastIndexOf() - 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 뒤에서부터 찾습니다.
 *  - StartsWith()  - 현재 문자열이 지정된 문자열로 시작하는지를 평가합니다.
 *  - EndsWith()    - 현재 문자열이 지정된 문자열로 끝나는지를 평가합니다.
 *  - Contains()    - 현재 문자열이 지정된 문자열을 포함하는지를 평가 합니다.
 *  - Replace()     - 현재 문자열에서 지정된 문자열이 다른 문자열로 모두 바뀐 새 문자열을 반환합니다.
 */
namespace StringSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";

            WriteLine(greeting);
            WriteLine();

            // indexOf()
            WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));                // 0
            WriteLine("IndexOf 'o' : {0}", greeting.IndexOf('o'));                      // 1

            // LastIndexOf()
            WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));        // 0
            WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf('o'));              // 6

            // StartsWith()
            WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));          // True
            WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));    // False

            // EndsWith()
            WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));              // False
            WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));        // True

            // Contains()
            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));        // False
            WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));        // True

            // Replace()
            WriteLine("Replaced 'Morning' with 'Evening' : {0}",
                greeting.Replace("Morning", "Evening"));                                // Good Evening
        }
    }
}