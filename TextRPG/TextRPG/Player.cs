using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 플레이어 관련 항목 실행 영역
namespace TextRPG
{
    public class Player
    {
        public Info m_tInfo;

        // 직업 선택 창
        public void SelectJob()
        {
            m_tInfo = new Info();

            Console.WriteLine("직업을 선택하세요(1.기사 2.마법사 3.도둑)");

            int iInput = 0;
            iInput = int.Parse(Console.ReadLine());

            switch (iInput)
            {
                case 1:
                    m_tInfo.strName = "기사";
                    m_tInfo.iHp = 100;
                    m_tInfo.iAttack = 10;
                    m_tInfo.level = 1;
                    m_tInfo.exp = 0;
                    m_tInfo.fullexp = 100;
                    //m_tInfo.death = 0;
                    break;
                case 2:
                    m_tInfo.strName = "마법사";
                    m_tInfo.iHp = 60;
                    m_tInfo.iAttack = 20;
                    m_tInfo.level = 1;
                    m_tInfo.exp = 0;
                    m_tInfo.fullexp = 100;
                    //m_tInfo.death = 0;
                    break;
                case 3:
                    m_tInfo.strName = "도적";
                    m_tInfo.iHp = 75;
                    m_tInfo.iAttack = 15;
                    m_tInfo.level = 1;
                    m_tInfo.exp = 0;
                    m_tInfo.fullexp = 100;
                    //m_tInfo.death = 0;
                    break;
                default:
                    Console.WriteLine("입력이 올바르지 않습니다.");
                    break;
            }
        }

        // switch문에서 선택된 직업 정보 출력 함수
        public void Render()
        {
            Console.WriteLine("==============================");
            Console.WriteLine($"직업: {m_tInfo.strName}");
            Console.WriteLine($"체력: {m_tInfo.iHp}");
            Console.WriteLine($"공격력: {m_tInfo.iAttack}");
            Console.WriteLine($"레벨: {m_tInfo.level}");
            Console.WriteLine($"현재 경험치: {m_tInfo.exp}");
            Console.WriteLine($"다음 레벨업까지 필요한 경험치: {m_tInfo.fullexp}");
            //Console.WriteLine($"죽은 횟수: {m_tInfo.death = 0}");
        }

        // 데미지를 입는 함수 
        public void SetDamage(int iAttack)
        {
            m_tInfo.iHp -= iAttack;
        }

        //플레이어 정보를 외부에서 볼 수 있는 함수
        public Info GetInfo()
        {
            return m_tInfo;
        }

        //hp를 다시 설정해주는 함수
        public void SetHP(int iHp)
        {
            m_tInfo.iHp = iHp;
        }

        //적을 물리치면 경험치를 획득하는 함수
        public void GetEXP(int exp)
        {
            m_tInfo.exp += exp;
        }

        // fullexp가 다 차면 레벨 업을 하는 함수
        public void LevelUP()
        {
            if(m_tInfo.fullexp < m_tInfo.exp + m_tInfo.fullexp)
            {
                m_tInfo.level++;
                m_tInfo.fullexp += 100;
            }
        }

        Random random = new Random();


        // 플레이어가 사망할 때마다 카운트하고 그만큼 강화를 해주도록 하는 함수
        public void Death()
        {
            m_tInfo.level = 1;
            m_tInfo.exp = 0;
            m_tInfo.fullexp = 100;
            m_tInfo.iAttack += random.Next(1, 11);
        }


        // 아래 생성자와 소멸자는 명시적으로 사용해도 되고 하지 않아도 된다.
        public Player() { }

        ~Player() { } // 소멸자 입력 
    }
}
