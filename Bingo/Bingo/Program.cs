using System;

namespace Bingo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bingo = new int[25];

            for (int i = 0; i < 25; i++)
                bingo[i] = i + 1;

            Random random = new Random();

            for (int i = 0; i < 100; i++)
            {
                int iA = random.Next(0, 25);
                int iB = random.Next(0, 25);
                int iT = bingo[iA];

                bingo[iA] = bingo[iB];
                bingo[iB] = iT;
            }

            int input = 0;
            //수정점! 이전에는 while문 안이었잖아!
            int iBingo = 0; // 빙고 개수 카운트
            int iCount = 0;

            while (true)
            {
                Console.Clear();
                

                // 빙고판 출력
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (bingo[i * 5 + j] == 0)
                            Console.Write(" * ");
                        else
                            Console.Write($"{bingo[i * 5 + j].ToString("D2")} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"빙고: {iBingo}");
                Console.Write("숫자를 입력하세요: ");
                input = int.Parse(Console.ReadLine());
                iBingo = 0;// 수정점! 빙고 개수를 초기화해서 이전 값 유지를 방지한다

                for (int i = 0; i < 25; i++)
                {
                    if (bingo[i] == input)
                    {
                        bingo[i] = 0;
                        break;
                    }
                }

                
                // 가로 체크
                for (int i = 0; i < 5; ++i) //수정점!
                {
                    for (int j = 0; j < 5; ++j) //수정점!
                    {
                        if (bingo[i * 5 + j] == 0)
                            ++iCount;
                        if (iCount == 5)
                            ++iBingo;
                    }
                    iCount = 0; //수정점! count를 안 넣었다!
                }

                // 세로 체크
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (bingo[i + 5 * j] == 0) //수정점! 이전에는 [i * 5 + j]로 작성!
                            ++iCount;
                        if (iCount == 5)
                            ++iBingo;
                    }
                    iCount = 0;
                }

                // 대각선 오른쪽 체크 (왼쪽 위 → 오른쪽 아래)
                // 00 01 02 03 *
                // 05 06 07 * 09
                // 10 11 * 13 14
                // 15 * 17 18 19
                // * 21 22 23 24
                //규칙: *은 4, 8, 12, 16, 20: (bingo[i*4+4]==0)인 수

                for (int i = 0; i < 5; i++)
                {
                    //수정점! 이전에는 for문을 한번 더 사용했다!
                    if (bingo[i * 4 + 4] == 0)
                        ++iCount;
                    if (iCount == 5)
                        ++iBingo;
                }
                iCount = 0; //수정점! for문 바깥에 작성!

                // 대각선 오른쪽 체크 (왼쪽 위 → 오른쪽 아래)
                // 규칙: (bingo[i*6]==0)인 수

                for (int i = 0; i < 5; i++)
                {
                    if (bingo[i * 6] == 0)
                        ++iCount;
                    if (iCount == 5)
                        ++iBingo;
                }
                iCount = 0;

                //수정점! 빙고 성공 부분 추가
                if (iBingo >= 5)
                {
                    //수정점! 빙고가 5줄 이상이면 빙고:X를 지우고 커서를 정리해 빙고 성공만 출력!
                    Console.SetCursorPosition(0, Console.CursorTop - 2); // 출력된 "빙고: X" 위치로 이동
                    Console.WriteLine(new string(' ', Console.WindowWidth)); // 공백으로 덮어쓰기
                    Console.SetCursorPosition(0, Console.CursorTop - 2); // 다시 위로 이동하여 커서 정리
                    Console.WriteLine("빙고 성공!");
                    break;
                }

            }
        }
    }
}