using System.Linq.Expressions;

/*
2023/07/04 // 식 트리 예제 1

Expression의 파생 클래스 및 설명

 - BinaryExpression             : 이항 연산자(+,-,/,%,&,|,^,<<,>>,&&,||,==,!=,>,>=,<,<=)를 갖는 식을 표현합니다.
 - BlockExpression              : 변수를 정의할 수 있는 식을 갖는 블록을 표현합니다.
 - ConditionalExpression        : 조건 연산자가 있는 식을 나타냅니다.
 - ConstantExpression           : 상수가 있는 식을 나타냅니다.
 - DefaultExpression            : 형식(type)이나 비어있는 식의 기본값을 표현합니다.
 - DynamicExpression            : 동적 작업을 나타냅니다.
 - GotoExpression               : return, break, continue, goto와 같은 점프문을 나타냅니다.
 - IndexExpression              : 배열의 인덱스 참조를 나타냅니다.
 - InvocationExpression         : 대리자나 람다식 호출을 나타냅니다.
 - LabelExpression              : 레이블을 나타냅니다.
 - LambdaExpression             : 람다식을 나타냅니다.
 - ListlnitExpression           : 컬랙션 이니셜라이저가 있는 생성자 호출을 나타냅니다.
 - LoopExpression               : 무한 루프를 나타냅니다. 무한 루프는 break 문을 이용해서 종료할 수 있습니다.
 - MemberExpression             : 객체의 필드나 속성을 나타냅니다.
 - MemberInitExpression         : 생성자를 호출하고 새 객체의 멤버를 초기화하는 동작을 나타냅니다.
 - MethodCallExpression         : 메소드 호출을 나타냅니다.
 - NewArrayExpression           : 새 배열의 생성과 초기화를 나타냅니다.
 - NewExpression                : 생성자 호출을 나타냅니다.
 - ParameterExpression          : 명명된 매개 변수를 나타냅니다.
 - RuntimeVariablesExpression   : 변수에 대한 런타임 읽기/쓰기 권한을 제공합니다.
 - SwitchExpression             : 다중 선택 제어 식을 나타냅니다.
 - TryExpression                : try ~ catch ~ finally 블록을 나타냅니다.
 - TypeBinaryExpression         : 형식 테스트를 비롯한 형식(Type)과 식(Expression)의 연산을 나타냅니다.
 - UnaryExpression              : 단항 연산자를 갖는 식을 나타냅니다.

실행 결과
1*2+(7-8) = 1
 */
namespace UsingExpressionTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1*2+(x-y)
            Expression const1 = Expression.Constant(1);
            Expression const2 = Expression.Constant(2);

            Expression leftExp = Expression.Multiply(const1, const2); // 1 * 2

            Expression param1 =
                Expression.Parameter(typeof(int)); // x를 위한 변수
            Expression param2 = 
                Expression.Parameter(typeof(int)); // y를 위한 변수

            Expression rightExp = Expression.Subtract(param1, param2); // x - y

            Expression exp = Expression.Add(leftExp, rightExp);

            Expression<Func<int, int, int>> expression =
                Expression<Func<int, int, int>>.Lambda<Func<int, int, int>>(
                    exp, new ParameterExpression[]
                    {
                        (ParameterExpression)param1,
                        (ParameterExpression)param2
                    });

            Func<int, int, int> func = expression.Compile();

            // x = 7, y = 8
            Console.WriteLine($"1*2+({7}-{8}) = {func(7,8)}");
        }
    }
}