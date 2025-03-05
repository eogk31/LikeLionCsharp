using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_25_2
{
    // 1. base 키워드
    class Parent
    {
        public virtual void ShowMessage()
        {
            Console.WriteLine("부모 클래스 메시지 출력");
        }
    }

    class Child : Parent
    {
        public override void ShowMessage()
        {
            Console.WriteLine("자식 클래스 메시지 출력");

            // 부모 클래스의 메소드를 자식에서 base로 자동 호출
            base.ShowMessage();
        }
    }

    // 2. 다시 한번 상속 관계에 대해
    class Player
    {
        protected string Name; //접근 제한자 protected: 부모-자식 상속에서만 사용

        public Player()
        {
            Name = "플레이어";
            Console.WriteLine("생성자입니다.");
        }

        public void Show()
        {
            Console.WriteLine($"{Name}");
        }
    }

    class Wizard : Player
    {
        public Wizard()
        {
            Name = "마법사";
            Console.WriteLine("자식 생성자입니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. 출력 부분
            Console.WriteLine("1. base 키워드");

            Child child = new Child();
            child.ShowMessage();

            Console.WriteLine("===============================");

            // 2. 출력 부분
            Console.WriteLine("2. 다시 한번 상속 관계에 대해 ");

            Player p = new Player();
            p.Show();

            Console.WriteLine();

            // 출력 순서
            // 1. Wizard는 Player를 상속하기에 먼저 Public Player() 출력. -> 생성자입니다.
            // 2. 그 다음, Wizard 클래스의 생성자 public Wizard() 출력. -> 자식 생성자입니다.
            // 3. w.Show(); 호출 → 부모 클래스 Player의 Show() 메서드 실행 -
            // -> public Wizard의 Name = "마법사"를 부모에게 상속받은 Show로 출력. -> 마법사
            Wizard w = new Wizard();
            w.Show();

            Console.WriteLine("===============================");
        }
    }
}
