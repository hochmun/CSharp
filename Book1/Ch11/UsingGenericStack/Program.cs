/*
2023/06/29 // Stack<T> 예제

Stack<T>도 Stack과 기능과 사용 방법이 동일함

실행 결과
5
4
3
2
1
 */
namespace UsingGenericStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

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