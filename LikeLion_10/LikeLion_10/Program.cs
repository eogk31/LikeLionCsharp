using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_10
{
    class Program
    {
        static void Main(string[] args)
        {
            ////4.연산자
            //int a = 5, b = 3;
            //int sum = a + b; // 산술 연산자 사용
            //bool isEqual = (a == b); // 관계형 연산자 사용

            //Console.WriteLine("4. 연산자");
            //Console.WriteLine($"합: {sum}"); // 출력: 8
            //Console.WriteLine($"a와 b가 같은가? {isEqual}"); // 출력: False
            //Console.WriteLine("=============================================");

            ////5. 단항 연산자
            //int number = 5;
            //bool flag = true;

            //Console.WriteLine("5. 단항 연산자");
            //Console.WriteLine(+number);
            //Console.WriteLine(-number);
            //Console.WriteLine(!flag);
            //Console.WriteLine("=============================================");

            ////6. 변환 연산자: ( ) 기호로 데이터 형식 변환하기
            //double pi = 3.14;
            //int integerPi = (int)pi;

            //Console.WriteLine("6. 변환 연산자: ( ) 기호로 데이터 형식 변환하기");
            //Console.WriteLine(integerPi);
            //Console.WriteLine("=============================================");

            ////7. 산술 연산자
            //int n = 10, m = 3;

            //Console.WriteLine("7. 산술 연산자");
            //Console.WriteLine(n + m); // 덧셈: 13
            //Console.WriteLine(n - m); // 뺄셈: 7
            //Console.WriteLine(n * m); // 곱셈: 30
            //Console.WriteLine(n / m); // 나눗셈: 3
            //Console.WriteLine(n % m); // 나머지: 1
            //Console.WriteLine("=============================================");

            ////8. 문자열 연결 연산자
            //string firstName = "Alice";
            //string lastName = "Smith";

            //Console.WriteLine("8. 문자열 연결 연산자");
            //Console.WriteLine(firstName + " " + lastName); // 출력: Alice Smith
            //Console.WriteLine("=============================================");

            ////9-1. 할당 연산자
            //int xa = 10;
            //xa += 5; // a = a + 5

            //Console.WriteLine("9-1. 할당 연산자");
            //Console.WriteLine(xa); // 출력: 15
            //Console.WriteLine("=============================================");

            ////9-2. 증감 연산자
            //int yb = 3;
            //yb++; // 후위 증가

            //Console.WriteLine("9-2. 할당 연산자");
            //Console.WriteLine(yb); // 출력: 4

            //--yb; // 전위 감소
            //Console.WriteLine(yb); // 출력: 3
            //Console.WriteLine("=============================================");

            ////10-1. 관계형 연산자
            //int x = 5, y = 10;

            //Console.WriteLine("10-1. 관계형 연산자");
            //Console.WriteLine(x < y); // 출력: True
            //Console.WriteLine(x == y); // 출력: False
            //Console.WriteLine("=============================================");

            ////10-2. 논리 연산자
            //bool i = true, l = false;

            //Console.WriteLine("10-2. 논리 연산자");
            //Console.WriteLine(i && l); // AND: False
            //Console.WriteLine(i || l); // OR: True
            //Console.WriteLine(!i); // NOT: False
            //Console.WriteLine("=============================================");

            ////문제
            //Console.Write("국어 성적 입력: ");
            //string kor = Console.ReadLine();
            //int Ikor = int.Parse(kor);

            //Console.Write("영어 성적 입력: ");
            //string eng = Console.ReadLine();
            //int Ieng = int.Parse(eng);

            //Console.Write("수학 성적 입력: ");
            //string math = Console.ReadLine();
            //int Imath = int.Parse(math);

            //int sum = Ikor + Ieng + Imath;
            //float avg = (float)sum / 3;

            //Console.WriteLine($"평균: {avg:F2}");
            //Console.WriteLine("=============================================");

            ////문제2
            //Console.Write("정수 입력: ");
            //string input = Console.ReadLine();
            //int num = int.Parse(input);

            //int result = ~num;
            //Console.WriteLine("원래 값 : " + num);
            //Console.WriteLine("~ 연산자 적용 후: " + result);

           //오전 수업(LikeLion_9 전체, 10은 오전 수업 주석이 달린 부분까지.)

            //11-1. 비트 연산자
            int x = 5; // 0101
            int y = 3; // 0011

            Console.WriteLine("11-1. 비트 연산자");
            Console.WriteLine(x & y); // AND: 1 (0001)
            Console.WriteLine(x | y); // OR: 7 (0111)
            Console.WriteLine(x ^ y); // XOR: 6 (0110)
            Console.WriteLine(~x); // NOT: -6
            Console.WriteLine("=============================================");

            //11-2. 시프트 연산자
            int value = 4; // 0100

            Console.WriteLine("11-2. 시프트 연산자");
            Console.WriteLine(value << 1); // 왼쪽 이동: 8 (1000)
            Console.WriteLine(value >> 1); // 오른쪽 이동: 2 (0010)
            Console.WriteLine("=============================================");

            //12. 기타 연산자
            int a= 10, b=20;
            int c;
            int? d = null;
            int max = (a > b) ? a : b;//삼항 연산자

            c = d ?? 100; //널 병합 연산자 '??'

            Console.WriteLine("12. 기타 연산자");
            Console.WriteLine(max);
            Console.WriteLine( a is object); //is 연산자
            Console.WriteLine(c); //d가 null이기에 100을 반환
            Console.WriteLine("=============================================");

            //12-1. 미니 테스트
            Console.WriteLine("12-1. 미니 테스트");
            Console.Write("0 또는 1 입력: ");
            string input = Console.ReadLine();
            int key = int.Parse(input);
            string str;

            str = (key == 1) ? "문이 열렸습니다." : "문을 못 열었습니다.";

            Console.WriteLine(str);
            Console.WriteLine("=============================================");

            //13.연산자 우선순위
            int result = 10 + 2 * 5; // 곱셈이 덧셈보다 우선
            Console.WriteLine("13.연산자 우선순위");
            Console.WriteLine(result); // 출력: 20

            int adjustedResult = (10 + 2) * 5; // 괄호로 우선순위 변경
            Console.WriteLine(adjustedResult); // 출력: 60
            Console.WriteLine("=============================================");
        }
    }
}
