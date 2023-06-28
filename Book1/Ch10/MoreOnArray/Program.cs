/*
2023/06/23 // Array 클래스의 주요 메소드와 프로퍼티 예제

실행 결과
80 74 81 90 34
34 74 80 81 90
Number of dimensions : 1
Binary Search : 81 is at 3
Linear Search : 90 is at 4
Everyone passed ? : False
Everyone passed ? : True
Old length of scores : 5
New length of scores : 10
61 74 80 81 90 0 0 0 0 0
61 74 80 0 0 0 0 0 0 0
 */
namespace MoreOnArray
{
    internal class Program
    {
        private static bool CheckPassed(int score)
        {
            if (score >= 60)
                return true;
            else
                return false;
        }

        private static void Print (int value)
        {
            Console.Write($"{value} ");
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            // 배열 출력
            foreach (int score in scores)
                Console.Write($"{score} ");
            Console.WriteLine();

            // 배열 정렬
            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            // 배열 차원 출력
            Console.WriteLine($"Number of dimensions : {scores.Rank}");

            // 이진 탐색
            Console.WriteLine("Binary Search : 81 is at {0}",
                Array.BinarySearch<int>(scores, 81));
            // 일반 탐색?
            Console.WriteLine("Linear Search : 90 is at {0}",
                Array.IndexOf(scores, 90));

            // 조건 부합 확인, 조건 => 60 이상 인가?
            Console.WriteLine("Everyone passed ? : {0}",
                Array.TrueForAll<int>(scores, CheckPassed));

            // 조건 부합 후 해당 인덱스 리턴
            int index = Array.FindIndex<int>(scores,
                delegate (int score)
                {
                    if (score < 60) return true;
                    else return false;
                });

            scores[index] = 61; // 해당 인덱스 값 변경

            Console.WriteLine("Everyone passed ? : {0}",
                Array.TrueForAll<int>(scores, CheckPassed));

            Console.WriteLine($"Old length of scores : {scores.GetLength(0)}");

            // 배열 길이 재정의
            Array.Resize<int>(ref scores, 10);

            Console.WriteLine($"New length of scores : {scores.Length}");

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            // 배열 비우기
            Array.Clear(scores, 3, 7);

            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();
        }
    }
}