using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 몬스터 생성 영역
namespace TextRPG
{
    public class Monster
    {
        // 몬스터 데이터 저장 부분
        public Info m_tMonster;

        // 들어오는 인자값으로 몬스터의 체력 감소
        public void SetDamage(int iAttack)
        {
            m_tMonster.iHp -= iAttack;
        }

        // Info 클래스 타입 인자로 몬스터 생성
        public void SetMonster(Info tMonster)
        {
            m_tMonster = tMonster;
        }

      
        public Info GetMonster()
        {
            return m_tMonster;
        }

        public void Render()
        {
            Console.WriteLine("==============================");
            Console.WriteLine($"몬스터 이름: {m_tMonster.strName}");
            Console.WriteLine($"체력: {m_tMonster.iHp}");
            Console.WriteLine($"공격력: {m_tMonster.iAttack}");
            Console.WriteLine($"처치 시 획득 가능한 경험치 : {m_tMonster.exp}");
        }

        public Monster() { } //기본 생성자
        ~Monster() { } // 소멸자
    }
}
