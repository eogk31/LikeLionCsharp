using System;
using System.Collections.Generic;
using System.Diagnostics; //stopwatch
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShootingGame_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int width = Math.Min(80, Console.LargestWindowWidth);
            int height = Math.Min(25, Console.LargestWindowHeight);
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
            Console.ReadKey(); // 키 입력 대기

            //플레이어가 될 화살표를 문자열 배열로 생성
            string[] player = new string[] {
                "->",
                ">>>",
                "->"
            };

            //플레이어의 x축과 y축.
            int playerX = 0;
            int playerY = 12;
            ConsoleKeyInfo keyInfo;
            Console.CursorVisible = true;

            //시간 1초 루프 생성.
            Stopwatch timer = new Stopwatch();

            timer.Start();

            long prevSecond = timer.ElapsedMilliseconds; // 1/1000 초

            while (true)
            {
                long currentSecond = timer.ElapsedMilliseconds; //현재시간 가져오기

                if (currentSecond - prevSecond >= 1000)
                {
                    Console.Clear();

                    prevSecond = currentSecond; //이전 시간 업데이트

                    keyInfo = Console.ReadKey(true); //키를 입력 받아 화면에 빠르게 출력

                    //방향키 입력에 따른 좌표 변경(switch 반복문 사용)
                    //상하로 y축 조정, 좌우로 x축 조정, 스페이스 바로 미사일 출력, ESC 키로 종료.
                    switch (keyInfo.Key)
                    {
                        case ConsoleKey.UpArrow: if (playerY > 0) playerY--; break;
                        case ConsoleKey.DownArrow: if (playerY < Console.WindowHeight - player.Length) playerY++; break;
                        case ConsoleKey.LeftArrow: if (playerX > 0) playerX--; break;
                        case ConsoleKey.RightArrow: if (playerX < Console.WindowWidth - 1) playerX++; break;
                        case ConsoleKey.Spacebar: Console.Write("Misslie"); break;
                        case ConsoleKey.Escape: return;
                    }

                    for (int i = 0; i < player.Length; i++)
                    {
                        int newY = Math.Min(playerY + i, Console.WindowHeight - 1); // 커서 위치 제한

                        //콘솔 좌표를 설정.
                        Console.SetCursorPosition(playerX +i, playerY + i);

                        //문자열 배열을 출력.
                        Console.WriteLine(player[i]);
                    }
                }
            }
        }
    }
}
