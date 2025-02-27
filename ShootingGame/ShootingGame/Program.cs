using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//c#을 통한 간단한 슈팅 게임 생성 프로젝트
namespace ShootingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //시작 방향 결정 변수
            int x = 10, y = 10;

            ConsoleKeyInfo keyInfo;

            Console.CursorVisible = true;

            while (true)
            {
                Console.Clear(); //화면 지우기

                Console.SetCursorPosition(x, y);

                Console.Write("●"); //현재의 위치 체크용 출력

                keyInfo = Console.ReadKey(true); //키를 입력 받아 화면에 빠르게 출력

                //방향키 입력에 따른 좌표 변경(switch 반복문 사용)
                //상하로 y축 조정, 좌우로 x축 조정, 스페이스 바로 미사일 출력, ESC 키로 종료.
                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:if (y > 0) y--; break;
                    case ConsoleKey.DownArrow:if (y < Console.WindowHeight-1) y++; break;
                    case ConsoleKey.LeftArrow:if (x > 0) x--; break;
                    case ConsoleKey.RightArrow: if (x < Console.WindowWidth - 1) x++; break;
                    case ConsoleKey.Spacebar: Console.Write("Misslie"); break;
                    case ConsoleKey.Escape: return; 
                }
            }
        }
    }
}
