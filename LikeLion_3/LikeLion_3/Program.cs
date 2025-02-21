using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //캐릭터
            //hp: 100
            //att: 56.7
            //캐릭터이름: ??
            //등급: S

            int hp = 100;
            double att = 56.7;
            string name = "배홍범";
            char rank = 'S';

            Console.WriteLine("캐릭터 프로필");
            Console.WriteLine("------------------");
            Console.WriteLine($"hp: {hp}");
            Console.WriteLine($"att: {att}");
            Console.WriteLine($"캐릭터이름: {name}");
            Console.WriteLine($"등급: {rank}");

        }
    }
}
