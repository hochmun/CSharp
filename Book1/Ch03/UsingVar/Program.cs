namespace UsingVar
{
    /*
     * 2023/05/17 // 심규영 // var: 데이터 형식을 알아서 파악하는 똑똑한 C# 컴파일러
     * 
     * - var는 지역 변수로만 사용할 수 있다.
     * - var 키워드로 필드를 선언하면 컴파일러가 무슨 형식인지 파악할 수 없기 때문
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 20;
            Console.WriteLine("Type : {0}, Value : {1}", a.GetType(), a);

            var b = 3.1414213;
            Console.WriteLine("Type : {0}, Value : {1}", b.GetType(), b);

            var c = "Hello, World!";
            Console.WriteLine("Type : {0}, Value : {1}", c.GetType(), c);

            var d = new int[] { 10, 20, 30 };
            Console.Write("Type : {0}, Value : ", d.GetType());

            foreach (var e in d) {
                Console.Write("{0} ", e);
            }

            Console.WriteLine();
        }
    }
}