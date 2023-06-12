/*
2023/06/10 // 심규영 // 기반 클래스와 파생 클래스 사이의 형식 변환, is 와 as 연산자

실행
Bark()
Meow()
Cat2 is not a Cat

is - 객체가 해당 형식에 해당하는지를 검사하여 그 결과를 bool 값으로 반환합니다.
as - 형식변환 연산자와 같은 역활을 합니다.
 다만 형변환 연산자가 변환에 실패하는 경우 예외를 던지는 반면에 as 연산자는 객체 참조를 null로 만든다는 것이 다릅니다.
 */
namespace TypeCasting
{
    class Mammal
    {
        public void Nurse()
        {
            Console.WriteLine("Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine("Bark()");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine("Meow()");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Dog();
            Dog dog;

            if (mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Cat();

            Cat cat = mammal2 as Cat;
            if (cat != null)
                cat.Meow();

            Cat cat2 = mammal as Cat;
            if (cat2 != null)
                cat2.Meow();
            else
                Console.WriteLine("Cat2 is not a Cat");
        }
    }
}