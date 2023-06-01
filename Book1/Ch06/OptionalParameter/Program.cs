/*
2023/06/01 // 심규영 // 선택적 매개 변수 예제

실행 결과
Name :태연, Phone :
Name :윤아, Phone :010-123-1234
Name :유리, Phone :
Name :서현, Phone :010-789-7890
 */
namespace OptionalParameter
{
    internal class Program
    {
        static void PrintProfile(string name, string phone = "")
        {
            Console.WriteLine($"Name :{name}, Phone :{phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile("태연");
            PrintProfile("윤아", "010-123-1234");
            PrintProfile(name:"유리");
            PrintProfile(name:"서현", phone:"010-789-7890");
        }
    }
}