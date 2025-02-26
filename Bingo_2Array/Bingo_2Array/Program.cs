using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo_2Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //2차원 배열로 5x5 빙고판 만들기
            int[,] bingoboard = new int[5, 5];

            //선택된 숫자 체크하는 2차원 배열
            bool[,] bingomark = new bool[5, 5];

            //빙고 카운트
            int bingoCount = 0;

            //랜덤 인스턴스
            Random random = new Random();

            //빙고판 초기화
            int[] numbers = new int[25];

            for(int i=0; i<25; i++)
                numbers[i] = i+1;

            //랜덤 셔플 알고리즘 작성
            for(int i=0; i<100; i++)
            {
                int a =random.Next(25);
                int b =random.Next(25);

                //a와 b를 셔플, C#의 튜플 방식
                //튜플 문법을 활용하여 두 변수의 값을 교환
                (numbers[a], numbers[b]) = (numbers[b],  numbers[a]);
            }

            //2차원 배열로 변환
            int index = 0;
            for(int i=0; i<5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    bingoboard[i,j] = numbers[index++];
                }
            }

            //빙고 게임 시작
            while (bingoCount < 5)
            {
                Console.Clear();

                //빙고판 출력
                Console.WriteLine("현재 빙고판");

                for(int i=0; i<5; i++)
                {
                    for(int j=0; j<5; j++)
                    {
                        if (bingomark[i, j])
                            Console.Write(" * ");
                        else
                            Console.Write($"{bingoboard[i, j]:D2} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine($"현재 빙고: {bingoCount}") ;
                Console.Write("숫자 입력(1~25): ");
                int number = int.Parse(Console.ReadLine());
                bool found = false;

                //숫자 입력
                for(int i =0; i<5; i++)
                {
                    for(int j=0; j<5; j++)
                    {
                        if (bingoboard[i, j] == number)
                        {
                            bingomark[i, j] = true; //숫자를 *로 변경
                            found = true;
                            break;
                        }
                    }
                    if (found)
                        break;
                }

                //빙고 개수 체크
                bingoCount = 0;

                //가로로 빙고 체크
                for(int i =0; i<5; i++)
                {
                    bool rowBingo = true;
                    for(int k=0; k<5; k++)
                    {
                        if (!bingomark[i, k])
                            rowBingo = false;

                        
                    }
                    if (rowBingo)
                        bingoCount++;
                }

                //세로로 빙고 체크
                for (int j = 0; j < 5; j++)
                {
                    bool colBingo = true;

                    for(int i=0; i<5; i++)
                    {
                        if(!bingomark[i, j])
                            colBingo = false;
                        
                    }
                    if (colBingo)
                        bingoCount++;
                }

                //대각선 빙고 체크(왼쪽 위 -> 오른쪽 아래)
                bool diag1Bingo = true;

                for(int i=0; i<5; i++)
                {
                    if (!bingomark[i, i])
                        diag1Bingo = false;
                }
                if (diag1Bingo)
                    bingoCount++;

                //대각선 빙고 체크(오른쪽 위 -> 왼쪽 아래)
                bool diag2Bingo = true;

                for (int i = 0; i < 5; i++)
                {
                    if (!bingomark[i, 4-i])
                        diag2Bingo = false;
                }
                if (diag2Bingo)
                    bingoCount++;
            }

            Console.WriteLine("빙고 5개 완성!!");
        }
    }
}
