﻿/*
2023/07/08 // LINQ 표준 연산자 예시

실행 결과
김태희, 62.094
하하, 67.203
고현정, 67.596
 */
namespace SimpleLinq2
{
    class Profile
    {
        public string Name { get; set; }
        public int Height { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name = "정우성", Height = 186 },
                new Profile(){Name = "김태희", Height = 158 },
                new Profile(){Name = "고현정", Height = 172 },
                new Profile(){Name = "이문세", Height = 178 },
                new Profile(){Name = "하하", Height = 171 }
            };

            var profiles = arrProfile
                .Where(profile => profile.Height < 175)
                .OrderBy(profile => profile.Height)
                .Select(profile =>
                    new
                    {
                        Name = profile.Name,
                        InchHeight = profile.Height * 0.393
                    });

            foreach (var profile in profiles)
                Console.WriteLine($"{profile.Name}, {profile.InchHeight}");
        }
    }
}