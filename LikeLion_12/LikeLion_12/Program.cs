using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 조건문: switch 문
            Console.WriteLine("1. 조건문: switch 문");
            Console.Write("input day: ");
            string input = Console.ReadLine();
            int day = int.Parse(input);

            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("What?");
                    break;
            }

            Console.WriteLine("===============================================");

            //1-1. switch문 캐릭터 선택(1. 전사, 2. 마법사, 3. 도적)
            Console.WriteLine("1-1. switch문 캐릭터 선택");
            Console.Write("캐릭터를 선택하세요.(1. 전사, 2. 마법사, 3. 도적): ");
            int character_index = int.Parse(Console.ReadLine());
            int atk = 0;
            int def = 0;

            switch (character_index)
            {
                case 1:
                    Console.WriteLine("전사를 선택하셨습니다.");
                    Console.WriteLine($"공격력: {atk+100}");
                    Console.WriteLine($"방어력: {def+90}");
                    break;
                case 2:
                    Console.WriteLine("마법사를 선택하셨습니다.");
                    Console.WriteLine($"공격력: {atk + 110}");
                    Console.WriteLine($"방어력: {def + 80}");
                    break;
                case 3:
                    Console.WriteLine("도적을 선택하셨습니다.");
                    Console.WriteLine($"공격력: {atk + 115}");
                    Console.WriteLine($"방어력: {def + 70}");
                    break;
                default:
                    Console.WriteLine("잘못된 입력입니다.");
                    break;
            }

            Console.WriteLine("===============================================");

            //2. 반복문: for문으로 반복하기
            Console.WriteLine("2. 반복문: for문으로 반복하기");
            for(int i=0; i<5; i++)
            {
                Console.WriteLine($"숫자: {i}");
            }
            Console.WriteLine("===============================================");

            //2-1. for문 0부터 9까지 출력하기
            Console.WriteLine("2-1. 0부터 9까지 출력하기");
            for (int i=0; i<10; i++)
            {
                Console.WriteLine($"0부터 9까지 출력하기: {i}");
            }
            Console.WriteLine("===============================================");

            Console.WriteLine("2-2. 1부터 10까지의 합 구하기");
            int sum = 0;
            for (int i = 1; i < 11; i++)
            {
                sum += i;
            }
            Console.WriteLine($"1부터 10까지의 합: {sum}");
            Console.WriteLine("===============================================");

            //3. 무한 루프
            Console.WriteLine("3. 무한 루프");
            int count = 0;
            while (true) 
            {
                Console.WriteLine("무한 루프 생성");
                count++;
                if (count == 3) break;
            }
            Console.WriteLine("===============================================");

            //3-1. 미니 테스트, 대장장이 키우기
            Console.WriteLine("미니 테스트, 대장장이 키우기");
            Random rand = new Random();
            int randValue = 0;
            for(int i = 0; i < 5; i++)
            {
                randValue = rand.Next(1, 101);
                if(randValue >=1 && randValue <=10 )
                    Console.WriteLine("SSS급 도끼가 나왔습니다.");
                else if (randValue >= 11 && randValue <= 40)
                    Console.WriteLine("SS급 도끼가 나왔습니다.");
                else
                    Console.WriteLine("S급 도끼가 나왔습니다.");
            }
            Console.WriteLine("===============================================");

            ////4. for 문으로 1부터 4까지 팩토리얼 값 출력하기
            //Console.WriteLine("4. for 문으로 1부터 4까지 팩토리얼 값 출력하기");
            //int fc = 1;
            //for(int i=1; i<5; i++)
            //{
            //    fc *= i;
            //}
            //Console.WriteLine($"1부터 4까지 팩토리얼 값: {fc}");
            //Console.WriteLine("===============================================");

            ////5. 구구단을 가로로 출력하기
            //Console.WriteLine("5. 구구단을 가로로 출력하기");
            //for(int i=1; i<=9; i++)
            //{
            //    for(int j=1; j<=9; j++)
            //    {
            //        Console.WriteLine($"{i} x {j} = {i*j}");
            //    }
            //}
            //Console.WriteLine("===============================================");

            //4. do while 반복문으로 최소 한 번은 실행하기
            Console.WriteLine("4. do while 반복문으로 최소 한 번은 실행하기");
            int x = 5;
            do
            {
                Console.WriteLine("최소 한 번은 실행하기");
                x--;
            }
            while(x>0); //세미콜론으로 막아주기
            Console.WriteLine("===============================================");

            //5. break 문으로 반복문 제어하기
            Console.WriteLine("5. break 문으로 반복문 제어하기");
            for(int i=0; i<=10; i++)
            {
                if (i == 5) break;
                Console.WriteLine(i);
            }
            Console.WriteLine("===============================================");

            //6. continue 문으로 코드 건너뛰기
            Console.WriteLine("6. continue 문으로 코드 건너뛰기");
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 ==0 ) continue;
                Console.WriteLine(i); //홀수만 출력
            }
            Console.WriteLine("===============================================");

            //7. goto로 프로그램 흐름을 원하는 대로 바꾸기
            Console.WriteLine("7. goto로 프로그램 흐름을 원하는 대로 바꾸기");
            int n = 1;
            start:
            if (n <= 5)
            {
                Console.WriteLine(n);
                n++;
                goto start;
            }
            Console.WriteLine("===============================================");
        }
    }
}
