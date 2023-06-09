﻿/*
2023/07/04 // 식으로 이루어지는 멤버 예시

실행 결과
FriendList()
Meeny
Miny
4
10
Meeny
Moe
Miny
 */
namespace ExpressionBodiedMember
{
    class FriendList
    {
        private List<string> list = new List<string>();

        public void Add(string name) => list.Add(name);
        public void Remove(string name) => list.Remove(name);
        public void PrintAll()
        {
            foreach (var s in list)
                Console.WriteLine(s);
        }

        public FriendList() => Console.WriteLine("FriendList()");
        ~FriendList() => Console.WriteLine("~FriendList()");

        // public int Capacity => list.Capacity; // 읽기 전용

        public int Capacity
        {
            get => list.Capacity;
            set => list.Capacity = value;
        }

        // public string this[int index] => list[index]; // 읽기 전용
        public string this[int index]
        {
            get => list[index];
            set => list[index] = value;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FriendList obj = new FriendList();
            obj.Add("Eeny");
            obj.Add("Meeny");
            obj.Add("Miny");
            obj.Remove("Eeny");
            obj.PrintAll();

            Console.WriteLine($"{obj.Capacity}");
            obj.Capacity = 10;
            Console.WriteLine($"{obj.Capacity}");

            Console.WriteLine($"{obj[0]}");
            obj[0] = "Moe";
            obj.PrintAll();
        }
    }
}