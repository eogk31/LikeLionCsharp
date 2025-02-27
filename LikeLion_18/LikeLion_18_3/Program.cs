using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dev1
{
    class Program
    {
        //1. 네임스페이스 기본 사용법
        public static void SayHello()
        {
            Console.WriteLine("1. 네임스페이스 기본 사용법");
            Console.WriteLine("Hello, World!");
        }
    }
}


namespace LikeLion_18_3_1
{
    class Program
    {
        //2. 화살표 함수
        static int Square(int x) => x * x;
        //위 함수는 아래와 같다.
        /* static int Square(int x)
         {
             return x*x;
         } 
         */

        //3. 열거형 enum
        enum Days
        {
            Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
        }

        //문제. 열거형과 함수를 이용해서 풀어주세요.
        //Weapontype.Sword 검을 선택했습니다.
        //Weapontype.Bow 활을 선택했습니다.
        //Weapontype.Staff 지팡이를 선택했습니다.

        //ChooseWeapon(Weapon.Bow); //출력: 활을 선택했습니다.

        enum WeaponType
        {
            Sword, Bow, Staff
        }

        static string ChooseWeapon(WeaponType type)
        {
            var weaponNames = new Dictionary<WeaponType, string>
            {
                { WeaponType.Sword, "검" },
                { WeaponType.Bow, "활" },
                { WeaponType.Staff, "지팡이" }
             };

            return $"{weaponNames[type]}을 선택했습니다.";
        }

        static void SayHello()
        {
            Console.WriteLine("Hello, Tom!");
        }
        static void Main(string[] args) 
        {
            //1. 출력 부분
            dev1.Program.SayHello();
            SayHello();
            Console.WriteLine("=================================");

            //2. 출력 부분
            Console.WriteLine("2. 화살표 함수");
            Console.WriteLine($"Square(4): {Square(4)}");
            Console.WriteLine("=================================");

            //3. 출력 부분
            Console.WriteLine("3. 열거형 enum");
            Days today = Days.Sunday;
            Console.WriteLine($"Today is {today}");
            Console.WriteLine("=================================");

            //문제 출력 부분
            Console.WriteLine("문제");
            WeaponType weapon = WeaponType.Sword;
            Console.WriteLine(ChooseWeapon(weapon));
            Console.WriteLine("=================================");
        }
    }
}
