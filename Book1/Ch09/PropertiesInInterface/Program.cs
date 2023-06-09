﻿/*
2023/06/22 // 인터페이스의 프로퍼티 예제

실행 결과
이름 : 박상현
키 : 177cm
몸무게 : 90Kg
 */
namespace PropertiesInInterface
{
    interface INamedValue
    {
        string Name { get; set; }
        string Value { get; set; }
    }

    class NamedValue : INamedValue
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            NamedValue name = new NamedValue()
            {
                Name = "이름", Value = "박상현"
            };

            NamedValue height = new NamedValue()
            {
                Name = "키",
                Value = "177cm"
            };

            NamedValue weight = new NamedValue()
            {
                Name = "몸무게",
                Value = "90Kg"
            };

            Console.WriteLine($"{name.Name} : {name.Value}");
            Console.WriteLine($"{height.Name} : {height.Value}");
            Console.WriteLine($"{weight.Name} : {weight.Value}");
        }
    }
}