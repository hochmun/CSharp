﻿/*
2023/07/08 // group by로 데이터 분류하기 예제

실행 결과
- 175cm 미만? : True
    김태희, 158
    하하, 171
    고현정, 172
- 175cm 미만? : False
    이문세, 178
    정우성, 186
 */
namespace GroupBy
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

            var listProfile = from profile in arrProfile
                              orderby profile.Height
                              group profile by profile.Height < 175 into g
                              select new { GroupKey = g.Key, Profile = g };

            foreach (var Group in listProfile)
            {
                Console.WriteLine($"- 175cm 미만? : {Group.GroupKey}");

                foreach (var profile in Group.Profile)
                {
                    Console.WriteLine($"    {profile.Name}, {profile.Height}");
                }
            }
        }
    }
}