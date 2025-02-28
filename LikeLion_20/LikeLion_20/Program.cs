using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_20
{
    class Person
    {
        public string name;
        public int age;

        //4. 기본 생성자
        //public Person() 
        //{
        //    name = "이름 없음";
        //    age = 20;
        //    Console.WriteLine("기본 생성자 실행"); //인스턴스 실행 시 바로 할당되어 출력
        //}

        //5. 매개 변수를 가진 생성자
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
            Console.WriteLine("기본 생성자 실행");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"이름: {name}, 나이: {age}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //1. 내장형 구조체로 만드는 현재 시간
            DateTime now = DateTime.Now;
            Console.WriteLine("1. 내장형 구조체로 만드는 현재 시간");
            Console.WriteLine($"Current Date and Time: {now}");
            Console.WriteLine("============================================");

            //2. 시간을 사용자가 직접 지정해서 출력
            TimeSpan duration = new TimeSpan(1, 30, 0);
            Console.WriteLine("2. 시간을 사용자가 직접 지정해서 출력");
            Console.WriteLine($"Duration: {duration}");
            Console.WriteLine("============================================");

            //3. 클래스 - 4. 기본 생성자
            Console.WriteLine("3. 클래스 - 4. 기본 생성자");
            Person p1 = new Person("철수", 20); //매개 변수가 있는 생성자는 내부를 채워야 한다.
            p1.ShowInfo();
            Console.WriteLine("============================================");


        }
    }
}