using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rakshasa
{
    class Program
    {
        static void Main(string[] args)
        {
            //타이틀 화면을 설계
            //우선은 콘솔 창을 띄우면 거기에 게임 시작 화면을 네모 박스로 나타내고 그 안에 제목을 넣는다.
            //네모 박스는 79 x 10
            //제목을 아스키 아트로 넣을 수 있다면 어떨까?
            //LikeLion_15에 있는 콘솔 창을 참조하자.

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            Console.SetWindowPosition(0, 0);
            Console.CursorVisible = false;
            Console.Clear();

            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┌─────────────────────────────────────────────────────────────────────────────┐");

            Console.SetCursorPosition(0, 10);
            Console.WriteLine("└─────────────────────────────────────────────────────────────────────────────┘");
            
            for(int y =1; y<=9; y++)
            {
                Console.SetCursorPosition(0, y);
                Console.WriteLine("│                                                                             │");
            }

            Console.SetCursorPosition(0, 20);
        }
    }
}
