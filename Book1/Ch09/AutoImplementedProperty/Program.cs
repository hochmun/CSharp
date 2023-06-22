/*
2023/06/22 // 자동 구현 프로퍼티 예제

실행 결과
Name : Unknown
Birthday : 0001-01-01
Age : 2023
Name : 호문
Birthday : 1996-02-14
Age : 28

 - 객체는 C# 컴파일러가 자동으로 private로 선언되어짐
 */
namespace AutoImplementedProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; } = "Unknown";
        public DateTime Birthday { get; set; } = new DateTime(1, 1, 1);
        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo();
            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");

            birth.Name = "호문";
            birth.Birthday = new DateTime(1996, 2, 14);

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}