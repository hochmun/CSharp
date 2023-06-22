/*
2023/06/22 // 심규영 // 여러 개의 인터페이스, 한꺼번에 상속하기

실행 결과
Run! Run!
Fly! Fly!
Run! Run!
Fly! Fly!

여러 클래스에서 구현을 물려받고 싶은 경우
 - 클래스 안에 물려받고 싶은 기능을 가진 클래스들을 필드로 선언해 넣는 방법이 있음.
 */
namespace MultiInterfaceInheritance
{
    interface IRunnable
    {
        void Run();
    }

    interface IFlyable
    {
        void Fly();
    }

    class FlyingCar : IRunnable, IFlyable
    {
        public void Run()
        {
            Console.WriteLine("Run! Run!");
        }

        public void Fly()
        {
            Console.WriteLine("Fly! Fly!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            FlyingCar car = new FlyingCar();
            car.Run();
            car.Fly();

            IRunnable runnable = car as IRunnable;
            runnable.Run();

            IFlyable flyable = car as IFlyable;
            flyable.Fly();
        }
    }
}