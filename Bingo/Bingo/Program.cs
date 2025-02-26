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

            while (true)
            {
                Console.Clear();
                int iBingo = 0; // 빙고 개수 카운트
                int iCount = 0;

                // 빙고판 출력
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (bingo[i * 5 + j] == 0)
                            Console.Write(" * ");
                        else
                            Console.Write($"{bingo[i * 5 + j]:D2} ");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine($"빙고: {iBingo}");
                Console.Write("숫자를 입력하세요: ");
                int input = int.Parse(Console.ReadLine());

                for (int i = 0; i < 25; i++)
                {
                    if (bingo[i] == input)
                    {
                        bingo[i] = 0;
                        break;
                    }
                }

                

                // 가로 체크
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (bingo[i * 5 + j] == 0)
                            ++iCount;
                        if (iCount == 5)
                            ++iBingo;
                    }
                }

                // 세로 체크
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (bingo[i * 5 + j] == 0)
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
                    for (int j = 0; j < 5; j++)
                    {
                        if (bingo[i * 4 + 4] == 0)
                            ++iCount;
                        if (iCount == 5)
                            ++iBingo;
                    }
                    iCount = 0;
                }

                // 대각선 오른쪽 체크 (왼쪽 위 → 오른쪽 아래)
                // 규칙: (bingo[i*6]==0)인 수

                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (bingo[i * 6] == 0)
                            ++iCount;
                        if (iCount == 5)
                            ++iBingo;
                    }
                    iCount = 0;
                }

                
            }
        }
    }
}