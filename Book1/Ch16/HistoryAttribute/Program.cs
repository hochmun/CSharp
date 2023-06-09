﻿/*
2023/07/13 // 내가 만드는 애트리뷰트 예시

실행 결과
MyClass change history...
Ver : 0.1, Programmer : Sean, Changes : 2017-11-01 Created class stub
Ver : 0.2, Programmer : Bob, Changes : 2017-12-03 Added Func() Method
 */
namespace HistoryAttribute
{
    [System.AttributeUsage(System.AttributeTargets.Class, AllowMultiple = true)] // 애트리뷰트의 중복 사용 여부 설정
    class History : System.Attribute // 상속을 통해 클래스를 애트리뷰트로 선언
    {
        private string programmer;
        public double version;
        public string changes;

        public History(string programmer)
        {
            this.programmer = programmer;
            version = 1.0;
            changes = "First release";
        }

        public string GetProgrammer()
        {
            return programmer;
        }
    }

    [History("Sean", version = 0.1, changes = "2017-11-01 Created class stub")]
    [History("Bob",  version = 0.2, changes = "2017-12-03 Added Func() Method")]
    class Myclass
    {
        public void Func()
        {
            Console.WriteLine("Func()");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Myclass);
            Attribute[] attributes = Attribute.GetCustomAttributes(type);

            Console.WriteLine("MyClass change history...");

            foreach (Attribute a in attributes)
            {
                History? h = a as History;
                if (h != null)
                    Console.WriteLine("Ver : {0}, Programmer : {1}, Changes : {2}",
                        h.version, h.GetProgrammer(), h.changes);
            }
        }
    }
}