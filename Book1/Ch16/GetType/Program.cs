using System.Reflection;

/*
2023/07/12 // 리플렉션, Object.GetType() 메소드와 Type 클래스

 - int 형식의 주요 정보(상속하는 인터페이스, 필드, 메소드, 프로퍼티 등)를 출력하는 예제
 - Type의 다른 메소드는 P.518 참조
 - 또는 MSDN을 통해 모든 기능 확인 가능

실행 결과
-------- Interfaces --------
Name : IComparable
Name : IConvertible
Name : ISpanFormattable
Name : IFormattable
Name : IComparable`1
Name : IEquatable`1
Name : IBinaryInteger`1
Name : IBinaryNumber`1
Name : IBitwiseOperators`3
Name : INumber`1
Name : IComparisonOperators`3
Name : IEqualityOperators`3
Name : IModulusOperators`3
Name : INumberBase`1
Name : IAdditionOperators`3
Name : IAdditiveIdentity`2
Name : IDecrementOperators`1
Name : IDivisionOperators`3
Name : IIncrementOperators`1
Name : IMultiplicativeIdentity`2
Name : IMultiplyOperators`3
Name : ISpanParsable`1
Name : IParsable`1
Name : ISubtractionOperators`3
Name : IUnaryPlusOperators`2
Name : IUnaryNegationOperators`2
Name : IShiftOperators`3
Name : IMinMaxValue`1
Name : ISignedNumber`1

-------- Fields --------
Access : private, Type : Int32, Name : m_value
Access : public, Type : Int32, Name : MaxValue
Access : public, Type : Int32, Name : MinValue

-------- Properties --------

-------- Methods --------
type : Int32, Name : CompareTo, Parameter : Object
type : Int32, Name : CompareTo, Parameter : Int32
type : Boolean, Name : Equals, Parameter : Object
type : Boolean, Name : Equals, Parameter : Int32
type : Int32, Name : GetHashCode, Parameter :
type : String, Name : ToString, Parameter :
type : String, Name : ToString, Parameter : String
type : String, Name : ToString, Parameter : IFormatProvider
type : String, Name : ToString, Parameter : String, IFormatProvider
type : Boolean, Name : TryFormat, Parameter : Span`1, Int32&, ReadOnlySpan`1, IFormatProvider
type : Int32, Name : Parse, Parameter : String
type : Int32, Name : Parse, Parameter : String, NumberStyles
type : Int32, Name : Parse, Parameter : String, IFormatProvider
type : Int32, Name : Parse, Parameter : String, NumberStyles, IFormatProvider
type : Int32, Name : Parse, Parameter : ReadOnlySpan`1, NumberStyles, IFormatProvider
type : Boolean, Name : TryParse, Parameter : String, Int32&
type : Boolean, Name : TryParse, Parameter : ReadOnlySpan`1, Int32&
type : Boolean, Name : TryParse, Parameter : String, NumberStyles, IFormatProvider, Int32&
type : Boolean, Name : TryParse, Parameter : ReadOnlySpan`1, NumberStyles, IFormatProvider, Int32&
type : TypeCode, Name : GetTypeCode, Parameter :
type : ValueTuple`2, Name : DivRem, Parameter : Int32, Int32
type : Int32, Name : LeadingZeroCount, Parameter : Int32
type : Int32, Name : PopCount, Parameter : Int32
type : Int32, Name : RotateLeft, Parameter : Int32, Int32
type : Int32, Name : RotateRight, Parameter : Int32, Int32
type : Int32, Name : TrailingZeroCount, Parameter : Int32
type : Boolean, Name : IsPow2, Parameter : Int32
type : Int32, Name : Log2, Parameter : Int32
type : Int32, Name : Clamp, Parameter : Int32, Int32, Int32
type : Int32, Name : CopySign, Parameter : Int32, Int32
type : Int32, Name : Max, Parameter : Int32, Int32
type : Int32, Name : Min, Parameter : Int32, Int32
type : Int32, Name : Sign, Parameter : Int32
type : Int32, Name : Abs, Parameter : Int32
type : Int32, Name : CreateChecked, Parameter : TOther
type : Int32, Name : CreateSaturating, Parameter : TOther
type : Int32, Name : CreateTruncating, Parameter : TOther
type : Boolean, Name : IsEvenInteger, Parameter : Int32
type : Boolean, Name : IsNegative, Parameter : Int32
type : Boolean, Name : IsOddInteger, Parameter : Int32
type : Boolean, Name : IsPositive, Parameter : Int32
type : Int32, Name : MaxMagnitude, Parameter : Int32, Int32
type : Int32, Name : MinMagnitude, Parameter : Int32, Int32
type : Boolean, Name : TryParse, Parameter : String, IFormatProvider, Int32&
type : Int32, Name : Parse, Parameter : ReadOnlySpan`1, IFormatProvider
type : Boolean, Name : TryParse, Parameter : ReadOnlySpan`1, IFormatProvider, Int32&
type : Type, Name : GetType, Parameter :
 */
namespace GetType
{
    internal class Program
    {
        static void PrintInterfaces(Type type)
        {
            Console.WriteLine("-------- Interfaces --------");

            Type[] interfaces = type.GetInterfaces();

            foreach (Type i in interfaces)
                Console.WriteLine("Name : {0}", i.Name);

            Console.WriteLine();
        }

        static void PrintFields(Type type)
        {
            Console.WriteLine("-------- Fields --------");

            FieldInfo[] fields = type.GetFields(
                    BindingFlags.NonPublic |
                    BindingFlags.Public |
                    BindingFlags.Static |
                    BindingFlags.Instance
                );

            foreach (FieldInfo field in fields)
            {
                String accessLevel = "protected";
                if (field.IsPublic) accessLevel = "public";
                else if (field.IsPrivate) accessLevel = "private";

                Console.WriteLine("Access : {0}, Type : {1}, Name : {2}",
                    accessLevel, field.FieldType.Name, field.Name);
            }

            Console.WriteLine();
        }

        static void PrintMethods(Type type)
        {
            Console.WriteLine("-------- Methods --------");

            MethodInfo[] methods = type.GetMethods();

            foreach (MethodInfo method in methods)
            {
                Console.Write("type : {0}, Name : {1}, Parameter : ",
                    method.ReturnType.Name, method.Name);

                ParameterInfo[] args = method.GetParameters();

                for (int i = 0; i < args.Length; i++)
                {
                    Console.Write("{0}", args[i].ParameterType.Name);

                    if (i < args.Length - 1)
                        Console.Write(", ");
                }

                Console.WriteLine() ;
            }

            Console.WriteLine();
        }

        static void PrintProperties(Type type)
        {
            Console.WriteLine("-------- Properties --------");

            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo property in properties)
                Console.WriteLine("Type : {0}, Name : {1}",
                    property.PropertyType.Name, property.Name);

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            int a = 0;
            Type type = a.GetType();

            PrintInterfaces(type);
            PrintFields(type);
            PrintProperties(type);
            PrintMethods(type);
        }
    }
}