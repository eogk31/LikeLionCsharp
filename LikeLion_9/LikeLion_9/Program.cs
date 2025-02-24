using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_9
{
    class Program
    {
        static void Main(string[] args)
        {
            ////1. 이진수 다루기
            //Console.WriteLine("1. 이진수 다루기");
            //Console.Write("2진수를 입력: ");
            //string input = Console.ReadLine();

            //int deInput = Convert.ToInt32(input, 2); //2진수 문자열을 10진수 정수로 변환
            //string decimalValue = Convert.ToString(deInput, 2); // 입력값과 동일한 2진수 문자열 출력

            //Console.WriteLine($"2진수를 10진수 정수로 변환: {deInput}");
            //Console.WriteLine($"입력값과 동일한 2진수 문자열 출력: {decimalValue}");
            //Console.WriteLine("=======================================================");

            ////2. var 키워드로 암시적으로 형식화된 로컬 변수 만들기
            //// var를 사용하여 변수 선언
            //var name = "Alice"; // 문자열로 추론
            //var age = 25; // 정수로 추론
            //var isStudent = true; // 논리값으로 추론

            //Console.WriteLine("2. var 키워드로 암시적으로 형식화된 로컬 변수 만들기");
            //Console.WriteLine($"이름: {name}, 나이: {age}, 학생 여부: {isStudent}");
            //Console.WriteLine("=======================================================");

            //3. 변수의 기본값을 default 키워드로 설정하기
            int defaultInt = default;
            string defaultString = default;
            bool defaultBool = default;

            Console.WriteLine("3. 변수의 기본값을 default 키워드로 설정하기");
            Console.WriteLine(($"정수 기본값: {defaultInt}"));
            Console.WriteLine($"문자열 기본값: {defaultString}");
            Console.WriteLine($"논리값 기본값: {defaultBool}");
            Console.WriteLine("=======================================================");
        }
    }
}
