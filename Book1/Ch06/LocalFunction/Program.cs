/*
2023/06/01 // 심규영 // 로컬 함수 예제

실행
hello!
good morning.
this is c#.
 */
namespace LocalFunction
{
    internal class Program
    {
        static string ToLowerString (string input)
        {
            var arr = input.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = ToLowerChar(i); // 로컬 함수 호출
            }

            char ToLowerChar(int i) // 로컬 함수 선언
            { // 로컬 함수는 자신이 소속된 메소드의 지역 변수를 사용할 수 있습니다.
                if (arr[i] < 65 || arr[i] > 90)
                    return arr[i];
                else
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ToLowerString("Hello!"));
            Console.WriteLine(ToLowerString("Good Morning."));
            Console.WriteLine(ToLowerString("This is C#."));
        }
    }
}