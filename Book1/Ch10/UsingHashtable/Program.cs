using System.Collections;

/*
2023/06/28 // Hashtable 예제

 - Hashtable은 키(key)와 값(value)의 쌍으로 이루어진 데이터를 다룰 때 사용됨.
 - 어떤 형식으로도 키로 사용가능.
 - Hashtable은 배열에서 인덱스를 이용해서 배열 요소에 접근하는 것에 준하는 탐색 속도를 가짐.

실행 결과
one
two
three
four
five
 */
namespace UsingHashtable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht["하나"] = "one";
            ht["둘"] = "two";
            ht["셋"] = "three";
            ht["넷"] = "four";
            ht["다섯"] = "five";

            Console.WriteLine(ht["하나"]);
            Console.WriteLine(ht["둘"]);
            Console.WriteLine(ht["셋"]);
            Console.WriteLine(ht["넷"]);
            Console.WriteLine(ht["다섯"]);
        }
    }
}