using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

//2월 28일 수업 시간에 제작해보는 강사님 스타일 슈팅 게임
namespace NewShootingGame
{
    //미사일 클래스 제작 부분
    public class Misslie
    {
        //미사일을 발사하는 2차원 좌표
        public int x;
        public int y;

        //미사일이 날아갔는가 체크할 bool 값
        public bool fire;
    }

    //플레이어 클래스 제작 부분
    public class Player
    {
        //C언어의 함수를 가져온 부분
        [DllImport("msvcrt.dll")]
        static extern int _getch(); //_getch는 따로 필기할 것!

        //플레이어의 2차원 좌표
        public int PlayerX;
        public int PlayerY;

        //플레이어가 가지고 있는 미사일
        public Misslie[] PlayerMisslie = new Misslie[20];

        //미사일 배열 늘려주기
        public Misslie[] PlayerMisslie2 = new Misslie[20];
        public Misslie[] PlayerMisslie3 = new Misslie[20];

        //플레이어가 가지고 있는 아이템
        public Item item = new Item();
        public int itemCount = 0;
        public int Score = 100;

        //플레이어를 생성자로 초기화
        public Player()
        {
            //플레이어의 좌표 위치 초기화
            PlayerX = 0;
            PlayerY = 12;



            //미사일 배열 초기화
            for(int i=0; i<20; i++)
            {
                PlayerMisslie[i] = new Misslie();
                PlayerMisslie[i].x = 0;
                PlayerMisslie[i].y = 0;
                PlayerMisslie[i].fire = false;

                //미사일 배열 추가
                PlayerMisslie2[i] = new Misslie();
                PlayerMisslie2[i].x = 0;
                PlayerMisslie2[i].y = 0;
                PlayerMisslie2[i].fire = false;

                PlayerMisslie3[i] = new Misslie();
                PlayerMisslie3[i].x = 0;
                PlayerMisslie3[i].y = 0;
                PlayerMisslie3[i].fire = false;
            }
        }
        //게임 키 설정 설계
        public void GameMain()
        {
            KeyControl();
            PlayerDraw();
            MisslieDraw();

            //UI 점수 부분 추가
            UIscore();

            if (item.itemLife)
            {
                item.ItemMove();
                item.ItemDraw();
                CrashItem();
            }
        }

        //키보드로 입력하는 메소드 부분 설계
        public void KeyControl()
        {
            int playerHeight = 3;

            //정수형 변수를 선언해 키 값을 받을 부분 설계
            int pressKey;

            //키가 눌렸을 때 true로 들어가는 조건문 if

            //수정한 부분: _getch는 키를 두번 눌러야 반응하는 걸 1번으로 줄여 더 부드럽게 움직이도록 수정.
            if (Console.KeyAvailable)
            {
                pressKey = _getch();  // 🔹 첫 번째 값 읽기

                if (pressKey == 0 || pressKey == 224)
                {
                    pressKey = _getch();  // 🔹 방향키일 경우 두 번째 값 읽기
                }

                switch (pressKey)
                {
                    //방향키 위쪽 입력
                    case 72:
                    {
                      PlayerY--;
                            if (PlayerY < 0)
                                PlayerY = 0;
                            break;
                    }
                    //방향키 왼쪽 입력
                    case 75:
                        {
                            PlayerX--;
                            if (PlayerX < 0)
                                PlayerX = 0;
                            break;
                        }
                    //방향키 오른쪽 입력
                    case 77:
                        {
                            PlayerX++;
                            if (PlayerX > Console.WindowWidth)
                                PlayerX = Console.WindowWidth-1;
                            break;
                        }
                    //방향키 아래쪽 입력
                    case 80:
                        {
                            PlayerY++;
                            if (PlayerY > Console.WindowHeight - playerHeight)
                                PlayerY = Console.WindowHeight - playerHeight;
                            break;
                        }
                    //스페이스 바 입력으로 미사일 발사
                    case 32:
                        {
                            for(int i=0; i<20; i++)
                            {
                                //미사일이 false일 경우 발사가능
                                if (PlayerMisslie[i].fire == false)
                                {
                                    PlayerMisslie[i].fire = true;

                                    //플레이어 앞에서 미사일 쏘기 + 5정도 앞에
                                    PlayerMisslie[i].x = PlayerX + 5;
                                    PlayerMisslie[i].y = PlayerY + 1;

                                    //미사일은 1발씩만 발사
                                    //break 없으면 스페이스 한번에 연사한다.
                                    break;
                                }
                            }

                            //두번째, 세번째 미사일 발사 부분
                            for (int i = 0; i < 20; i++)
                            {
                                //미사일이 false일 경우 발사가능
                                if (PlayerMisslie2[i].fire == false)
                                {
                                    PlayerMisslie2[i].fire = true;

                                    //플레이어 앞에서 미사일 쏘기 + 5정도 앞에
                                    PlayerMisslie2[i].x = PlayerX + 8;
                                    PlayerMisslie2[i].y = PlayerY;

                                    //미사일은 1발씩만 발사
                                    //break 없으면 스페이스 한번에 연사한다.
                                    break;
                                }
                            }

                            for (int i = 0; i < 20; i++)
                            {
                                //미사일이 false일 경우 발사가능
                                if (PlayerMisslie3[i].fire == false)
                                {
                                    PlayerMisslie3[i].fire = true;

                                    //플레이어 앞에서 미사일 쏘기 + 5정도 앞에
                                    PlayerMisslie3[i].x = PlayerX + 8;
                                    PlayerMisslie3[i].y = PlayerY + 2;

                                    //미사일은 1발씩만 발사
                                    //break 없으면 스페이스 한번에 연사한다.
                                    break;
                                }
                            }
                            break;
                        }
                }
            }
        }

