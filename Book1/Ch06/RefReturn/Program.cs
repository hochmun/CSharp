/*
2023/05/31 // 심규영 // refReturn 예제

출력
Price :100
Ref Local Price :100
Normal Local Price :100
Price :200
Local Price :200
Normal Local Price : 100
 */
namespace RefReturn
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            Console.WriteLine($"Price :{price}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice(); // Price :100
            Console.WriteLine($"Ref Local Price :{ref_local_price}"); // Ref Local Price :100
            Console.WriteLine($"Normal Local Price :{normal_local_price}"); // Normal Local Price :100

            ref_local_price = 200;

            carrot.PrintPrice(); // Price :200
            Console.WriteLine($"Local Price :{ref_local_price}"); // Local Price :200
            Console.WriteLine($"Normal Local Price : {normal_local_price}"); // Normal Local Price : 100
        }
    }
}