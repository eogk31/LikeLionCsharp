using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // 콘솔 창 크기를 버퍼 크기와 맞추기
            Console.SetWindowSize(80, 25);

            // 콘솔 버퍼 크기 설정
            Console.SetBufferSize(80, 25);

            // 창 위치를 좌상단(0,0)으로 설정
            Console.SetWindowPosition(0, 0);

            // 커서 숨기기
            Console.CursorVisible = false;

            // 화면 지우기
            Console.Clear();

            // 텍스트 출력
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("┌━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┐");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("│                                             │");
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("│                                             │");
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("│               대장장이 키우기               │");
            Console.SetCursorPosition(0, 4);
            Console.WriteLine("│                                             │");
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("│                                             │");
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("└━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┘");

            Thread.Sleep(3000);

            //0부터 29까지 이동
            for(int x =0; x<30; x++)
            {
                Console.Clear();
                Console.SetCursorPosition(x, 10);
                Console.WriteLine("◎");
                Thread.Sleep(100);
            }
        }
    }
}
