using System.Collections;

/*
2023/06/28 // Stack 예제

 - Stack은 Queue와는 반대로 먼저 들어온 데이터가 나중에 나가고(First In - Last Out),
나중에 들어온 데이터는 먼저 나가는(Last In - First Out) 구조의 컬렉션이다.
 - 입력은 Push, 출력은 Pop

실행 결과
5
4
3
2
1
 */
namespace UsingStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            while (stack.Count > 0)
                Console.WriteLine(stack.Pop());
        }
    }
}