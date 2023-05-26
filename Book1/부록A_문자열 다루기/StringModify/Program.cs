﻿using static System.Console;

/*
 * 2023/05/20 // 심규영 // 문자열 변형
 *  - ToLower()     : 현재 문자열의 모든 대문자를 소문자로 바꾼 새 문자열을 반환합니다.
 *  - ToUpper()     : 현재 문자열의 모둔 소문자를 대문자로 바꾼 새 문자열을 반환합니다.
 *  - Insert()      : 현재 문자열의 지정된 위치에 지정된 문자열이 삽입된 새 문자열을 반환합니다.
 *  - Remove()      : 현재 문자열의 지정된 위치로부터 지정된 수만큼의 무자가 삭제된 새 문자열을 반환합니다.
 *  - Trim()        : 현재 문자열의 앞/뒤에 있는 공백을 삭제한 새 문자열을 반환합니다.
 *  - TrimStart()   : 현재 문자열의 앞에 있는 공백을 삭제한 새 문자열을 반환합니다.
 *  - TrimEnd()     : 현재 문자열의 뒤에 있는 공백을 삭제한 새 문자열을 반환합니다.
 */
namespace StringModify
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Lower() : '{0}'", "ABC".ToLower());                      // 'abc'
            WriteLine("ToUpper() : '{0}'", "ABC".ToUpper());                    // 'ABC'

            WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny")); // 'Happy Sunny Friday!'
            WriteLine("Remove() : '{0}'", "I Don't Love You".Remove(2, 6));     // 'I Love You'

            WriteLine("Trim() : '{0}'", " No Spaces ".Trim());                  // 'No Spaces'
            WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());        // 'No Spaces '
            WriteLine("TrimEnd() : '{0}'", " No Spaces ".TrimEnd());            // ' No Spaces'
        }
    }
}