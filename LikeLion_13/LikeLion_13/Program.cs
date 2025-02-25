using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LikeLion_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random 인스턴스 생성
            Random ran = new Random();

            //제목 입력
            Console.Write("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.Write("■                                                                                                                    ■");
            Console.Write("■                                                                                                                    ■");
            Console.Write("■                                                  대장장이 키우기                                                   ■");
            Console.Write("■                                                                                                                    ■");
            Console.Write("■                                                                                                                    ■");
            Console.Write("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

            int pmoney = 100;
            int input;
            int rand;

            Thread.Sleep(1000);

            while (true)
            {
                Console.Clear(); //화면 삭제

                //메뉴 바 생성
                Console.Write("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Console.Write("■                                                                                                                    ■");
                Console.Write("■                                                  1. 나무 캐기                                                      ■");
                Console.Write("■                                                  2. 장비 뽑기                                                      ■");
                Console.Write("■                                                  3. 나가기                                                         ■");
                Console.Write("■                                                                                                                    ■");
                Console.Write("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

                //입력 창 생성
                Console.Write("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
                Console.Write("■                                                                                                                    ■");
                Console.Write("    ■                                            입력:                                                               ■"); // 입력창을 메뉴 스타일에 맞춤
                Console.SetCursorPosition(50, Console.CursorTop);
                input = int.Parse(Console.ReadLine());
                Console.Write("■                                                                                                                    ■");
                Console.Write("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

                //입력된 숫자에 따른 분기를 조건문 if로 작성. 
                //1번, 나무 캐기 화면
                if (input == 1)
                {
                    //중첩 조건문 while로 입력 숫자에 따른 분기의 기능을 작성.
                    while (true)
                    {
                        Console.WriteLine("나무 캐기(엔터)");
                        Console.WriteLine("뒤로 가기(x)");

                        string str = Console.ReadLine();

                        pmoney += 100;
                        Console.WriteLine($"소지금: {pmoney}");

                        //뒤로 가기(x 입력) 기능을 if문으로 구현
                        if (str == "x")
                        {
                            Console.WriteLine("뒤로");
                            break;
                        }

                    }
                }

                //2번, 장비 뽑기 화면
                else if (input == 2)
                {
                    //장비뽑기
                    if (pmoney >= 1000) //돈이 있는지 확인후 뽑기
                    {
                        pmoney -= 1000;


                        //20번 뽑기
                        for (int i = 1; i <= 20; i++)
                        {
                            rand = ran.Next(1, 101);

                            if (rand == 1) // 1퍼
                            {
                                Console.WriteLine("도끼등급 SSS");
                            }
                            else if (rand >= 2 && rand <= 6)
                            {
                                Console.WriteLine("도끼등급 SS");
                            }
                            else if (rand >= 7 && rand <= 17)
                            {
                                Console.WriteLine("도끼등급 S");
                            }
                            else if (rand >= 18 && rand <= 38)
                            {
                                Console.WriteLine("도끼등급 A");
                            }
                            else if (rand >= 39 && rand <= 69)
                            {
                                Console.WriteLine("도끼등급 B");
                            }
                            else
                            {
                                Console.WriteLine("도끼등급 C");
                            }
                            Thread.Sleep(500); // 0.5초정도로 뽑혀라.
                        }
                    }
                    //pmoney가 1000 미만일 경우, 돈 부족 답변
                    else
                    {
                        Console.WriteLine("돈이 부족합니다. \n");
                        Thread.Sleep(1000);
                    }
                }

                //3번, 나가기 화면
                else if (input == 3)
                {
                    Console.WriteLine("나갑니다.");
                    Environment.Exit(0);
                }
            }
        }
    }
}
