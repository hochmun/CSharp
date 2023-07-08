/*
2023/07/08 // LINQ의 기본 from, where, orderby, select 예시 1

from : 범위 변수 설정
where : 필터 역활
orderby : 데이터의 정렬을 수행하는 연산자 {ascending : 오름차순, descending : 내림차순}
select : 최종 결과 추출

실행 결과
짝수 : 2
짝수 : 4
짝수 : 6
짝수 : 8
짝수 : 10
 */
namespace From
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 9, 2, 6, 4, 5, 3, 7, 8, 1, 10 };

            var result = from n in numbers
                         where n % 2 == 0
                         orderby n ascending
                         select n;

            foreach (int n in result)
                Console.WriteLine($"짝수 : {n}");
        }
    }
}