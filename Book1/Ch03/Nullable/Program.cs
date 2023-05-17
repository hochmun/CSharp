namespace Nullable
{
    /*
     * 2023/05/17 // 심규영 // nullable 예시
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = null;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);

            a = 3;

            Console.WriteLine(a.HasValue);
            Console.WriteLine(a != null);
            Console.WriteLine(a.Value);
        }
    }
}