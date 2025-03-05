using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_25
{
    // 1. 메서드 오버라이드: 재정의
    class Animal
    {
        public string Name { get; set; }

        // 가상 메소드(virtual): 자식 클래스에서 재정의가 가능.
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    class Dog : Animal
    {
        // 부모 클래스 메소드 오버라이드
        public override void Speak()
        {
            Console.WriteLine($"{Name}이(가) 멍멍 짖습니다.");
        }
    }

    // 2. 업캐스팅
    class Animal_2
    {
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다.");
        }
    }

    class Dog_2 : Animal_2
    {
        public void Bark()
        {
            Console.WriteLine("Bark!!");
        }
    }

    // 미니 테스트
    class Dongmul
    {
        public virtual void Speak()
        {
            Console.WriteLine("동물이 소리를 냅니다!");
        }
    }

    class Mung:Dongmul
    {
        public override void Speak()
        {
            Console.WriteLine("멍멍멍!");
        }

        public void tail()
        {
            Console.WriteLine("꼬리 흔들기!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //1. 출력 부분
            Console.WriteLine("1. 메서드 오버라이드: 재정의");

            Animal a = new Animal();

            Console.Write("부모 클래스 가상 메소드 실행 : ");
            a.Speak();

            Dog d = new Dog();
            d.Name = "바둑";

            Console.Write("오버라이드 된 자식 클래스 메소드 실행 : ");
            d.Speak();

            Console.WriteLine("===================================");

            // 2. 출력 부분
            Console.WriteLine("2. 업캐스팅");

            // 자식 클래스 객체 생성
            Dog_2 mydog = new Dog_2();

            // 업캐스팅(자식 -> 부모)
            Animal_2 myanimal = mydog;

            // 업캐스팅 후 부모의 메소드 사용 가능
            myanimal.Speak();

            // myanimal.Bark();는 오류. 업캐스팅 후 자식 클래스 메소드 접근은 불가능.

            Console.WriteLine("===================================");

            // 3. 다운캐스팅
            Console.WriteLine("3. 다운캐스팅");

            // 업캐스팅
            Animal_2 myanimal_2 = new Dog_2();

            // 다운캐스팅(명시적 변환)
            //Dog_2 myDog_2 = (Dog_2)myanimal_2;

            //myDog_2.Bark();

            /* 다음 과정은 불가. 이미 객체를 부모로 생성했기에 자식으로 다운캐스팅 불가.
             Animal_2 myanimal_2 = new Animal_2();
             Dog_2 myDog_2 = (Dog_2)myanimal_2;
             */

            Console.Write("is문을 통한 출력 : ");
            if (myanimal_2 is Dog_2 myDog1)
                myDog1.Bark();
            else
                Console.WriteLine("변환 불가!");

            Console.Write("as문을 통한 출력 : ");
            Dog_2 myDog_2 = myanimal_2 as Dog_2;

            if(myDog_2 != null)
                myDog_2.Bark();
            else
                Console.WriteLine("변환 불가!");


            Console.WriteLine("===================================");

            // #. 미니 테스트 출력
            Console.WriteLine("#. 미니 테스트 출력");

            Dongmul dongmul = new Mung(); //업캐스팅
            dongmul.Speak(); //출력 결과는 멍멍멍! 자식의 speak() 메소드가 오버라이딩

            Mung m = (Mung)dongmul;
            m.tail();

            Dongmul dongmul1 = new Dongmul();
            dongmul1.Speak();

            Console.WriteLine("===================================");
        }
    }
}
