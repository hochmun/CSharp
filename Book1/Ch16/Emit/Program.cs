using System.Reflection;
using System.Reflection.Emit;

/*
2023/07/12 // 형식 내보내기 예시

System.Reflection.Emit 네임스페이스의 클래스 사용 순서
1. AssemblyBuilder를 이용해서 어셈블리 생성
2. ModuleBuilder를 이용해서 1에서 생성한 어셈블리 안에 모듈을 만들어 넣는다.
3. TypeBuilder를 2에서 생성한 모둘 안에 클래스(형식)를 만들어 넣는다.
4. 3 에서 생성한 클래스 안에 메소드(MethodBuilder 이용)나 프로퍼티(PropertyBuilder 이용)를 만들어 넣는다.
5. 4 에서 생성한 것이 메소드라면, ILGenerator를 이용해서 메소드 안에 CPU가 실행할 IL 명령들을 넣는다.

실행 결과
5050
 */
namespace Emit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // .Net 7.0 에서는 지원하지 않는 방식
            /* 
            AssemblyBuilder newAssembly =
                AppDomain.CurrentDomain.DefineDynamicAssembly(
                    new AssemblyName("CalculatorAssembly"),
                    AssemblyBuilderAccess.Run);
            */

            // .Net 7.0 에서 지원하는 방식
            // 어셈블리 생성
            AssemblyBuilder newAssembly =
                AssemblyBuilder.DefineDynamicAssembly(
                    new AssemblyName("CalculatorAssembly"),
                    AssemblyBuilderAccess.Run);

            // 모듈 생성
            ModuleBuilder newModule = newAssembly.DefineDynamicModule("Calculator");
            // 클래스 생성
            TypeBuilder newType = newModule.DefineType("Sum1To100");

            // 메소드 생성 (껍데기)
            MethodBuilder newMethod = newType.DefineMethod(
                "Calculate",
                MethodAttributes.Public,
                typeof(int),                // 반환 형식
                new Type[0]);               // 매개 변수

            // 메소드가 실행할 코드 채워 넣기
            ILGenerator generator = newMethod.GetILGenerator();

            generator.Emit(OpCodes.Ldc_I4, 1); // 32비트 정수(1)를 계산 스택에 넣음

            for (int i = 2; i <= 100; i++)
            {
                generator.Emit(OpCodes.Ldc_I4, i); // 32비트 정수(i)를 계산 스택에 넣음
                generator.Emit(OpCodes.Add); // 계산 후 계산 스택에 담겨 있는 두 개의 값을 꺼내서 더한 후, 그 결과를 다시 계산 스택에 넣음
            }

            generator.Emit(OpCodes.Ret); // 계산 스택에 담겨 있는 값을 반환 함
            // 메소드 제출
            newType.CreateType();

            object sum1To100 = Activator.CreateInstance(newType);
            MethodInfo Calculate = sum1To100.GetType().GetMethod("Calculate");
            Console.WriteLine(Calculate.Invoke(sum1To100, null));
        }
    }
}