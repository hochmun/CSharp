/*
2023/06/22 // 추상 클래스의 프로퍼티 예제

실행 결과
Product : 00000, Product Date : 2018-01-10 오전 12:00:00
Product : 00001, Product Date : 2018-02-03 오전 12:00:00
 */
namespace PropertiesInAbstractClass
{
    abstract class Product
    {
        private static int serial = 0;

        // 추상 클래스는 구현을 가진 프로퍼티와
        public string SerialID
        {
            get { return String.Format("{0:d5}", serial++); }
        }

        // 구현이 없는 추상 프로퍼티 모두를 가질 수 있다.
        abstract public DateTime ProductDate { get; set; }
    }

    class MyProduct : Product
    {
        // 파생 클래스는 부모 추상 클래스의 모든 추상 메소드뿐 아니라
        // 추상 프로퍼티를 재정의 해야 함.
        public override DateTime ProductDate { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product product_1 = new MyProduct()
            {
                ProductDate = new DateTime(2018, 1, 10)
            };

            Console.WriteLine("Product : {0}, Product Date : {1}",
                product_1.SerialID, product_1.ProductDate);

            Product product_2 = new MyProduct()
            {
                ProductDate = new DateTime(2018, 2, 3)
            };

            Console.WriteLine("Product : {0}, Product Date : {1}",
                product_2.SerialID, product_2.ProductDate);

        }
    }
}