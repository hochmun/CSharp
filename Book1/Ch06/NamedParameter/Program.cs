/*
2023/06/01 // 심규영 // 명명된 매개 변수 사용 예제

실행 값
Name:박찬호, Phone:010-123-1234
Name:박지성, Phone:010-987-9876
Name:박세리, Phone:010-222-2222
Name:박상현, Phone:010-567-5678
 */
namespace NamedParameter
{
    internal class Program
    {
        static void PrintProfile(string name, string phone)
        {
            Console.WriteLine($"Name:{name}, Phone:{phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile(name: "박찬호", phone: "010-123-1234");
            PrintProfile(phone: "010-987-9876", name:"박지성");
            PrintProfile("박세리", "010-222-2222");
            PrintProfile("박상현", phone: "010-567-5678");
        }
    }
}