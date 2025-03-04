using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion_22
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1교시

            ////1. Environment 클래스로 프로그램 강제 종료하기
            //Console.WriteLine("1. Environment 클래스로 프로그램 강제 종료하기");
            //Console.WriteLine("프로그램 종료");

            //string path = Environment.GetEnvironmentVariable("PATH");
            //Console.WriteLine($"PATH: {path}");
            //Console.WriteLine("=======================================================================================================================");

            ////2. Random 클래스
            //Random random = new Random();

            //int randomNumber = random.Next(1, 101); // 1부터 100까지

            //Console.WriteLine("2. Random 클래스");
            //Console.WriteLine("랜덤 숫자 : " + randomNumber);
            //Console.WriteLine("================================");

            ////Environment.Exit(0);

            ////3. 프로그램 실행 시간 구하기
            //Stopwatch stopwatch = Stopwatch.StartNew();

            ////실행코드
            //for (int i = 0; i < 100; i++)
            //{
            //    Thread.Sleep(1);
            //}
            ////0.001

            //stopwatch.Stop();

            //Console.WriteLine("3. 프로그램 실행 시간 구하기");
            //Console.WriteLine($"for 시간 {stopwatch.ElapsedMilliseconds}ms");
            //Console.WriteLine("================================");

            ////4. 정규식
            //string input = "123-456-7890";
            //string pattern = @"^\d{3}-\d{3}-\d{4}$";
            //bool isMatch = Regex.IsMatch(input, pattern);

            //Console.WriteLine("4. 정규식");
            //Console.WriteLine($"Is valid phone number: {isMatch}");
            //Console.WriteLine("================================");


            // 2교시
            // 1. 값 형식과 참조 형식

            //int valutType = 10;
            //object refernceType = valutType;

            //valutType = 20;

            //Console.WriteLine("1. 값 형식과 참조 형식");
            //Console.WriteLine($"valutType: {valutType}");
            //Console.WriteLine($"refernceType: {refernceType}");
            //Console.WriteLine("================================");

            //// 2. 박싱과 언박싱
            //int value = 42;

            //object boxed = value; // 박싱
            //int unboxed = (int)boxed; // 언박싱

            //Console.WriteLine("2. 박싱과 언박싱");
            //Console.WriteLine($"Boxed: {boxed}, Unboxed: {unboxed}");
            //Console.WriteLine("================================");

            //// 3. is 연산자로 형식 비교하기
            //object obj = "Hello";

            //Console.WriteLine("3. is 연산자로 형식 비교하기");
            //Console.WriteLine(obj is string); // true
            //Console.WriteLine(obj is int); // false
            //Console.WriteLine("================================");

            //// 4. as 연산자로 형식 변환하기
            //object obj2 = "Hello";
            //string str = obj2 as string;

            //Console.WriteLine("4. as 연산자로 형식 변환하기");
            //Console.WriteLine(str ?? "Conversion failed");
            //Console.WriteLine("================================");

            //// 5. 패턴 매칭: if 문과 is 연산자 사용하기
            //var obj3 = 42;

            //Console.WriteLine("5. 패턴 매칭: if 문과 is 연산자 사용하기");

            //if (obj3 is int number)
            //    Console.WriteLine($"Number: {number}");
            //else
            //    Console.WriteLine("Not a Number!");

            //Console.WriteLine("================================");


            // 3교시
            //1. 문자열 다루기
            string greeting = "Hello";
            string name = "Alice";
            string message = greeting + ", " + name + "!";

            Console.WriteLine("1. 문자열 다루기");
            Console.WriteLine(message); // Hello, Alice!
            Console.WriteLine($"Length of name: {name.Length}"); // 문자열 길이
            Console.WriteLine($"To Upper: {name.ToUpper()}"); // 대문자 변환
            Console.WriteLine($"Substring: {name.Substring(1)}"); // 부분 문자열
            Console.WriteLine("================================");

            //2. string의 다양한 메소드
            string text = "C# is awesome!";

            Console.WriteLine("2. string의 다양한 메소드");
            Console.WriteLine($"Cotains 'awesome' : {text.Contains("awesome")}"); //Cotains: 특정 문자열 포함 확인 메소드
            Console.WriteLine($"Starts with 'C#' : {text.StartsWith("C#")}"); //StartsWith: 문자열의 시작 부분이 지정된 문자열과 일치하는지 확인하는 메소드
            Console.WriteLine($"Index of 'is' : {text.IndexOf("is")}"); // IndexOf: 문자열에서 지정된 문자열이 처음 등장한 인덱스 부분을 반환하는 메소드
            Console.WriteLine($"Replace 'awesome' with 'great' : {text.Replace("awesome", "great")}"); //Replace: 앞선 문자열을 새로이 작성한 문자열로 반환하는 메소드
            Console.WriteLine("================================");

            //3. StringBuilder 클래스를 사용하여 문자열 연결하기
            StringBuilder sb = new StringBuilder("Hello");
            sb.Append(", ");
            sb.Append("World!");

            Console.WriteLine("3. StringBuilder 클래스를 사용하여 문자열 연결하기");
            Console.WriteLine(sb.ToString()); // Hello, World!
            Console.WriteLine("================================");

            // 4. String 과 StringBuilder 클래스의 성능 차이 비교하기
            int iterations = 10000;

            Stopwatch sw = Stopwatch.StartNew();

            string text2 = "";

            for (int i = 0; i < iterations; i++)
            {
                text2 += "a";
            }

            Console.WriteLine("4. String 과 StringBuilder 클래스의 성능 차이 비교하기");

            sw.Stop();
            Console.WriteLine($"String  : {sw.ElapsedMilliseconds}ms");

            sw.Restart();
            StringBuilder sb2 = new StringBuilder();

            for (int i = 0; i < iterations; i++)
            {
                sb2.Append("a");
            }

            sw.Stop();
            Console.WriteLine($"StringBuilder : {sw.ElapsedMilliseconds}ms");
            Console.WriteLine("================================");
        }
    }
}
