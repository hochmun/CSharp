using System.Collections;

/*
2023/06/28 // Queue(대기열) 예제

 - Queue는 입력(Enqueue)은 오직 뒤에서 출력(Dequeue)은 앞에서만 이루어짐
 - Queue는 출력을 실행 하면 데이터를 자료 구조에서 실제로 꺼내게 됨

실행 결과
1
2
3
4
5
 */
namespace UsingQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);

            while (que.Count > 0) 
                Console.WriteLine(que.Dequeue());
        }
    }
}