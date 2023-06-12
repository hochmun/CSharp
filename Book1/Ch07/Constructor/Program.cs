/*
2023/06/05 // 심규영 // 생성자와 종료자 예제

출력
키티 : 야옹
키티 : 하얀색
네로 : 야옹
네로 : 검은색

종료자의 출력은 될 수도 있고 안 될 수도 있음
종료자의 사용은 권장 되지 않음
가비지 컬렉터의 실행 시간을 정확히 알 수 없고
기능 저하를 유발함
 */
namespace Constructor
{
    class Cat
    {
        public string Name;
        public string Color;

        // 생성자
        public Cat()
        {
            Name = "";
            Color = "";
        }

        public Cat(string _Name, string _Color)
        {
            Name = _Name;
            Color = _Color;
        }

        // 기능
        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }

        // 종료자
        ~Cat() 
        {
            Console.WriteLine($"{Name} : 잘가");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat("키티", "하얀색");
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat("네로", "검은색");
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}