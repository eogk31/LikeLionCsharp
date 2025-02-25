using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_20250224
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1번 문제");
            Console.WriteLine("========================================");
            Console.Write("첫번째 정수 입력: ");
            string str1 = Console.ReadLine();
            int num1 = int.Parse(str1);

            Console.Write("두번째 정수 입력: ");
            string str2 = Console.ReadLine();
            int num2 = int.Parse(str2);

            Console.Write("세번째 정수 입력: ");
            string str3 = Console.ReadLine();
            int num3 = int.Parse(str3);

            //int max2 = num1 < num2 ? num2 : (num1 < num3)? num3: num1;

            int max = num1;

            if (num2 > max)
                max = num2;

            if (num3 > max)
                max = num3;

            Console.WriteLine($"최댓값: {max}");
            Console.WriteLine("========================================");

            Console.WriteLine("2번 문제");
            Console.WriteLine("========================================");

            Console.Write("점수 입력: ");
            string input = Console.ReadLine();
            int score = int.Parse(input);

            if (score >= 90)
                Console.WriteLine("A 학점");
            else if (score >= 80)
                Console.WriteLine("B 학점");
            else if (score >= 70)
                Console.WriteLine("C 학점");
            else if (score >= 60)
                Console.WriteLine("D 학점");
            else
                Console.WriteLine("F 학점");

            Console.WriteLine("========================================");

            Console.WriteLine("3번 문제");
            Console.WriteLine("========================================");

            Console.Write("숫자 1 입력: ");
            string n = Console.ReadLine();
            int n1 = int.Parse(n);

            Console.Write("연산자 입력: ");
            string op = Console.ReadLine();

            Console.Write("숫자 2 입력: ");
            string m = Console.ReadLine();
            int m1 = int.Parse(m);

            int result = 0;

            if (op == "+")
                result = n1 + m1;
            else if (op == "-")
                result = n1 - m1;
            else if (op == "*")
                result = n1 * m1;
            else if (op == "/")
            {
                if (m1 != 0)
                    result = n1 / m1;
                else
                {
                    Console.WriteLine("0으로 나눌 수 없습니다.");
                    return;
                }

            }
            else
            {
                Console.WriteLine("잘못된 연산자입니다.");
                return;
            }

            Console.WriteLine($"결과: {n1} {op} {m1} = {result}");
        }
    }
}
