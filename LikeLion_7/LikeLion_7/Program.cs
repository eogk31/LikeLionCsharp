using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. 문자 데이터 형식 char
            // char 형식: 단일 문자를 표현
            char letter = 'A'; //문자 'A' 저장
            char symbol = '#'; // 특수 기호 저장
            char number = '9'; // 숫자 형태의 문자 저장 (문자 '9', 숫자 9 아님)

            Console.WriteLine("1. 문자 데이터 형식 char");
            Console.WriteLine("======================================");
            Console.WriteLine(letter); // 출력: A
            Console.WriteLine(symbol); // 출력: #
            Console.WriteLine(number); // 출력: 9
            Console.WriteLine("======================================");

            //2. 문자열 데이터 형식 string
            // string 형식: 여러 문자를 저장
            string greeting = "Hello, World!"; // 문자열 저장
            string name = "Alice"; // 이름 저장

            Console.WriteLine("2. 문자열 데이터 형식 string");
            Console.WriteLine(greeting); // 출력: Hello, World!
            Console.WriteLine(name); // 출력: Alice
            Console.WriteLine($"{greeting} {name}"); //Hello World Alice 콘솔한줄로 표현하기
            Console.WriteLine("======================================");

            //3. 논리 데이터 형식 bool
            // bool 형식: 참(True) 또는 거짓(False)
            bool isRunning = true;
            bool isFinished = false;

            Console.WriteLine("3. 논리 데이터 형식 bool");
            Console.WriteLine(isRunning);
            Console.WriteLine(isFinished);
            Console.WriteLine("======================================");

            //4. 변하지 않는 값 상수(const)
            // const: 변하지 않는 값을 정의
            const double PI = 3.14159;
            const int MaxScore = 100;

            Console.WriteLine("4. 변하지 않는 값 상수(const)");
            Console.WriteLine(PI);
            Console.WriteLine(MaxScore);
            Console.WriteLine("======================================");
            // Pi = 3.14; // 오류! 상수 값은 변경할 수 없습니다.

            //5. 닷넷 데이터 형식
            // 닷넷 형식: 기본 형식의 닷넷 표현
            System.Int32 n = 123;
            System.String hello = "Hello";
            System.Boolean flag = true;

            Console.WriteLine("5. 닷넷 데이터 형식");
            Console.WriteLine(n);
            Console.WriteLine(hello);
            Console.WriteLine(flag);
            Console.WriteLine("======================================");

            //6. 래퍼 형식
            // int 래퍼 형식의 메서드 활용
            int num = 123;
            string numberAsString = num.ToString(); // 정수를 문자열로 변환

            Console.WriteLine("6. 래퍼 형식");
            bool f = true; // bool 래퍼 형식의 메서드 활용
            string flagAsString = flag.ToString(); // 논리값을 문자열로 변환
            Console.WriteLine(numberAsString); // 출력: "123"
            Console.WriteLine(flagAsString); // 출력: "True
            Console.WriteLine("======================================");

            
        }
    }
}