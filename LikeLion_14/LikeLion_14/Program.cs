using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Text.Encoding;

//모험가 키우기 미니 프로젝트
//이번 프로젝트는 주석 없이 이해하는 연습을 진행.
namespace LikeLion_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8;
            Random random = new Random();

            int gold = 500;
            int health = 100;
            int power = 10;
            int input;
            bool isAlive = true;

            Console.WriteLine("================================================================");
            Console.WriteLine("⚔️ 모험가 키우기 ⚔️");
            Console.WriteLine("================================================================");
            Thread.Sleep(1000);

            while (isAlive == true)
            {
                Console.Clear();
                Console.WriteLine("================================================================");
                Console.WriteLine($"현재 상태: 체력 {health} | 골드 {gold} | 공격력 {power}");
                Console.WriteLine("\n1. 탐험하기 🏕️");
                Console.WriteLine("2. 장비 뽑기 🎲 (1000 골드)");
                Console.WriteLine("3. 휴식하기💤  (체력 +20)");
                Console.WriteLine("4. 게임 종료 ");

                Console.Write("입력: ");
                input = int.Parse(Console.ReadLine());
                Console.WriteLine("================================================================");

                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("탐험을 떠납니다.");
                    Thread.Sleep(500);
                    Console.WriteLine("탐험을 떠납니다..");
                    Thread.Sleep(500);
                    Console.WriteLine("탐험을 떠납니다...");
                    Thread.Sleep(500);
                    Console.WriteLine("탐험을 떠납니다....");

                    int eventChange = random.Next(1, 101);

                    if(eventChange <= 30)
                    {
                        int damage = random.Next(5, 21);
                        Console.WriteLine($"⚔️ 몬스터가 나타났다! ⚔️ 체력 -{damage}");
                        health -= damage;
                        Thread.Sleep(5000);
                    }
                    else if(eventChange <= 70)
                    {
                        int reward = random.Next(100, 301);
                        Console.WriteLine($"💰 보물을 발견했다! 💰 골드 +{reward}");
                        gold += reward;
                        Thread.Sleep(5000);
                    }
                    else
                    {
                        int heal = random.Next(10, 31);
                        Console.WriteLine($"🌿 신비한 약초를 발견했다! 🌿 체력 +{heal}");
                        health += heal;
                        Thread.Sleep(5000);
                    }

                    if(health <= 0)
                    {
                        Console.WriteLine("\n 💀 사망했습니다. 💀");
                        isAlive = false;
                    }
                }
                else if(input == 2)
                {
                    if(gold >= 1000)
                    {
                        gold -= 1000;
                        Console.Clear();

                        Console.WriteLine("🎲 장비를 뽑습니다... 🎲");
                        Thread.Sleep(5000);

                        int rnd = random.Next(1, 101);

                        if(rnd == 1)
                        {
                            Console.WriteLine("SSS급 전설의 검을 뽑았습니다!! (공격력 +50)");
                            power += 50;
                        }
                        else if(rnd <= 10)
                        {
                            Console.WriteLine("SS급 희귀한 검을 뽑았습니다!! (공격력 +30)");
                            power += 30;
                        }
                        else if (rnd <= 30)
                        {
                            Console.WriteLine("S급 강철의 검을 뽑았습니다!! (공격력 +20)");
                            power += 20;
                        }
                        else
                        {
                            Console.WriteLine("평범한 검을 뽑았습니다!! (공격력 +5)");
                            power += 5;
                        }
                        Thread.Sleep(5000);
                    }
                    else
                    {
                        Console.WriteLine("골드 부족! 1000 골드 이상부터 구매 가능합니다!");
                        Thread.Sleep(5000);
                    }
                }
                else if(input == 3)
                {
                    Console.WriteLine("휴식을 취합니다...(체력 + 20)");
                    health += 20;
                    Thread.Sleep(000);
                }
                else if(input == 4)
                {
                    Console.WriteLine("게임을 종료합니다......");
                    return;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    Thread.Sleep(5000);
                }
            }
        }
    }
}
