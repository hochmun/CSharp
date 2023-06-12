/*
2023/06/12 // 심규영 // 구조체 예제

실행 결과
10, 20, 40
100, 200, 300
100, 200, 400

 - 선언 방법 struct
 - 구조체는 데이터를 담기 위한 자료 구조이므로 굳이 private를 사용하지 않음

 -- 그런데 java 에서는 private를 사용 했는데? 
 -- getter, setter 메소드를 만들어서 ??
 */
namespace Structure
{
    struct Point3D
    {
        public int x;
        public int y;
        public int z;

        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // System.Object 형식의 ToString() 메소드를 오버라이딩
        public override string ToString()
        {
            return string.Format($"{x}, {y}, {z}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 선언만으로도 인스턴스가 생성됨
            Point3D p3d1;
            p3d1.x = 10;
            p3d1.y = 20;
            p3d1.z = 40;

            Console.WriteLine(p3d1.ToString());

            // 생성자를 이용한 인스턴스 생성
            Point3D p3d2 = new Point3D(100, 200, 300);
            Point3D p3d3 = p3d2; // 구조체의 인스턴스를 다른 인스턴스에 할당하면 깊은 복사가 이루어집니다.
            p3d3.z = 400;

            Console.WriteLine(p3d2.ToString());
            Console.WriteLine(p3d3.ToString());
        }
    }
}