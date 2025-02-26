using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion_17
{
    class Program
    {
        //1. 함수
        static void SayHello()
        {
            Console.WriteLine("1. 함수");
            Console.WriteLine("Hello, World!");
            Console.WriteLine("==========================================");
        }

        //2. 함수 정의하고 사용하기
        static void Greet()
        {
            Console.WriteLine("2. 함수 정의하고 사용하기");
            Console.WriteLine("Welcome to C# programming!");
            Console.WriteLine("==========================================");
        }

        //3. 매개변수와 반환값
        static int Add(int a, int b)
        {
            return a + b;
        }

        //4. 매개변수가 있는 함수
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        //중간 확인, 게임 로딩.
        static void Loading()
        {
            Console.WriteLine("로딩중.");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중..");
            Thread.Sleep(1000);
            Console.WriteLine("로딩중...");
            Thread.Sleep(1000);
        }

        //중간 확인 2, 함수 입력.
        static void AttackFunction(int _Attack)
        {
            Console.WriteLine($"공격력: {_Attack}");
        }

        //중간 확인 3, 함수 출력.
        static int BaseAttack()
        {
            //출력하는 건 기본공격력 10
            int attack = 10;
            return attack;
        }


        static void Main(string[] args)
        {
            //1. 함수 출력 부분
            SayHello();

            //2. 출력 부분
            Greet();

            //3. 출력 부분
            int result = Add(10, 20);
            Console.WriteLine("3. 매개변수와 반환값");
            Console.WriteLine($"10 + 20 = {result}");
            Console.WriteLine("==========================================");

            //4. 출력 부분
            Console.WriteLine("4. 매개변수가 있는 함수");
            PrintMessage("Hello, with parameter!");
            Console.WriteLine("==========================================");

            //중간 확인 출력 부분
            Console.WriteLine("중간 확인 1");
            Loading();
            Console.WriteLine("게임이 시작됩니다...");
            Console.ReadLine();
            Console.WriteLine("==========================================");

            //중간 확인 2 출력 부분
            int atk = 0;
            Console.WriteLine("중간 확인 2");
            Console.Write("캐릭터의 공격력 입력 : ");
            atk = int.Parse(Console.ReadLine());
            AttackFunction(atk);
            Console.WriteLine("==========================================");

            //중간 확인 3 출력 부분
            Console.WriteLine("중간 확인 3");
            int Battack =0;
            Battack = BaseAttack();
            AttackFunction(Battack + atk);
            Console.WriteLine("==========================================");

            //중간 확인 4. foreach 반복문
            string[] fruits = { "사과", "바나나", "체리" };
            Console.WriteLine("중간 확인 4");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine("==========================================");
        }
    }
}
