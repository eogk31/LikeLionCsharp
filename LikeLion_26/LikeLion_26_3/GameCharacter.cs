using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_26_3
{
    public abstract class GameCharacter
    {
        public string Name { get; set; }
        public int Health {  get; set; }
        public int Attack {  get; set; }
        public int Defense {  get; set; }

        protected GameCharacter(string name, int health, int attack, int defense) 
        {
            Name = name;
            Health = health;
            Attack = attack;
            Defense = defense;
        }

        // 추상 메소드: 모든 캐릭터가 시전해야 하는 기본 공격 
        public abstract void BasicAttack(GameCharacter target);

        // 추상 메소드: 모든 캐릭터가 시전해야 하는 특수 공격 
        public abstract void SkillAttack(GameCharacter target);

        // 일반 메소드: 모든 캐릭터가 공유하는 피해 계산 기능
        public void TakeDamage(int damage)
        {
            int actualDamage = Math.Max(1, damage - Defense);
            Health = Math.Max(0, Health - actualDamage);
            Console.WriteLine($"{Name}가 {actualDamage}의 피해를 받았다! 남은 체력 {Health}");

        }
    }
}