        //플레이어를 그리는 부분
        public void PlayerDraw()
        {

            //string[] 배열을 선언해서 플레이어를 그려주는 부분 설계
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };

            for (int i = 0; i < player.Length; i++)
            {
                int drawY = PlayerY + i;

                // 화면을 벗어나지 않도록 제한
                if (drawY >= Console.WindowHeight)
                    continue;

                Console.SetCursorPosition(PlayerX, drawY);
                Console.WriteLine(player[i]);
            }
        }

        //미사일을 그리는 부분 설계
        public void MisslieDraw()
        {
            //string으로 미사일 모습 생성
            string misslie = "->";

            //20개의 미사일 작성
            for (int i=0; i<20; i++)
            {
                //미사일이 살아있는 상태면 발사되는 조건문 작성
                if (PlayerMisslie[i].fire == true)
                {
                    //미사일의 좌표를 설정
                    //중간 위치를 위해 보정
                    Console.SetCursorPosition(PlayerMisslie[i].x, PlayerMisslie[i].y);
                    Console.Write("  ");

                    //총알을 출력
                    

                    //미사일이 오른쪽으로 날아가도록 설계
                    PlayerMisslie[i].x++;

                    //미사일을 모두 쏘고 나면 다시 false로 바꿔 재장전 설계
                    if (PlayerMisslie[i].x >= Console.WindowWidth - 1)
                    {
                        PlayerMisslie[i].fire = false;
                    }
                    else
                    {
                        // 새로운 위치에 미사일 출력
                        Console.SetCursorPosition(PlayerMisslie[i].x, PlayerMisslie[i].y);
                        Console.Write(misslie);
                    }
                }
            }
        }

