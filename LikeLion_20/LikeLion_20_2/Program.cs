using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LikeLion_20_2
{
    class Marine
    {
        public string name;
        public int mineral;

        public Marine()
        {
            name ="Marine";
            mineral = 50;
            Console.WriteLine("스타크래프트 마린, 기본 생성자");
        }

        public Marine(string name, int mineral)
        {
            this.name = name;
            this.mineral = mineral;
            Console.WriteLine("스타크래프트 마린, 매개 변수 존재");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"명칭: {name}, 미네랄: {mineral}");
        }
    }

    class Scv
    {
        public string name;
        public int mineral;

        public Scv()
        {
            name = "scv";
            mineral = 30;
            Console.WriteLine("스타크래프트 Scv, 기본 생성자");
        }

        public Scv(string name, int mineral)
        {
            this.name = name;
            this.mineral = mineral;
            Console.WriteLine("스타크래프트 Scv, 매개 변수 존재");
        }

        public void Show()
        {
            Console.WriteLine($"명칭: {name}, 미네랄: {mineral}");
        }
    }

    class Barracks
    {
        public string name;
        public int mineral;
        public Barracks() 
        {
            name = "Barracks";
            mineral = 150;
            Console.WriteLine("스타크래프트 Barracks, 기본 생성자");
        }

        public Barracks(string name, int mineral)
        {
            this.name = name;
            this.mineral = mineral;
            Console.WriteLine("스타크래프트 Barracks, 매개 변수 존재");
        }

        public void ShowBarracks()
        {
            Console.WriteLine($"명칭: {name}, 미네랄: {mineral}");
        }
    }

    class Minerals
    {
        public int mineralCount;

        public Minerals()
        {
            mineralCount = 150;
            Console.WriteLine("스타크래프트 Minerals, 기본 생성자");
        }

        public Minerals(int mineralCount)
        {
            this.mineralCount = mineralCount;
            Console.WriteLine("스타크래프트 Minerals, 매개 변수 존재");
        }

        public void ShowMinerals()
        {
            Console.WriteLine($"미네랄: {mineralCount}");
        }
    }

    //전체적인 관리를 담당하는 Game 클래스를 만들어보자
    class Game
    {
        public static int mineral;
        public static int gas;
        public static int humanCount;
        public static void ShowGame()
        {
            Console.WriteLine($"미네랄: {mineral}, 가스: {gas}, 인구: {humanCount}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Marine mar = new Marine();
            mar.ShowInfo();
            Console.WriteLine();

            Marine marine = new Marine("마린", 100);
            marine.ShowInfo();
            Console.WriteLine();

            Scv scv1 = new Scv();
            scv1.Show();
            Console.WriteLine();

            Scv scv2 = new Scv("에스씨브이", 10);
            scv2.Show();
            Console.WriteLine();

            Barracks barracks1 = new Barracks();
            barracks1.ShowBarracks();
            Console.WriteLine();

            Barracks barracks2 = new Barracks("배럭", 200);
            barracks2.ShowBarracks();
            Console.WriteLine();

            //여기서 만들어진 건 Minerals 클래스의 배열
            Minerals[] minerals1 = new Minerals[7];

            //각 배열의 new 할당 객체화
            for(int i=0; i<minerals1.Length; i++)
            {
                minerals1[i] = new Minerals();
                minerals1[i].ShowMinerals();
                Console.WriteLine();
            }

            Game.mineral =50;
            Game.gas = 0;
            Game.humanCount = 4;

            Console.WriteLine("초기 주어진 Game 조건");
            Game.ShowGame();
        }
    }
}
