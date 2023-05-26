using System.Globalization;
using static System.Console;

/*
 * 2023/05/26 // 심규영 // 날짜 및 시간 서식화
 * 
 * - 서식 지정자(MSDN)
 *  y   : 연도       : yy(두자리수 연도), yyyy(네 자릿수 연도)
 *  M   : 월         : M(한 자릿수 월), MM(두 자릿수 월)
 *  d   : 일         : d(한자릿수 일), dd
 *  h   : 시(1~12)   : h, hh
 *  H   : 시(1~23)   : H, HH
 *  m   : 분         : m, mm
 *  s   : 초         : s, ss
 *  tt  : 오전/오후  : tt
 *  ddd : 요일       : ddd(약식 요일), dddd(전체 요일)
 */
namespace StringFormatDatetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2023, 05, 26, 14, 54, 38);

            WriteLine("12시간 형식 : {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt); // 12시간 형식 : 2023-05-26 오후 02:54:38 (금)
            WriteLine("24시간 형식 : {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt); // 24시간 형식 : 2023-05-26 14:54:38 (금요일)

            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)}", ciKo)); // 2023-05-26 오후 02:54:38 (금)}
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)}", ciKo)); // 2023-05-26 14:54:38 (금요일)}
            WriteLine(dt.ToString(ciKo)); // 2023-05-26 오후 2:54:38

            CultureInfo ciEn = new CultureInfo("en-US");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)}", ciEn)); // 2023-05-26 PM 02:54:38 (Fri)}
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)}", ciEn)); // 2023-05-26 14:54:38 (Friday)}
            WriteLine(dt.ToString(ciEn)); // 5/26/2023 2:54:38 PM
        }
    }
}