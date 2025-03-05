using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_24_4
{
    // 1. 클래스와 개체
    class Person
    {
        public string Name;
        public void SayHello()
        {
            Console.WriteLine($"Hello, my name is {Name}");
        }
    }

    // 2. 개체와 인스턴스
    class Car
    {
        public string Model;
    }

    // 3. 상속 예시
    class Player
    {
        public string Name;
        public void Render()
        {
            Console.WriteLine($"플레이어: {Name}");
        }
    }

    class Wizard : Player
    {
        public string Class;

        public void ClassChange()
        {
            Console.WriteLine($"직업은 {Class}입니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. 출력 부분
            Console.WriteLine("1. 클래스와 개체");

            Person p = new Person();
            p.Name = "Vram";
            p.SayHello();

            Console.WriteLine("===============================");

            // 2. 출력 부분

            Console.WriteLine("2. 개체와 인스턴스");

            Car c = new Car();
            c.Model = "Tesla";
            Console.WriteLine(c.Model);

            Console.WriteLine("===============================");

            // 3. 출력 부분
            Console.WriteLine("3. 상속 예시");

            Wizard w = new Wizard();
            w.Name = "멋사";
            w.Class = "마법사";
            w.Render();
            w.ClassChange();

            Console.WriteLine("===============================");
        }
    }
}
