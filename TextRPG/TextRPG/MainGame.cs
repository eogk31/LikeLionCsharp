using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 게임 과정 관리 영역
namespace TextRPG
{
    class MainGame
    {
        public Player m_pPlayer = null;

        // 필드 객체
        public Field m_pField = null;

        // 초기화해주는 함수 작성
        public void Initialize()
        {
            // 플레이어 생성 및 직업 선택
            m_pPlayer = new Player();
            m_pPlayer.SelectJob();
        }

        // 게임의 전체적인 과정 관리 함수(유니티의 업데이트)
        public void Progress()
        {
            int iInput = 0;

            // 플레이어 출력 부분
            while (true)
            {
                Console.Clear();
                m_pPlayer.Render();
                Console.Write("1.사냥 2.종료: ");
                iInput = int.Parse(Console.ReadLine());

                // 종료 선택 시 종료 구현
                if (iInput == 2)
                    break;

                // 사냥 선택 시 사냥터 구현
                if (iInput == 1)
                {
                    if(m_pField == null)
                    {
                        m_pField = new Field();
                        //필드로 갈때 플레이어 넣어주기
                        m_pField.SetPlayer(ref m_pPlayer);
                    }
                    m_pField.Progress();
                }
            }
        }

        public MainGame() { }
        ~MainGame() { }
    }
}
