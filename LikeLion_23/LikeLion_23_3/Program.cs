using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_23_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Dictionary〈T, T〉 제네릭 클래스 사용하기
            Console.WriteLine("1. Dictionary〈T, T〉 제네릭 클래스 사용하기");

            // Dictionary 선언
            Dictionary<string, int> ages = new Dictionary<string, int>
            {
                {"alice", 25 },
                {"Tom", 30 }
            };

            // 추가
            ages["charlie"] = 25;

            // 배열 접근 출력
            foreach(var pair in ages)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }
            Console.WriteLine("====================================================");

            // 2. null 값
            Console.WriteLine("2. null 값");
            string str = null;

            if (str == null)
            {
                Console.WriteLine("str is null");
            }

            //2-1. null 연산자
            Console.WriteLine(str ?? "DefaultValue");//str이 null이면 "Default Value

            Console.WriteLine("====================================================");

            // 3. null 가능 형식: Nullable〈T〉 형식
            Console.WriteLine("3. null 가능 형식: Nullable〈T〉 형식");

            int? nullableInt = null;
            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() :"No value");

            nullableInt = 10;
            Console.WriteLine(nullableInt.HasValue ? nullableInt.Value.ToString() : "No value");

            Console.WriteLine("====================================================");

            //4. null 값을 다루는 연산자 소개하기 (??, ?. 연산자)
            Console.WriteLine("4. null 값을 다루는 연산자 소개하기 (??, ?. 연산자)");

            string str2 = null;

            //str2가 null이면 "Default Value" 출력
            Console.WriteLine(str2 ?? "Default Value");

            str2 = "Hello";

            Console.WriteLine(str2 ?? "Default Value");

            Console.WriteLine("====================================================");

            // 5. LINQ - 확장 메서드 사용하기
            Console.WriteLine("5. LINQ - 확장 메서드 사용하기");

            int[] num = { 1, 2, 3, 4, 5 };

            var evenNumbers = num.Where(n => n % 2 == 0);

            foreach(var number  in evenNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("====================================================");
        }
    }
}
