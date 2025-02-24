using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. 제어문
            //1-1. 순차문
            Console.WriteLine("1-1. 순차문");
            Console.WriteLine("===========================================");
            Console.WriteLine("1단계: 시작");
            Console.WriteLine("2단계: 진행 중");
            Console.WriteLine("3단계: 종료");
            Console.WriteLine("===========================================");

            //1-2. 조건문: if 문과 가지치기
            Console.WriteLine("1-2. 조건문: if 문과 가지치기");
            int score = 85;
            if (score >= 90)
                Console.WriteLine("A 학점");
            else
                Console.WriteLine("90점 미만");
            Console.WriteLine("===========================================");

            //1-3. else 문
            Console.WriteLine("1-3. else 문");
            int number = 10;
            if (number > 15)
                Console.WriteLine("15보다 큽니다.");
            else
                Console.WriteLine("15보다 작습니다.");
            Console.WriteLine("===========================================");

            //1-4. else if 문 (다중 조건 처리)
            Console.WriteLine("else if 문 (다중 조건 처리)");
            int score_2 = 75;
            if (score_2 >= 90)
                Console.WriteLine("Grade A");
            else if (score_2 >= 80)
                Console.WriteLine("Grade B");
            else if (score_2 >= 70)
                Console.WriteLine("Grade C");
            else
                Console.WriteLine("Grade F");
            Console.WriteLine("===========================================");

            //미니 테스트 1단계
            Console.Write("가지고 있는 소지금을 입력: ");

            string input = Console.ReadLine();
            int gold = int.Parse(input);

            int atk = 100;
            int atkBonus = 0;
            string weapon = "";


            if (gold <= 100)
            {
                weapon = "무한의 대검";
                atkBonus = 1;
            }
            else if (gold <= 200)
            {
                weapon = "카타나";
                atkBonus = 2;
            }
            else if (gold <= 300)
            {
                weapon = "진은검";
                atkBonus = 3;
            }
            else if (gold <= 400)
            {
                weapon = "집판검";
                atkBonus = 4;
            }
            else if (gold <= 500)
            {
                weapon = "엑스칼리버";
                atkBonus = 5;
            }
            else if (gold <= 600)
            {
                weapon = "유령검";
                atkBonus = 6;
            }
            else
            {
                weapon = "전설의 검";
                atkBonus = 10;
            }


            Console.Write("캐릭터 이름을 입력: ");
            string name = Console.ReadLine();

            Console.WriteLine("===========================================");
            Console.WriteLine($"캐릭터 이름: {name}");
            Console.WriteLine($"소지하고 있는 무기: {weapon}");
            Console.WriteLine($"공격력: {atk} + {atkBonus} = {atk + atkBonus}");
        }
    }
}
