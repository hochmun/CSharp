/*
2023/06/11 // 심규영 // override 예제

실행
Creating Armorsuite...
Armored

Creating IronMan...
Armored
Repulsor Rays Armed

Creating WarMaching...
Armored
Double-Barrel Cannons Armed
Micro-Rocket Launcher Armed

 - private로 선언한 메소드는 오버라이딩 할 수 없다.
 */
namespace Overriding
{
    class ArmorSuite
    {
        public virtual void Initalize()
        {
            Console.WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        public override void Initalize()
        {
            base.Initalize();
            Console.WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        public override void Initalize()
        {
            base.Initalize();
            Console.WriteLine("Double-Barrel Cannons Armed");
            Console.WriteLine("Micro-Rocket Launcher Armed");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Armorsuite...");
            ArmorSuite armorsuite = new ArmorSuite();
            armorsuite.Initalize();

            Console.WriteLine("\nCreating IronMan...");
            ArmorSuite ironman = new IronMan();
            ironman.Initalize();

            Console.WriteLine("\nCreating WarMaching...");
            ArmorSuite warmachine = new WarMachine();
            warmachine.Initalize();
        }
    }
}