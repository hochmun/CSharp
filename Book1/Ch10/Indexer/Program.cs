/*
2032/06/28 // 인덱서 예제

실행 결과
Array Resized : 4
Array Resized : 5
0
1
2
3
4
 */
namespace Indexer
{
    class MyList
    {
        private int[] array;

        public MyList()
        {
            array = new int[3];
        }

        // 인덱서 선언
        public int this[int index]
        {
            get { return array[index]; }
            set {
                if (index >= array.Length)
                {
                    Array.Resize<int>(ref array, index + 1);
                    Console.WriteLine($"Array Resized : {array.Length}");
                }

                array[index] = value;
            }
        }

        public int Length
        {
            get { return array.Length;}
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            MyList list = new MyList();
            for (int i = 0; i < 5; i++)
                list[i] = i;

            for (int i = 0; i < list.Length; i++)
                Console.WriteLine(list[i]);
        }
    }
}