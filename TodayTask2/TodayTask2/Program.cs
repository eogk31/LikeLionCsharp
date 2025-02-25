using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodayTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int ran = random.Next(1, 101);

            Console.Write("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");
            Console.Write("■                                                                                                                    ■");
            Console.Write("■                                                                                                                    ■");
            Console.Write("■                         1~100 중의 숫자 하나가 생성되었습니다. Updown_Game을 시작합니다.                           ■");
            Console.Write("■                                                                                                                    ■");
            Console.Write("■                                                                                                                    ■");
            Console.Write("■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■■");

            int count = 10;

            while (true)
            {
                if (count == 0)
                {
                    Console.WriteLine("기회를 전부 소실했습니다.");
                    Console.WriteLine($"정답은 {ran}이었습니다.");
                    break;
                }

                Console.Write("숫자 입력: ");
                string str = Console.ReadLine();
                int number = int.Parse(str);

                if (ran == number)
                {
                    Console.WriteLine($"{ran}입니다. 정답입니다.");
                    break;
                }
                else
                {
                    if (ran > number)
                        Console.WriteLine($"{number}보다 큽니다. UP");
                    else
                        Console.WriteLine($"{number}보다 작습니다. DOWN");
                    count--;
                }

            }
        }
    }
}
