using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Homework_20250304
{
    // 1번 문제
    class Warrior
    {
        public string Name;
        public int Score;
        public int Strenght;

        public Warrior(string name, int score, int strenght)
        {
            Name = name;
            Score = score;
            Strenght = strenght;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ////1번 출력
            Console.WriteLine("1번 문제 출력");

            Warrior w = new Warrior("멋사", 100, 20);
            Console.WriteLine($"이름 : {w.Name}");
            Console.WriteLine($"점수 : {w.Score}");
            Console.WriteLine($"힘 : {w.Strenght}");

            Console.WriteLine("=============================================");

            ////2번 출력
            Console.WriteLine("2번 문제 출력");
            try
            {
                Console.Write("변환할 숫자를 입력하세요: ");
                int parse = int.Parse(Console.ReadLine());
                Console.WriteLine($"숫자 변환 성공: {parse}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"\"올바른 숫자를 입력하세요!\"");
            }

            Console.WriteLine("=============================================");

            //3번 출력
            Console.WriteLine("3번 문제 출력");
            List<string> list = new List<string> { "사과", "바나나", "포도" };

            Console.Write("List 출력: ");
            foreach (string i in list)
            {
                Console.Write($"{i}");
                Console.Write(" ");
            }
            Console.WriteLine();


            Queue<string> queue = new Queue<string>();
            queue.Enqueue("첫 번째 작업");
            queue.Enqueue("두 번째 작업");
            queue.Enqueue("세 번째 작업");

            Console.Write("Queue 출력: ");
            while (queue.Count > 0)
            {
                Console.Write(queue.Dequeue());
                Console.Write(" ");
            }
            Console.WriteLine();

            Stack<int> stack = new Stack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.Write("Stack 출력: ");
            while (stack.Count > 0)
            {
                Console.Write(stack.Pop());
                Console.Write(" ");
            }
            Console.WriteLine();

            Console.WriteLine("=============================================");

            // 4번 출력
            Console.WriteLine("4번 문제 출력");
            Console.Write("문자열 입력: ");
            string input = Console.ReadLine();

            Console.WriteLine($"대문자로 변환 : {input.ToUpper()}");
            Console.WriteLine($"문자 변경: {input.Replace("C#", "CSharp")}");
            Console.WriteLine($"문자열의 길이 출력 : {input.Length}");
            Console.WriteLine("=============================================");

            //5번 출력
            Console.WriteLine("5번 문제 출력");
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evenNumbers = numbers.Where(n => n % 2 == 0);

            Console.Write("LINQ를 사용하여 짝수만 필터링하고 출력: ");
            foreach (var number in evenNumbers)
            {
                Console.Write(number);
                Console.Write(" ");
            }
            Console.WriteLine();

            var evenNumbers2 = numbers.Aggregate((runningProduct, nextFactor) => runningProduct + nextFactor);

            Console.WriteLine($"LINQ를 사용하여 모든 숫자의 합을 구하고 출력: {evenNumbers2}");
            Console.WriteLine("=============================================");
        }
    }
}
