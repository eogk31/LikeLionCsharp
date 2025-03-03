using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Rakshasa
{
    class Program
    {
        // 게임 시작 / 게임 설명 / 게임 종료 부분을 가운데 정렬하는 텍스트 정렬
        // 현재 창의 가로 길이에서 텍스트의 길이만큼 감산 후 나눠서 여백 계산
        // 여백에는 공백을 추가해서 중앙 정렬 후 출력한다.
        static void CenterText(string text)
        {
            int windowWidth = Console.WindowWidth;
            int textLength = text.Length;
            int padding = (windowWidth - textLength) / 3;

            Console.WriteLine(new string(' ', padding) + text);
        }


        static void Main()
        {
            //UTF-8 출력으로 한글 및 특수 문자 깨짐을 방지하고, 콘솔 창 제목 결정
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.Title = "락샤사 (Rakshasa)";

            // 게임 제목 출력
            // 게임 제목은 string형 변수 title 안에 넣어서 표기.
            string title = @"
                .########.....###....##....##..######..##.....##....###.....######.....###...
                .##.....##...##.##...##...##..##....##.##.....##...##.##...##....##...##.##..
                .##.....##..##...##..##..##...##.......##.....##..##...##..##........##...##.
                .########..##.....##.#####.....######..#########.##.....##..######..##.....##
                .##...##...#########.##..##.........##.##.....##.#########.......##.#########
                .##....##..##.....##.##...##..##....##.##.....##.##.....##.##....##.##.....##
                .##.....##.##.....##.##....##..######..##.....##.##.....##..######..##.....##
        ";
            Console.WriteLine(title);

            // 선택지 출력
            //Console.WriteLine("\n ▶ 『게임 시작』");
            //Console.WriteLine("    『게임 설명』");
            //Console.WriteLine("    『게임 종료』");

            // 선택지 변경을 위해 게임 시작 / 게임 설명 / 게임 종료에 변수를 추가
            // 3개의 선택지는 0~2까지의 범위를 가진다.
            int selectedIndex = 0;

            // 방향 키 입력 감지 변수
            ConsoleKeyInfo keyInfo;

            // 게임 설명 화면 클릭 시, 설명문이 나오는 페이지를 백스페이스로 되돌아가도록 하는 기능 추가.
            bool Explanation = false;

            // 콘솔 화면에서 깜빡임 커서가 나오지 않도록
            Console.CursorVisible = false;

            // do - while 반복문 사용
            // do 안에 내용은 조건을 확인 전 무조건 1회는 반드시 실행.
            // 
            do
            {
                Console.Clear();
                Console.WriteLine(title);

                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine();

                // 텍스트 가운데 정렬과 인덱스 번호를 0~2 까지 순서대로 부여.
                // 조건 상, 현재 게임 설명 화면이 아니면 다음 설명문을 나타낸다.
                if (!Explanation)
                {
                    CenterText("  " + (selectedIndex == 0 ? "▶ " : "   ") + "『게임 시작』");
                    Console.WriteLine();
                    CenterText("  " + (selectedIndex == 1 ? "▶ " : "   ") + "『게임 설명』");
                    Console.WriteLine();
                    CenterText("  " + (selectedIndex == 2 ? "▶ " : "   ") + "『게임 종료』");
                }
                // 게임 설명 화면, 향후 수정할 것.
                else
                {
                    Console.WriteLine("\n[ 게임 설명 ]");
                    Console.WriteLine("이 게임은 텍스트 기반 RPG입니다.");
                    Console.WriteLine("락샤사의 세계에서 당신은 칼잡이가 되어 살아남아야 합니다.");
                    Console.WriteLine("\n[ Backspace ]를 눌러 타이틀 화면으로 돌아가기.");
                }

                // 키 입력을 감지하며, 화면에 출력되지 않도록 숨겨주는 역할.
                keyInfo = Console.ReadKey(true);

                // 현재 게임 설명 화면이 아니면 선택 가능
                // if 내 중첩 if문 및 && 조건문으로 게임 시작 / 설명 / 종료의 인덱스 번호를 선택.
                if (!Explanation)
                {
                    if (keyInfo.Key == ConsoleKey.UpArrow && selectedIndex > 0)
                        selectedIndex--;
                    else if (keyInfo.Key == ConsoleKey.DownArrow && selectedIndex < 2)
                        selectedIndex++;
                    else if (keyInfo.Key == ConsoleKey.Spacebar)
                    {
                        // 게임 시작 (여기에 게임 시작 코드 추가 가능)
                        if (selectedIndex == 0)
                        {
                            Console.Clear();
                            GameStart(); // 게임 시작 화면으로 이동
                            break;
                        }
                        // "게임 설명" 선택 시 설명 화면으로 이동
                        else if (selectedIndex == 1)
                        {
                            Explanation = true;
                        }
                        // "게임 종료" 선택 시 종료
                        else if (selectedIndex == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("게임을 종료합니다.");
                            Environment.Exit(0);
                        }
                    }
                }
                // "게임 설명" 화면에서만 Backspace 작동
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    Explanation = false;
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
