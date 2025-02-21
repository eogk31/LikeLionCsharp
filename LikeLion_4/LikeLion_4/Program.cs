using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. 변수를 만들어 값 저장 후 사용하기

            // 변수 선언 후 값 저장
            string greeting; // 문자열 변수를 선언
            greeting = "Hello, World!"; // 변수에 값을 저장

            // 변수의 값을 사용
            Console.WriteLine("3. 변수를 만들어 값 저장 후 사용하기");
            Console.WriteLine(greeting); // 출력: Hello, World!
            Console.WriteLine("----------------------------------------");

            //4. 변수 선언과 동시에 초기화하기

            // 변수 선언과 초기화를 한 번에 수행
            int score = 100; // 정수형 변수 선언과 동시에 100으로 초기화
            double temperature = 36.5; // 실수형 변수 선언과 초기화
            string city = "Seoul"; // 문자열 변수 선언과 초기화

            // 변수 출력
            Console.WriteLine("4. 변수 선언과 동시에 초기화하기");
            Console.WriteLine(score); // 출력: 100
            Console.WriteLine(temperature); // 출력: 36.5
            Console.WriteLine(city); // 출력: Seoul
            Console.WriteLine("----------------------------------------");

            //5. 형식이 같은 변수 여러 개를 한 번에 선언하기

            // 같은 데이터 타입의 변수를 쉼표로 구분해 한 번에 선언
            int x = 10, y = 20, z = 30; // 정수형 변수 x, y, z를 선언하고 각각 초기화

            // 출력
            Console.WriteLine("5. 형식이 같은 변수 여러 개를 한 번에 선언하기");
            Console.WriteLine(x); // 출력: 10
            Console.WriteLine(y); // 출력: 20
            Console.WriteLine(z); // 출력: 30
            Console.WriteLine("----------------------------------------");

            //6. 상수 사용하기 = const

            // 상수: 값을 변경할 수 없는 변수
            const double Pi = 3.14159; // 상수 Pi 선언 및 초기화
            const int MaxScore = 100; // 정수형 상수 선언

            // 출력
            Console.WriteLine("6. 상수 사용하기 = const");
            Console.WriteLine("Pi: " + Pi); // 출력: Pi: 3.14159
            Console.WriteLine("Max Score: " + MaxScore); // 출력: Max Score: 100
            Console.WriteLine("----------------------------------------");

            //PI=3.14는 오류. 상수는 값 변경이 불가능하기 때문.
        }
    }
}
