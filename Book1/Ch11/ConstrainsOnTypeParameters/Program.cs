﻿/*
2023/06/29 // 형식 매개 변수 제약시키기

where 절과 함께 사용할 수 있는 제약 조건
 - where T : struct             : T는 값 형식이여야 함
 - where T : class              : T는 참조 형식이여야 함
 - where T : new()              : T는 반드시 매개 변수가 없는 생성자가 있어야 함
 - where T : 기반_클래스_이름   : T는 명시한 기반 클래스의 파생 클래스여야 함
 - where T : 인터페이스_이름    : T는 명시한 인터페이스를 반드시 구현해야 함.
                                  '인터페이스_이름'에는 여러 개의 인터페이스를 명시할 수도 있습니다.
 - where T : U                  : T는 또 다른 형식 매개 변수 U로부터 상속받은 클래스여야 함

실행 결과
출력 값 없음
 */
namespace ConstrainsOnTypeParameters
{
    class StructArray<T> where T : struct
    {
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }

    class RefArray<T> where T : class
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }

    class Base { }
    class Derived : Base { }
    class BaseArray<U> where U : Base
    {
        public U[] Array { get; set; }
        public BaseArray(int size)
        {
            Array = new U[size];
        }

        public void CopyArray<T>(T[] Source) where T : U
        {
            Source.CopyTo(Array, 0);
        }
    }

    internal class Program
    {
        public static T CreateInstance<T>() where T : new()
        {
            return new T();
        }

        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 0;
            a.Array[1] = 1;
            a.Array[2] = 2;

            RefArray<StructArray<double>> b = new RefArray<StructArray<double>>(3);
            b.Array[0] = new StructArray<double>(5);
            b.Array[1] = new StructArray<double>(10);
            b.Array[2] = new StructArray<double>(1005);

            BaseArray<Base> c = new BaseArray<Base>(3);
            c.Array[0] = new Base();
            c.Array[1] = new Derived();
            c.Array[2] = CreateInstance<Base>();

            BaseArray<Derived> d = new BaseArray<Derived>(3);
            d.Array[0] = new Derived(); // Base 형식은 여기에 할당 할 수 없다.
            d.Array[1] = CreateInstance<Derived>();
            d.Array[2] = CreateInstance<Derived>();

            BaseArray<Derived> e = new BaseArray<Derived>(3);
            e.CopyArray<Derived>(d.Array);
        }
    }
}