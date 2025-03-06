using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Your; // 네임스페이스를 편하게 사용하는 방법: using 키워드

// 1. 네임스페이스 만들기
namespace Your
{
    class YourClass
    {
        public void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }
    }
}

namespace LikeLion_26
{
    // 2. 필드 만들기
    class Person
    {
        // 필드
        public string Name;
    }

    // 3. 엑세스 한정자
    class Per
    {
        private string name;
        public void SetName(string n)
        {
            name = n;
        }

        public string GetName()
        {
            return name;
        }
    }

    // 4. 여러 가지 형태의 필드 선언, 초기화, 참조 구현
    class Rider
    {
        public string Name;
        public int age;
        public Rider() // 생성자
        {
            Name = "Unknown";
        }

        public Rider(string n)
        {
            Name = n;
        }

        public Rider(string n, int a)
        {
            Name = n;
            age = a;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //1. 출력 부분
            Console.WriteLine("1. 네임스페이스 만들기");

            YourClass yc = new YourClass();
            yc.SayHello();

            Console.WriteLine("==========================================");

            // 2. 출력 부분
            Console.WriteLine("2. 필드 만들기");

            Person person = new Person();
            person.Name = "Valen";
            Console.WriteLine(person.Name);

            Console.WriteLine("==========================================");

            // 3. 출력 부분
            Console.WriteLine("3. 엑세스 한정자");

            Per per = new Per();
            per.SetName("Vram");
            Console.WriteLine(per.GetName());

            Console.WriteLine("==========================================");

            // 4. 출력 부분
            Console.WriteLine("4. 여러 가지 형태의 필드 선언, 초기화, 참조 구현");
            Console.WriteLine();

            Console.WriteLine("첫 번째 생성자 호출");
            Rider r1 = new Rider();
            r1.Name = "Gavv";
            Console.WriteLine($"이름: {r1.Name}");
            Console.WriteLine();

            Console.WriteLine("두 번째 생성자 호출");
            Rider r2 = new Rider("Gav");
            Console.WriteLine($"이름: {r2.Name}");
            Console.WriteLine();

            Console.WriteLine("세 번째 생성자 호출");
            Rider r3 = new Rider("Gavv", 2025); //생성자 호출: 객체를 생성하면 만들어진다.
            Console.WriteLine($"이름: {r3.Name}, 연도: {r3.age}");

            Console.WriteLine("==========================================");
        }
    }
}
