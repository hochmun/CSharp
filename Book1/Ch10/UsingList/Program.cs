using System.Collections;

/*
2023/06/28 // ArrayList 예제

실행 결과
0 1 2 3 4
0 1 3 4
0 1 2 3 4
0 1 2 3 4 abc def

ArrayList가 다양한 형식의 객체를 담을 수 있는 이유
 - object 형식의 매개변수를 받아서
 - int 형식의 데이터를 넣더라도 형식 그대로 입력되는 것이 아니라 object형식으로 박싱(Boxing)되어 입력됨
 - 반대로 ArrayList의 요소에 접근해서 사용할 때는 원래의 데이터 형식으로 언박싱(Unboxing)이 이루어짐
 - 박싱과 언박싱은 작지 않은 오버헤드를 요구하는 작업이므로 ArrayList가 다루는 데이터가 많으면 많아질수록 성능의 저하가 늘어남
 - ArrayList 만의 문제가 아니며 Stack, Queue, Hashtable 등의 컬렉션 또한 같은 문제를 가지고 있음
 - 일반화 컬렉션(Generic Collection)으로 해결 한다고 함.
 */
namespace UsingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            foreach (Object obj in list)
            {
                Console.Write($"{obj} ");  
            }
            Console.WriteLine();

            // 인덱스가 2인 요소 제거
            list.RemoveAt(2);

            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            // 인덱스 2에 2 삽입
            list.Insert(2, 2);

            foreach (object obj in list)
                Console.Write($"{obj} ");
            Console.WriteLine();

            // 배열의 끝 부분에 추가
            list.Add("abc");
            list.Add("def");

            for (int i = 0; i < list.Count; i++)
                Console.Write($"{list[i]} ");
            Console.WriteLine();
        }
    }
}