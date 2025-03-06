using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_26_2
{
    // 3. 추상 클래스
    abstract class Animal
    {
        // 추상 메소드(구현은 하지 않으나 상속받은 클래스가 구현하도록 강제)
        public abstract void MakeSound();

        // 일반 메소드(공통 기능 제공)
        public void Sleep()
        {
            Console.WriteLine("Animal Sleep.....");
        }
    }

    //추상 클래스를 상속받아 구체적인 클래스를 구현
    class Dog : Animal
    {
        // 추상 클래스 구현을 위해서는 virtual-override 처럼 override 키워드 필요!
        public override void MakeSound()
        {
            Console.WriteLine("Bark!!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meow.");
        }
    }

    // 4. 부모 클래스의 생성자를 호출
    class Parent
    {
        public Parent(string message)
        {
            Console.WriteLine($"부모 생성자 : {message}");
        }
    }

    class Child : Parent
    {
        public Child() : base("Success") //base로 부모 생성자 호출
        {
            Console.WriteLine("자식 생성자 호출");
        }
    }

    class Program
    {
        // 2. 메서드의 매개변수 전달 방식 (ref, out)
        static void Increase(ref int x)
        {
            x++;
        }

        //out은 반환이 여러 개일 때 유용
        static void Increase2(int b, int c, out int x, out int y)
        {
            x = b;
            y = c;
        }

        static void Main(string[] args)
        {
            // 2. 출력 부분
            Console.WriteLine("2. 메서드의 매개변수 전달 방식 (ref, out)");

            int a = 10;
            Increase(ref a);
            Console.WriteLine($"a의 값 : {a}");

            int b = 10;
            int c = 20;
            int x, y;
            Increase2(b, c, out x, out y);
            Console.WriteLine($"x: {x}, y: {y}");

            Console.WriteLine("=============================================");

            // 3. 출력 부분
            Console.WriteLine("3. 추상 클래스");

            Animal dog = new Dog();
            dog.MakeSound();
            dog.Sleep();

            Animal cat = new Cat();
            cat.MakeSound();
            cat.Sleep();

            Console.WriteLine("=============================================");

            // 4. 출력 부분
            Console.WriteLine("4.부모 클래스의 생성자를 호출");

            Child child = new Child();
            
            Console.WriteLine("=============================================");
        }
    }
}
