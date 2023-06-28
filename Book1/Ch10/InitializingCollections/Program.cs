using System.Collections;

/*
2023/06/28 // 컬렉션 초기화 예제

실행 결과
ArrayList : 123
ArrayList : 456
ArrayList : 789

Stack : 789
Stack : 456
Stack : 123

Queue : 123
Queue : 456
Queue : 789

ArrayList2  : 11
ArrayList2  : 22
ArrayList2  : 33
 */
namespace InitializingCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 123, 456, 789 };

            // 배열을 이용한 컬렉션 초기화
            ArrayList list = new ArrayList(arr);
            foreach (object item in list)
                Console.WriteLine($"ArrayList : {item}");
            Console.WriteLine();

            Stack stack = new Stack(arr);
            foreach(object item in stack)
                Console.WriteLine($"Stack : {item}");
            Console.WriteLine();

            Queue queue = new Queue(arr);
            foreach (object item in  queue)
                Console.WriteLine($"Queue : {item}");
            Console.WriteLine();

            // 컬렉션 초기자를 이용한 컬렉션 초기화
            ArrayList list2 = new ArrayList() { 11, 22, 33 };
            foreach (object item in list2)
                Console.WriteLine($"ArrayList2  : {item}");
            Console.WriteLine();

            // 딕셔너리 초기자(Dictionary Initialzer)를 이용한 초기화
            // 컬렉션 초기자를 사용할 수 도 있음.
            Hashtable ht = new Hashtable()
            {
                ["하나"] = 1,
                ["둘"] = 2,
                ["셋"] = 3
            };
        }
    }
}