using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion_25_4
{
    class Skill
    {
        public string Name;
        public int ManaCost;
        public int CoolTime;
        public int LastUsedTime;

        public Skill(string name, int mana, int cool)
        {
            Name = name;
            ManaCost = mana;
            CoolTime = cool * 1000;
            LastUsedTime = 0;
        }

        // 스킬 사용 가능 확인 여부
        public bool CanUse(int playerMana)
        {
            int currentTime = Environment.TickCount;

            if (playerMana < ManaCost)
            {
                Console.WriteLine($"마나가 부족합니다(필요 MP: {ManaCost})");
                return false;
            }

            if (currentTime - LastUsedTime < CoolTime)
            {
                int remain = (CoolTime - (currentTime - LastUsedTime)) / 1000;
                Console.WriteLine($"쿨타임입니다(남은 시간: {remain}");
                return false;
            }

            return true;
        }

        // 스킬 사용
        public void Use(ref int playerMana)
        {
            if (!CanUse(playerMana))
                return;
            playerMana -= ManaCost; // 플레이어 마나 참조로 외부 값도 같이 조정 동기화
            LastUsedTime = Environment.TickCount; // 현재 시간을 저장.

            Console.WriteLine($"{Name} 스킬 사용! (MP - {ManaCost})");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int playerMana = 200;

            // 초기 마나 부여 후 스킬 목록
            Skill[] skills = new Skill[]
            {
                new Skill("Fireball", 20, 3),
                new Skill("Ice Spear", 15, 2),
                new Skill("Healing", 30, 5)
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"현재 MP :{playerMana}");
                Console.WriteLine("사용 가능한 스킬 목록: ");
                for (int i = 0; i < skills.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {skills[i].Name} (MP {skills[i].ManaCost}), (쿨타임 {skills[i].CoolTime / 1000}s)");
                }
                Console.WriteLine("0. 종료");
                Console.Write("사용할 스킬 번호를 입력하세요: ");

                try
                    {
                        int skillIndex = int.Parse(Console.ReadLine());

                        if (skillIndex == 0)
                            break;

                        if (skillIndex > 0 && skillIndex <= skills.Length)
                        {
                            skills[skillIndex - 1].Use(ref playerMana);
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다.");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("숫자를 입력하세요.");
                    }

                    Thread.Sleep(500);
                }
                Console.WriteLine("게임 종료");
            }
        }
    }
