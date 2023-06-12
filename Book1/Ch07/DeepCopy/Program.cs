/*
2023/06/06 // 심규영 // 얕은 복사와 깊은 복사 예제

실행
Shallow Copy
10 30
10 30
Deep Copy
10 20
10 30
 */
namespace DeepCopy
{
    // .Net 프레임워크의 System 네임스페이스에 ICloneable 인터페이스
    // 인터페이스에는 clone메소드 하나만 존재
    // 코드 호완용 인터페이스
    // 인터페이스는 다중 상속이 가능함
    class MyClass : ICloneable
    {
        public int MyField1;
        public int MyField2;

        // 인터페이스에서 상속받은 메소드
        public object Clone()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }

        public MyClass DeepCopy()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");

            { 
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }

            Console.WriteLine("Deep Copy");

            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                Console.WriteLine($"{source.MyField1} {source.MyField2}");
                Console.WriteLine($"{target.MyField1} {target.MyField2}");
            }
        }
    }
}