﻿/*
2023/07/08 // 여러 개의 데이터 원본에 질의하기 예제

실행 결과
낙제 : 노랑반 (0)
낙제 : 노랑반 (17)
낙제 : 연두반 (24)
낙제 : 파랑반 (30)
낙제 : 분홍반 (45)
 */
namespace FromFrom
{
    class Class
    {
        public string Name { get; set; }
        public int[] Score { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Class[] arrClass =
            {
                new Class(){Name = "연두반", Score = new int[]{99, 80, 70, 24}},
                new Class(){Name = "분홍반", Score = new int[]{66, 45, 87, 72}},
                new Class(){Name = "파랑반", Score = new int[]{82, 30, 85, 94}},
                new Class(){Name = "노랑반", Score = new int[]{90, 88, 0, 17}},
            };

            var classes = from c in arrClass
                          from s in c.Score
                          where s < 60
                          orderby s
                          select new { c.Name, Lowest = s };

            foreach (var c in classes)
                Console.WriteLine($"낙제 : {c.Name} ({c.Lowest})");
        }
    }
}