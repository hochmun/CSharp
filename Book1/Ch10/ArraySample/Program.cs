/*
2023/06/23 // 배열 예제

실행 결과
80
74
81
90
34
Average Score : 71
 */
namespace ArraySample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 90;
            scores[4] = 34;

            foreach (int score in scores) 
                Console.WriteLine(score);

            int sum = 0;
            foreach (int score in scores)
                sum += score;

            // 배열 객체의 Length 프로퍼티는 배열의 용량을 나타냅니다.
            int average = sum / scores.Length;

            Console.WriteLine($"Average Score : {average}");
        }
    }
}