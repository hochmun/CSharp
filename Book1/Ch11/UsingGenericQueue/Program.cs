/*
2023/06/29 // Queue<T> 예제

Queue<T> 클래스는 형식 매개 변수를 요구한다는 점만 다를 뿐,
비일반화 클래스인 Queue와 같은 기능을 하며 사용법도 동일함

실행 결과
1
2
3
4
5
 */
namespace UsingGenericQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            while (queue.Count > 0)
                Console.WriteLine(queue.Dequeue());
        }
    }
}