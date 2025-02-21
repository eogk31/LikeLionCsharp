using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LikeLion_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////문자열 입력 관련 메서드
            //// 사용자 입력을 문자열로 받기
            //Console.WriteLine("문자열 입력 관련 메서드");
            //Console.Write("이름을 입력: ");
            //string name = Console.ReadLine();

            //Console.WriteLine(name);
            //Console.WriteLine("======================================");

            ////형식 변환
            //// 문자열을 정수로 변환
            //Console.WriteLine("문자열 입력 관련 메서드");
            //Console.Write("나이를 입력: ");
            //string age = Console.ReadLine();
            //int age_number = int.Parse(age);

            //Console.WriteLine(age_number);
            //Console.WriteLine($"내년에는 {age_number+1}이 되겠군요.");
            //Console.WriteLine("======================================");

            //미니테스트 - 스테이터스 입출력
            //ex)루인 스킬 피해: 4.5 %<- 입력
            Console.WriteLine("                 입력                   ");
            Console.WriteLine("========================================");
            Console.Write("루인 스킬 피해 입력: ");
            string ruin = Console.ReadLine();
            double ruin_number = double.Parse(ruin);

            Console.Write("카드 게이지 획득량 입력: ");
            string card = Console.ReadLine();
            double card_number = double.Parse(card);

            Console.Write("각성기 피해 입력: ");
            string ab = Console.ReadLine();
            double ab_number = double.Parse(ab);

            Console.Write("최대 마나: ");
            string Maxmana = Console.ReadLine();
            double Maxmananumber = double.Parse(Maxmana);

            Console.Write("전투 중 마나 회복량: ");
            string mana_walk = Console.ReadLine();
            double mana_walk_number = double.Parse(mana_walk);

            Console.Write("비전투 중 마나 회복량: ");
            string mana_idle = Console.ReadLine();
            double mana_idle_number = double.Parse(mana_idle);

            Console.Write("이동 속도: ");
            string walk = Console.ReadLine();
            double walk_number = double.Parse(walk);

            Console.Write("탈 것 속도: ");
            string ride = Console.ReadLine();
            double rid_number = double.Parse(ride);

            Console.Write("운반 속도: ");
            string lift = Console.ReadLine();
            double lift_number = double.Parse(lift);

            Console.Write("스킬 재사용 대기시간 감소: ");
            string cooltime = Console.ReadLine();
            double cooltime_number = double.Parse(cooltime);

            Console.WriteLine();
            Console.WriteLine("활동                                   v");
            Console.WriteLine("========================================");
            Console.WriteLine($"루인 스킬 피해: {ruin_number:F1}%");
            Console.WriteLine($"카드 게이지 획득량: {card_number:F1}%");
            Console.WriteLine($"각성기 피해: {ab_number:F1}%");
            Console.WriteLine($"최대 마나: {Maxmananumber}");
            Console.WriteLine($"전투 중 마나 회복량: {mana_walk_number}");
            Console.WriteLine($"비전투 중 마나 회복량: {mana_idle_number}");
            Console.WriteLine($"이동 속도: {walk_number:F1}%");
            Console.WriteLine($"탈 것 속도: {rid_number:F1}%");
            Console.WriteLine($"운반 속도: {lift_number:F1}%");
            Console.WriteLine($"스킬 재사용 대기시간 감소: {cooltime_number:F1}%");

        }
    }
}
