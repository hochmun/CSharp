using System.Reflection;

/*
2023/07/12 // 리플렉션을 이용해서 객체 생성하고 이용하기 예제

실행 결과
박상현, 512-1234
박찬호, 997-5511
 */
namespace DynamicInstance
{
    class Profile
    {
        private string name;
        private string phone;

        public Profile()
        {
            name = ""; phone = "";
        }

        public Profile(string name, string phone)
        {
            this.name = name;
            this.phone = phone;
        }

        public void Print()
        {
            Console.WriteLine($"{name}, {phone}");
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Profile 클래스의 형식 정보 받기
            Type type = Type.GetType("DynamicInstance.Profile");

            MethodInfo methodInfo = type.GetMethod("Print"); // 해당 형식의 Print 이름의 메소드 받기
            PropertyInfo nameProperty = type.GetProperty("Name"); // 해당 형식의 Name 이름의 프로퍼티 받기
            PropertyInfo phoneProperty = type.GetProperty("Phone");

            // 리플렉션을 이용한 동적으로 인스턴스 생성
            object profile = Activator.CreateInstance(type, "박상현", "512-1234");

            // 동적으로 메소드 호출
            // 첫번째는 인스턴스, 두번째 이후 부터는 해당 메소드가 호출할 매개 변수
            methodInfo.Invoke(profile, null);

            profile = Activator.CreateInstance(type);
            nameProperty.SetValue(profile, "박찬호", null);
            phoneProperty.SetValue(profile, "997-5511", null);

            Console.WriteLine("{0}, {1}",
                nameProperty.GetValue(profile, null),
                phoneProperty.GetValue(profile, null));
        }
    }
}