using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //공격력, 최대 생명력, 치명, 특화, 제압, 신속, 인내, 숙련을 출력
            int Attack = 16755;
            int MaxHp = 78103;
            int Critical = 36;
            int Specialization = 1017;
            int Suppression = 41;
            int Swiftness = 611;
            int Endurance = 22;
            int Mastery = 39;

            Console.WriteLine("         기본 특성       ?");
            Console.WriteLine("------------v--------------");
            Console.WriteLine($"공격력: {Attack}");
            Console.WriteLine($"최대 생명력: {MaxHp}");
            Console.WriteLine();
            Console.WriteLine("         전투 특성       ?");
            Console.WriteLine("------------v--------------");
            Console.WriteLine($"치명: {Critical}");
            Console.WriteLine($"특화: {Specialization}");
            Console.WriteLine($"제압: {Suppression}");
            Console.WriteLine($"신속: {Swiftness}");
            Console.WriteLine($"인내: {Endurance}");
            Console.WriteLine($"숙련: {Mastery}");
            Console.WriteLine("         상세 정보           ");
        }
    }
}
