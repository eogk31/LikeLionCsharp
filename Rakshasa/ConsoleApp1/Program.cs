using System;
using System.Threading;

namespace Rakshasa
{
    class Program
    {
        // 텍스트를 콘솔 화면 중앙에 정렬하여 출력하는 함수
        static void CenterText(string text)
        {
            int windowWidth = Console.WindowWidth;
            int textLength = text.Length;
            int padding = (windowWidth - textLength) / 3;
            Console.WriteLine(new string(' ', padding) + text);
        }

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "락샤사 (Rakshasa)";
            Console.CursorVisible = false;

            // 게임 제목 (ASCII 아트)
            string title = @"
                .########.....###....##....##..######..##.....##....###.....######.....###...
                .##.....##...##.##...##...##..##....##.##.....##...##.##...##....##...##.##..
                .##.....##..##...##..##..##...##.......##.....##..##...##..##........##...##.
                .########..##.....##.#####.....######..#########.##.....##..######..##.....##
                .##...##...#########.##..##.........##.##.....##.#########.......##.#########
                .##....##..##.....##.##...##..##....##.##.....##.##.....##.##....##.##.....##
                .##.....##.##.....##.##....##..######..##.....##.##.....##..######..##.....##
        ";
            int selectedIndex = 0;
            ConsoleKeyInfo keyInfo;
            bool isExplanation = false;

            do
            {
                Console.Clear();
                Console.WriteLine(title);
                Console.WriteLine();
                Console.WriteLine();

                if (!isExplanation)
                {
                    CenterText("  " + (selectedIndex == 0 ? "▶ " : "   ") + "『게임 시작』");
                    Console.WriteLine();
                    CenterText("  " + (selectedIndex == 1 ? "▶ " : "   ") + "『게임 설명』");
                    Console.WriteLine();
                    CenterText("  " + (selectedIndex == 2 ? "▶ " : "   ") + "『게임 종료』");
                }
                else
                {
                    Console.WriteLine("\n[ 게임 설명 ]");
                    Console.WriteLine("이 게임은 텍스트 기반 RPG입니다.");
                    Console.WriteLine("락샤사의 세계에서 당신은 칼잡이가 되어 살아남아야 합니다.");
                    Console.WriteLine("\n[ Backspace ]를 눌러 타이틀 화면으로 돌아가기.");
                }

                keyInfo = Console.ReadKey(true);

                if (!isExplanation)
                {
                    if (keyInfo.Key == ConsoleKey.UpArrow && selectedIndex > 0)
                        selectedIndex--;
                    else if (keyInfo.Key == ConsoleKey.DownArrow && selectedIndex < 2)
                        selectedIndex++;
                    else if (keyInfo.Key == ConsoleKey.Spacebar)
                    {
                        if (selectedIndex == 0)
                        {
                            Console.Clear();
                            GameStart(); // 게임 시작 화면으로 이동
                            break;
                        }
                        else if (selectedIndex == 1)
                        {
                            isExplanation = true;
                        }
                        else if (selectedIndex == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("게임을 종료합니다.");
                            Environment.Exit(0);
                        }
                    }
                }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    isExplanation = false;
                }

            } while (true);
        }

        // "게임 시작" 후 실행될 화면
        static void GameStart()
        {
            Console.Clear();

            string title2 = @"
    ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■
    ■            게임 시작!                                    ■
    ■                                                          ■
    ■  당신은 어두운 숲 속을 걷고 있다...                      ■
    ■  어디선가 싸늘한 기운이 느껴진다.                        ■
    ■                                                          ■
    ■  1) 계속 이동한다                                        ■
    ■  2) 주변을 탐색한다                                      ■
    ■                                                          ■
    ■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■";

            Console.WriteLine(title2); // 아스키 아트 스타일로 한 번에 출력

            while (true)
            {
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.D1)
                {
                    Console.Clear();
                    Console.WriteLine("당신은 앞으로 나아갔다...");
                    Thread.Sleep(1000);
                    break; // 이후 전투, NPC 조우 등 이벤트 추가 가능
                }
                else if (key == ConsoleKey.D2)
                {
                    Console.Clear();
                    Console.WriteLine("주변을 탐색 중...");
                    Thread.Sleep(1000);
                    break; // 탐색 이벤트 추가 가능
                }
            }
        }
    }
}