        public void MisslieDraw2()
        {
            //string으로 미사일 모습 생성
            string misslie = "->";

            //20개의 미사일 작성
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태면 발사되는 조건문 작성
                if (PlayerMisslie2[i].fire == true)
                {
                    //미사일의 좌표를 설정
                    //중간 위치를 위해 보정
                    Console.SetCursorPosition(PlayerMisslie2[i].x, PlayerMisslie2[i].y);
                    Console.Write("  ");

                    //총알을 출력


                    //미사일이 오른쪽으로 날아가도록 설계
                    PlayerMisslie2[i].x++;

                    //미사일을 모두 쏘고 나면 다시 false로 바꿔 재장전 설계
                    if (PlayerMisslie2[i].x >= Console.WindowWidth - 1)
                    {
                        PlayerMisslie2[i].fire = false;
                    }
                    else
                    {
                        // 새로운 위치에 미사일 출력
                        Console.SetCursorPosition(PlayerMisslie2[i].x, PlayerMisslie2[i].y);
                        Console.Write(misslie);
                    }
                }
            }
        }

        public void MisslieDraw3()
        {
            //string으로 미사일 모습 생성
            string misslie = "->";

            //20개의 미사일 작성
            for (int i = 0; i < 20; i++)
            {
                //미사일이 살아있는 상태면 발사되는 조건문 작성
                if (PlayerMisslie3[i].fire == true)
                {
                    //미사일의 좌표를 설정
                    //중간 위치를 위해 보정
                    Console.SetCursorPosition(PlayerMisslie3[i].x, PlayerMisslie3[i].y);
                    Console.Write("  ");

                    //총알을 출력


                    //미사일이 오른쪽으로 날아가도록 설계
                    PlayerMisslie3[i].x++;

                    //미사일을 모두 쏘고 나면 다시 false로 바꿔 재장전 설계
                    if (PlayerMisslie3[i].x >= Console.WindowWidth - 1)
                    {
                        PlayerMisslie3[i].fire = false;
                    }
                    else
                    {
                        // 새로운 위치에 미사일 출력
                        Console.SetCursorPosition(PlayerMisslie3[i].x, PlayerMisslie3[i].y);
                        Console.Write(misslie);
                    }
                }
            }
        }


        //적 오브젝트와의 충돌 처리 부분 설계
        public void ClashEnemyAndMisslie(Enemy enemy)
        {
            //미사일 20개와 비교 부분 설계
            for(int i=0; i<20; i++)
            {
                //발사하여 살아있는 미사일
                if (PlayerMisslie[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (PlayerMisslie[i].y == enemy.enemyY)
                    {
                        //&&(AND) 문으로 x 좌표 충돌 설계
                        if (PlayerMisslie[i].x >= (enemy.enemyX - 1) && PlayerMisslie[i].x <= (enemy.enemyX+1))
                        {
                            //충돌
                            item.itemLife = true;
                            item.itemX = enemy.enemyX;
                            item.itemY = enemy.enemyY;

                            Random ran = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = ran.Next(2, 22);

                            //충돌 시, 미사일 지우기
                            PlayerMisslie[i].fire = false;

                            //미사일이 적과 충돌하면 점수 증가 설계
                            Score += 100;
                        }
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                //발사하여 살아있는 미사일
                if (PlayerMisslie2[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (PlayerMisslie2[i].y == enemy.enemyY)
                    {
                        //&&(AND) 문으로 x 좌표 충돌 설계
                        if (PlayerMisslie2[i].x >= (enemy.enemyX - 1) && PlayerMisslie2[i].x <= (enemy.enemyX + 1))
                        {
                            //충돌
                            Random ran = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = ran.Next(2, 22);

                            //충돌 시, 미사일 지우기
                            PlayerMisslie2[i].fire = false;

                            //미사일이 적과 충돌하면 점수 증가 설계
                            Score += 100;
                        }
                    }
                }
            }

            for (int i = 0; i < 20; i++)
            {
                //발사하여 살아있는 미사일
                if (PlayerMisslie3[i].fire == true)
                {
                    //미사일과 적의 y값이 같을 때
                    if (PlayerMisslie3[i].y == enemy.enemyY)
                    {
                        //&&(AND) 문으로 x 좌표 충돌 설계
                        if (PlayerMisslie3[i].x >= (enemy.enemyX - 1) && PlayerMisslie3[i].x <= (enemy.enemyX + 1))
                        {
                            //충돌
                            Random ran = new Random();
                            enemy.enemyX = 75;
                            enemy.enemyY = ran.Next(2, 22);

                            //충돌 시, 미사일 지우기
                            PlayerMisslie3[i].fire = false;

                            //미사일이 적과 충돌하면 점수 증가 설계
                            Score += 100;
                        }
                    }
                }
            }
        }

        public void UIscore()
        {
            Console.SetCursorPosition(63, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(63, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(65, 1);
            Console.Write("Score : "+Score);
            Console.SetCursorPosition(63, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        //아이템 충돌 발생하면 위아래 미사일에서도 미사일 발사 기능 설계
        public void CrashItem()
        {

            if (PlayerY + 1 == item.itemY)
            {
                if (PlayerX >= item.itemX - 2 && PlayerX <= item.itemX + 2)
                {
                    item.itemLife = false;

                    if (itemCount < 3)
                        itemCount++;

                    for (int i = 0; i < 20; i++) //총알 초기화
                    {
                        PlayerMisslie[i] = new Misslie();
                        PlayerMisslie[i].x = 0;
                        PlayerMisslie[i].y = 0;
                        PlayerMisslie[i].fire = false;

                        PlayerMisslie2[i] = new Misslie();
                        PlayerMisslie2[i].x = 0;
                        PlayerMisslie2[i].y = 0;
                        PlayerMisslie2[i].fire = false;


                        PlayerMisslie3[i] = new Misslie();
                        PlayerMisslie3[i].x = 0;
                        PlayerMisslie3[i].y = 0;
                        PlayerMisslie3[i].fire = false;
                    }

                }
            }


        }
    }

    //적 클래스 생성
    public class Enemy
    {
        //적의 2차원 좌표 
        public int enemyX;
        public int enemyY;

        public Enemy()
        {
            //적의 2차원 좌표 초기화.
            enemyX = 77;
            enemyY = 12;
        }

        //적을 그리는 메소드 선언
        public void EnemyDraw()
        {
            //적을 그리고, 문자열로 표현, 좌표 설정, 출력
            string enemy = "<-0->";
            Console.SetCursorPosition(enemyX, enemyY);
            Console.Write(enemy);
        }

        public void EnemyMove()
        {
            Random random = new Random();
            enemyX--;
            
            //왼쪽 끝까지 넘어가면 화면을 넘어가서 새로이 좌표를 잡도록 설계
            //y좌표는 random으로 2에서 21까지
            if(enemyX < 2)
            {
                enemyX = 77;
                enemyY = random.Next(2, 22);
            }
        }
    }

    //아이템 클래스를 설계하는 부분
    public class Item
    {
        //아이템의 이름, 모양, 좌표, 생성 선언.
        public string itemName;
        public string itemSprite;
        public int itemX =0;
        public int itemY =0;
        public bool itemLife = false;

        public void ItemDraw()
        {
            Console.SetCursorPosition(itemX, itemY);
            itemSprite = "☆";
            Console.Write(itemSprite);
        }

        public void ItemMove()
        {
            //if(itemX <= 1 || itemY <= 1)
            //{
            //    itemLife = false;
            //}
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int width = Math.Min(80, Console.LargestWindowWidth);
            int height = Math.Min(25, Console.LargestWindowHeight);
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
            Console.CursorVisible = false;

            Player player = new Player();
            Enemy enemy = new Enemy();

            int frameTime = Environment.TickCount;   // 전체 게임 루프 속도 (100ms)
            int missileTime1 = Environment.TickCount; // MisslieDraw() 속도 (50ms)
            int missileTime2 = Environment.TickCount; // MisslieDraw2() 속도 (70ms)
            int missileTime3 = Environment.TickCount; // MisslieDraw3() 속도 (90ms)

            while (true)
            {
                player.KeyControl();

                // 각 미사일 속도를 다르게 설정
                if (missileTime1 + 50 < Environment.TickCount)  // MisslieDraw() → 50ms (가장 빠름)
                {
                    missileTime1 = Environment.TickCount;
                    player.MisslieDraw();
                }

                if (player.itemCount >= 1 && missileTime2 + 70 < Environment.TickCount)  // MisslieDraw2() → 70ms
                {
                    missileTime2 = Environment.TickCount;
                    player.MisslieDraw2();
                }

                if (player.itemCount >= 2 && missileTime3 + 90 < Environment.TickCount)  // MisslieDraw3() → 90ms (가장 느림)
                {
                    missileTime3 = Environment.TickCount;
                    player.MisslieDraw3();
                }

                // 게임 전체 속도 (100ms)
                if (frameTime + 100 < Environment.TickCount)
                {
                    frameTime = Environment.TickCount;
                    Console.Clear();

                    player.GameMain();

                    // 적 개체 갱신
                    enemy.EnemyMove();
                    enemy.EnemyDraw();

                    // 적과 미사일 충돌 처리
                    player.ClashEnemyAndMisslie(enemy);
                }
            }
        }
    }

}
