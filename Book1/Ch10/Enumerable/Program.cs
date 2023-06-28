using System.Collections;

/*
2023/06/28 // foreach가 가능한 객체 만들기

IEnumerable 인터페이스의 보유 메소드
 - IEnumerator GetEnumerator() : IEnumerator 형식의 객체를 반환

IEnumerator 인터페이스의 보유 메소드 또는 프로퍼티
 - boolean MoveNext() : 다음 요소로 이동합니다.
                        컬렉션의 끝을 지난 경우에는 false, 이동이 성공한 경우에는 true를 반환
 - void Reset() : 컬렉션의 첫 번째 위치의 "앞"으로 이동합니다.
                  첫 번째 위치가 0번이라면, Reset()을 호출하면 -1번으로 이동
                  첫 번째 위치로의 이동은 MoveNext()를 호출한 다음에 이루어짐
 - Object Current{ get;} : 컬렉션의 현재 요소를 반환합니다.

실행 결과
Array Resized : 4
Array Resized : 5
0
1
2
3
4
 */
namespace Enumerable
{
    class MyList : IEnumerable, IEnumerator
    {
        private int[] array;
        int position = -1;

        public MyList()
        {
            array = new int[3];
        }

        public int this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        // IEnumerator 멤버
        // 현제 위치의 요소 반환
        public object Current
        {
            get { return array[position]; }
        }

        // IEnumerator 멤버
        // 요소의 위치를 첫 요소의 앞으로 옮김
        public void Reset() { position = -1; }

        // IEnumerator 멤버
        // 다음 위치의 요소로 이동
        public bool MoveNext()
        {
            if (position == array.Length - 1)
            {
                Reset();
                return false;
            }

            position++;
            return (position < array.Length);
        }

        // IEnumerable 멤버
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++) { yield return array[i]; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            foreach (int e in list)
                Console.WriteLine(e);
        }
    }
}