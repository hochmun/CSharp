/*
2023/06/13 // 심규영 // 재밌는 나머지 연산

문제 
 - 정수 N을 m으로 나눈 나머지가 R이 되도록 하는 모든 양의 정수 m의 합을 구하라.

입력
 - 첫째 줄에 정수 N과 R이 공백을 사이에 두고 주어진다. ( 1 <= N <= 10^12, 0 <= R < N )

출력
 - 정수 N을 m으로 나눈 나머지가 R이 되도록 하는 모든 양의 정수 m의 합을 출력 한다.
 - 조건을 만족하는 m이 없으면 0 을 출력한다.

풀이
 N = xm + R  =>  xm = N - R  =>  m = (N - R) / x
 (N - R)을 a로 치환 하면
 a 에 대한 약수의 합 구하기
 합을 구하는 약수는 R보다 커야함
 */
namespace _28138
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split();

            long sum = 0; // 합계를 담을 변수
            long N = long.Parse(arr1[0]); // 정수 N
            long R = long.Parse(arr1[1]); // 나머지 R

            long a = N - R; // 약수를 구해야 하는 a

            List<long> list = new List<long>();

            for (long x = 1; x <= Math.Sqrt(a); x++)
            {
                if (a % x == 0)
                {
                    list.Add(x); // 전반부 약수 저장
                }
            }

            int cnt = list.Count();
            for (int i = 0; i < cnt; i++)
            {
                list.Add(a / list[i]); // 후반부 약수 저장
            }

            // 중복 값 제거 (Distinct())
            // 약수 값이 나머지 보다 큰 것 중에서 (Where(item => item > R)
            // 합계 구하기(Sum())
            sum = list.Distinct().Where(item => item > R).Sum();

            Console.WriteLine(sum);
        }
    }
}