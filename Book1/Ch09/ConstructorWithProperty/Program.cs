/*
2023/06/22 // 프로퍼티와 생성자 예시

실행 결과
Name : 호문
Birthday : 1996-02-14
Age : 28
 */
namespace ConstructorWithProperty
{
    class BirthdayInfo
    {
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Age
        {
            get { return new DateTime(DateTime.Now.Subtract(Birthday).Ticks).Year; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 프로퍼티 생성자 형식
            BirthdayInfo birth = new BirthdayInfo()
            {
                Name = "호문",
                Birthday = new DateTime(1996, 2, 14)
            };

            Console.WriteLine($"Name : {birth.Name}");
            Console.WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            Console.WriteLine($"Age : {birth.Age}");
        }
    }
}