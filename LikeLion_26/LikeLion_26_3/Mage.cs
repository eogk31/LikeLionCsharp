using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_26_3
{
    public class Mage : GameCharacter
    {
        public Mage(string name) : base(name, 80, 20, 5)
        {
        }

        public override void BasicAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}가 {target.Name}에게 에너지 볼트! 이얏!");
            target.TakeDamage(Attack);
        }

        public override void SkillAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}가 {target.Name}에게 카돈 짓수! 타츠진!");
            target.TakeDamage(Attack * 3);
        }
    }
}
