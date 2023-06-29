/*
2023/06/29 // List<T> 예제

ArrayList와 차이점
 - List<T> 클래스는 인스턴스를 만들 때 형식 매개 변수를 필요로 함
 - "아무"형식의 객체나 마구 집어 넣을 수 있었던 ArrayList와는 달리
   LIst<T>는 형식 매개 변수로 입력한 형식 외에는 입력을 허용하지 않음

실행 결과
0 1 2 3 4
0 1 3 4
0 1 2 3 4
 */
namespace UsingGenericList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
                list.Add(i);

            foreach (int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();

            list.Remove(2);

            foreach (int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();

            list.Insert(2, 2);

            foreach (int element in list)
                Console.Write($"{element} ");
            Console.WriteLine();
        }
    }
}