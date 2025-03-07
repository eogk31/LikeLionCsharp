using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 1.사냥을 입력 시 사냥터로 이동하는 영역
namespace TextRPG
{
    public class Field
    {
        // 먼저 플레이어를 초기화
        Player m_pPlayer = null;

        // 몬스터 생성
        Monster m_monster = null;

        // 플레이어 MainGame에서 생성한 과정 가져오기
        // 플레이어가 필드에서 전투를 하면 데미지를 입고 hp 감소
        // ref로 읽기 쓰기를 함께
        public void SetPlayer(ref Player pPlayer)
        {
            m_pPlayer = pPlayer;
        }

        // 사냥터로 들어온 걸 알리는 부분
        public void Progress()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();

                m_pPlayer.Render();
                DrawMap();

                iInput = int.Parse(Console.ReadLine());

                if (iInput == 4)
                    break;

                // 몬스터 생성 부분
                // 1번이면 초보 몬스터, 2번이면 중급 몬스터, 3번이면 상급 몬스터 생성
                if(iInput <= 3)
                {
                    CreateMonster(iInput);
                    Fight();
                }
            }
        }

        // 몬스터의 생성을 Monster 클래스와 Info 클래스의 정보를 받아서 생성하는 메소드
        public void Create(string _strName, int _iHp, int _iAttack, int _exp, out Monster pMonster)
        {
            pMonster = new Monster();
            Info tMonster = new Info();

            tMonster.strName = _strName;
            tMonster.iHp = _iHp;
            tMonster.iAttack = _iAttack;
            tMonster.exp = _exp;

            // 생성된 데이터 Info 클래스 타입으로 몬스터 세팅
            pMonster.SetMonster(tMonster);
        }

        // 몬스터를 공장처럼 찍어내리는 디자인 패턴 팩토리 메소드 패턴을 구현
        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("초보 몬스터", 30, 3, 20, out m_monster);
                    break;
                case 2:
                    Create("중급 몬스터", 60, 6, 40, out m_monster);
                    break;
                case 3:
                    Create("상급 몬스터", 90, 9, 60, out m_monster);
                    break;
            }
        }

        public void Fight()
        {
            int iInput = 0;

            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                m_monster.Render();

                Console.Write("1.공격 2.도망 : ");
                iInput = int.Parse(Console.ReadLine());

                // 플레이어 공격으로 데미지 구현
                if(iInput == 1)
                {
                    m_pPlayer.SetDamage(m_monster.GetMonster().iAttack);
                    m_monster.SetDamage(m_pPlayer.GetInfo().iAttack);

                    // 플레이어 사망 구현. 플레이어 사망 시 좀 더 강한 능력을 얻도록 추가
                    if (m_pPlayer.GetInfo().iHp <= 0)
                    {
                        m_pPlayer.Death();
                        m_pPlayer.SetHP(100);
                        break;
                    }

                    // 플레이어가 적을 물리친 뒤, hp가 0 이상에 적의 hp가 0 이하면 경험치 획득
                    if(m_pPlayer.GetInfo().iHp >= 0 && m_monster.GetMonster().iHp <=0)
                    {
                        m_pPlayer.GetEXP(m_monster.GetMonster().exp);
                    }

                    // 플레이어가 사냥으로 얻은 경험치가 최대 경험치와 비교해 크거나 같으면 레벨 업
                    if(m_pPlayer.GetInfo().exp >= m_pPlayer.GetInfo().fullexp)
                    {
                        m_pPlayer.LevelUP();
                    }
                }

                if(iInput ==2 || m_monster.GetMonster().iHp <= 0)
                {
                    m_monster = null;
                    break;
                }
            }
        }

        public void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계로");
            Console.WriteLine("==========================");
            Console.Write("맵을 선택하세요 : ");
        }

        public Field() { }
        ~Field() { }
    }
}
