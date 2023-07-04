/*
2023/07/04 // 문 형식의 람다식 예시

실행 결과
>StatementLambda.exe 아버지가 방에 들어가신다.
아버지가방에들어가신다.

>StatementLambda.exe 할머니가 죽을 잡수신다.
할머니가죽을잡수신다.

>StatementLambda.exe 아 기다리고 기다리던 방학.
아기다리고기다리던방학.
 */
namespace StatementLambda
{
    internal class Program
    {
        // Concatenate : 연쇄시키다, 연쇄된, 이어진, 연결된
        delegate string Concatenate(string[] args);

        static void Main(string[] args)
        {
            Concatenate concat = (arr) =>
            {
                string result = "";
                foreach (string s in arr)
                    result += s;

                return result;
            };

            Console.WriteLine(concat(args));
        }
    }
}