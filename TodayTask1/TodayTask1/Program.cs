using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.WriteLine("□□□□□□□□□□□");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("■□□□□□□□□□□");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("■■□□□□□□□□□");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("■■■□□□□□□□□");
        Thread.Sleep(5000);
        Console.Clear();

        // 상단 빈 공간 (이미지 공간을 표현하는 느낌)
        Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
        for (int i = 0; i < 15; i++)
        {
            Console.WriteLine("□                                                                            □");
        }
        Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

        // 대화창 출력 (테두리는 유지)
        Console.WriteLine("■                                                                            ■");
        Console.WriteLine("■                                                                            ■");
        Console.WriteLine("■                                                                            ■");
        Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

        Thread.Sleep(1000);
        Console.SetCursorPosition(5, 18);
        Console.ForegroundColor = ConsoleColor.Red; // 텍스트 색상 변경
        Console.Write("\"그 날... 나도 너희와 함께 갔다면 행복했을까?\"");
        Console.ResetColor(); // 원래 색상으로 복구

        Thread.Sleep(2000);
        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("나는 평범한 사냥꾼이었다...");
        Thread.Sleep(1500);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("부모를 일찍 여의었지만, 사랑하는 동생이 있었다.");
        Thread.Sleep(1500);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("작은 마을에서 나무꾼 친구들과 지냈고,");
        Thread.Sleep(1500);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("부모를 잃은 빵집 자매와도 가족처럼 지냈다.");
        Thread.Sleep(1500);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("부모를 잃은 빵집 자매와도 가족처럼 지냈다.");
        Thread.Sleep(1500);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("하지만...");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("마을에는 이상한 물건이 퍼지고 있었다.");
        Thread.Sleep(1500);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("누군가는 그것을 '쿠키'라고 불렀다.");
        Thread.Sleep(1500);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("마치 달콤한 과자처럼 보였지만...");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("그것은 사람을 망가뜨리는 독이었다.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("나무꾼 친구들은 언제나 쾌활했다.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("하지만...");
        Thread.Sleep(1500);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("어느 날부터 그들의 눈빛이 변했다.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("\"요즘 이상한 걸 맛봤어. 기운이 솟더라니까!\"");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                    "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("그 후...그들은 점점 더 숲에 나가지 않게 되었다.");
        Thread.Sleep(1500);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                      "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("몸이 쇠약해지고, 피부는 창백해졌다.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        Console.SetCursorPosition(5, 18);
        Console.ForegroundColor = ConsoleColor.Red; // 텍스트 색상 변경
        Console.Write("\"이젠... 나무 냄새도 싫어. 손에 쥐는 도끼도 무겁고... \"");
        Console.ResetColor(); // 원래 색상으로 복구

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                          "); // 기존 문장 덮어쓰기

        Console.SetCursorPosition(5, 18);
        Console.ForegroundColor = ConsoleColor.Red; // 텍스트 색상 변경
        Console.Write("\"그냥... 아무것도 하고 싶지 않아.\"");
        Console.ResetColor(); // 원래 색상으로 복구

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("그날 이후, 그들은 사라졌다.");
        Thread.Sleep(2500);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("빵집 자매는 누구보다도 서로를 아꼈다.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("우리 형제와 같은 처지의 두 사람.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("그러나...");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("쿠키가 그녀들의 빵집을 찾아온 날.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("둘은 점점 변해갔다.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("빵집에서 언제나 풍겨오던 갓 구운 향은 사라진 지 오래");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                      "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("그녀들은 서로의 몫을 두고 다투기 시작했다.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("그리고 결국...");
        Thread.Sleep(2500);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("언니는 쿠키를 차지하기 위해...");
        Thread.Sleep(2500);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("가장 소중한 동생을 해쳤다.");
        Thread.Sleep(3000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("한없이 착했던 내 동생마저...");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("집안의 돈을 훔치다 나에게 들켜 도망쳤다.");
        Thread.Sleep(2000);

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("나는 필사적으로 그를 말렸다.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("\"그만둬! 이건 너답지 않아!\"");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("그러나 동생은 울면서 외쳤다.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("\"이렇게라도 하지 않으면... 쿠키를 못 먹어...\"");
        Thread.Sleep(2500);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("얼마 후...");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("상처투성이가 된 동생은 집으로 돌아왔고...");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.ForegroundColor = ConsoleColor.Red; // 텍스트 색상 변경
        Console.WriteLine("\"형... 미안해...\"");
        Console.ResetColor(); // 원래 색상으로 복구

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("마지막 말을 남기고 숨을 멎었다.");
        Thread.Sleep(3000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("나는... 한순간에 모든 것을 잃었다.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("이 모든 것의 원인은 단 하나.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("쿠키...");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("놈들을 용서할 수 없어.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기

        // 새로운 문장 출력
        Console.SetCursorPosition(5, 18);
        Console.Write("나는 복수를 결심했다.");
        Thread.Sleep(2000);

        // 이전 문장을 공백으로 덮어쓰기 (지우기)
        Console.SetCursorPosition(5, 18);
        Console.Write("                                                 "); // 기존 문장 덮어쓰기



        // 모든 대화가 끝난 후 게임 제목 및 메뉴 출력
        Console.Clear();
        Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
        Console.WriteLine("□                                                                            □");
        Console.WriteLine("□                            [ 마지막 한 입 ]                                □");
        Console.WriteLine("□                                                                            □");
        Console.WriteLine("□                            1. 시작                                         □");
        Console.WriteLine("□                                                                            □");
        Console.WriteLine("□                                                                            □");
        Console.WriteLine("□                                                                            □");
        Console.WriteLine("□                                                                            □");
        Console.WriteLine("□                                                                            □");
        Console.WriteLine("□                            2. 종료                                         □");
        Console.WriteLine("□                                                                            □");
        Console.WriteLine("□                                                                            □");
        Console.WriteLine("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

        // 대화창 아래로 이동해서 "계속하려면..." 출력
        Console.SetCursorPosition(0, 23);
        Console.Write("계속하려면 아무 키나 누르십시오...");

        // 키 입력 대기
        Console.ReadKey();

        // 이후 같은 방식으로 적용...
    }
}
