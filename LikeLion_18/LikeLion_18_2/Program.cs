using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_18_2
{
    class Program
    {

        //1. out 키워드: 여러 값을 반환할 때
        static void Divide(int a, int b, out int q, out int r) 
        {
            q = a / b;
            r = a % b;
        }

        //2. ref 키워드(값을 참조하여 수정)
        static void Increase(ref int num)
        {
            num += 10;
        }

        //3. 가변 매개 변수 params
        static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach(int i in numbers)
            {
                total += i;
            }
            return total;
        }

        //4. 재귀 함수: 함수가 자기 자신을 호출
        static int Function(int n)
        {
            if (n <= 1)
            {
                Console.WriteLine($"*{n}");
                return 1;
            }
            Console.WriteLine($"*{n}");
            return n*Function(n-1);
        }


        static void Main(string[] args)
        {
            //1. 출력 부분
            Console.WriteLine("1. out 키워드: 여러 값을 반환할 때");
            int q, r;
            Divide(10, 3, out q, out r);
            Console.WriteLine($"나누기: {q}, 나머지: {r}");
            Console.WriteLine("========================================");

            //2. 출력 부분
            Console.WriteLine("2. ref 키워드(값을 참조하여 수정)");
            int value = 5;
            Increase(ref value);
            Console.WriteLine($"참조한 결과: {value}");
            Console.WriteLine("========================================");

            //3. 출력 부분
            Console.WriteLine("3. 가변 매개 변수 params");
            Console.WriteLine($"배열 numbers 합계: {Sum(1, 2, 3)}");
            //위 배열에 들어가는 수는 1차원 배열 규칙만 지키면 얼마든지 넣을 수 있다.
            Console.WriteLine("========================================");

            //4. 출력 부분
            Console.WriteLine("4. 재귀 함수: 함수가 자기 자신을 호출");
            Console.WriteLine($"Function(5): {Function(5)}");
            Console.WriteLine("========================================");
        }
    }
}
