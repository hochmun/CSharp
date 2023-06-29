using System.Collections;

/*
2023/06/29 // foreach를 사용할 수 있는 일반화 클래스 예제

IEnumerable<T> 클래스의 메소드와 설명
 - IEnumerator GetEnumerator()      : IEnumerator 형식의 객체를 반환(IEnumerable로부터 상속받은 메소드)
 - IEnumerator<T> GetEnumerator()   : IEnumerator<T> 형식의 객체를 반환

IEnumerator<T> 클래스의 메소드와 프로퍼티 설명
 - Boolean MoveNext()       : 다음 요소로 이동합니다.
                              컬렉션의 끝을 지난 경우에는 false, 이동이 성공한 경우에는 true를 반환
 - void Reset()             : 컬렉션의 첫 번째 위치의 "앞"으로 이동합니다.
                              첫 번째 위치가 0번일 때, Reset()을 호출 하면 -1번으로 이동함
                              첫 번째 위치로의 이동은 MoveNext()를 호출한 다음에 이루어집니다.
 - Object Current { get; }  : 컬렉션의 현재 요소를 반환합니다.
                              IEnumerator로부터 상속받은 프로퍼티이다.
 - T Current { get; }       : 컬렉션의 현재 요소를 반환합니다.

실행 결과
Array Resized : 4
Array Resized : 5
abc
def
ghi
jkl
mno

Array Resized : 4
Array Resized : 5
0
1
2
3
4
 */
namespace EnumerableGeneric
{
    class MyList<T> : IEnumerable<T>, IEnumerator<T>
    {
        private T[] array;
        int position = -1;

        public MyList() { array = new T[3]; }

        public T this[int index]
        {
            get { return array[index]; }
            set
            {
                if (index >= array.Length)
                {
                    Array.Resize<T>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        public int Length { get { return array.Length; } }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        public T Current
        {
            get { return array[position]; }
        }

        object IEnumerator.Current
        {
            get { return array[position]; }
        }

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

        public void Reset() { position = -1; }

        public void Dispose() { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> str_list = new MyList<string>();
            str_list[0] = "abc";
            str_list[1] = "def";
            str_list[2] = "ghi";
            str_list[3] = "jkl";
            str_list[4] = "mno";

            foreach(string str in str_list) 
                Console.WriteLine(str);

            Console.WriteLine();

            MyList<int> int_list = new MyList<int>();
            int_list[0] = 0;
            int_list[1] = 1;
            int_list[2] = 2;
            int_list[3] = 3;
            int_list[4] = 4;

            foreach (int no in int_list)
                Console.WriteLine(no);
        }
    }
}