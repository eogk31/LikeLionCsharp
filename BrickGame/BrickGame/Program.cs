using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BrickGame
{
    class Program
    {
        [DllImport("msvcrt.dll")]
        public static extern int _getch(); //C언어 함수 가져옴

        public static void gotoxy(int x, int y)
        {
            int maxX = Console.WindowWidth - 1;
            int maxY = Console.WindowHeight - 1;

            x = Math.Max(0, Math.Min(maxX, x));
            y = Math.Max(0, Math.Min(maxY, y));

            Console.SetCursorPosition(x, y);
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            GameManager gameManager = new GameManager();
            gameManager.Initialize();

            int Curr = Environment.TickCount;

            while (true)
            {
                if(Curr +50 < Environment.TickCount)
                {
                    Curr = Environment.TickCount;

                    gameManager.Progress(); //처리되지 않은 예외
                    gameManager.Render();
                }
            }
        }
    }
}
