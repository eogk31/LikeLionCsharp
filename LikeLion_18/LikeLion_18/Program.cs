using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_18
{
    class Program
    {

        //1. 매개 변수도 반환값도 없는 함수
        static void PrintHello()
        {
            Console.WriteLine("Hello!");
        }

        //2. 매개변수만 있는 함수
        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        //3. 반환값만 있는 함수
        static int Number()
        {
            return 10;
        }

        //4. 전역 변수
        static int n = 20;

        //5. 매개 변수와 반환값이 있는 함수
        static int Add(int x, int y)
        {
            return x + y;
        }

        //6. 기본 값을 가진 매개 변수(=default 매개변수)
        static void Greet(string name="손님")
        {
            Console.WriteLine($"기본 값: {name}");
        }

        //7. 함수 오버로딩: 타입이 다르면 같은 함수 이름 사용 가능.
        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static Double Multiply(double a, double b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            //1. 출력 부분
            Console.WriteLine("1. 매개 변수도 반환값도 없는 함수");
            PrintHello();
            Console.WriteLine("========================================");

            //2. 출력 부분
            Console.WriteLine("2. 매개변수만 있는 함수");
            PrintMessage("World!");
            Console.WriteLine("========================================");

            //3. 출력 부분
            Console.WriteLine("3. 반환값만 있는 함수");
            int num = Number();
            Console.WriteLine(num);
            Console.WriteLine("========================================");

            //4. 출력 부분
            Console.WriteLine("4. 전역 변수");
            Console.WriteLine(n);
            Console.WriteLine("========================================");

            //5. 출력 부분
            Console.WriteLine("5. 매개 변수와 반환값이 있는 함수");
            int result = Add(5, 10);
            Console.WriteLine($"5 + 10 = {result}");
            Console.WriteLine("========================================");

            //6. 출력 부분
            Console.WriteLine("6. 기본 값을 가진 매개 변수(=default 매개변수)");
            Greet();
            Greet("철수");
            Console.WriteLine("========================================");

            //7. 출력 부분
            Console.WriteLine("7. 함수 오버로딩: 타입이 다르면 같은 함수 이름 사용 가능.");
            int mul = Multiply(5, 10);
            double mul2 = Multiply(5.5, 5);
            Console.WriteLine($"mul: {mul}");
            Console.WriteLine($"mul2: {mul2}");
            Console.WriteLine("========================================");
        }
    }
}
