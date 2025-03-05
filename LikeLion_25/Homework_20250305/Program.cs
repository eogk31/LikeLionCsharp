using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Homework_20250305
{
    class Test_subject
    {
        public string Name;
        protected int Health;
        protected int Stamina;

        public int Atk;
        public int Def;

        public Test_subject()
        {
            Name = "Unknown";
            Health = 0;
            Stamina = 0;
        }

        public virtual void Attack()
        {
            Console.WriteLine($"{Name}는(은) 적에게 기본 공격! {Atk}만큼의 피해!");
        }

        public virtual void Animal()
        {
            Console.WriteLine($"{Name}는(은) 야생 동물에게 기본 공격! {Atk}만큼의 피해!");
        }

        public virtual void Skill()
        {
            Console.WriteLine($"{Name}의 스킬 공격! {Atk * 100 / (100 + Def)}만큼의 피해!");
        }

        public virtual void Rest()
        {
            Console.WriteLine($"{Name}는(은) 휴식 중....");
        }

        public virtual void Produce()
        {
            Console.WriteLine($"{Name}는(은) 장비 제작 중....");
        }

    }

    class Hyunwoo : Test_subject
    {
        public Hyunwoo()
        {
            Name = "현우";
            Health = 1000;
            Stamina = 350;
            Atk = 40;
            Def = 51;
        }

        // 현우와 유키의 전투 메소드 작성.
        // 그냥 공격을 한다면 단순히 문구만이 출력.
        // 만약, 현우가 유키를 공격했다면 유키를 지정했을 경우 발생하는 방어와 죽음 메소드 발생을 분기로.
        public void Attack(Test_subject target)
        {
            int damage = Atk; 
            Console.WriteLine($"{Name}는(은) {target.Name}을(를) 공격! 피해: {damage}");

            if (target is Yuki yukiTarget)
            {
                yukiTarget.Defense(damage);
                yukiTarget.Die();
            }
        }

        public override void Animal()
        {
            Console.WriteLine($"{Name}는(은) 야생 동물에게 기본 공격! {Atk}만큼의 피해!");
        }

        // 현우가 유키를 공격할 경우의 스킬 공격 메소드 
        // 먼저, 공격 데미지 연산을 지정.
        // 그리고 유키를 타깃으로 한 경우에는 다음처럼 유키의 스킬 공격 방어와 죽음 메소드 작동 여부를 선택.

        public void Skill(Test_subject target)
        {
            int damage = Atk * 100 / (100 + Def); 
            Console.WriteLine($"{Name}의 스킬 공격! {target.Name}에게 {damage}의 피해!");

            if (target is Yuki yukiTarget)
            {
                yukiTarget.Skill_Defense(damage);
                yukiTarget.Die();
            }
        }

        public override void Rest()
        {
            Console.WriteLine($"{Name}는(은) 휴식 중....");
        }

        public override void Produce()
        {
            Console.WriteLine($"{Name}는(은) 장비 제작 중....");
        }
    }

    class Magnus : Test_subject
    {
        public Magnus()
        {
            Name = "매그너스";
            Health = 1070;
            Stamina = 410;
            Atk = 44;
            Def = 45;
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name}는(은) 공격! 적에게 {Atk}만큼 피해!");
        }

        public override void Animal()
        {
            Console.WriteLine($"{Name}는(은) 야생 동물에게 기본 공격! {Atk}만큼의 피해!");
        }

        public override void Skill()
        {
            Console.WriteLine($"{Name}의 스킬 공격! {Atk * 100 / (100 + Def)}만큼의 피해!");
        }

        public override void Rest()
        {
            Console.WriteLine($"{Name}는(은) 휴식 중....");
        }

        public override void Produce()
        {
            Console.WriteLine($"{Name}는(은) 장비 제작 중....");
        }
    }

    class Markus : Test_subject
    {
        public Markus()
        {
            Name = "마커스";
            Health = 880;
            Stamina = 430;
            Atk = 37;
            Def = 47;
        }

        public override void Attack()
        {
            Console.WriteLine($"{Name}는(은) 적에게 {Atk}공격력으로 공격!");
        }

        public override void Animal()
        {
            Console.WriteLine($"{Name}는(은) 야생 동물에게 {Atk}공격력으로 공격!");
        }

        public override void Skill()
        {
            Console.WriteLine($"{Name}의 스킬 공격! {Atk * 100 / (100 + Def)}의 피해!");
        }

        public override void Rest()
        {
            Console.WriteLine($"{Name}는(은) 휴식 중....");
        }

        public override void Produce()
        {
            Console.WriteLine($"{Name}는(은) 장비 제작 중....");
        }
    }

    class Yuki:Test_subject
    {

        public Yuki()
        {
            Name = "유키";
            Health = 20;
            Stamina = 410;
            Atk = 33;
            Def = 50;
        }

        // 유키의 공격 방어 메소드
        // 공격을 받으면 그 공격을 attackDamage로 저장하도록.
        // 저장 후에는 그만큼 Health로 감소.
        // 이후, 감소한 Health를 콘솔에 출력.
        public void Defense(int Damage)
        {
            int AttackDamage = Damage - (Def/100);
            Health -= AttackDamage;
            Console.WriteLine($"{Name}이 공격을 받았다! 남은 체력: {Health}");
        }

        // 스킬 공격 방어 메소드
        // 스킬 공격을 받으면 그 공격을 SkillDamage에 저장.
        // 저장 후에는 그만큼 Health에서 감소.
        // 이후, 감소한 Health를 콘솔에 출력.
        public void Skill_Defense(int Damage)
        {
            int SkillDamage = Damage * 100 / (100 + Def);
            Health -= SkillDamage;
            Console.WriteLine($"{Name}이 스킬 공격을 받았다! 남은 체력: {Health}");
        }

        // 죽음 메소드.
        // Health가 0 이하가 되면 그대로 죽었다는 것을 출력.
        public void Die()
        {
            if(Health <= 0)
                Console.WriteLine($"{Name}은 죽었다....");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // 리스트로 실험체 클래스를 배열로 만들어주고 현우, 매그너스, 마커스를 스쿼드로 생각하고 입력.
            List<Test_subject> test_Subjects = new List<Test_subject>();
            test_Subjects.Add(new Hyunwoo());
            test_Subjects.Add(new Magnus());
            test_Subjects.Add(new Markus());

            // 우선적으로 셋 모두 휴식을 취하는 중인 것을 가정.
            foreach(var test in test_Subjects)
            {
                test.Rest();
            }

            // 현우와 유키의 경우는 전투를 수행하기에 새롭게 객체를 부여.
            Hyunwoo h = new Hyunwoo();
            Yuki y = new Yuki();

            // 현우가 유키를 공격하는 상황. 이 경우에는 현우의 공격과 유키의 방어가 함께 작동.
            Console.WriteLine();
            h.Attack(y);

            // 매그너스의 객체 부여 후 야생 동물 공격을 작동.
            Console.WriteLine();
            Magnus m = new Magnus();
            m.Animal();

            // 마커스의 객체 부여 후 제작 작동.
            Console.WriteLine();
            Markus markus = new Markus();
            markus.Produce();
        }
    }
}
