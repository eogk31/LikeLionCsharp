using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_25_3
{
    // 부모 클래스(기본 유닛)
    class Unit
    {
        public string Name;
        protected int Health;

        public Unit()
        {
            Name = "Unknown";
            Health = 0;
        }

        // 공격, 회복, 이동을 virtual 메소드로 구현.
        public virtual void Attack()
        {
            Console.WriteLine($"{Name}의 공격!");
        }

        public virtual void Heal(Unit target)
        {
            Console.WriteLine($"{Name}은 회복할 수 없다....");
        }

        public virtual void Move()
        {
            Console.WriteLine($"{Name}은 이동했다!");
        }
    }

    // SCV 유닛(건설과 수리 가능): Unit 상속
    class SCV : Unit
    {
        public SCV()
        {
            Name = "SCV";
            Health = 60;
        }

        public override void Attack()
        {
            Console.WriteLine("SCV의 용접기 공격! 효과는 미미했다...");
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"SCV 사이의 {target.Name}을 수리합니다.");
        }
    }

    //Marine 유닛(총기 공격): Unit 상속
    class Marine : Unit
    {
        public Marine()
        {
            Name = "Marine";
            Health = 40;
        }

        public override void Attack()
        {
            Console.WriteLine("Marine의 소총 공격!");
        }
    }

    class Medic : Unit
    {
        public Medic()
        {
            Name = "Medic";
            Health = 50;
        }

        public override void Attack()
        {
            //this unit cannot attack
        }

        public override void Heal(Unit target)
        {
            Console.WriteLine($"Medic이 {target.Name}을 치료합니다...");
        }
    }

    class Tank : Unit
    {
        public Tank()
        {
            Name = "Tank";
            Health = 100;
        }

        public override void Attack()
        {
            Console.WriteLine("Tank의 공격 실시!");
        }

        public override void Move()
        {
            Console.WriteLine("Tank의 이동 실시!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 객체를 하나씩 생성하지 말고, 상속하는 객체를 리스트로 묶어서 생성.
            // unit으로 모든 자식 개체의 조작 가능.
            List<Unit> units = new List<Unit>();

            units.Add(new SCV());
            units.Add(new Marine());
            units.Add(new Medic());
            units.Add(new Tank());

            // 모든 유닛을 순회하며 다형성 적용
            foreach (var unit in units)
            {
                unit.Move();
                unit.Attack();
                // 유닛 중 Move 메소드와 Attack 메소드를 가졌다면 동작 실행.
                Console.WriteLine();
            }

            // SCV가 탱크 수리 시도
            SCV scv = new SCV();
            scv.Heal(units[3]);

            // Medic의 Marine 치료 시도
            Medic medic = new Medic();
            medic.Heal(units[1]);
        }
    }
}
