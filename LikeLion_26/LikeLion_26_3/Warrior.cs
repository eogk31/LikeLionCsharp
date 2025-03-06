using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_26_3
{
    public class Warrior:GameCharacter
    {
        public Warrior(string name) : base(name, 100, 15, 10)
        {
        }

        public override void BasicAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}가 {target.Name}에게 이아이도! 이얏!");
            target.TakeDamage(Attack);
        }

        public override void SkillAttack(GameCharacter target)
        {
            Console.WriteLine($"{Name}가 {target.Name}에게 데스 베기! 키리스테 고멘!");
            target.TakeDamage(Attack * 3);
        }
    }
}
