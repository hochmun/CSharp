/*
2023/06/22 // 무명 형식 예제

실행 결과
Name : 박상현, Age : 123
Subject : 수학, Scores : 90 80 70 60
 */
namespace AnnoymousType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new { Name = "박상현", Age = 123 };
            Console.WriteLine($"Name : {a.Name}, Age : {a.Age}");

            var b = new { Subject = "수학", Scores = new int[] { 90, 80, 70, 60 } };
            Console.Write($"Subject : {b.Subject}, Scores : ");
            foreach ( var score in b.Scores )
            {
                Console.Write($"{score} ");
            }
            Console.WriteLine();
        }
    }
}